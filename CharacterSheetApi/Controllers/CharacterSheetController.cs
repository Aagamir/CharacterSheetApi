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

        [HttpPost("weapon/sheet={id}")]
        public IActionResult AddWeapon([FromBody] List<int> weaponIds, [FromRoute] int id)
        {
            _characterSheetService.AddWeapon(weaponIds, id);
            return Ok();
        }

        [HttpDelete("weapon/sheet=/{id}")]
        public IActionResult DeleteWeapon([FromBody] int weaponId, [FromRoute] int id)
        {
            _characterSheetService.DeleteWeapon(weaponId, id);
            return NoContent();
        }

        [HttpPost("armor/sheet=/{id}")]
        public IActionResult AddArmor([FromBody] List<int> armorIds, [FromRoute] int id)
        {
            _characterSheetService.AddArmor(armorIds, id);
            return Ok();
        }

        [HttpDelete("armor/sheet=/{id}")]
        public IActionResult DeleteArmor([FromBody] int armorId, [FromRoute] int id)
        {
            _characterSheetService.DeleteArmor(armorId, id);
            return NoContent();
        }

        [HttpPost("equipment/sheet=/{id}")]
        public IActionResult AddEquipment([FromBody] List<int> equipmentIds, [FromRoute] int id)
        {
            _characterSheetService.AddEquipment(equipmentIds, id);
            return Ok();
        }

        [HttpDelete("equipment/sheet=/{id}")]
        public IActionResult DeleteEquipment([FromBody] int equipmentId, [FromRoute] int id)
        {
            _characterSheetService?.DeleteEquipment(equipmentId, id);
            return NoContent();
        }

        [HttpPost("skill/sheet=/{id}")]
        public IActionResult AddSkill([FromBody] List<int> skillIds, [FromRoute] int id)
        {
            _characterSheetService.AddSkill(skillIds, id);
            return Ok();
        }

        [HttpDelete("skill/sheet=/{id}")]
        public IActionResult DeleteSkill([FromBody] int skillId, [FromRoute] int id)
        {
            _characterSheetService.DeleteSkill(skillId, id);
            return NoContent();
        }

        [HttpPost("ability/sheet=/{id}")]
        public IActionResult AddAbilty([FromBody] List<int> abilityIds, [FromRoute] int id)
        {
            _characterSheetService.AddAbility(abilityIds, id);
            return Ok();
        }

        [HttpDelete("ability/sheet=/{id}")]
        public IActionResult DeleteAbility([FromBody] int abilityId, [FromRoute] int id)
        {
            _characterSheetService.DeleteAbility(abilityId, id);
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