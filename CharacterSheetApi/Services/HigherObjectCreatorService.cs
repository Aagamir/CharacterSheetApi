﻿using CharacterSheetApi.Entities;
using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{
    public class HigherObjectCreatorService : IHigherObjectCreatorService
    {
        private readonly Context _context;
        private readonly IUserContextService _userContextService;

        public HigherObjectCreatorService(Context context, IUserContextService userContextService)
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
            //Zrobić BodyLocations/ponieważ mogą być robione customowe armory
            _context.Armors.Add(armor);
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
            //Zrobić WeaponCharacteristics bo mogą być customowe bronie
            _context.Weapons.Add(weapon);
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

        public void CreateAbility(CreateAbilityDto dto)
        {
            var ability = new Ability();
            ability.Name = dto.Name;
            ability.Description = dto.Description;
            _context.Abilities.Add(ability);
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

        public void CreateClass(CreateClassDto dto)
        {
            var newClass = new Class();
            newClass.Name = dto.Name;
            _context.Classes.Add(newClass);
            _context.SaveChanges();
        }
    }
}
