using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SportQuestTrackerAPI.Contracts;
using SportQuestTrackerAPI.Data.Models;
using SportQuestTrackerAPI.DTOs;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace SportQuestTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        //private ILoggerService _logger;
        private readonly IConfiguration _config;

        public UserController(SignInManager<IdentityUser> signInManager,
                                UserManager<IdentityUser> userManager,
                                //ILoggerService logger,
                                IConfiguration config)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            //_logger = logger;
            _config = config;
        }



        /// <summary>
        /// User Login Endpoint
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserDTO userDto)
        {
            var username = userDto.Username;
            var password = userDto.Password;
            
            var result = await _signInManager.PasswordSignInAsync(username, password, false, false);
            
            //TODO: enable logging by email

            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(username);
                var tokenString = await GenerateJSONWebToken(user);
                //return Ok(new { token = tokenString });
                return Ok(user);
            }

            return Unauthorized(userDto);
        }

        private async Task<string> GenerateJSONWebToken(IdentityUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id ),
            };

            var roles = await _userManager.GetRolesAsync(user);
            claims.AddRange(roles.Select(r=> new Claim(ClaimsIdentity.DefaultRoleClaimType, r)));

            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                null,
                expires:DateTime.Now.AddMinutes(5),
                signingCredentials: credentials
            );
            
            
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}