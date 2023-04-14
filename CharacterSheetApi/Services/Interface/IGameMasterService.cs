using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{
    public interface IGameMasterService
    {
        void CreateArmor(CreateArmorDto armorDto);
        void DeleteArmor(int armorId);
        void CreateWeapon(CreateWeaponDto weaponDto);
        void DeleteWeapon(int weaponId);
        void CreateEquipment(CreateEquipmentDto dto);
        void DeleteEquipment(int equipmentId);
        void CreateAbility(CreateAbilityDto dto);
        void DeleteAbility(int abilityId);
        void CreateSkill(CreateSkillDto dto);
        void DeleteSkill(int skillId);
        void CreateClass(CreateClassDto dto);
        void DeleteClass(int classId);
    }
}
