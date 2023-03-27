using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using CharacterSheetApi.Models;
using CharacterSheetApi.Models.CharacterSheetDtos;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetApi.Services
{

    public class CharacterSheetService : ICharacterSheetService
    {
        private readonly Context _context;
        private readonly IUserContextService _userContextService;

        public CharacterSheetService(Context context, IUserContextService userContextService)
        {
            _context = context;
            _userContextService = userContextService;
        }

        public void AddWeapon(AddWeaponDto dto )
        {
            var characterInfo = _context.CharacterInfos.FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            if (characterInfo.Weapons is null)
            {
                characterInfo.Weapons = new List<Weapon>();
            }
            var weapons = _context.Weapons.ToList().Join(dto.WeaponIds, c => c.Id, d => d, (c, d) => c).ToList();//_context.Weapons.FirstOrDefault(w => w.Id == dto.WeaponId);
            //jak nie znajdzie to błąd
            characterInfo.Weapons.AddRange(weapons);
            //jak nie znajdzie to błąd
            _context.SaveChanges();
        }
        public void DeleteWeapon(DeleteWeaponDto dto)
        {
            var characterInfo = _context.CharacterInfos.Include(c => c.Weapons).FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            //custom błąd jeżeli null
            var weapon = characterInfo.Weapons.FirstOrDefault(a => a.Id == dto.WeaponId);
            //custom błąd jeżeli null
            characterInfo.Weapons.Remove(weapon);
            _context.SaveChanges();
        }

        public void AddArmor(AddArmorDto dto)
        {
            var characterInfo = _context.CharacterInfos.FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            if (characterInfo.Armor is null)
            {
                characterInfo.Armor = new List<Armor>();
            }
            List<Armor> armors = _context.Armors.ToList().Join(dto.ArmorIds, c => c.Id, d => d, (c,d) => c).ToList();
            characterInfo.Armor.AddRange(armors);
            _context.SaveChanges();
        }
        public void DeleteArmor(DeleteArmorDto dto)
        {
            var characterInfo = _context.CharacterInfos.Include(c => c.Armor).FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            //custom błąd jeżeli null
            var armor = characterInfo.Armor.FirstOrDefault(a => a.Id == dto.ArmorId);
            //custom błąd jeżeli null
            characterInfo.Armor.Remove(armor);
            _context.SaveChanges();
        }

        public void AddEquipment(AddEquipmentDto dto)
        {
            var characterInfo = _context.CharacterInfos.FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            if (characterInfo.Equipment is null)
            {
                characterInfo.Equipment = new List<Equipment>();
            }
            List<Equipment> equipments = _context.Equipments.ToList().Join(dto.EquipmentIds, c => c.Id, d => d, (c, d ) => c).ToList();
            characterInfo.Equipment.AddRange(equipments);
            _context.SaveChanges();
        }
        public void DeleteEquipment(DeleteEquipmentDto dto) 
        {
            var characterInfo = _context.CharacterInfos.Include(c => c.Equipment).FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            //custom błąd jeżeli null
            var equipment = characterInfo.Equipment.FirstOrDefault(a => a.Id == dto.EquipmentId);
            //custom błąd jeżeli null
            characterInfo.Equipment.Remove(equipment);
            _context.SaveChanges();
        }

        public void AddSkill(AddSkillDto dto)
        {
            var characterInfo = _context.CharacterInfos.FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            if (characterInfo.Skills is null)
            {
                characterInfo.Skills = new List<Skill>();
            }
            var dupa = _context.Skills;
            var skills = _context.Skills.ToList().Join(dto.SkillIds, c => c.Id, d => d, (c,d) => c).ToList();
            characterInfo.Skills.AddRange(skills);
            _context.SaveChanges();
        }
        public void DeleteSkill(DeleteSkillDto dto)
        {
            var characterInfo = _context.CharacterInfos.Include(c => c.Skills).FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            //custom błąd jeżeli null
            var skill = characterInfo.Skills.FirstOrDefault(a => a.Id == dto.SkillId);
            //custom błąd jeżeli null
            characterInfo.Skills.Remove(skill);
            _context.SaveChanges();
        }

        public void AddAbility(AddAbilityDto dto)
        {
            var characterInfo = _context.CharacterInfos.FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            if (characterInfo.Abilities is null)
            {
                characterInfo.Abilities = new List<Ability>();
            }
            List<Ability> abilities = _context.Abilities.ToList().Join(dto.AbilityIds, c => c.Id, d => d, (c, d) => c).ToList();
            characterInfo.Abilities.AddRange(abilities);
            _context.SaveChanges();
        }
        public void DeleteAbility(DeleteAbilityDto dto)
        {
            var characterInfo = _context.CharacterInfos.Include(c => c.Abilities).FirstOrDefault(c => c.Id == dto.characterInfoId);
            //custom błąd jeżeli null
            var ability = characterInfo.Abilities.FirstOrDefault(a => a.Id == dto.abilityId);
            //custom błąd jeżeli null
            characterInfo.Abilities.Remove(ability);
            _context.SaveChanges();
        }
    }
}
