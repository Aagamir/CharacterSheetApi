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

        [HttpPost("sheet-creation")]
        public ActionResult CreateSheet([FromBody] CreateSheetDto sheetDto)
        {
            int newSheetId = _playerService.CreateSheet(sheetDto);
            return Ok(newSheetId);
        }

        [HttpPut("sheet-change/{id}")]
        public IActionResult ChangeSheet([FromBody] ChangeSheetDto sheetDto)
        {
            _playerService.ChangeSheet(sheetDto);
            return Ok();
        }

        [HttpPost("character-description-creation")]
        public ActionResult CreateCharacterDescription([FromBody] CreateDescriptionDto characterDescriptionDto)
        {
            int newDescriptionId = _playerService.CreateCharacterDescription(characterDescriptionDto);
            return Ok(newDescriptionId);
        }

        [HttpPut("character-description-change/{id}")]
        public IActionResult ChangeCharacterDescription([FromBody] ChangeCharacterDescriptionDto characterDescriptionDto)
        {
            _playerService.ChangeCharacterDescription(characterDescriptionDto);
            return Ok();
        }

        /*
        [HttpPost("base-stats/{id}")]
        [AllowAnonymous]
        public IActionResult CreateBaseStats([FromBody] int characterDescriptionId)
        {
            string newBaseStatsId = _playerService.CreateBaseStats(characterDescriptionId);
            return Ok();
        }
        */

        [HttpPut("base-stats-change/{id}")]
        public IActionResult ChangeBaseStats([FromBody] ChangeStatsDto statsDto)
        {
            _playerService.ChangeBaseStats(statsDto);
            return Ok();
        }

        [HttpPost("monetary-wealth-creation")]
        public IActionResult CreateMonetaryWealth([FromBody] CreateMonetaryWealthDto monetaryWealthDto)
        {
            int newMonetaryWealthId = _playerService.CreateMonetaryWealth(monetaryWealthDto);
            return Ok(newMonetaryWealthId);
        }

        [HttpPut("monetary-wealth-change/{id}")]
        public IActionResult ChangeMonetaryWealth([FromBody] ChangeMonetaryWealthDto monetaryWealthDto)
        {
            _playerService.ChangeMonetaryWealth(monetaryWealthDto);
            return Ok();
        }

        [HttpPost("expirience-points-creation")]
        public IActionResult CreateExpiriencePoints([FromBody] CreateExpiriencePointsDto expiriencePointsDto)
        {
            int newExpiriencePointsId = _playerService.CreateExpiriencePoints(expiriencePointsDto);
            return Ok(newExpiriencePointsId);
        }

        [HttpPut("expirience-points-change/{id}")]
        public IActionResult ChangeExpiriencePoints([FromBody] ChangeExpiriencePointsDto changeExpiriencePointsDto)
        {
            _playerService.ChangeExpiriencePoints(changeExpiriencePointsDto);
            return Ok();
        }

        [HttpPost("player-info-creation")]
        public IActionResult CreatePlayerInfo([FromBody] CreatePlayerInfoDto playerInfoDto)
        {
            int newPlayerInfoId = _playerService.CreatePlayerInfo(playerInfoDto);
            return Ok(newPlayerInfoId);
        }

        [HttpPost("character-info-creation")]
        public IActionResult CreateCharacterInfo([FromBody] CreateCharacterInfoDto characterInfoDto)
        {
            int newCharacterInfoId = _playerService.CreateCharacterInfo(characterInfoDto);
            return Ok(newCharacterInfoId);
        }
    }
}