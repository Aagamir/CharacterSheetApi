using AutoMapper;
using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using CharacterSheetApi.Exceptions;
using CharacterSheetApi.Models;
using CharacterSheetApi.Models.playerDtos;
using CharacterSheetApi.Models.PlayerDtos;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetApi.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly Context _context;
        private readonly IUserContextService _userContextService;
        private readonly IMapper _mapper;

        public PlayerService(Context context, IUserContextService userContextService, IMapper mapper)
        {
            _context = context;
            _userContextService = userContextService;
            _mapper = mapper;
        }

        public int CreatePlayerInfo(CreatePlayerInfoDto dto)
        {
            var playerInfo = _mapper.Map<PlayerInfo>(dto);
            _context.PlayerInfo.Add(playerInfo);
            _context.SaveChanges();
            return playerInfo.Id;
        }

        public int CreateCharacterInfo(CreateCharacterInfoDto dto)
        {
            var characterInfo = new CharacterInfo();
            characterInfo.PlayerInfo = _context.PlayerInfo.FirstOrDefault(c => c.Id == dto.PlayerInfoId);
            characterInfo.ExpiriencePoints = _context.ExpiriencePoints.FirstOrDefault(c => c.Id == dto.ExpiriencePointsId);
            characterInfo.CharacterDescription = _context.CharacterDescriptions.FirstOrDefault(c => c.Id == dto.CharacterDescriptionId);
            characterInfo.Class = _context.Class.FirstOrDefault(c => c.Id == dto.ClassId);
            characterInfo.LastClass = _context.LastClass.FirstOrDefault(c => c.Id == dto.LastClassId);
            characterInfo.CharacterDescription.BaseStats = characterInfo.CharacterDescription.BaseStats;
            characterInfo.CharacterDescription.CurrentStats = characterInfo.CharacterDescription.CurrentStats;
            characterInfo.MonetaryWealth = _context.MonetaryWealth.FirstOrDefault(c => c.Id == dto.MonetaryWealthId);
            characterInfo.Name = dto.Name;
            characterInfo.Weapons = new List<Weapon>();
            characterInfo.Armor = new List<Armor>();
            characterInfo.Skills = new List<Skill>();
            characterInfo.Abilities = new List<Ability>();
            characterInfo.Equipment = new List<Equipment>();
            _context.CharacterInfos.AddRange(characterInfo);
            _context.SaveChanges();
            return characterInfo.Id;
        }

        public int CreateSheet(CreateSheetDto dto)
        {
            var characterSheet = _mapper.Map<CharacterSheet>(dto);
            characterSheet.DateOfCreation = DateTime.Now;
            characterSheet.CharacterInfo = _context.CharacterInfos.FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            _context.CharacterSheets.Add(characterSheet);
            _context.SaveChanges();
            return characterSheet.Id;
        }

        public void ChangeSheet(CreateSheetDto dto, int id)
        {
            var characterSheet = _context.CharacterSheets.FirstOrDefault(c => c.Id == id);
            if (characterSheet.UsersId != _userContextService.GetUserId)
            {
                throw new ForbiddenException("Nie masz uprawnień");
            }
            if (characterSheet is null)
            {
                throw new NotFoundException("Sheet not found");
            }
            characterSheet.Name = dto.Name;
            characterSheet.RpgSystemId = dto.RpgSystemId;
            characterSheet.CreatorName = dto.CreatorName;
            characterSheet.CharacterInfo = _context.CharacterInfos.FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            characterSheet.UsersId = _userContextService.GetUserId.Value;
            _context.CharacterSheets.Add(characterSheet);
            _context.SaveChanges();
        }

        public int CreateCharacterDescription(CreateDescriptionDto dto)
        {
            Random random = new Random();
            var characterDescription = new CharacterDescription();
            var baseStats = new BaseStats();
            var currentStats = new CurrentStats();
            var race = dto.RaceId;
            int raceIdNumber = random.Next(3);
            characterDescription.RaceId = dto.RaceId;
            characterDescription.Age = dto.Age;
            characterDescription.PlaceOfBirth = dto.PlaceOfBirth;
            characterDescription.Weight = dto.Weight;
            characterDescription.CharacteriticSigns = dto.CharacteriticSigns;
            characterDescription.EyeColorId = (EyeColorId)random.Next(14);
            characterDescription.HairColorId = (HairColorId)random.Next(16);
            characterDescription.StarSignId = (StarSignId)random.Next(20);
            switch (characterDescription.RaceId)
            {
                case RaceId.Human:
                    characterDescription.Height = 150 + random.Next(1, 10) + random.Next(1, 10);
                    break;

                case RaceId.Elf:
                    characterDescription.Height = 160 + random.Next(1, 10) + random.Next(1, 10);
                    break;

                case RaceId.Dwarf:
                    characterDescription.Height = 130 + random.Next(1, 10) + random.Next(1, 10);
                    break;

                case RaceId.Hafling:
                    characterDescription.Height = 100 + random.Next(1, 10) + random.Next(1, 10);
                    break;
            }
            int[,] SiblingArray = new int[,] { { 0, 0, 0, 1 }, { 1, 1, 0, 2 }, { 1, 1, 0, 2 }, { 2, 1, 1, 3 }, { 2, 1, 1, 3 }, { 3, 2, 1, 4 }, { 3, 2, 1, 4 }, { 4, 2, 2, 5 }, { 4, 2, 2, 5 }, { 5, 3, 3, 6 } };
            characterDescription.Siblings = SiblingArray[random.Next(0, 9), raceIdNumber];
            characterDescription.GenderId = dto.GenderId;

            if (race == RaceId.Human)
            {
                currentStats.WW = baseStats.WW = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.US = baseStats.US = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.K = baseStats.K = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Odp = baseStats.Odp = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Zr = baseStats.Zr = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Int = baseStats.Int = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.SW = baseStats.SW = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Ogd = baseStats.Ogd = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.A = baseStats.A = 1;
                currentStats.Zyw = baseStats.Zyw = random.Next(1, 10);
                currentStats.S = baseStats.S = (baseStats.K - baseStats.K % 10) / 10;
                currentStats.Wt = baseStats.Wt = (baseStats.Odp - baseStats.Odp % 10) / 10;
                currentStats.Sz = baseStats.Sz = 0;
                currentStats.Mag = baseStats.Mag = 0;
                currentStats.PO = baseStats.PO = 0;
                currentStats.PP = baseStats.PP = random.Next(1, 4);
            }
            else if (race == RaceId.Elf)
            {
                currentStats.WW = baseStats.WW = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.US = baseStats.US = 30 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.K = baseStats.K = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Odp = baseStats.Odp = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Zr = baseStats.Zr = 30 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Int = baseStats.Int = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.SW = baseStats.SW = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Ogd = baseStats.Ogd = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.A = baseStats.A = 1;
                currentStats.Zyw = baseStats.Zyw = random.Next(1, 10);
                currentStats.S = baseStats.S = (baseStats.K - baseStats.K % 10) / 10;
                currentStats.Wt = baseStats.Wt = (baseStats.Odp - baseStats.Odp % 10) / 10;
                currentStats.Sz = baseStats.Sz = 0;
                currentStats.Mag = baseStats.Mag = 0;
                currentStats.PO = baseStats.PO = 0;
                currentStats.PP = baseStats.PP = random.Next(1, 4);
            }
            else if (race == RaceId.Dwarf)
            {
                currentStats.WW = baseStats.WW = 30 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.US = baseStats.US = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.K = baseStats.K = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Odp = baseStats.Odp = 30 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Zr = baseStats.Zr = 10 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Int = baseStats.Int = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.SW = baseStats.SW = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Ogd = baseStats.Ogd = 10 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.A = baseStats.A = 1;
                currentStats.Zyw = baseStats.Zyw = random.Next(1, 10);
                currentStats.S = baseStats.S = (baseStats.K - baseStats.K % 10) / 10;
                currentStats.Wt = baseStats.Wt = (baseStats.Odp - baseStats.Odp % 10) / 10;
                currentStats.Sz = baseStats.Sz = 0;
                currentStats.Mag = baseStats.Mag = 0;
                currentStats.PO = baseStats.PO = 0;
                currentStats.PP = baseStats.PP = random.Next(1, 4);
            }
            else if (race == RaceId.Hafling)
            {
                currentStats.WW = baseStats.WW = 10 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.US = baseStats.US = 30 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.K = baseStats.K = 10 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Odp = baseStats.Odp = 10 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Zr = baseStats.Zr = 30 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Int = baseStats.Int = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.SW = baseStats.SW = 20 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.Ogd = baseStats.Ogd = 30 + random.Next(1, 10) + random.Next(1, 10);
                currentStats.A = baseStats.A = 1;
                currentStats.Zyw = baseStats.Zyw = random.Next(1, 10);
                currentStats.S = baseStats.S = (baseStats.K - baseStats.K % 10) / 10;
                currentStats.Wt = baseStats.Wt = (baseStats.Odp - baseStats.Odp % 10) / 10;
                currentStats.Sz = baseStats.Sz = 0;
                currentStats.Mag = baseStats.Mag = 0;
                currentStats.PO = baseStats.PO = 0;
                currentStats.PP = baseStats.PP = random.Next(1, 4);
            }
            characterDescription.BaseStats = baseStats;
            characterDescription.CurrentStats = currentStats;
            _context.CharacterDescriptions.Add(characterDescription);

            _context.SaveChanges();
            return characterDescription.Id;
        }

        public void ChangeCharacterDescription(ChangeCharacterDescriptionDto dto)
        {
            var characterSheet = _context.CharacterSheets.FirstOrDefault(c => c.CharacterInfo.CharacterDescription.Id == dto.CharacterDescriptionId);
            if (characterSheet.UsersId != _userContextService.GetUserId)
            {
                throw new ForbiddenException("Nie masz uprawnień");
            }
            if (characterSheet is null)
            {
                throw new NotFoundException("Sheet not found");
            }
            var characterDescription = _mapper.Map<CharacterDescription>(dto);
            _context.SaveChanges();
        }

        public void ChangeBaseStats(ChangeStatsDto dto, int id)
        {
            var characterSheet = _context.CharacterSheets.FirstOrDefault(c => c.CharacterInfo.CharacterDescription.BaseStats.Id == id);
            if (characterSheet.UsersId != _userContextService.GetUserId)
            {
                throw new ForbiddenException("Nie masz uprawnień");
            }
            if (characterSheet is null)
            {
                throw new NotFoundException("Sheet not found");
            }
            var baseStats = _context.BaseStats.FirstOrDefault(c => c.Id == id);
            var currentStats = _context.CurrentStats.FirstOrDefault(c => c.Id == id);

            foreach (var stat in dto.GetType().GetProperties())
            {
                var value = stat.GetValue(dto);
                var name = stat.Name;
                if (value is null)
                {
                    continue;
                }
                else
                {
                    baseStats.GetType().GetProperty(name).SetValue(baseStats, value);
                    currentStats.GetType().GetProperty(name).SetValue(currentStats, value);
                }
            }

            baseStats.S = currentStats.S = (baseStats.K - baseStats.K % 10) / 10;
            baseStats.Wt = currentStats.Wt = (baseStats.Odp - baseStats.Odp % 10) / 10;
            _context.SaveChanges();
        }

        public int CreateMonetaryWealth(CreateMonetaryWealthDto dto)
        {
            var monetaryWealth = _mapper.Map<MonetaryWealth>(dto);
            _context.MonetaryWealth.Add(monetaryWealth);
            _context.SaveChanges();
            return monetaryWealth.Id;
        }

        public void ChangeMonetaryWealth(CreateMonetaryWealthDto dto, int id)
        {
            var characterSheet = _context.CharacterSheets.FirstOrDefault(c => c.CharacterInfo.MonetaryWealth.Id == id);
            if (characterSheet.UsersId != _userContextService.GetUserId)
            {
                throw new ForbiddenException("Nie masz uprawnień");
            }
            var monetaryWealth = _context.MonetaryWealth.FirstOrDefault(x => x.Id == id);
            if (monetaryWealth is null)
            {
                throw new NotFoundException("Monetary wealth not found");
            }
            if (dto.CopperPences != null)
            {
                monetaryWealth.CopperPences = dto.CopperPences;
            }
            if (dto.SilverShilling != null)
            {
                monetaryWealth.SilverShilling = dto.SilverShilling;
            }
            if (dto.GoldCrowns != null)
            {
                monetaryWealth.GoldCrowns = dto.GoldCrowns;
            }
            _context.SaveChanges();
        }

        public int CreateExpiriencePoints(CreateExpiriencePointsDto dto)
        {
            var expiriencePoints = _mapper.Map<ExpiriencePoints>(dto);
            _context.ExpiriencePoints.Add(expiriencePoints);
            _context.SaveChanges();
            return expiriencePoints.Id;
        }

        public void ChangeExpiriencePoints(CreateExpiriencePointsDto dto, int id)
        {
            var characterSheet = _context.CharacterSheets.FirstOrDefault(c => c.CharacterInfo.ExpiriencePoints.Id == id);
            if (characterSheet.UsersId != _userContextService.GetUserId)
            {
                throw new ForbiddenException("Nie masz uprawnień");
            }
            if (characterSheet is null)
            {
                throw new NotFoundException("Sheet not found");
            }
            characterSheet.CharacterInfo.ExpiriencePoints.CurrentPoints = dto.CurrentPoints;
            characterSheet.CharacterInfo.ExpiriencePoints.OverallPoints = dto.OverallPoints;
            _context.SaveChanges();
        }

        //POZAMIENIAC ŻEBY NIE BYŁO WIDAĆ LIST CHARACTER INFO

        public List<GetAllWeaponsDto> GetAllWeapons()
        {
            var weapons = _context.Weapons.Include(w => w.WeaponCategory).Include(w => w.WeaponCharacteristics).ToList();
            var dto = new List<GetAllWeaponsDto>();
            foreach (Weapon weapon in weapons)
            {
                var map = _mapper.Map<GetAllWeaponsDto>(weapon);
                map.WeaponCategory = weapon.WeaponCategory.Name;
                var characteristics = new List<String>();
                foreach (var character in weapon.WeaponCharacteristics)
                {
                    var name = weapon.WeaponCharacteristics.FirstOrDefault(c => c.WeaponCharacteristicsId == character.WeaponCharacteristicsId).Name;
                    characteristics.Add(name);
                }
                map.WeaponCharacteristics = characteristics;
                dto.Add(map);
            }
            return dto;
        }

        public List<GetAllArmorsDto> GetAllArmors()
        {
            var armors = _context.Armors.Include(a => a.ArmorType).Include(a => a.BodyLocations).ToList();
            var dto = new List<GetAllArmorsDto>();
            foreach (Armor armor in armors)
            {
                var map = _mapper.Map<GetAllArmorsDto>(armor);
                map.ArmorType = armor.ArmorType.Name;
                var locations = new List<String>();
                foreach (var location in armor.BodyLocations)
                {
                    var name = armor.BodyLocations.FirstOrDefault(c => c.BodyLocationsId == location.BodyLocationsId).Name;
                    locations.Add(name);
                }
                map.BodyLocations = locations;
                dto.Add(map);
            }
            return dto;
        }

        public List<GetAllEquipmentsDto> GetAllEquipments()
        {
            var equipments = _context.Equipments.ToList();
            var dto = new List<GetAllEquipmentsDto>();
            foreach (Equipment equipment in equipments)
            {
                var map = _mapper.Map<GetAllEquipmentsDto>(equipment);
                dto.Add(map);
            }
            return dto;
        }

        public List<GetAllSkillsDto> GetAllSkills()
        {
            var skills = _context.Skills.Include(s => s.SkillLevel).ToList();
            var dto = new List<GetAllSkillsDto>();
            foreach (Skill skill in skills)
            {
                var map = _mapper.Map<GetAllSkillsDto>(skill);
                map.SkillLevel = skill.SkillLevel.Name;
                dto.Add(map);
            }
            return dto;
        }

        public List<GetAllAbilitiesDto> GetAllAbilities()
        {
            var abilities = _context.Abilities.ToList();
            var dto = new List<GetAllAbilitiesDto>();
            foreach (Ability ability in abilities)
            {
                var map = _mapper.Map<GetAllAbilitiesDto>(ability);
                dto.Add(map);
            }
            return dto;
        }
    }
}