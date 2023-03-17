using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{
    public interface ICharacterSheetService
    {
        int CreateSheet(CreateSheetDto dto);
        int CreateCharacterDescription(CreateDescriptionDto characterDescriptionDto);
        void CreateArmor(CreateArmorDto armorDto);
        int CreateBaseStats(int characterDescriptionId);
        void CreateWeapon(CreateWeaponDto weaponDto);
        int CreateMonetaryWealth(CreateMonetaryWealthDto dto);
        int CreateExpiriencePoints(CreateExpiriencePointsDto dto);
        int CreatePlayerInfo(CreatePlayerInfoDto dto);
        void CreateEquipment(CreateEquipmentDto dto);
        void CreateAbility(CreateAbilityDto dto);
        void CreateSkill(CreateSkillDto dto);
        int CreateCurrentClass(CreateCurrentClassDto dto);
        int CreateLastClass(CreateLastClassDto dto);
        int CreateCharacterInfo(CreateCharacterInfoDto dto);
        void AddWeapon (AddWeaponDto dto);
    }
}