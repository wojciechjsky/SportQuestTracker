using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
    public class QuestController : ControllerBase
    {
        private readonly IQuestRepository _questRepository;
        private readonly ILoggerService _loggerService;
        private readonly IMapper _mapper;

        public QuestController(IQuestRepository questRepository,
            ILoggerService loggerService, IMapper mapper)
        {
            _questRepository = questRepository;
            _loggerService = loggerService;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetQuests()
        {
            _loggerService.LogInfo($"Get Quests: Attempted Call");
            var quests = await _questRepository.FindAll();
            var response = _mapper.Map<IList<QuestDTO>>(quests);
            _loggerService.LogInfo("Successfully got all quests");
            return Ok(response);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetQuest(int id)
        {
            //var location = GetControllerActionNames();
            //try
            //{
            //_loggerService.LogInfo($"{location}: Attempted Call for id: {id}");
            var quest = await _questRepository.FindById(id);
            var response = _mapper.Map<QuestDTO>(quest);
            _loggerService.LogInfo($"Successfully got record with id: {id}");
            if (quest == null)
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
        /// Post quest to Database
        /// </summary>
        /// <param name="questDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] QuestDTO questDTO)
        {
            //var location = GetControllerActionNames();
            //try
            //{
            //_loggerService.LogInfo($"{location}: submission Attempted!");
            if (questDTO == null)
            {
                _loggerService.LogWarn($"Empty Request was submitted");
                return BadRequest(ModelState);
            }

            if (!ModelState.IsValid)
            {
                _loggerService.LogWarn("quest Data was Incomplete");
                return BadRequest(ModelState);
            }

            var quest = _mapper.Map<Quest>(questDTO);
            var isSuccess = await _questRepository.Create(quest);
            //if (!isSuccess)
            //{
            //    return InternalError("quest Creation failed");
            //}
            _loggerService.LogInfo("quest Created");

            return Created("Create", new {quest});
            //}
            //catch (Exception e)
            //{
            //    return InternalError($"{e.Message} - {e.InnerException}");
            //}
        }

        /// <summary>
        /// Put quest to Database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="questDTO"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(int id, [FromBody] QuestDTO questDTO)
        {
            //try
            //{
            _loggerService.LogInfo($"quest with id: {id} data update attempt!");
            if (id < 1 || questDTO == null || id != questDTO.Id)
            {
                _loggerService.LogWarn("quest update failed with bad data!");
                return BadRequest();
            }

            var isExists = await _questRepository.IsExists(id);
            if (!isExists)
            {
                _loggerService.LogWarn($"Such quest doesn't exist");
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var quest = _mapper.Map<Quest>(questDTO);
            var isSuccess = await _questRepository.Update(quest);
            //if (!isSuccess)
            //{
            //    return InternalError($"quest update has failed!");
            //}

            return NoContent();
            //}
            //catch (Exception e)
            //{
            //    return InternalError($"{e.Message} - {e.InnerException}");
            //}
        }

        /// <summary>
        /// Delete quest from Database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            //var location = GetControllerActionNames();
            //try
            //{
            //_loggerService.LogInfo($"{location} Delete quest attempt!");
            if (id < 1)
            {
                _loggerService.LogWarn($"quest Delete failed with bad data");
                return BadRequest();
            }

            var isExist = await _questRepository.IsExists(id);
            if (!isExist)
            {
                _loggerService.LogWarn($"quest with id:{id} not found!");
                return NotFound();
            }

            var quest = await _questRepository.FindById(id);
            var isSuccess = await _questRepository.Delete(quest);
            //if (!isSuccess)
            //{
            //    return InternalError($"quest Delete Failed!");
            //}
            _loggerService.LogWarn($"quest with id: {id} successfully deleted");
            return NoContent();
            //}
            //catch (Exception e)
            //{
            //    return InternalError($"{e.Message} - {e.InnerException}");
            //}
        }
    }
}
