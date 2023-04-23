using CharacterSheetApi.Models;
using CharacterSheetApi.Models.playerDtos;
using CharacterSheetApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApi.Controllers
{
    [Route("api/player")]
    [ApiController]
    [Authorize(Roles = "Player, GameMaster")]
    public class PlayerController : ControllerBase
    {
        private IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpPost("sheet")]
        public IActionResult CreateSheet([FromBody] CreateSheetDto sheetDto)
        {
            int newSheetId = _playerService.CreateSheet(sheetDto);
            string uri = $"https://www.test.com/api/sheet=test";
            return Created(uri, newSheetId);
        }

        [HttpPut("sheet/{id}")]
        public IActionResult ChangeSheet([FromBody] CreateSheetDto sheetDto, [FromQuery] int id)
        {
            _playerService.ChangeSheet(sheetDto, id);
            return Accepted();
        }

        [HttpPost("character-description")]
        public ActionResult CreateCharacterDescription([FromBody] CreateDescriptionDto characterDescriptionDto)
        {
            int newDescriptionId = _playerService.CreateCharacterDescription(characterDescriptionDto);
            string uri = $"https://www.test.com/api/sheet=test";
            return Created(uri, newDescriptionId);
        }

        [HttpPut("character-description/{id}")]
        public IActionResult ChangeCharacterDescription([FromBody] ChangeCharacterDescriptionDto characterDescriptionDto)
        {
            _playerService.ChangeCharacterDescription(characterDescriptionDto);
            return Accepted();
        }

        [HttpPut("base-stats/{id}")]
        public IActionResult ChangeBaseStats([FromBody] ChangeStatsDto statsDto, [FromRoute] int id)
        {
            _playerService.ChangeBaseStats(statsDto, id);
            return Accepted();
        }

        [HttpPost("monetary-wealth")]
        public IActionResult CreateMonetaryWealth([FromBody] CreateMonetaryWealthDto monetaryWealthDto)
        {
            int newMonetaryWealthId = _playerService.CreateMonetaryWealth(monetaryWealthDto);
            string uri = $"https://www.test.com/api/sheet=test";
            return Created(uri, newMonetaryWealthId);
        }

        [HttpPut("monetary-wealth/{id}")]
        public IActionResult ChangeMonetaryWealth([FromBody] CreateMonetaryWealthDto monetaryWealthDto, [FromRoute] int id)
        {
            _playerService.ChangeMonetaryWealth(monetaryWealthDto, id);
            return Accepted();
        }

        [HttpPost("expirience-points")]
        public IActionResult CreateExpiriencePoints([FromBody] CreateExpiriencePointsDto expiriencePointsDto)
        {
            int newExpiriencePointsId = _playerService.CreateExpiriencePoints(expiriencePointsDto);
            string uri = $"https://www.test.com/api/sheet=test";
            return Created(uri, newExpiriencePointsId);
        }

        [HttpPut("expirience-points/{id}")]
        public IActionResult ChangeExpiriencePoints([FromBody] CreateExpiriencePointsDto changeExpiriencePointsDto, [FromRoute] int id)
        {
            _playerService.ChangeExpiriencePoints(changeExpiriencePointsDto, id);
            return Accepted();
        }

        [HttpPost("player-info")]
        public IActionResult CreatePlayerInfo([FromBody] CreatePlayerInfoDto playerInfoDto)
        {
            int newPlayerInfoId = _playerService.CreatePlayerInfo(playerInfoDto);
            string uri = $"https://www.test.com/api/sheet=test";
            return Created(uri, newPlayerInfoId);
        }

        [HttpPost("character-info")]
        public IActionResult CreateCharacterInfo([FromBody] CreateCharacterInfoDto characterInfoDto)
        {
            int newCharacterInfoId = _playerService.CreateCharacterInfo(characterInfoDto);
            string uri = $"https://www.test.com/api/sheet=test";
            return Created(uri, newCharacterInfoId);
        }

        [HttpGet("weapon")]
        public IActionResult GetAllWeapons()
        {
            var weapons = _playerService.GetAllWeapons();
            return Ok(weapons);
        }

        [HttpGet("armor")]
        public IActionResult GetAllArmors()
        {
            var armors = _playerService.GetAllArmors();
            return Ok(armors);
        }

        [HttpGet("equipment")]
        public IActionResult GetAllEquipments()
        {
            var equipments = _playerService.GetAllEquipments();
            return Ok(equipments);
        }

        [HttpGet("skill")]
        public IActionResult GetAllSkills()
        {
            var skills = _playerService.GetAllSkills();
            return Ok(skills);
        }

        [HttpGet("ability")]
        public IActionResult GetAllAbilities()
        {
            var abilities = _playerService.GetAllAbilities();
            return Ok(abilities);
        }
    }
}