using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{
    public interface IGameMasterService
    {
        int CreateArmor(CreateArmorDto armorDto);

        void DeleteArmor(int armorId);

        int CreateWeapon(CreateWeaponDto weaponDto);

        void DeleteWeapon(int weaponId);

        int CreateEquipment(CreateEquipmentDto dto);

        void DeleteEquipment(int equipmentId);

        int CreateAbility(CreateAbilityDto dto);

        void DeleteAbility(int abilityId);

        int CreateSkill(CreateSkillDto dto);

        void DeleteSkill(int skillId);

        int CreateClass(CreateClassDto dto);

        void DeleteClass(int classId);
    }
}