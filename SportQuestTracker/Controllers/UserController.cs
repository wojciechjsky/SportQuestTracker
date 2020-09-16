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
        /// Get user by ID
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
        /// Create a user
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] UserCreationDTO userDTO)
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

        private ObjectResult InternalError(string message)
        {
            _loggerService.LogError(message);
            return StatusCode(500, "Something went wrong!");
        }
    }

}