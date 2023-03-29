using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using CharacterSheetApi.Models;
using CharacterSheetApi.Models.ObjectCreatorDtos;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetApi.Services
{
    public class ObjectCreatorService : IObjectCreatorService
    {
        private readonly Context _context;
        private readonly IUserContextService _userContextService;

        public ObjectCreatorService(Context context, IUserContextService userContextService)
        {
            _context = context;
            _userContextService = userContextService;
        }

        public int CreateSheet(CreateSheetDto dto)
        {
            var characterSheet = new CharacterSheet();
            characterSheet.Name = dto.Name;
            characterSheet.RpgSystemId = dto.RpgSystem;
            characterSheet.DateOfCreation = DateTime.Now;
            characterSheet.CreatorName = dto.CreatorName;
            characterSheet.CharacterInfo = _context.CharacterInfos.FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            _context.CharacterSheets.Add(characterSheet);
            _context.SaveChanges();
            return characterSheet.CharacterInfo.Id;
            //zwróć Id
        }
        public void ChangeSheet(ChangeSheetDto dto)
        {
            var characterSheet = _context.CharacterSheets.FirstOrDefault(c => c.Id == dto.CharacterSheetId);
            characterSheet.Name = dto.Name;
            characterSheet.RpgSystemId = dto.RpgSystem;
            characterSheet.CreatorName = dto.CreatorName;
            characterSheet.CharacterInfo = _context.CharacterInfos.FirstOrDefault(c => c.Id == dto.CharacterInfoId);
            _context.CharacterSheets.Add(characterSheet);
            _context.SaveChanges();
            //zwróć Id
        }

        public int CreateCharacterDescription(CreateDescriptionDto dto)
        {
            Random random = new Random();
            var characterDescription = new CharacterDescription();
            //Połączyć jakoś ID z SheetInfo / żeby było wiadomo do której karty które info 
            int raceIdNumber = random.Next(3);
            characterDescription.RaceId = dto.RaceId;//(RaceId)raceIdNumber;
            characterDescription.EyeColorId = (EyeColorId)random.Next(14);
            characterDescription.HairColorId = (HairColorId)random.Next(16);
            characterDescription.StarSignId = (StarSignId)random.Next(20);
            characterDescription.Weight = dto.Weight;
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
            //Tutaj może da się zrobić array, żeby unikac dużych switch/case i else if. Zapytać wojtka (to samo w wielu innych tabelkach 
            int[,] SiblingArray = new int[,] {{0, 0, 0, 1 }, {1, 1, 0, 2 }, {1, 1, 0, 2 }, {2, 1, 1, 3 }, {2, 1, 1, 3 }, {3, 2, 1, 4 }, {3, 2, 1, 4 }, {4, 2, 2, 5 }, {4, 2, 2, 5 }, {5, 3, 3, 6 }};
            characterDescription.Siblings = SiblingArray[random.Next(0, 9), raceIdNumber];
            characterDescription.GenderId = dto.GenderId;
            characterDescription.Age = dto.Age;
            characterDescription.PlaceOfBirth = dto.PlaceOfBirth;
            characterDescription.CharacteriticSigns = dto.CharacteriticSigns;
            _context.CharacterDescriptions.Add(characterDescription);
            _context.SaveChanges();
            return characterDescription.Id;
        }
        public void ChangeCharacterDescription(ChangeCharacterDescriptionDto dto)
        {
            //var characterSheet = _context.CharacterSheets.FirstOrDefault(c => c.Id == CharacterSheetId)

        }

        public int CreateBaseStats(int characterDescriptionId)
        {
            var baseStats = new BaseStats();
            var race = _context.CharacterDescriptions.FirstOrDefault(c => c.Id == characterDescriptionId).RaceId;
            Random random = new Random();
            int randomk10 = random.Next(1, 10);
            if (race == RaceId.Human)
            {
                baseStats.WW = 20 + randomk10 + randomk10;
                baseStats.US = 20 + randomk10 + randomk10;
                baseStats.K = 20 + randomk10 + randomk10;
                baseStats.Odp = 20 + randomk10 + randomk10;
                baseStats.Zr = 20 + randomk10 + randomk10;
                baseStats.Int = 20 + randomk10 + randomk10;
                baseStats.SW = 20 + randomk10 + randomk10;
                baseStats.Ogd = 20 + randomk10 + randomk10;
                baseStats.A = 1;
                baseStats.Zyw = randomk10;//to trzeba poprwaić na tabele
                baseStats.S = (baseStats.K - baseStats.K % 10) / 10;
                baseStats.Wt = (baseStats.Odp - baseStats.Odp % 10) / 10;
                baseStats.Sz = 0;
                baseStats.Mag = 0;
                baseStats.PO = 0;
                baseStats.PP = random.Next(1, 4);
            }
            else if (race == RaceId.Elf)
            {
                baseStats.WW = 20 + randomk10 + randomk10;
                baseStats.US = 30 + randomk10 + randomk10;
                baseStats.K = 20 + randomk10 + randomk10;
                baseStats.Odp = 20 + randomk10 + randomk10;
                baseStats.Zr = 30 + randomk10 + randomk10;
                baseStats.Int = 20 + randomk10 + randomk10;
                baseStats.SW = 20 + randomk10 + randomk10;
                baseStats.Ogd = 20 + randomk10 + randomk10;
                baseStats.A = 1;
                baseStats.Zyw = randomk10;//to trzeba poprwaić na tabele
                baseStats.S = (baseStats.K - baseStats.K % 10) / 10;
                baseStats.Wt = (baseStats.Odp - baseStats.Odp % 10) / 10;
                baseStats.Sz = 0;
                baseStats.Mag = 0;
                baseStats.PO = 0;
                baseStats.PP = random.Next(1, 4);
            }
            else if (race == RaceId.Dwarf)
            {
                baseStats.WW = 30 + randomk10 + randomk10;
                baseStats.US = 20 + randomk10 + randomk10;
                baseStats.K = 20 + randomk10 + randomk10;
                baseStats.Odp = 30 + randomk10 + randomk10;
                baseStats.Zr = 10 + randomk10 + randomk10;
                baseStats.Int = 20 + randomk10 + randomk10;
                baseStats.SW = 20 + randomk10 + randomk10;
                baseStats.Ogd = 10 + randomk10 + randomk10;
                baseStats.A = 1;
                baseStats.Zyw = randomk10;//to trzeba poprwaić na tabele
                baseStats.S = (baseStats.K - baseStats.K % 10) / 10;
                baseStats.Wt = (baseStats.Odp - baseStats.Odp % 10) / 10;
                baseStats.Sz = 0;
                baseStats.Mag = 0;
                baseStats.PO = 0;
                baseStats.PP = random.Next(1, 4);
            }
            else if (race == RaceId.Hafling)
            {
                baseStats.WW = 10 + randomk10 + randomk10;
                baseStats.US = 30 + randomk10 + randomk10;
                baseStats.K = 10 + randomk10 + randomk10;
                baseStats.Odp = 10 + randomk10 + randomk10;
                baseStats.Zr = 30 + randomk10 + randomk10;
                baseStats.Int = 20 + randomk10 + randomk10;
                baseStats.SW = 20 + randomk10 + randomk10;
                baseStats.Ogd = 30 + randomk10 + randomk10;
                baseStats.A = 1;
                baseStats.Zyw = randomk10;//to trzeba poprwaić na tabele
                baseStats.S = (baseStats.K - baseStats.K % 10) / 10;
                baseStats.Wt = (baseStats.Odp - baseStats.Odp % 10) / 10;
                baseStats.Sz = 0;
                baseStats.Mag = 0;
                baseStats.PO = 0;
                baseStats.PP = random.Next(1, 4);
            }
            _context.BaseStats.Add(baseStats);
            _context.SaveChanges();
            return baseStats.Id;
        }
        public void ChangeBaseStats(ChangeStatsDto dto)
        { 
            var stats = _context.BaseStats.FirstOrDefault(c => c.Id == dto.StatsId);
            /*
            foreach(var stat in stats)
            {
                if (dto.)
            }
            */

            if (dto.WW != 0)
            {
                stats.WW = dto.WW;
            }
            if (dto.US != 0)
            {
                stats.US = dto.US;
            }
            if (dto.K != 0)
            {
                stats.K = dto.K;
                stats.S = (stats.K - stats.K % 10) / 10;
            }
            if (dto.Odp != 0)
            {
                stats.Odp = dto.Odp;
                stats.Wt = (stats.Odp - stats.Odp % 10) / 10;
            }
            if (dto.Zr != 0)
            {
                stats.Zr = dto.Zr;
            }
            if (dto.Int != 0)
            {
                stats.Int = dto.Int;
            }
            if (dto.SW != 0)
            {
                stats.SW = dto.SW;
            }
            if (dto.Ogd != 0)
            {
                stats.Ogd = dto.Ogd;
            }
            if (dto.A != 0)
            {
                stats.A = dto.A;
            }
            if (dto.Zyw != 0)
            {
                stats.Zyw = dto.Zyw;
            }
            if (dto.Mag != 0)
            {
                stats.Mag = dto.Mag;
            }
            if (dto.PO != 0)
            {
                stats.PO = dto.PO;
            }
            if (dto.PP != 0)
            {
                stats.PP = dto.PP;
            }
            _context.SaveChanges();
        }

        public int CreateMonetaryWealth(CreateMonetaryWealthDto dto)
        {
            var monetaryWealth = new MonetaryWealth();
            monetaryWealth.GoldCrowns = dto.GoldCrowns;
            monetaryWealth.SilverShilling = dto.SilverShilling;
            monetaryWealth.CopperPences = dto.CopperPences;
            _context.MonetaryWealth.Add(monetaryWealth);
            _context.SaveChanges();
            return monetaryWealth.Id;
        }
        public void ChangeMonetaryWealth(ChangeMonetaryWealthDto dto)
        {
            var monetaryWealth = _context.MonetaryWealth.FirstOrDefault(x => x.Id == dto.MonetaryWealthId);
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
            var expiriencePoints = new ExpiriencePoints();
            expiriencePoints.CurrentPoints = dto.CurrentPoints;
            expiriencePoints.OverallPoints = dto.OverallPoints;
            _context.ExpiriencePoints.Add(expiriencePoints);
            _context.SaveChanges();
            return expiriencePoints.Id;
        }

        public int CreatePlayerInfo(CreatePlayerInfoDto dto)
        {
            var playerInfo = new PlayerInfo();
            playerInfo.PlayerName = dto.PlayerName;
            playerInfo.GameMasterName = dto.GameMasterName;
            playerInfo.CampaignName = dto.CampaignName;
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
            characterInfo.BaseStats = _context.BaseStats.FirstOrDefault(c => c.Id == dto.BaseStatsId);
            characterInfo.MonetaryWealth = _context.MonetaryWealth.FirstOrDefault(c => c.Id == dto.MonetaryWealthId);
            characterInfo.Name = dto.Name;
            characterInfo.Weapons = new List<Weapon>(); //_context.Weapons.ToList().Join(dto.WeaponIds, c => c.Id, d => d, (c, d) => new { c.Id });
            characterInfo.Armor = new List<Armor>(); //= _context.Armors.ToList().Join(dto.ArmorIds, c => c.Id, d => d, (c, d) => new { c.Id });
            characterInfo.Skills = new List<Skill>(); //_context.Skills.ToList().Join(dto.SkillIds, c => c.Id, d => d, (c, d) => new { c.Id });
            characterInfo.Abilities = new List<Ability>(); //_context.Abilities.ToList().Join(dto.AbilityIds, c => c.Id, d => d, (c, d) => new { c.Id });
            characterInfo.Equipment = new List<Equipment>(); //_context.Equipments.ToList().Join(dto.EquipmentIds, c => c.Id, d => d, (c, d) => new { c.Id });            
            _context.CharacterInfos.AddRange(characterInfo);
            _context.SaveChanges();
            return characterInfo.Id;
        }
    }
}

