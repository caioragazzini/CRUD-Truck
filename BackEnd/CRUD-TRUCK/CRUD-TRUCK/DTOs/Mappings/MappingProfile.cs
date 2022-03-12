using AutoMapper;
using CRUD_TRUCK.Models;

namespace CRUD_TRUCK.DTOs.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Truck, TruckDto>().ReverseMap();
            CreateMap<TruckModel, TruckModelDto>().ReverseMap();

        }
    }
}
