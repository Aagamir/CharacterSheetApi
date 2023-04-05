using CharacterSheetApi.Models;
using CharacterSheetApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApi.Controllers
{
    [Route("api/object-creator")]
    [ApiController]
    [AllowAnonymous]
    public class ObjectCreatorController : ControllerBase
    {
        private IHigherObjectCreatorService _higherObjectCreatorService;
        public ObjectCreatorController(IHigherObjectCreatorService higherObjectCreatorService)
        {
            _higherObjectCreatorService = higherObjectCreatorService;
        }

        [HttpPost("armor")]
        [AllowAnonymous]
        public IActionResult CreateArmor([FromBody] CreateArmorDto armorDto)
        {
            _higherObjectCreatorService.CreateArmor(armorDto);
            return Ok();
        }
        [HttpDelete("armor/{id}")]
        public IActionResult DeleteArmor([FromBody] int armorId)
        {
            _higherObjectCreatorService.DeleteArmor(armorId);
            return Ok();
        }

        [HttpPost("weapon")]
        [AllowAnonymous]
        public IActionResult CreateWeapon([FromBody] CreateWeaponDto weaponDto)
        {
            _higherObjectCreatorService.CreateWeapon(weaponDto);
            return Ok();
        }
        [HttpDelete("weapon/{id}")]
        public IActionResult DeleteWeapon([FromBody] int weaponId)
        {
            _higherObjectCreatorService.DeleteWeapon(weaponId);
            return Ok();
        }

        [HttpPost("equipment")]
        [AllowAnonymous]
        public IActionResult CreateEquipment([FromBody] CreateEquipmentDto equipmentDto)
        {
            _higherObjectCreatorService.CreateEquipment(equipmentDto);
            return Ok();
        }
        [HttpDelete("equipment/{id}")]
        public IActionResult DeleteEquipment([FromBody] int equipmentId)
        {
            _higherObjectCreatorService.DeleteEquipment(equipmentId);
            return Ok();
        }

        [HttpPost("ability")]
        [AllowAnonymous]
        public IActionResult CreateAblity([FromBody] CreateAbilityDto abilityDto)
        {
            _higherObjectCreatorService.CreateAbility(abilityDto);
            return Ok();
        }
        [HttpDelete("ability/{id}")]
        public IActionResult DeleteAbility([FromBody] int abilityId)
        {
            _higherObjectCreatorService.DeleteAbility(abilityId);
            return Ok();
        }

        [HttpPost("skill")]
        [AllowAnonymous]
        public IActionResult CreateSkill([FromBody] CreateSkillDto skillDto)
        {
            _higherObjectCreatorService.CreateSkill(skillDto);
            return Ok();
        }
        [HttpDelete("skill/{id}")]
        public IActionResult DeleteSkill([FromBody] int skillId)
        {
            _higherObjectCreatorService.DeleteSkill(skillId);
            return Ok();
        }

        [HttpPost("class")]
        [AllowAnonymous]
        public IActionResult CreateClass([FromBody] CreateClassDto classDto)
        {
            _higherObjectCreatorService.CreateClass(classDto);
            return Ok();
        }
        [HttpDelete("class/{id}")]
        public IActionResult DeleteClass([FromBody]int classId)
        {
            _higherObjectCreatorService.DeleteClass(classId);
            return Ok();
        }
    }
}
