using CharacterSheetApi.Models;
using CharacterSheetApi.Models.CharacterSheetDtos;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApi.Services
{
    public interface ICharacterSheetService
    {
        void AddWeapon (AddWeaponDto dto);
        void DeleteWeapon(DeleteWeaponDto dto);
        void AddArmor(AddArmorDto dto);
        void DeleteArmor(DeleteArmorDto dto);
        void AddEquipment(AddEquipmentDto dto);
        void DeleteEquipment(DeleteEquipmentDto dto);
        void AddSkill(AddSkillDto dto);
        void DeleteSkill(DeleteSkillDto dto);
        void AddAbility(AddAbilityDto dto);
        void DeleteAbility(DeleteAbilityDto dto);
        FileStreamResult PrintSheet(int characterSheetId);
    }
}