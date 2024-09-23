using AutoMapper;
using ProductService.DTO;
using ProductService.Model;

namespace ProductService.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }  
    }
}
