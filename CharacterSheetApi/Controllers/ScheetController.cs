using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using CharacterSheetApi.Models;
using CharacterSheetApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApi.Controllers
{
    [Route("api/sheet")]
    [ApiController]
    public class SheetControler : ControllerBase
    {
        private ICharacterSheetService _characterSheetService;
        public SheetControler( ICharacterSheetService characterSheetService)
        {
            _characterSheetService = characterSheetService;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetSheets()
        {
            var sheet = _characterSheetService;
            return Ok();
        }

        [HttpPost("SheetCreator")]
        [AllowAnonymous]
        public ActionResult CreateSheet([FromBody] CreateSheetDto sheetDto)
        {
            int newSheetId = _characterSheetService.SheetCreator(sheetDto);
            return Ok(newSheetId);
        }

        [HttpPost("CharacterDescriptionCreator")]
        [AllowAnonymous]
        public ActionResult CreateCharacterDescription([FromBody]CreateDescriptionDto characterDescriptionDto)
        {
            int newDescriptionId = _characterSheetService.CharacterDescriptionCreator(characterDescriptionDto);
            return Ok(newDescriptionId);
        }
        
        [HttpPost("AddArmor")]
        [AllowAnonymous]
        public IActionResult AddArmor ([FromBody]CreateArmorDto armorDto)
        {
            int newArmorId = _characterSheetService.ArmorCreator(armorDto);
            return Ok(newArmorId);
        }

        [HttpPost("AddWeapon")]
        [AllowAnonymous]
        public IActionResult AddWeapon([FromBody]CreateWeaponDto weaponDto)
        {
            int newWeaponId = _characterSheetService.WeaponCreator(weaponDto);
            return Ok(newWeaponId);
        }

        [HttpPost("AddMonetaryWealth")]
        [AllowAnonymous]
        public IActionResult AddMonetaryWealth([FromBody] CreateMonetaryWealthDto monetaryWealthDto)
        {
            int newMonetaryWealthId = _characterSheetService.MonetaryWealthCreator(monetaryWealthDto);
            return Ok(newMonetaryWealthId);
        }

        [HttpPost("AddExpiriencePoints")]
        [AllowAnonymous]
        public IActionResult AddExpiriencePoints([FromBody] CreateExpiriencePointsDto expiriencePointsDto)
        {
            int newExpiriencePointsId = _characterSheetService.ExpiriencePointsCreator(expiriencePointsDto);
            return Ok(newExpiriencePointsId);
        }

        [HttpPost("AddPlayerInfo")]
        [AllowAnonymous]
        public IActionResult AddPlayerInfo([FromBody] CreatePlayerInfoDto playerInfoDto)
        {
            int newPlayerInfoId = _characterSheetService.PlayerInfoCreator(playerInfoDto);
            return Ok(newPlayerInfoId);
        }

        [HttpPost("AddEquipment")]
        [AllowAnonymous]
        public IActionResult AddEquipment([FromBody] CreateEquipmentDto equipmentDto)
        {
            int newEquipmentId = _characterSheetService.EquipmentCreator(equipmentDto);
            return Ok(newEquipmentId);
        }

        [HttpPost("AddAbility")]
        [AllowAnonymous]
        public IActionResult AddAblity([FromBody] CreateAbilityDto abilityDto)
        {
            int newAbilityId = _characterSheetService.AbilityCreator(abilityDto);
            return Ok(newAbilityId);
        }

        [HttpPost("AddSkill")]
        [AllowAnonymous]
        public IActionResult AddSkill([FromBody] CreateSkillDto skillDto)
        {
            int newSkillId = _characterSheetService.SkillCreator(skillDto);
            return Ok(newSkillId);
        }

        [HttpPost("AddBaseStats")]
        [AllowAnonymous]
        public IActionResult AddBaseStats([FromBody]int characterDescriptionId)
        {
            int newBaseStatsId = _characterSheetService.BaseStatsCreator(characterDescriptionId);
            return Ok(newBaseStatsId);
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
