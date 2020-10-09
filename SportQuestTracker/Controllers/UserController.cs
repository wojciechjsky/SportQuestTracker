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

    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly ILoggerService _loggerService;
        private readonly IMapper _mapper;


        public UserController(IUserRepository userRepository, ILoggerService loggerService, IMapper mapper)
        {
            _userRepository = userRepository;
            _loggerService = loggerService;
            _mapper = mapper;
        }


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


        [HttpGet("{id}")]
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

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] UserCrudDTO userDTO)
        {
            var location = GetControllerActionNames();
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


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(int id, [FromBody] UserUpdateDTO userDTO)
        {
            try
            {
                _loggerService.LogInfo($"User with id: {id} data update attempt!");
                if (id < 1 || userDTO == null || id != userDTO.UserId)
                {
                    _loggerService.LogWarn("User update failed with bad data!");
                    return BadRequest();
                }

                var isExist = await _userRepository.IsExists(id);
                if (!isExist)
                {
                    _loggerService.LogWarn($"User with id:{id} not found!");
                    return NotFound();
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var location = GetControllerActionNames();
            try
            {
                _loggerService.LogInfo($"{location} Delete user attempt!");
                if (id < 1)
                {
                    _loggerService.LogWarn($"User Delete failed with bad data");
                    return BadRequest();
                }
                var isExist = await _userRepository.IsExists(id);
                if (!isExist)
                {
                    _loggerService.LogWarn($"User with id:{id} not found!");
                    return NotFound();
                }

                var user = await _userRepository.FindById(id);
                var isSuccess = await _userRepository.Delete(user);
                if (!isSuccess)
                {
                    return InternalError($"User Delete Failed!");
                }
                _loggerService.LogWarn($"User with id: {id} successfully deleted");
                return NoContent();
            }
            catch (Exception e)
            {
                return InternalError($"{e.Message} - {e.InnerException}");
            }
        }

        private string GetControllerActionNames()
        {
            var controller = ControllerContext.ActionDescriptor.ControllerName;
            var action = ControllerContext.ActionDescriptor.ActionName;

            return $"{controller} - {action}";
        }


        private ObjectResult InternalError(string message)
        {
            _loggerService.LogError(message);
            return StatusCode(500, "Something went wrong!");
        }
    }

}