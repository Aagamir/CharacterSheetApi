using CharacterSheetApi.Models;
using CharacterSheetApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApi.Controllers
{
    [Route("api/add")]
    [ApiController]
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

        [HttpPost("CreateCharacterDescription")]
        [AllowAnonymous]
        public ActionResult CreateCharacterDescription([FromBody] CreateDescriptionDto characterDescriptionDto)
        {
            int newDescriptionId = _objectCreatorService.CreateCharacterDescription(characterDescriptionDto);
            return Ok(newDescriptionId);
        }

        [HttpPost("CreateBaseStats")]
        [AllowAnonymous]
        public IActionResult CreateBaseStats([FromBody] int characterDescriptionId)
        {
            int newBaseStatsId = _objectCreatorService.CreateBaseStats(characterDescriptionId);
            return Ok(newBaseStatsId);
        }

        [HttpPost("CreateMonetaryWealth")]
        [AllowAnonymous]
        public IActionResult CreateMonetaryWealth([FromBody] CreateMonetaryWealthDto monetaryWealthDto)
        {
            int newMonetaryWealthId = _objectCreatorService.CreateMonetaryWealth(monetaryWealthDto);
            return Ok(newMonetaryWealthId);
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
