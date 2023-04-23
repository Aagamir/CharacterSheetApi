using AutoMapper;
using CharacterSheetApi.Entities;
using CharacterSheetApi.Models;
using CharacterSheetApi.Models.CharacterSheetDtos;
using CharacterSheetApi.Models.playerDtos;
using CharacterSheetApi.Models.PlayerDtos;
using CharacterSheetApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetApi
{
    public class SheetMappingProfile : Profile
    {
        public SheetMappingProfile()
        {
            CreateMap<CreateArmorDto, Armor>()
                .ForMember(x => x.BodyLocations, opt => opt.Ignore());

            CreateMap<CreateWeaponDto, Weapon>()
                .ForMember(x => x.WeaponCharacteristics, opt => opt.Ignore());

            CreateMap<CreateEquipmentDto, Equipment>();

            CreateMap<CreateAbilityDto, Ability>();

            CreateMap<CreateSkillDto, Skill>();

            CreateMap<CreateClassDto, Class>();

            CreateMap<CreatePlayerInfoDto, PlayerInfo>();

            CreateMap<CreateSheetDto, CharacterSheet>()
                .ForMember(x => x.DateOfCreation, opt => opt.Ignore())
                .ForMember(x => x.CharacterInfo, opt => opt.Ignore());

            CreateMap<CreateMonetaryWealthDto, MonetaryWealth>();

            CreateMap<CreateExpiriencePointsDto, ExpiriencePoints>();

            CreateMap<ChangeCharacterDescriptionDto, CharacterDescription>();

            CreateMap<Weapon, GetAllWeaponsDto>()
                .ForMember(x => x.WeaponCategory, opt => opt.Ignore())
                .ForMember(x => x.WeaponCharacteristics, opt => opt.Ignore());

            CreateMap<Armor, GetAllArmorsDto>()
                .ForMember(x => x.ArmorType, opt => opt.Ignore())
                .ForMember(x => x.BodyLocations, opt => opt.Ignore());

            CreateMap<Equipment, GetAllEquipmentsDto>();

            CreateMap<Skill, GetAllSkillsDto>()
                .ForMember(x => x.SkillLevel, opt => opt.Ignore());

            CreateMap<Ability, GetAllAbilitiesDto>();
        }
    }
}