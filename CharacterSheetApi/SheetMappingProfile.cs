using AutoMapper;
using CharacterSheetApi.Entities;
using CharacterSheetApi.Models;
using CharacterSheetApi.Models.CharacterSheetDtos;
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
        }
    }
}