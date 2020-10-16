using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SportQuestTrackerAPI.Contracts;
using SportQuestTrackerAPI.Data.Models;
using SportQuestTrackerAPI.DTOs;

namespace SportQuestTrackerAPI.Controllers
{
    [Route("api/[controllers")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public UserController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
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
            var userEmail = userDto.Email;
            var userPassword = userDto.Password;
            var result = await _signInManager.PasswordSignInAsync(userEmail, userPassword, false, false);
            if (result != null)
            {
                var user = await _userManager.FindByEmailAsync(userEmail);
                return Ok(user);
            }

            return Unauthorized();
        }
    }
}