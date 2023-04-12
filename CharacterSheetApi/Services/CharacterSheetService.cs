using CharacterSheetApi.Entities;
using CharacterSheetApi.Models;
using CharacterSheetApi.Models.CharacterSheetDtos;
using Microsoft.AspNetCore.Mvc;
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

        public void AddWeapon(AddWeaponDto dto)
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
            List<Armor> armors = _context.Armors.ToList().Join(dto.ArmorIds, c => c.Id, d => d, (c, d) => c).ToList();
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
            List<Equipment> equipments = _context.Equipments.ToList().Join(dto.EquipmentIds, c => c.Id, d => d, (c, d) => c).ToList();
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
            var skills = _context.Skills.ToList().Join(dto.SkillIds, c => c.Id, d => d, (c, d) => c).ToList();
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

        public FileStreamResult PrintSheet(int characterSheetId)
        {
            var characterSheet = _context.CharacterSheets.Include(c => c.CharacterInfo)
                .Include(c => c.CharacterInfo.CharacterDescription)
                .Include(c => c.CharacterInfo.Class).Include(c => c.CharacterInfo.ExpiriencePoints)
                .Include(c => c.CharacterInfo.BaseStats)
                .Include(c => c.CharacterInfo.CurrentStats)
                .Include(c => c.CharacterInfo.Armor)
                .FirstOrDefault(c => c.Id == characterSheetId);
            //var characterDescription = characterSheet.CharacterDescription;

            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            PdfDocument doc = PdfDocument.FromFile(@$"{projectDirectory}\repos\CharacterSheetApi\Karta.pdf");
            var form = doc.Form;

            //Bohater
            form.Fields[0].Value = characterSheet.CharacterInfo.Name;
            form.Fields[1].Value = characterSheet.CharacterInfo.CharacterDescription.RaceId.ToString();
            form.Fields[2].Value = _context.Class.FirstOrDefault(c => c.Id == characterSheet.CharacterInfo.Class.Id).Name;
            form.Fields[2].Value = characterSheet.CharacterInfo.Class.Name;
            if (characterSheet.CharacterInfo.LastClass != null)
            {
                form.Fields[3].Value = characterSheet.CharacterInfo.LastClass.ToString();
            }
            //Opis Bohatera
            form.Fields[4].Value = characterSheet.CharacterInfo.CharacterDescription.Age.ToString();
            form.Fields[5].Value = characterSheet.CharacterInfo.CharacterDescription.GenderId.ToString();
            form.Fields[6].Value = characterSheet.CharacterInfo.CharacterDescription.EyeColorId.ToString();
            form.Fields[7].Value = characterSheet.CharacterInfo.CharacterDescription.Weight.ToString();
            form.Fields[8].Value = characterSheet.CharacterInfo.CharacterDescription.HairColorId.ToString();
            form.Fields[9].Value = characterSheet.CharacterInfo.CharacterDescription.Height.ToString();
            form.Fields[10].Value = characterSheet.CharacterInfo.CharacterDescription.StarSignId.ToString();
            form.Fields[11].Value = characterSheet.CharacterInfo.CharacterDescription.Siblings.ToString();
            form.Fields[12].Value = characterSheet.CharacterInfo.CharacterDescription.PlaceOfBirth;
            form.Fields[13].Value = characterSheet.CharacterInfo.CharacterDescription.CharacteriticSigns;
            //Gracz
            form.Fields[14].Value = characterSheet.CreatorName;
            //Punkty Doświadczenia
            form.Fields[18].Value = characterSheet.CharacterInfo.ExpiriencePoints.CurrentPoints.ToString();
            form.Fields[19].Value = characterSheet.CharacterInfo.ExpiriencePoints.OverallPoints.ToString();
            //Cechy
            form.Fields[31].Value = characterSheet.CharacterInfo.BaseStats.WW.ToString();
            form.Fields[32].Value = characterSheet.CharacterInfo.BaseStats.US.ToString();
            form.Fields[33].Value = characterSheet.CharacterInfo.BaseStats.K.ToString();
            form.Fields[34].Value = characterSheet.CharacterInfo.BaseStats.Odp.ToString();
            form.Fields[35].Value = characterSheet.CharacterInfo.BaseStats.Zr.ToString();
            form.Fields[36].Value = characterSheet.CharacterInfo.BaseStats.Int.ToString();
            form.Fields[37].Value = characterSheet.CharacterInfo.BaseStats.SW.ToString();
            form.Fields[38].Value = characterSheet.CharacterInfo.BaseStats.Ogd.ToString();
            form.Fields[39].Value = null;
            form.Fields[40].Value = null;
            form.Fields[41].Value = null;
            form.Fields[42].Value = null;
            form.Fields[43].Value = null;
            form.Fields[44].Value = null;
            form.Fields[45].Value = null;
            form.Fields[46].Value = null;
            form.Fields[47].Value = characterSheet.CharacterInfo.CurrentStats.WW.ToString();
            form.Fields[48].Value = characterSheet.CharacterInfo.CurrentStats.US.ToString();
            form.Fields[49].Value = characterSheet.CharacterInfo.CurrentStats.K.ToString();
            form.Fields[50].Value = characterSheet.CharacterInfo.CurrentStats.Odp.ToString();
            form.Fields[51].Value = characterSheet.CharacterInfo.CurrentStats.Zr.ToString();
            form.Fields[52].Value = characterSheet.CharacterInfo.CurrentStats.Int.ToString();
            form.Fields[53].Value = characterSheet.CharacterInfo.CurrentStats.SW.ToString();
            form.Fields[54].Value = characterSheet.CharacterInfo.CurrentStats.Ogd.ToString();
            form.Fields[79].Value = characterSheet.CharacterInfo.CurrentStats.A.ToString();
            form.Fields[80].Value = characterSheet.CharacterInfo.CurrentStats.Zyw.ToString();
            form.Fields[81].Value = characterSheet.CharacterInfo.CurrentStats.S.ToString();
            form.Fields[82].Value = characterSheet.CharacterInfo.CurrentStats.Wt.ToString();
            form.Fields[83].Value = characterSheet.CharacterInfo.CurrentStats.Sz.ToString();
            form.Fields[84].Value = characterSheet.CharacterInfo.CurrentStats.Mag.ToString();
            form.Fields[85].Value = characterSheet.CharacterInfo.CurrentStats.PO.ToString();
            form.Fields[86].Value = characterSheet.CharacterInfo.CurrentStats.PP.ToString();
            form.Fields[63].Value = characterSheet.CharacterInfo.BaseStats.A.ToString();
            form.Fields[64].Value = characterSheet.CharacterInfo.BaseStats.Zyw.ToString();
            form.Fields[65].Value = characterSheet.CharacterInfo.BaseStats.S.ToString();
            form.Fields[66].Value = characterSheet.CharacterInfo.BaseStats.Wt.ToString();
            form.Fields[67].Value = characterSheet.CharacterInfo.BaseStats.Sz.ToString();
            form.Fields[68].Value = characterSheet.CharacterInfo.BaseStats.Mag.ToString();
            form.Fields[69].Value = characterSheet.CharacterInfo.BaseStats.PO.ToString();
            form.Fields[70].Value = characterSheet.CharacterInfo.BaseStats.PP.ToString();
            form.Fields[71].Value = null;
            form.Fields[72].Value = null;
            form.Fields[73].Value = null;
            form.Fields[74].Value = null;
            form.Fields[75].Value = null;
            form.Fields[76].Value = null;
            form.Fields[77].Value = null;
            form.Fields[78].Value = null;
            //Punkty Zbroi
            form.Fields[87].Value = (characterSheet.CharacterInfo.CurrentStats.Wt + characterSheet.CharacterInfo.Armor.Where(a => a.BodyLocations.Any(b => b.BodyLocationsId == Enums.BodyLocationsId.Head)).Sum(a => a.ArmorPoints)).ToString();
            form.Fields[88].Value = (characterSheet.CharacterInfo.CurrentStats.Wt + characterSheet.CharacterInfo.Armor.Where(a => a.BodyLocations.Any(b => b.BodyLocationsId == Enums.BodyLocationsId.Torso)).Sum(a => a.ArmorPoints)).ToString();
            form.Fields[89].Value = (characterSheet.CharacterInfo.CurrentStats.Wt + characterSheet.CharacterInfo.Armor.Where(a => a.BodyLocations.Any(b => b.BodyLocationsId == Enums.BodyLocationsId.RightArm)).Sum(a => a.ArmorPoints)).ToString();
            form.Fields[90].Value = (characterSheet.CharacterInfo.CurrentStats.Wt + characterSheet.CharacterInfo.Armor.Where(a => a.BodyLocations.Any(b => b.BodyLocationsId == Enums.BodyLocationsId.LeftArm)).Sum(a => a.ArmorPoints)).ToString();
            form.Fields[91].Value = (characterSheet.CharacterInfo.CurrentStats.Wt + characterSheet.CharacterInfo.Armor.Where(a => a.BodyLocations.Any(b => b.BodyLocationsId == Enums.BodyLocationsId.RightLeg)).Sum(a => a.ArmorPoints)).ToString();
            form.Fields[92].Value = (characterSheet.CharacterInfo.CurrentStats.Wt + characterSheet.CharacterInfo.Armor.Where(a => a.BodyLocations.Any(b => b.BodyLocationsId == Enums.BodyLocationsId.LeftLeg)).Sum(a => a.ArmorPoints)).ToString();
            /*
            form.Fields[93].Value = ;
            form.Fields[94].Value = ;
            form.Fields[95].Value = ;
            form.Fields[96].Value = ;
            form.Fields[97].Value = ;
            form.Fields[98].Value = ;
            form.Fields[99].Value = ;
            form.Fields[100].Value = ;
            form.Fields[101].Value = ;
            form.Fields[102].Value = ;
            form.Fields[103].Value = ;
            form.Fields[104].Value = ;
            form.Fields[105].Value = ;
            form.Fields[106].Value = ;
            form.Fields[107].Value = ;
            form.Fields[108].Value = ;
            form.Fields[109].Value = ;
            form.Fields[110].Value = ;
            form.Fields[111].Value = ;
            form.Fields[112].Value = ;
            form.Fields[113].Value = ;
            form.Fields[114].Value = ;
            form.Fields[115].Value = ;
            form.Fields[116].Value = ;
            form.Fields[117].Value = ;
            form.Fields[118].Value = ;
            form.Fields[119].Value = ;
            form.Fields[120].Value = ;
            form.Fields[121].Value = ;
            form.Fields[122].Value = ;
            form.Fields[123].Value = ;
            form.Fields[124].Value = ;
            form.Fields[125].Value = ;
            form.Fields[126].Value = ;
            form.Fields[127].Value = ;
            form.Fields[128].Value = ;
            form.Fields[129].Value = ;
            form.Fields[130].Value = ;
            form.Fields[131].Value = ;
            form.Fields[132].Value = ;
            form.Fields[133].Value = ;
            form.Fields[134].Value = ;
            form.Fields[135].Value = ;
            form.Fields[136].Value = ;
            form.Fields[137].Value = ;
            form.Fields[138].Value = ;
            form.Fields[139].Value = ;
            form.Fields[140].Value = ;
            form.Fields[141].Value = ;
            form.Fields[142].Value = ;
            form.Fields[143].Value = ;
            form.Fields[144].Value = ;
            form.Fields[145].Value = ;
            form.Fields[146].Value = ;
            form.Fields[147].Value = ;
            form.Fields[148].Value = ;
            form.Fields[149].Value = ;
            form.Fields[150].Value = ;
            form.Fields[151].Value = ;
            form.Fields[152].Value = ;
            form.Fields[153].Value = ;
            form.Fields[154].Value = ;
            form.Fields[155].Value = ;
            form.Fields[156].Value = ;
            form.Fields[157].Value = ;
            form.Fields[158].Value = ;
            form.Fields[159].Value = ;
            form.Fields[160].Value = ;
            form.Fields[161].Value = ;
            form.Fields[162].Value = ;
            form.Fields[163].Value = ;
            form.Fields[164].Value = ;
            form.Fields[165].Value = ;
            form.Fields[166].Value = ;
            form.Fields[167].Value = ;
            form.Fields[168].Value = ;
            form.Fields[169].Value = ;
            form.Fields[170].Value = ;
            form.Fields[171].Value = ;
            form.Fields[172].Value = ;
            form.Fields[173].Value = ;
            form.Fields[174].Value = ;
            form.Fields[175].Value = ;
            form.Fields[176].Value = ;
            form.Fields[177].Value = ;
            form.Fields[178].Value = ;
            form.Fields[179].Value = ;
            form.Fields[180].Value = ;
            form.Fields[181].Value = ;
            form.Fields[182].Value = ;
            form.Fields[183].Value = ;
            form.Fields[184].Value = ;
            form.Fields[185].Value = ;
            form.Fields[186].Value = ;
            form.Fields[187].Value = ;
            form.Fields[188].Value = ;
            form.Fields[189].Value = ;
            form.Fields[190].Value = ;
            form.Fields[191].Value = ;
            form.Fields[192].Value = ;
            form.Fields[193].Value = ;
            form.Fields[194].Value = ;
            form.Fields[195].Value = ;
            form.Fields[196].Value = ;
            form.Fields[197].Value = ;
            form.Fields[198].Value = ;
            form.Fields[199].Value = ;
            form.Fields[200].Value = ;
            form.Fields[201].Value = ;
            form.Fields[202].Value = ;
            form.Fields[203].Value = ;
            form.Fields[204].Value = ;
            form.Fields[205].Value = ;
            form.Fields[206].Value = ;
            form.Fields[207].Value = ;
            form.Fields[208].Value = ;
            form.Fields[209].Value = ;
            form.Fields[210].Value = ;
            form.Fields[211].Value = ;
            form.Fields[212].Value = ;
            form.Fields[213].Value = ;
            form.Fields[214].Value = ;
            form.Fields[215].Value = ;
            form.Fields[216].Value = ;
            form.Fields[217].Value = ;
            form.Fields[218].Value = ;
            form.Fields[219].Value = ;
            form.Fields[220].Value = ;
            form.Fields[221].Value = ;
            form.Fields[222].Value = ;
            form.Fields[223].Value = ;
            form.Fields[224].Value = ;
            form.Fields[225].Value = ;
            form.Fields[226].Value = ;
            form.Fields[227].Value = ;
            form.Fields[228].Value = ;
            form.Fields[229].Value = ;
            form.Fields[230].Value = ;
            form.Fields[231].Value = ;
            form.Fields[232].Value = ;
            form.Fields[233].Value = ;
            form.Fields[234].Value = ;
            form.Fields[235].Value = ;
            form.Fields[236].Value = ;
            form.Fields[237].Value = ;
            form.Fields[238].Value = ;
            form.Fields[239].Value = ;
            form.Fields[240].Value = ;
            form.Fields[241].Value = ;
            form.Fields[242].Value = ;
            form.Fields[243].Value = ;
            form.Fields[244].Value = ;
            form.Fields[245].Value = ;
            form.Fields[246].Value = ;
            form.Fields[247].Value = ;
            form.Fields[248].Value = ;
            form.Fields[249].Value = ;
            form.Fields[250].Value = ;
            form.Fields[251].Value = ;
            form.Fields[252].Value = ;
            form.Fields[253].Value = ;
            form.Fields[254].Value = ;
            form.Fields[255].Value = ;
            form.Fields[256].Value = ;
            form.Fields[257].Value = ;
            form.Fields[258].Value = ;
            form.Fields[259].Value = ;
            form.Fields[260].Value = ;
            form.Fields[261].Value = ;
            form.Fields[262].Value = ;
            form.Fields[263].Value = ;
            form.Fields[264].Value = ;
            form.Fields[265].Value = ;
            form.Fields[266].Value = ;
            form.Fields[267].Value = ;
            form.Fields[268].Value = ;
            form.Fields[269].Value = ;
            form.Fields[270].Value = ;
            form.Fields[271].Value = ;
            form.Fields[272].Value = ;
            form.Fields[273].Value = ;
            form.Fields[274].Value = ;
            form.Fields[275].Value = ;
            form.Fields[276].Value = ;
            form.Fields[277].Value = ;
            form.Fields[278].Value = ;
            form.Fields[279].Value = ;
            form.Fields[280].Value = ;
            form.Fields[281].Value = ;
            form.Fields[282].Value = ;
            form.Fields[283].Value = ;
            form.Fields[284].Value = ;
            form.Fields[285].Value = ;
            form.Fields[286].Value = ;
            form.Fields[287].Value = ;
            form.Fields[288].Value = ;
            form.Fields[289].Value = ;
            form.Fields[290].Value = ;
            form.Fields[291].Value = ;
            form.Fields[292].Value = ;
            form.Fields[293].Value = ;
            form.Fields[294].Value = ;
            form.Fields[295].Value = ;
            form.Fields[296].Value = ;
            form.Fields[297].Value = ;
            form.Fields[298].Value = ;
            form.Fields[299].Value = ;
            form.Fields[300].Value = ;
            form.Fields[301].Value = ;
            form.Fields[302].Value = ;
            form.Fields[303].Value = ;
            form.Fields[304].Value = ;
            form.Fields[305].Value = ;
            form.Fields[306].Value = ;
            form.Fields[307].Value = ;
            form.Fields[308].Value = ;
            form.Fields[309].Value = ;
            form.Fields[310].Value = ;
            form.Fields[311].Value = ;
            form.Fields[312].Value = ;
            form.Fields[313].Value = ;
            form.Fields[314].Value = ;
            form.Fields[315].Value = ;
            form.Fields[316].Value = ;
            form.Fields[317].Value = ;
            form.Fields[318].Value = ;
            form.Fields[319].Value = ;
            form.Fields[320].Value = ;
            form.Fields[321].Value = ;
            form.Fields[322].Value = ;
            form.Fields[323].Value = ;
            form.Fields[324].Value = ;
            form.Fields[325].Value = ;
            form.Fields[326].Value = ;
            form.Fields[327].Value = ;
            form.Fields[328].Value = ;
            form.Fields[329].Value = ;
            form.Fields[330].Value = ;
            form.Fields[331].Value = ;
            form.Fields[332].Value = ;
            form.Fields[333].Value = ;
            form.Fields[334].Value = ;
            form.Fields[335].Value = ;
            form.Fields[336].Value = ;
            form.Fields[337].Value = ;
            form.Fields[338].Value = ;
            form.Fields[339].Value = ;
            form.Fields[340].Value = ;
            form.Fields[341].Value = ;
            form.Fields[342].Value = ;
            form.Fields[343].Value = ;
            form.Fields[344].Value = ;
            form.Fields[345].Value = ;
            form.Fields[346].Value = ;
            form.Fields[347].Value = ;
            form.Fields[348].Value = ;
            form.Fields[349].Value = ;
            form.Fields[350].Value = ;
            form.Fields[351].Value = ;
            form.Fields[352].Value = ;
            form.Fields[353].Value = ;
            form.Fields[354].Value = ;
            form.Fields[355].Value = ;
            form.Fields[356].Value = ;
            form.Fields[357].Value = ;
            form.Fields[358].Value = ;
            form.Fields[359].Value = ;
            form.Fields[360].Value = ;
            form.Fields[361].Value = ;
            form.Fields[362].Value = ;
            form.Fields[363].Value = ;
            form.Fields[364].Value = ;
            form.Fields[365].Value = ;
            form.Fields[366].Value = ;
            form.Fields[367].Value = ;
            form.Fields[368].Value = ;
            form.Fields[369].Value = ;
            form.Fields[370].Value = ;
            form.Fields[371].Value = ;
            form.Fields[372].Value = ;
            form.Fields[373].Value = ;
            form.Fields[374].Value = ;
            form.Fields[375].Value = ;
            form.Fields[376].Value = ;
            form.Fields[377].Value = ;
            form.Fields[378].Value = ;
            form.Fields[379].Value = ;
            form.Fields[380].Value = ;
            form.Fields[381].Value = ;
            form.Fields[382].Value = ;
            form.Fields[383].Value = ;
            form.Fields[384].Value = ;
            form.Fields[385].Value = ;
            form.Fields[386].Value = ;
            form.Fields[387].Value = ;
            form.Fields[388].Value = ;
            form.Fields[389].Value = ;
            form.Fields[390].Value = ;
            form.Fields[391].Value = ;
            form.Fields[392].Value = ;
            form.Fields[393].Value = ;
            form.Fields[394].Value = ;
            form.Fields[395].Value = ;
            form.Fields[396].Value = ;
            form.Fields[397].Value = ;
            form.Fields[398].Value = ;
            form.Fields[399].Value = ;
            form.Fields[400].Value = ;
            */
            //form.Fields[0].Value = characterInfo.Name;
            /*
            form.GetFieldByName("Rasa:").Value = characterDescription.Race;
            form.GetFieldByName("Obecna Profesja:").Value = characterInfo.Class;
            form.GetFieldByName("Wiek:").Value = characterDescription.Age;
            form.GetFieldByName("Kolor Oczu:").Value = characterDescription.EyeColor;
            form.GetFieldByName("Kolor Włosów:").Value = characterDescription.HairColor;
            form.GetFieldByName("Znak Gwiezdny:").Value = characterDescription.StarSign;
            */

            Stream pdf = doc.Stream;
            FileStreamResult stream = new FileStreamResult(pdf, "application/pdf")
            {
                FileDownloadName = $"Karta_{characterSheet.RpgSystemId}_{characterSheet.CreatorName}_#{characterSheetId}.pdf"
            };
            return stream;
        }
    }
}