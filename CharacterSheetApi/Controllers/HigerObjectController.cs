using CharacterSheetApi.Models;
using CharacterSheetApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApi.Controllers
{
    [Route("api/ClassifiedCreator")]
    [ApiController]
    [AllowAnonymous]
    public class HigerObjectController : ControllerBase
    {
        private IHigherObjectCreatorService _higherObjectCreatorService;
        public HigerObjectController(IHigherObjectCreatorService higherObjectCreatorService)
        {
            _higherObjectCreatorService = higherObjectCreatorService;
        }

        [HttpPost("CreateArmor")]
        [AllowAnonymous]
        public IActionResult CreateArmor([FromBody] CreateArmorDto armorDto)
        {
            _higherObjectCreatorService.CreateArmor(armorDto);
            return Ok();
        }
        [HttpDelete("DeleteArmor")]
        public IActionResult DeleteArmor([FromBody] int armorId)
        {
            _higherObjectCreatorService.DeleteArmor(armorId);
            return Ok();
        }

        [HttpPost("CreateWeapon")]
        [AllowAnonymous]
        public IActionResult CreateWeapon([FromBody] CreateWeaponDto weaponDto)
        {
            _higherObjectCreatorService.CreateWeapon(weaponDto);
            return Ok();
        }
        [HttpDelete("DeleteWeapon")]
        public IActionResult DeleteWeapon([FromBody] int weaponId)
        {
            _higherObjectCreatorService.DeleteWeapon(weaponId);
            return Ok();
        }

        [HttpPost("CreateEquipment")]
        [AllowAnonymous]
        public IActionResult CreateEquipment([FromBody] CreateEquipmentDto equipmentDto)
        {
            _higherObjectCreatorService.CreateEquipment(equipmentDto);
            return Ok();
        }
        [HttpDelete("DeleteEquipment")]
        public IActionResult DeleteEquipment([FromBody] int equipmentId)
        {
            _higherObjectCreatorService.DeleteEquipment(equipmentId);
            return Ok();
        }

        [HttpPost("CreateAbility")]
        [AllowAnonymous]
        public IActionResult CreateAblity([FromBody] CreateAbilityDto abilityDto)
        {
            _higherObjectCreatorService.CreateAbility(abilityDto);
            return Ok();
        }
        [HttpDelete("DeleteAbility")]
        public IActionResult DeleteAbility([FromBody] int abilityId)
        {
            _higherObjectCreatorService.DeleteAbility(abilityId);
            return Ok();
        }

        [HttpPost("CreateSkill")]
        [AllowAnonymous]
        public IActionResult CreateSkill([FromBody] CreateSkillDto skillDto)
        {
            _higherObjectCreatorService.CreateSkill(skillDto);
            return Ok();
        }
        [HttpDelete("DeleteSkill")]
        public IActionResult DeleteSkill([FromBody] int skillId)
        {
            _higherObjectCreatorService.DeleteSkill(skillId);
            return Ok();
        }

        [HttpPost("CreateClass")]
        [AllowAnonymous]
        public IActionResult CreateClass([FromBody] CreateClassDto classDto)
        {
            _higherObjectCreatorService.CreateClass(classDto);
            return Ok();
        }
        [HttpDelete("DeleteClass")]
        public IActionResult DeleteClass([FromBody]int classId)
        {
            _higherObjectCreatorService.DeleteClass(classId);
            return Ok();
        }
    }
}
