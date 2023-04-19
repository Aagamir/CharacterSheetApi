using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using CharacterSheetApi.Models;
using CharacterSheetApi.Models.CharacterSheetDtos;
using CharacterSheetApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace CharacterSheetApi.Controllers
{
    [Route("api/sheet-editing")]
    [ApiController]
    [Authorize(Roles = "Player, GameMaster")]
    public class SheetControler : ControllerBase
    {
        private ICharacterSheetService _characterSheetService;

        public SheetControler(ICharacterSheetService characterSheetService)
        {
            _characterSheetService = characterSheetService;
        }

        [HttpPost("weapon/{id}")]
        public IActionResult AddWeapon([FromBody] AddWeaponDto weaponDto)
        {
            _characterSheetService.AddWeapon(weaponDto);
            return Ok();
        }

        [HttpDelete("weapon/{id}")]
        public IActionResult DeleteWeapon([FromBody] DeleteWeaponDto weaponDto)
        {
            _characterSheetService.DeleteWeapon(weaponDto);
            return Ok();
        }

        [HttpPost("armor/{id}")]
        public IActionResult AddArmor([FromBody] AddArmorDto armorDto)
        {
            _characterSheetService.AddArmor(armorDto);
            return Ok();
        }

        [HttpDelete("armor/{id}")]
        public IActionResult DeleteArmor([FromBody] DeleteArmorDto armorDto)
        {
            _characterSheetService.DeleteArmor(armorDto);
            return Ok();
        }

        [HttpPost("equipment/{id}")]
        public IActionResult AddEquipment([FromBody] AddEquipmentDto equipmentDto)
        {
            _characterSheetService.AddEquipment(equipmentDto);
            return Ok();
        }

        [HttpDelete("equipment/{id}")]
        public IActionResult DeleteEquipment([FromBody] DeleteEquipmentDto equipmentDto)
        {
            _characterSheetService?.DeleteEquipment(equipmentDto);
            return Ok();
        }

        [HttpPost("skill/{id}")]
        public IActionResult AddSkill([FromBody] AddSkillDto skillDto)
        {
            _characterSheetService.AddSkill(skillDto);
            return Ok();
        }

        [HttpDelete("skill/{id}")]
        public IActionResult AddSkill([FromBody] DeleteSkillDto skillDto)
        {
            _characterSheetService.DeleteSkill(skillDto);
            return Ok();
        }

        [HttpPost("ability/{id}")]
        public IActionResult AddAbilty([FromBody] AddAbilityDto abilityDto)
        {
            _characterSheetService.AddAbility(abilityDto);
            return Ok();
        }

        [HttpDelete("ability/{id}")]
        public IActionResult DeleteAbility([FromBody] DeleteAbilityDto abilityDto)
        {
            _characterSheetService.DeleteAbility(abilityDto);
            return NoContent();
        }

        [HttpGet("sheet-print/{id}")]
        [AllowAnonymous]
        public FileStreamResult PrintSheet([FromRoute] int id)
        {
            FileStreamResult pdf = _characterSheetService.PrintSheet(id);
            return pdf;
        }
    }
}