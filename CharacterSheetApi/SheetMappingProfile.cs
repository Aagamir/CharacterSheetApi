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
                .ForMember(x => x.BodyLocations, opt => opt.Ignore())
                .ForMember(x => x.ArmorType, opt => opt.Ignore());

            CreateMap<Ability, CreateAbilityDto>();

            /*
            CreateMap<Users, RegisterUserDto>()
                .ForMember(m => m.Name, c => c.MapFrom(m => m.Name))
                .ForMember(m => m.Email, c => c.MapFrom(m => m.Email))
                .ForMember(m => m.Password, c => c.MapFrom(m => m.Password))
            */
        }
    }
}