using CharacterSheetApi.Models;
using CharacterSheetApi.Models.ObjectCreatorDtos;
using CharacterSheetApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApi.Controllers
{
    [Route("api/add")]
    [ApiController]
    [AllowAnonymous]
    public class ObjectController : ControllerBase
    {
        private IObjectCreatorService _objectCreatorService;
        public ObjectController(IObjectCreatorService objectCreatorService)
        {
            _objectCreatorService = objectCreatorService;
        }


        [HttpPost("CreateSheet")]
        [AllowAnonymous]
        public ActionResult CreateSheet([FromBody] CreateSheetDto sheetDto)
        {
            int newSheetId = _objectCreatorService.CreateSheet(sheetDto);
            return Ok(newSheetId);
        }
        [HttpPut("ChangeSheet")]
        [AllowAnonymous]
        public IActionResult ChangeSheet([FromBody] ChangeSheetDto sheetDto)
        {
            _objectCreatorService.ChangeSheet(sheetDto);
            return Ok();
        }

        [HttpPost("CreateCharacterDescription")]
        [AllowAnonymous]
        public ActionResult CreateCharacterDescription([FromBody] CreateDescriptionDto characterDescriptionDto)
        {
            int newDescriptionId = _objectCreatorService.CreateCharacterDescription(characterDescriptionDto);
            return Ok(newDescriptionId);
        }
        [HttpPut("ChangeCharacterDescription")]
        public IActionResult ChangeCharacterDescription([FromBody] ChangeCharacterDescriptionDto characterDescriptionDto)
        {
            _objectCreatorService.ChangeCharacterDescription(characterDescriptionDto);
            return Ok();
        }

        [HttpPost("CreateBaseStats")]
        [AllowAnonymous]
        public IActionResult CreateBaseStats([FromBody] int characterDescriptionId)
        {
            int newBaseStatsId = _objectCreatorService.CreateBaseStats(characterDescriptionId);
            return Ok(newBaseStatsId);
        }
        [HttpPut("ChangeBaseStats")]
        [AllowAnonymous]
        public IActionResult ChangeBaseStats([FromBody] ChangeStatsDto statsDto)
        {
            _objectCreatorService.ChangeBaseStats(statsDto);
            return Ok();
        }

        [HttpPost("CreateMonetaryWealth")]
        [AllowAnonymous]
        public IActionResult CreateMonetaryWealth([FromBody] CreateMonetaryWealthDto monetaryWealthDto)
        {
            int newMonetaryWealthId = _objectCreatorService.CreateMonetaryWealth(monetaryWealthDto);
            return Ok(newMonetaryWealthId);
        }
        [HttpPut("ChangeMonetaryWealth")]
        [AllowAnonymous]
        public IActionResult ChangeMonetaryWealth([FromBody] ChangeMonetaryWealthDto monetaryWealthDto)
        {
            _objectCreatorService.ChangeMonetaryWealth(monetaryWealthDto);
            return Ok();
        }

        [HttpPost("CreateExpiriencePoints")]
        [AllowAnonymous]
        public IActionResult CreateExpiriencePoints([FromBody] CreateExpiriencePointsDto expiriencePointsDto)
        {
            int newExpiriencePointsId = _objectCreatorService.CreateExpiriencePoints(expiriencePointsDto);
            return Ok(newExpiriencePointsId);
        }

        [HttpPost("CreatePlayerInfo")]
        [AllowAnonymous]
        public IActionResult CreatePlayerInfo([FromBody] CreatePlayerInfoDto playerInfoDto)
        {
            int newPlayerInfoId = _objectCreatorService.CreatePlayerInfo(playerInfoDto);
            return Ok(newPlayerInfoId);
        }

        [HttpPost("CreateCharacterInfo/CharacterCard")]
        [AllowAnonymous]
        public IActionResult CreateCharacterInfo([FromBody] CreateCharacterInfoDto characterInfoDto)
        {
            int newCharacterInfoId = _objectCreatorService.CreateCharacterInfo(characterInfoDto);
            return Ok(newCharacterInfoId);
        }
    }
}
