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

        [HttpPost("armor")]
        public IActionResult CreateArmor([FromBody] CreateArmorDto armorDto)
        {
            _gameMasterService.CreateArmor(armorDto);
            return Ok();
        }

        [HttpDelete("armor/{id}")]
        public IActionResult DeleteArmor([FromBody] int armorId)
        {
            _gameMasterService.DeleteArmor(armorId);
            return Ok();
        }

        [HttpPost("weapon")]
        public IActionResult CreateWeapon([FromBody] CreateWeaponDto weaponDto)
        {
            _gameMasterService.CreateWeapon(weaponDto);
            return Ok();
        }

        [HttpDelete("weapon/{id}")]
        public IActionResult DeleteWeapon([FromBody] int weaponId)
        {
            _gameMasterService.DeleteWeapon(weaponId);
            return Ok();
        }

        [HttpPost("equipment")]
        public IActionResult CreateEquipment([FromBody] CreateEquipmentDto equipmentDto)
        {
            _gameMasterService.CreateEquipment(equipmentDto);
            return Ok();
        }

        [HttpDelete("equipment/{id}")]
        public IActionResult DeleteEquipment([FromBody] int equipmentId)
        {
            _gameMasterService.DeleteEquipment(equipmentId);
            return Ok();
        }

        [HttpPost("ability")]
        public IActionResult CreateAblity([FromBody] CreateAbilityDto abilityDto)
        {
            _gameMasterService.CreateAbility(abilityDto);
            return Ok();
        }

        [HttpDelete("ability/{id}")]
        public IActionResult DeleteAbility([FromBody] int abilityId)
        {
            _gameMasterService.DeleteAbility(abilityId);
            return Ok();
        }

        [HttpPost("skill")]
        public IActionResult CreateSkill([FromBody] CreateSkillDto skillDto)
        {
            _gameMasterService.CreateSkill(skillDto);
            return Ok();
        }

        [HttpDelete("skill/{id}")]
        public IActionResult DeleteSkill([FromBody] int skillId)
        {
            _gameMasterService.DeleteSkill(skillId);
            return Ok();
        }

        [HttpPost("class")]
        public IActionResult CreateClass([FromBody] CreateClassDto classDto)
        {
            _gameMasterService.CreateClass(classDto);
            return Ok();
        }

        [HttpDelete("class/{id}")]
        public IActionResult DeleteClass([FromBody] int classId)
        {
            _gameMasterService.DeleteClass(classId);
            return Ok();
        }
    }
}