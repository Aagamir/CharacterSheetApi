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

        [HttpPost("CreateSheet")]
        [AllowAnonymous]
        public ActionResult CreateSheet([FromBody] CreateSheetDto sheetDto)
        {
            int newSheetId = _characterSheetService.CreateSheet(sheetDto);
            return Ok(newSheetId);
        }

        [HttpPost("CreateCharacterDescription")]
        [AllowAnonymous]
        public ActionResult CreateCharacterDescription([FromBody]CreateDescriptionDto characterDescriptionDto)
        {
            int newDescriptionId = _characterSheetService.CreateCharacterDescription(characterDescriptionDto);
            return Ok(newDescriptionId);
        }
        
        [HttpPost("CreateArmor")]
        [AllowAnonymous]
        public IActionResult CreateArmor ([FromBody]CreateArmorDto armorDto)
        {
            _characterSheetService.CreateArmor(armorDto);
            return Ok();
        }

        [HttpPost("CreateWeapon")]
        [AllowAnonymous]
        public IActionResult CreateWeapon([FromBody]CreateWeaponDto weaponDto)
        {
            _characterSheetService.CreateWeapon(weaponDto);
            return Ok();
        }

        [HttpPost("CreateMonetaryWealth")]
        [AllowAnonymous]
        public IActionResult CreateMonetaryWealth([FromBody] CreateMonetaryWealthDto monetaryWealthDto)
        {
            int newMonetaryWealthId = _characterSheetService.CreateMonetaryWealth(monetaryWealthDto);
            return Ok(newMonetaryWealthId);
        }

        [HttpPost("CreateExpiriencePoints")]
        [AllowAnonymous]
        public IActionResult CreateExpiriencePoints([FromBody] CreateExpiriencePointsDto expiriencePointsDto)
        {
            int newExpiriencePointsId = _characterSheetService.CreateExpiriencePoints(expiriencePointsDto);
            return Ok(newExpiriencePointsId);
        }

        [HttpPost("CreatePlayerInfo")]
        [AllowAnonymous]
        public IActionResult CreatePlayerInfo([FromBody] CreatePlayerInfoDto playerInfoDto)
        {
            int newPlayerInfoId = _characterSheetService.CreatePlayerInfo(playerInfoDto);
            return Ok(newPlayerInfoId);
        }

        [HttpPost("CreateEquipment")]
        [AllowAnonymous]
        public IActionResult CreateEquipment([FromBody] CreateEquipmentDto equipmentDto)
        {
            _characterSheetService.CreateEquipment(equipmentDto);
            return Ok();
        }

        [HttpPost("CreateAbility")]
        [AllowAnonymous]
        public IActionResult CreateAblity([FromBody] CreateAbilityDto abilityDto)
        {
            _characterSheetService.CreateAbility(abilityDto);
            return Ok();
        }

        [HttpPost("CreateSkill")]
        [AllowAnonymous]
        public IActionResult CreateSkill([FromBody] CreateSkillDto skillDto)
        {
            _characterSheetService.CreateSkill(skillDto);
            return Ok();
        }

        [HttpPost("CreateCurrentClass")]
        [AllowAnonymous]
        public IActionResult CreateCurrentClass([FromBody] CreateCurrentClassDto currentClassDto)
        {
            int newCurrentClassId = _characterSheetService.CreateCurrentClass(currentClassDto);
            return Ok(newCurrentClassId);
        }

        [HttpPost("CreateLastClass")]
        [AllowAnonymous]
        public IActionResult CreateLastClass([FromBody] CreateLastClassDto lastClassDto)
        {
            int newLastClassId = _characterSheetService.CreateLastClass(lastClassDto);
            return Ok(newLastClassId);
        }

        [HttpPost("CreateBaseStats")]
        [AllowAnonymous]
        public IActionResult CreateBaseStats([FromBody]int characterDescriptionId)
        {
            int newBaseStatsId = _characterSheetService.CreateBaseStats(characterDescriptionId);
            return Ok(newBaseStatsId);
        }

        [HttpPost("CreateCharacterInfo/CharacterCard")]
        [AllowAnonymous]
        public IActionResult CreateCharacterInfo([FromBody] CreateCharacterInfoDto characterInfoDto)
        {
            int newCharacterInfoId = _characterSheetService.CreateCharacterInfo(characterInfoDto);
            return Ok(newCharacterInfoId);
        }
        
        [HttpPost("AddWeapon")]
        [AllowAnonymous]
        public IActionResult AddWeapon([FromBody] AddWeaponDto weaponDto)
        {
            _characterSheetService.AddWeapon(weaponDto);
            return Ok();
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
