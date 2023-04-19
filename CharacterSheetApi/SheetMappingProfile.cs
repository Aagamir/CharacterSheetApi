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
            CreateMap<Armor, CreateArmorDto>()
                .ForMember(m => m.Name, c => c.MapFrom(m => m.Name))
                .ForMember(m => m.Weight, c => c.MapFrom(c => c.Weight))
                .ForMember(m => m.ArmorType, c => c.MapFrom(a => a.ArmorType))
                .ForMember(m => m.ArmorPoints, c => c.MapFrom(a => a.ArmorPoints))
                .ForMember(m => m.BodyLocations, c => c.MapFrom(a => a.BodyLocations));

            /*
            CreateMap<Users, RegisterUserDto>()
                .ForMember(m => m.Name, c => c.MapFrom(m => m.Name))
                .ForMember(m => m.Email, c => c.MapFrom(m => m.Email))
                .ForMember(m => m.Password, c => c.MapFrom(m => m.Password))
            */
        }
    }
}