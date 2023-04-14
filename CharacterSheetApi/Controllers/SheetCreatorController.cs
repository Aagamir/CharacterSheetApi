using CharacterSheetApi.Models;
using CharacterSheetApi.Models.ObjectCreatorDtos;
using CharacterSheetApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApi.Controllers
{
    [Route("api/sheet-creator")]
    [ApiController]
    [AllowAnonymous]
    public class SheetCreatorController : ControllerBase
    {
        private IPlayerService _objectCreatorService;

        public SheetCreatorController(IPlayerService objectCreatorService)
        {
            _objectCreatorService = objectCreatorService;
        }

        [HttpPost("sheet")]
        [AllowAnonymous]
        public ActionResult CreateSheet([FromBody] CreateSheetDto sheetDto)
        {
            int newSheetId = _objectCreatorService.CreateSheet(sheetDto);
            return Ok(newSheetId);
        }

        [HttpPut("sheet/{id}")]
        [AllowAnonymous]
        public IActionResult ChangeSheet([FromBody] ChangeSheetDto sheetDto)
        {
            _objectCreatorService.ChangeSheet(sheetDto);
            return Ok();
        }

        [HttpPost("character-description")]
        [AllowAnonymous]
        public ActionResult CreateCharacterDescription([FromBody] CreateDescriptionDto characterDescriptionDto)
        {
            int newDescriptionId = _objectCreatorService.CreateCharacterDescription(characterDescriptionDto);
            return Ok(newDescriptionId);
        }

        [HttpPut("character-description/{id}")]
        public IActionResult ChangeCharacterDescription([FromBody] ChangeCharacterDescriptionDto characterDescriptionDto)
        {
            _objectCreatorService.ChangeCharacterDescription(characterDescriptionDto);
            return Ok();
        }

        /*
        [HttpPost("base-stats/{id}")]
        [AllowAnonymous]
        public IActionResult CreateBaseStats([FromBody] int characterDescriptionId)
        {
            string newBaseStatsId = _objectCreatorService.CreateBaseStats(characterDescriptionId);
            return Ok();
        }
        */

        [HttpPut("base-stats/{id}")]
        [AllowAnonymous]
        public IActionResult ChangeBaseStats([FromBody] ChangeStatsDto statsDto)
        {
            _objectCreatorService.ChangeBaseStats(statsDto);
            return Ok();
        }

        [HttpPost("monetary-wealth/{id}")]
        [AllowAnonymous]
        public IActionResult CreateMonetaryWealth([FromBody] CreateMonetaryWealthDto monetaryWealthDto)
        {
            int newMonetaryWealthId = _objectCreatorService.CreateMonetaryWealth(monetaryWealthDto);
            return Ok(newMonetaryWealthId);
        }

        [HttpPut("monetary-wealth/{id}")]
        [AllowAnonymous]
        public IActionResult ChangeMonetaryWealth([FromBody] ChangeMonetaryWealthDto monetaryWealthDto)
        {
            _objectCreatorService.ChangeMonetaryWealth(monetaryWealthDto);
            return Ok();
        }

        [HttpPost("expirience-points/{id}")]
        [AllowAnonymous]
        public IActionResult CreateExpiriencePoints([FromBody] CreateExpiriencePointsDto expiriencePointsDto)
        {
            int newExpiriencePointsId = _objectCreatorService.CreateExpiriencePoints(expiriencePointsDto);
            return Ok(newExpiriencePointsId);
        }

        [HttpPost("player-info/{id}")]
        [AllowAnonymous]
        public IActionResult CreatePlayerInfo([FromBody] CreatePlayerInfoDto playerInfoDto)
        {
            int newPlayerInfoId = _objectCreatorService.CreatePlayerInfo(playerInfoDto);
            return Ok(newPlayerInfoId);
        }

        [HttpPost("character-card/{id}")]
        [AllowAnonymous]
        public IActionResult CreateCharacterInfo([FromBody] CreateCharacterInfoDto characterInfoDto)
        {
            int newCharacterInfoId = _objectCreatorService.CreateCharacterInfo(characterInfoDto);
            return Ok(newCharacterInfoId);
        }
    }
}