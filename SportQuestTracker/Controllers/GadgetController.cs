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
    /// Interacts with Gadgets table
    /// </summary>
    //[Route("api/[controller]")]
    //[ApiController]
    //[ProducesResponseType(StatusCodes.Status200OK)]
    public class GadgetController : Controller
    {
        private readonly IGadgetRepository _gadgetRepository;
        private readonly ILoggerService _loggerService;
        private readonly IMapper _mapper;

        public GadgetController(IGadgetRepository gadgetRepository, ILoggerService loggerService, IMapper mapper)
        {
            _gadgetRepository = gadgetRepository;
            _loggerService = loggerService;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all gadgets (for admin and companies usage)
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetGadgets")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetGadgets()
        {
            var location = GetControllerActionNames();
            try
            {
                _loggerService.LogInfo($"{location}: Attempted Call");
                var gadgets = await _gadgetRepository.FindAll();
                var response = _mapper.Map<IList<GadgetDTO>>(gadgets);
                _loggerService.LogInfo("Successfully got all gadgets");
                return Ok(response);
            }
            catch (Exception e)
            {
                return InternalError($"{location}: {e.Message} - {e.InnerException}");
            }
        }


        /// <summary>
        /// Retrive gadget by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetGadget(int id)
        {
            var location = GetControllerActionNames();
            try
            {
                _loggerService.LogInfo($"{location}: Attempted Call for id: {id}");
                var gadget = await _gadgetRepository.FindById(id);
                var response = _mapper.Map<GadgetDTO>(gadget);
                _loggerService.LogInfo($"Successfully got record with id: {id}");
                if (gadget == null)
                {
                    _loggerService.LogWarn($"{location}: Failed to get record with id: {id}");
                    return NotFound();
                }
                return Ok(response);
            }
            catch (Exception e)
            {
                return InternalError($"{location}: {e.Message} - {e.InnerException}");
            }
        }
        /// <summary>
        /// Create new gadget
        /// </summary>
        /// <param name="gadgetDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] GadgetCrudDTO gadgetDTO)
        {
            var location = GetControllerActionNames();
            try
            {
                _loggerService.LogInfo($"{location}: submission Attempted!");
                if (gadgetDTO == null)
                {
                    _loggerService.LogWarn($"Empty Request was submitted");
                    return BadRequest(ModelState);
                }

                if (!ModelState.IsValid)
                {
                    _loggerService.LogWarn("Gadget Data was Incomplete");
                    return BadRequest(ModelState);
                }

                var gadget = _mapper.Map<Gadget>(gadgetDTO);
                var isSuccess = await _gadgetRepository.Create(gadget);
                if (!isSuccess)
                {
                    return InternalError("User Creation failed");
                }
                _loggerService.LogInfo("User Created");

                return Created("Create", new { gadget });
            }
            catch (Exception e)
            {
                return InternalError($"{e.Message} - {e.InnerException}");
            }
        }


        /// <summary>
        /// Update gadget data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="gadgetDTO"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(int id, [FromBody] GadgetDTO gadgetDTO)
        {
            try
            {
                _loggerService.LogInfo($"gadget with id: {id} data update attempt!");
                if (id < 1 || gadgetDTO == null || id != gadgetDTO.GadgetId)
                {
                    _loggerService.LogWarn("gadget update failed with bad data!");
                    return BadRequest();
                }
                var isExists = await _gadgetRepository.IsExists(id);
                if (!isExists)
                {
                    _loggerService.LogWarn($"Such gadget doesn't exist");
                    return NotFound();
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var gadget = _mapper.Map<Gadget>(gadgetDTO);
                var isSuccess = await _gadgetRepository.Update(gadget);
                if (!isSuccess)
                {
                    return InternalError($"gadget update has failed!");
                }

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

        public ObjectResult InternalError(string message)
        {
            _loggerService.LogError(message);
            return StatusCode(500, "Something went wrong!");
        }
    }
}