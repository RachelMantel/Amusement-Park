using AmusementPark.Api.PostModels;
using AmusementPark.Core.DTOs;
using AmusementPark.Core.Entities;
using AutoMapper;

namespace AmusementPark.Api
{
    public class MappingPostProfile : Profile
    {
        public MappingPostProfile()
        {
            CreateMap<CustomerPostModel, CustomerDto>();
            CreateMap<EmployeePostModel, EmployeeDto>();
            CreateMap<FacilitiePostModel, FacilitieDto>();
            CreateMap<OrderPostModel, OrderDto>();
            CreateMap<TicketPostModel, TicketDto>();

        }
    }
}
