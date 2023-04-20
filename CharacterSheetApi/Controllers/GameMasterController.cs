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
        public IActionResult DeleteArmor([FromRoute] int id)
        {
            _gameMasterService.DeleteArmor(id);
            return Ok();
        }

        [HttpPost("weapon")]
        public IActionResult CreateWeapon([FromBody] CreateWeaponDto weaponDto)
        {
            _gameMasterService.CreateWeapon(weaponDto);
            return Ok();
        }

        [HttpDelete("weapon/{id}")]
        public IActionResult DeleteWeapon([FromRoute] int id)
        {
            _gameMasterService.DeleteWeapon(id);
            return Ok();
        }

        [HttpPost("equipment")]
        public IActionResult CreateEquipment([FromBody] CreateEquipmentDto equipmentDto)
        {
            _gameMasterService.CreateEquipment(equipmentDto);
            return Ok();
        }

        [HttpDelete("equipment/{id}")]
        public IActionResult DeleteEquipment([FromRoute] int id)
        {
            _gameMasterService.DeleteEquipment(id);
            return Ok();
        }

        [HttpPost("ability")]
        public IActionResult CreateAblity([FromBody] CreateAbilityDto abilityDto)
        {
            _gameMasterService.CreateAbility(abilityDto);
            return Ok();
        }

        [HttpDelete("ability/{id}")]
        public IActionResult DeleteAbility([FromRoute] int id)
        {
            _gameMasterService.DeleteAbility(id);
            return Ok();
        }

        [HttpPost("skill")]
        public IActionResult CreateSkill([FromBody] CreateSkillDto skillDto)
        {
            _gameMasterService.CreateSkill(skillDto);
            return Ok();
        }

        [HttpDelete("skill/{id}")]
        public IActionResult DeleteSkill([FromRoute] int id)
        {
            _gameMasterService.DeleteSkill(id);
            return Ok();
        }

        [HttpPost("class")]
        public IActionResult CreateClass([FromBody] CreateClassDto classDto)
        {
            _gameMasterService.CreateClass(classDto);
            return Ok();
        }

        [HttpDelete("class/{id}")]
        public IActionResult DeleteClass([FromRoute] int id)
        {
            _gameMasterService.DeleteClass(id);
            return Ok();
        }
    }
}