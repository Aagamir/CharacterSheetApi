using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{
    public interface IHigherObjectCreatorService
    {
        void CreateArmor(CreateArmorDto armorDto);
        void CreateWeapon(CreateWeaponDto weaponDto);
        void CreateEquipment(CreateEquipmentDto dto);
        void CreateAbility(CreateAbilityDto dto);
        void CreateSkill(CreateSkillDto dto);
        void CreateClass(CreateClassDto dto);
    }
}
