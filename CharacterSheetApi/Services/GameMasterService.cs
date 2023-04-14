using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{
    public class GameMasterService : IGameMasterService
    {
        private readonly Context _context;
        private readonly IUserContextService _userContextService;

        public GameMasterService(Context context, IUserContextService userContextService)
        {
            _context = context;
            _userContextService = userContextService;
        }

        public void CreateArmor(CreateArmorDto dto)
        {
            var armor = new Armor();
            armor.Name = dto.Name;
            armor.ArmorPoints = dto.ArmorPoints;
            armor.Weight = dto.Weight;
            armor.ArmorTypeId = dto.ArmorType;
            armor.BodyLocations = _context.BodyLocations.ToList().Join(dto.BodyLocations, c => c.BodyLocationsId, d => d, (c, d) => c).ToList();
            _context.Armors.Add(armor);
            var dupa = armor.BodyLocations;
            _context.SaveChanges();
        }

        public void DeleteArmor(int armorId)
        {
            var armor = _context.Armors.FirstOrDefault(c => c.Id == armorId);
            _context.Armors.Remove(armor);
            _context.SaveChanges();
        }

        public void CreateWeapon(CreateWeaponDto dto)
        {
            var weapon = new Weapon();
            weapon.Name = dto.Name;
            weapon.Weight = dto.Weight;
            weapon.WeaponStrength = dto.WeaponStrenght;
            weapon.Range = dto.Range;
            weapon.ReloadTime = dto.ReloadTime;
            weapon.WeaponCategoryId = dto.WeaponCategory;
            weapon.WeaponCharacteristics = _context.WeaponsCharacteristics.ToList().Join(dto.WeaponCharacteristics, c => c.WeaponCharacteristicsId, d => d, (c, d) => c).ToList();
            _context.Weapons.Add(weapon);
            _context.SaveChanges();
        }

        public void DeleteWeapon(int weaponId)
        {
            var weapon = _context.Weapons.FirstOrDefault(c => c.Id == weaponId);
            _context.Weapons.Remove(weapon);
            _context.SaveChanges();
        }

        public void CreateEquipment(CreateEquipmentDto dto)
        {
            var equipment = new Equipment();
            equipment.Name = dto.Name;
            equipment.Description = dto.Description;
            equipment.Weight = dto.Weight;
            _context.Equipments.Add(equipment);
            _context.SaveChanges();
        }

        public void DeleteEquipment(int equipmentId)
        {
            var equipment = _context.Equipments.FirstOrDefault(c => c.Id == equipmentId);
            _context.Equipments.Remove(equipment);
            _context.SaveChanges();
        }

        public void CreateAbility(CreateAbilityDto dto)
        {
            var ability = new Ability();
            ability.Name = dto.Name;
            ability.Description = dto.Description;
            _context.Abilities.Add(ability);
            _context.SaveChanges();
        }

        public void DeleteAbility(int abilityId)
        {
            var ability = _context.Abilities.FirstOrDefault(c => c.Id == abilityId);
            _context.Abilities.Remove(ability);
            _context.SaveChanges();
        }

        public void CreateSkill(CreateSkillDto dto)
        {
            var skill = new Skill();
            skill.Name = dto.Name;
            skill.SkillLevelId = dto.SkillLevelId;
            _context.Skills.Add(skill);
            _context.SaveChanges();
        }

        public void DeleteSkill(int skillId)
        {
            var skill = _context.Skills.FirstOrDefault(c => c.Id == skillId);
            _context.Skills.Remove(skill);
            _context.SaveChanges();
        }

        public void CreateClass(CreateClassDto dto)
        {
            var newClass = new Class();
            newClass.Name = dto.Name;
            _context.Classes.Add(newClass);
            _context.SaveChanges();
        }

        public void DeleteClass(int classId)
        {
            var classe = _context.Class.FirstOrDefault(c => c.Id == classId);
            _context.Classes.Remove(classe);
            _context.SaveChanges();
        }
    }
}