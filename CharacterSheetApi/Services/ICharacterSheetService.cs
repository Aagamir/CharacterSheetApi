using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{
    public interface ICharacterSheetService
    {
        int SheetCreator(CreateSheetDto dto);
        int CharacterDescriptionCreator(CreateDescriptionDto characterDescriptionDto);
        int ArmorCreator(CreateArmorDto armorDto);
        int BaseStatsCreator(int characterDescriptionId);
        int WeaponCreator(CreateWeaponDto weaponDto);
        int MonetaryWealthCreator(CreateMonetaryWealthDto dto);
        int ExpiriencePointsCreator(CreateExpiriencePointsDto dto);
        int PlayerInfoCreator(CreatePlayerInfoDto dto);
        int EquipmentCreator(CreateEquipmentDto dto);
        int AbilityCreator(CreateAbilityDto dto);
        int SkillCreator(CreateSkillDto dto);
    }
}