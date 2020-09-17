using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportQuestTracker.Contracts;
using SportQuestTracker.DTOs;
using SportQuestTracker.Models.ClassModels;
using SQLitePCL;

namespace SportQuestTracker.Controllers
{

    /// <summary>
    /// Endpoint used to authenticate login for users
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly ILoggerService _loggerService;
        private readonly IMapper _mapper;
        

        // GET

        public UserController(IUserRepository userRepository, ILoggerService loggerService, IMapper mapper)
        {
            _userRepository = userRepository;
            _loggerService = loggerService;
            _mapper = mapper;
        }

        /// <summary>
        /// Get All Users for Admin
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                _loggerService.LogInfo("Attempted Get All users");
                var users = await _userRepository.FindAll();
                var response = _mapper.Map<IList<UserDTO>>(users);
                _loggerService.LogInfo("Successfully got all users");
                return Ok(response);
            }
            catch (Exception e)
            {
               return InternalError($"{e.Message} - {e.InnerException}");
            }

        }

        /// <summary>
        /// Get user by ID (admin and maybe some display in statistics)
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUser(int id)
        {
            try
            {
                _loggerService.LogInfo($"Attempted get user with id: {id}");
                var user = await _userRepository.FindById(id);
                if (user == null)
                {
                    _loggerService.LogWarn($"User with id:{id} was not found");
                    return NotFound();
                }
                var response = _mapper.Map<UserDTO>(user);
                _loggerService.LogInfo($"Successfully got user with id: {id}");
                return Ok(response);
            }
            catch (Exception e)
            {
                return InternalError($"{e.Message} - {e.InnerException}");
            }
        }
        /// <summary>
        /// Create a user registration
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] UserCrudDTO userDTO)
        {
            try
            {
                _loggerService.LogInfo($"User submission Attempted!");
                if (userDTO == null)
                {
                    _loggerService.LogWarn($"Empty Request was submitted");
                    return BadRequest(ModelState);
                }

                if (!ModelState.IsValid)
                {
                    _loggerService.LogWarn("User Data was Incomplete");
                    return BadRequest(ModelState);
                }

                var user = _mapper.Map<User>(userDTO);
                var isSuccess = await _userRepository.Create(user);
                if (!isSuccess)
                {
                    return InternalError("User Creation failed");
                }
                _loggerService.LogInfo("User Created");

                return Created("Create", new {user});
            }
            catch (Exception e)
            {
                return InternalError($"{e.Message} - {e.InnerException}");
            }
        }

        /// <summary>
        /// Update user (user options)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(int id, [FromBody] UserUpdateDTO userDTO)
        {
            try
            {
                _loggerService.LogInfo($"User with id: {id} data update attempt!");
                if (id < 1 || userDTO == null || id != userDTO.UserId )
                {
                    _loggerService.LogWarn("User update failed with bad data!");
                    return BadRequest();
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var user = _mapper.Map<User>(userDTO);
                var isSuccess = await _userRepository.Update(user);
                if (!isSuccess)
                {
                    return InternalError($"User update has failed!");
                }

                return NoContent();
            }
            catch (Exception e)
            {
                return InternalError($"{e.Message} - {e.InnerException}");
            }
        }

        /// <summary>
        /// Delete user (only for admin)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                _loggerService.LogInfo($"User with id: {id} delete attempt!");
                if (id < 1)
                {
                    _loggerService.LogWarn($"Deletion failed because of wrong data!");
                    return BadRequest();
                }

                var user = await _userRepository.FindById(id);
                if (user == null)
                {
                    _loggerService.LogWarn($"Such user doesn't exist");
                    return NotFound();
                }

                var isSuccess = await _userRepository.Delete(user);
                if (!isSuccess)
                {
                    _loggerService.LogWarn($"Deletion failed because of wrong data!");
                    return InternalError($"User delete failed!");
                }
                _loggerService.LogInfo($"User with id: {id} delete successful!");
                return NoContent();
            }
            catch (Exception e)
            {
                return InternalError($"{e.Message} - {e.InnerException}");
            }
        }

        private ObjectResult InternalError(string message)
        {
            _loggerService.LogError(message);
            return StatusCode(500, "Something went wrong!");
        }
    }

}