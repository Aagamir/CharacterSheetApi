using CharacterSheetApi.Entities;
using CharacterSheetApi.Models;
using CharacterSheetApi.Models.playerDtos;
using CharacterSheetApi.Models.PlayerDtos;

namespace CharacterSheetApi.Services
{
    public interface IPlayerService
    {
        int CreateSheet(CreateSheetDto dto);

        void ChangeSheet(CreateSheetDto sheetDto, int id);

        int CreateCharacterDescription(CreateDescriptionDto dto);

        void ChangeCharacterDescription(ChangeCharacterDescriptionDto dto);

        void ChangeBaseStats(ChangeStatsDto dto, int id);

        int CreateMonetaryWealth(CreateMonetaryWealthDto dto);

        void ChangeMonetaryWealth(CreateMonetaryWealthDto dto, int id);

        int CreateExpiriencePoints(CreateExpiriencePointsDto dto);

        void ChangeExpiriencePoints(CreateExpiriencePointsDto dto, int id);

        int CreatePlayerInfo(CreatePlayerInfoDto dto);

        int CreateCharacterInfo(CreateCharacterInfoDto dto);

        List<GetAllWeaponsDto> GetAllWeapons();

        List<GetAllArmorsDto> GetAllArmors();

        List<GetAllEquipmentsDto> GetAllEquipments();

        List<GetAllSkillsDto> GetAllSkills();

        List<GetAllAbilitiesDto> GetAllAbilities();
    }
}