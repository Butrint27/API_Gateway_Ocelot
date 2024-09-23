using AutoMapper;
using OrderService.DTO;
using OrderService.Model;

namespace OrderService.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Order, OrderDTO>().ReverseMap();
        }
    }
}
