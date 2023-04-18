using CharacterSheetApi.Models;
using CharacterSheetApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApi.Controllers
{
    [Route("api/game-master")]
    [ApiController]
    [Authorize(Roles = "GameMaster")]
    public class GameMasterController : ControllerBase
    {
        private IGameMasterService _gameMasterService;

        public GameMasterController(IGameMasterService gameMasterService)
        {
            _gameMasterService = gameMasterService;
        }

        [HttpPost("armor-creation")]
        public IActionResult CreateArmor([FromBody] CreateArmorDto armorDto)
        {
            _gameMasterService.CreateArmor(armorDto);
            return Ok();
        }

        [HttpDelete("armor-deletion/{id}")]
        public IActionResult DeleteArmor([FromBody] int armorId)
        {
            _gameMasterService.DeleteArmor(armorId);
            return Ok();
        }

        [HttpPost("weapon-creation")]
        public IActionResult CreateWeapon([FromBody] CreateWeaponDto weaponDto)
        {
            _gameMasterService.CreateWeapon(weaponDto);
            return Ok();
        }

        [HttpDelete("weapon-deletion/{id}")]
        public IActionResult DeleteWeapon([FromBody] int weaponId)
        {
            _gameMasterService.DeleteWeapon(weaponId);
            return Ok();
        }

        [HttpPost("equipment-creation")]
        public IActionResult CreateEquipment([FromBody] CreateEquipmentDto equipmentDto)
        {
            _gameMasterService.CreateEquipment(equipmentDto);
            return Ok();
        }

        [HttpDelete("equipment-deletion/{id}")]
        public IActionResult DeleteEquipment([FromBody] int equipmentId)
        {
            _gameMasterService.DeleteEquipment(equipmentId);
            return Ok();
        }

        [HttpPost("ability-creation")]
        public IActionResult CreateAblity([FromBody] CreateAbilityDto abilityDto)
        {
            _gameMasterService.CreateAbility(abilityDto);
            return Ok();
        }

        [HttpDelete("ability-deletion/{id}")]
        public IActionResult DeleteAbility([FromBody] int abilityId)
        {
            _gameMasterService.DeleteAbility(abilityId);
            return Ok();
        }

        [HttpPost("skill-creation")]
        public IActionResult CreateSkill([FromBody] CreateSkillDto skillDto)
        {
            _gameMasterService.CreateSkill(skillDto);
            return Ok();
        }

        [HttpDelete("skill-deletion/{id}")]
        public IActionResult DeleteSkill([FromBody] int skillId)
        {
            _gameMasterService.DeleteSkill(skillId);
            return Ok();
        }

        [HttpPost("class-creation")]
        public IActionResult CreateClass([FromBody] CreateClassDto classDto)
        {
            _gameMasterService.CreateClass(classDto);
            return Ok();
        }

        [HttpDelete("class-deletion/{id}")]
        public IActionResult DeleteClass([FromBody] int classId)
        {
            _gameMasterService.DeleteClass(classId);
            return Ok();
        }
    }
}