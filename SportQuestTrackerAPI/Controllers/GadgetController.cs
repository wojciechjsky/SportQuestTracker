using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportQuestTrackerAPI.Contracts;
using SportQuestTrackerAPI.Data.Models;
using SportQuestTrackerAPI.DTOs;

namespace SportQuestTrackerAPI.Controllers
{


   
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class GadgetController : ControllerBase
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


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetGadgets()
        {
            //var location = GetControllerActionNames();
            //try
            //{
                _loggerService.LogInfo($"GetGadgets: Attempted Call");
                var gadgets = await _gadgetRepository.FindAll();
                var response = _mapper.Map<IList<GadgetDTO>>(gadgets);
                _loggerService.LogInfo("Successfully got all gadgets");
                return Ok(response);
            //}
            //catch (Exception e)
            //{
            //    return InternalError($"{location}: {e.Message} - {e.InnerException}");
            //}
        }
        /// <summary>
        /// GetOneGadget
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetGadget(int id)
        {
            //var location = GetControllerActionNames();
            //try
            //{
                //_loggerService.LogInfo($"{location}: Attempted Call for id: {id}");
                var gadget = await _gadgetRepository.FindById(id);
                var response = _mapper.Map<GadgetDTO>(gadget);
                _loggerService.LogInfo($"Successfully got record with id: {id}");
                if (gadget == null)
                {
                    //_loggerService.LogWarn($"{location}: Failed to get record with id: {id}");
                    return NotFound();
                }

                return Ok(response);
            //}
            //catch (Exception e)
            //{
            //    return InternalError($"{location}: {e.Message} - {e.InnerException}");
            //}
        }
        /// <summary>
        /// Post Gadget to Database
        /// </summary>
        /// <param name="gadgetDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] GadgetCrudDTO gadgetDTO)
        {
            //var location = GetControllerActionNames();
            //try
            //{
                //_loggerService.LogInfo($"{location}: submission Attempted!");
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
                //if (!isSuccess)
                //{
                //    return InternalError("Gadget Creation failed");
                //}
                _loggerService.LogInfo("Gadget Created");

                return Created("Create", new { gadget });
            //}
            //catch (Exception e)
            //{
            //    return InternalError($"{e.Message} - {e.InnerException}");
            //}
        }

        /// <summary>
        /// Put gadget to Database
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
            //try
            //{
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
                //if (!isSuccess)
                //{
                //    return InternalError($"gadget update has failed!");
                //}

                return NoContent();
            //}
            //catch (Exception e)
            //{
            //    return InternalError($"{e.Message} - {e.InnerException}");
            //}
        }

        /// <summary>
        /// Delete gadget from Database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            //var location = GetControllerActionNames();
            //try
            //{
                //_loggerService.LogInfo($"{location} Delete gadget attempt!");
                if (id < 1)
                {
                    _loggerService.LogWarn($"gadget Delete failed with bad data");
                    return BadRequest();
                }
                var isExist = await _gadgetRepository.IsExists(id);
                if (!isExist)
                {
                    _loggerService.LogWarn($"gadget with id:{id} not found!");
                    return NotFound();
                }

                var gadget = await _gadgetRepository.FindById(id);
                var isSuccess = await _gadgetRepository.Delete(gadget);
                //if (!isSuccess)
                //{
                //    return InternalError($"Gadget Delete Failed!");
                //}
                _loggerService.LogWarn($"Gadget with id: {id} successfully deleted");
                return NoContent();
            //}
            //catch (Exception e)
            //{
            //    return InternalError($"{e.Message} - {e.InnerException}");
            //}
        }

        //private string GetControllerActionNames()
        //{
        //    var controller = ControllerContext.ActionDescriptor.ControllerName;
        //    var action = ControllerContext.ActionDescriptor.ActionName;

        //    return $"{controller} - {action}";
        //}

        //public ObjectResult InternalError(string message)
        //{
        //    _loggerService.LogError(message);
        //    return StatusCode(500, "Something went wrong!");
        //}
    }
}