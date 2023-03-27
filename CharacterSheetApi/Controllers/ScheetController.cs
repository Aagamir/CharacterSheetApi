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
    [AllowAnonymous]
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
        [HttpDelete("DeleteWeapon")]
        public IActionResult DeleteWeapon([FromBody] DeleteWeaponDto weaponDto)
        {
            _characterSheetService.DeleteWeapon(weaponDto);
            return Ok();
        }

        [HttpPost("AddArmor")]
        [AllowAnonymous]
        public IActionResult AddArmor([FromBody]AddArmorDto armorDto)
        {
            _characterSheetService.AddArmor(armorDto);
            return Ok();
        }
        [HttpDelete("DeleteArmor")]
        public IActionResult DeleteArmor([FromBody]DeleteArmorDto armorDto)
        {
            _characterSheetService.DeleteArmor(armorDto);
            return Ok();
        }
        
        [HttpPost("AddEquipment")]
        [AllowAnonymous]
        public IActionResult AddEquipment([FromBody]AddEquipmentDto equipmentDto)
        {
            _characterSheetService.AddEquipment(equipmentDto);
            return Ok();
        }
        [HttpDelete("DeleteEquipment")]
        public IActionResult DeleteEquipment([FromBody]DeleteEquipmentDto equipmentDto)
        {
            _characterSheetService?.DeleteEquipment(equipmentDto);
            return Ok();
        }

        [HttpPost("AddSkill")]
        [AllowAnonymous]
        public IActionResult AddSkill([FromBody]AddSkillDto skillDto)
        {
            _characterSheetService.AddSkill(skillDto);
            return Ok();
        }

        [HttpDelete("DeleteSkill")]
        [AllowAnonymous]
        public IActionResult AddSkill([FromBody]DeleteSkillDto skillDto)
        {
            _characterSheetService.DeleteSkill(skillDto);
            return Ok();
        }

        [HttpPost("AddAbility")]
        [AllowAnonymous]
        public IActionResult AddAbilty([FromBody]AddAbilityDto abilityDto)
        {
            _characterSheetService.AddAbility(abilityDto);
            return Ok();
        }

        [HttpDelete("DeleteAbility")]
        [AllowAnonymous]
        public IActionResult DeleteAbility([FromBody]DeleteAbilityDto abilityDto)
        {
            _characterSheetService.DeleteAbility(abilityDto);
            return NoContent();
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
