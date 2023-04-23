using AutoMapper;
using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using CharacterSheetApi.Exceptions;
using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{
    public class GameMasterService : IGameMasterService
    {
        private readonly Context _context;
        private readonly IUserContextService _userContextService;
        private readonly IMapper _mapper;

        public GameMasterService(Context context, IUserContextService userContextService, IMapper mapper)
        {
            _context = context;
            _userContextService = userContextService;
            _mapper = mapper;
        }

        public int CreateArmor(CreateArmorDto dto)
        {
            var armor = _mapper.Map<Armor>(dto);
            armor.BodyLocations = _context.BodyLocations.ToList().Join(dto.BodyLocations, c => c.BodyLocationsId, d => d, (c, d) => c).ToList();
            _context.Armors.Add(armor);
            _context.SaveChanges();
            return armor.Id;
        }

        public void DeleteArmor(int armorId)
        {
            var armor = _context.Armors.FirstOrDefault(c => c.Id == armorId);
            if (armor is null)
            {
                throw new NotFoundException("Armor not found");
            }
            _context.Armors.Remove(armor);
            _context.SaveChanges();
        }

        public int CreateWeapon(CreateWeaponDto dto)
        {
            var weapon = _mapper.Map<Weapon>(dto);
            weapon.WeaponCharacteristics = _context.WeaponsCharacteristics.ToList().Join(dto.WeaponCharacteristics, c => c.WeaponCharacteristicsId, d => d, (c, d) => c).ToList();
            _context.Weapons.Add(weapon);
            _context.SaveChanges();
            return weapon.Id;
        }

        public void DeleteWeapon(int weaponId)
        {
            var weapon = _context.Weapons.FirstOrDefault(c => c.Id == weaponId);
            if (weapon is null)
            {
                throw new NotFoundException("Weapon not found");
            }
            _context.Weapons.Remove(weapon);
            _context.SaveChanges();
        }

        public int CreateEquipment(CreateEquipmentDto dto)
        {
            var equipment = _mapper.Map<Equipment>(dto);
            _context.Equipments.Add(equipment);
            _context.SaveChanges();
            return equipment.Id;
        }

        public void DeleteEquipment(int equipmentId)
        {
            var equipment = _context.Equipments.FirstOrDefault(c => c.Id == equipmentId);
            if (equipment is null)
            {
                throw new NotFoundException("Equipment not found");
            }
            _context.Equipments.Remove(equipment);
            _context.SaveChanges();
        }

        public int CreateAbility(CreateAbilityDto dto)
        {
            var ability = _mapper.Map<Ability>(dto);
            _context.Abilities.Add(ability);
            _context.SaveChanges();
            return ability.Id;
        }

        public void DeleteAbility(int abilityId)
        {
            var ability = _context.Abilities.FirstOrDefault(c => c.Id == abilityId);
            if (ability is null)
            {
                throw new NotFoundException("Ability not found");
            }
            _context.Abilities.Remove(ability);
            _context.SaveChanges();
        }

        public int CreateSkill(CreateSkillDto dto)
        {
            var skill = _mapper.Map<Skill>(dto);
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return skill.Id;
        }

        public void DeleteSkill(int skillId)
        {
            var skill = _context.Skills.FirstOrDefault(c => c.Id == skillId);
            if (skill is null)
            {
                throw new NotFoundException("Skill not found");
            }
            _context.Skills.Remove(skill);
            _context.SaveChanges();
        }

        public int CreateClass(CreateClassDto dto)
        {
            var newClass = _mapper.Map<Class>(dto);
            _context.Classes.Add(newClass);
            _context.SaveChanges();
            return newClass.Id;
        }

        public void DeleteClass(int classId)
        {
            var classe = _context.Class.FirstOrDefault(c => c.Id == classId);
            if (classe is null)
            {
                throw new NotFoundException("Class not found");
            }
            _context.Classes.Remove(classe);
            _context.SaveChanges();
        }
    }
}