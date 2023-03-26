using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using CharacterSheetApi.Models;
using CharacterSheetApi.Models.CharacterSheetDtos;
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
        
        [HttpPost("AddWeapon")]
        [AllowAnonymous]
        public IActionResult AddWeapon([FromBody] AddWeaponDto weaponDto)
        {
            _characterSheetService.AddWeapon(weaponDto);
            return Ok();
        }

        [HttpPost("AddArmor")]
        [AllowAnonymous]
        public IActionResult AddArmor([FromBody]AddArmorDto armorDto)
        {
            _characterSheetService.AddArmor(armorDto);
            return Ok();
        }
        
        [HttpPost("AddEquipment")]
        [AllowAnonymous]
        public IActionResult AddEquipment(AddEquipmentDto equipmentDto)
        {
            _characterSheetService.AddEquipment(equipmentDto);
            return Ok();
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
