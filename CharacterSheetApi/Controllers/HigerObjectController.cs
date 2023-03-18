using CharacterSheetApi.Models;
using CharacterSheetApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApi.Controllers
{
    [Route("api/ClassifiedCreator")]
    [ApiController]
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

        [HttpPost("CreateWeapon")]
        [AllowAnonymous]
        public IActionResult CreateWeapon([FromBody] CreateWeaponDto weaponDto)
        {
            _higherObjectCreatorService.CreateWeapon(weaponDto);
            return Ok();
        }

        [HttpPost("CreateEquipment")]
        [AllowAnonymous]
        public IActionResult CreateEquipment([FromBody] CreateEquipmentDto equipmentDto)
        {
            _higherObjectCreatorService.CreateEquipment(equipmentDto);
            return Ok();
        }

        [HttpPost("CreateAbility")]
        [AllowAnonymous]
        public IActionResult CreateAblity([FromBody] CreateAbilityDto abilityDto)
        {
            _higherObjectCreatorService.CreateAbility(abilityDto);
            return Ok();
        }

        [HttpPost("CreateSkill")]
        [AllowAnonymous]
        public IActionResult CreateSkill([FromBody] CreateSkillDto skillDto)
        {
            _higherObjectCreatorService.CreateSkill(skillDto);
            return Ok();
        }

        [HttpPost("CreateClass")]
        [AllowAnonymous]
        public IActionResult CreateClass([FromBody] CreateClassDto classDto)
        {
            _higherObjectCreatorService.CreateClass(classDto);
            return Ok();
        }
    }
}
