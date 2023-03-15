using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using CharacterSheetApi.Models;
using CharacterSheetApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApi.Controllers
{
    [Route("api/sheet")]
    [ApiController]
    public class SheetControler : ControllerBase
    {
        private ICharacterSheetService _characterSheetService;
        public SheetControler( ICharacterSheetService characterSheetService)
        {
            _characterSheetService = characterSheetService;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetSheets()
        {
            var sheet = _characterSheetService;
            return Ok();
        }

        [HttpPost("SheetCreator")]
        [AllowAnonymous]
        public ActionResult CreateSheet([FromBody] CreateSheetDto sheetDto)
        {
            int newSheetId = _characterSheetService.SheetCreator(sheetDto);
            return Ok(newSheetId);
        }

        [HttpPost("CharacterDescriptionCreator")]
        [AllowAnonymous]
        public ActionResult CreateCharacterDescription([FromBody]CreateDescriptionDto characterDescriptionDto)
        {
            int newDescriptionId = _characterSheetService.CharacterDescriptionCreator(characterDescriptionDto);
            return Ok(newDescriptionId);
        }

        [HttpPost("AddArmor")]
        [AllowAnonymous]
        public IActionResult AddArmor ([FromBody]CreateArmorDto armorDto)
        {
            int newArmorId = _characterSheetService.ArmorCreator(armorDto);
            return Ok(newArmorId);
        }

        [HttpPost("AddBaseStats")]
        [AllowAnonymous]
        public IActionResult AddBaseStats([FromBody]int characterDescriptionId)
        {
            int newBaseStatsId = _characterSheetService.BaseStatsCreator(characterDescriptionId);
            return Ok(newBaseStatsId);
        }
        
        
        /*
        public ActionResult<IEnumerable<CharacterSheets>> GetAll()
        {
            var sheets = _dbContext
                .CharacterSheets
                .ToList;
            return Ok(sheets);
        }*/
    }
}
