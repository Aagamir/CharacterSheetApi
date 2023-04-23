using CharacterSheetApi.Entities;
using CharacterSheetApi.Models;
using CharacterSheetApi.Models.CharacterSheetDtos;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApi.Services
{
    public interface ICharacterSheetService
    {
        void AddWeapon(List<int> weaponIds, int id);

        void DeleteWeapon(int weaponId, int id);

        void AddArmor(List<int> armorIds, int id);

        void DeleteArmor(int armorid, int id);

        void AddEquipment(List<int> equipmentIds, int id);

        void DeleteEquipment(int equipmentIds, int id);

        void AddSkill(List<int> skillids, int id);

        void DeleteSkill(int skillId, int id);

        void AddAbility(List<int> AddAbility, int id);

        void DeleteAbility(int abilityId, int id);

        FileStreamResult PrintSheet(int characterSheetId);
    }
}