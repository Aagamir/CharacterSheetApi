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
            int id = _gameMasterService.CreateArmor(armorDto);
            string uri = $"api/armor={id}";
            return Created(uri, "Armor Created");
        }

        [HttpDelete("armor/{id}")]
        public IActionResult DeleteArmor([FromRoute] int id)
        {
            _gameMasterService.DeleteArmor(id);
            return NoContent();
        }

        [HttpPost("weapon")]
        public IActionResult CreateWeapon([FromBody] CreateWeaponDto weaponDto)
        {
            int id = _gameMasterService.CreateWeapon(weaponDto);
            string uri = $"api/weapon={id}";
            return Created(uri, "Weapon Created");
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
            int id = _gameMasterService.CreateEquipment(equipmentDto);
            string uri = $"api/equipment={id}";
            return Created(uri, "Equipment Created");
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
            int id = _gameMasterService.CreateAbility(abilityDto);
            string uri = $"api/ability={id}";
            return Created(uri, "Ability Created");
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
            int id = _gameMasterService.CreateSkill(skillDto);
            string uri = $"api/skill={id}";
            return Created(uri, "Skill Created");
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
            int id = _gameMasterService.CreateClass(classDto);
            string uri = $"api/class={id}";
            return Created(uri, "Class Created");
        }

        [HttpDelete("class/{id}")]
        public IActionResult DeleteClass([FromRoute] int id)
        {
            _gameMasterService.DeleteClass(id);
            return Ok();
        }
    }
}