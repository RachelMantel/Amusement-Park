using AmusementPark.Core.DTOs;
using AmusementPark.Core.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerEntity, CustomerDto>().ReverseMap();

            CreateMap<EmployeeEntity, EmployeeDto>().ReverseMap();

            CreateMap<FacilitieEntity, FacilitieDto>().ReverseMap();

            CreateMap<OrderEntity, OrderDto>().ReverseMap();

            CreateMap<TicketEntity, TicketDto>().ReverseMap();
        }
    }
}
