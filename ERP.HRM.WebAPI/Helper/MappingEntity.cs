using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.HRM.DTO;
using ERP.HRM.DTO.PersonelDTOS;
using ERP.Shared.Entities;

namespace ERP.HRM.WebAPI.Helper
{
    public class MappingEntity : Profile
    {
        public MappingEntity()
        {
            CreateMap<Personel, CreatePersonelDTO>().ReverseMap();
            CreateMap<Personel, PersonelGetByIdDTO>().ReverseMap();

            CreateMap<User, CreateUserDTO>().ReverseMap();
        }
    }
}
