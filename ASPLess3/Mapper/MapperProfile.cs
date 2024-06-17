using ASPLess3.Dto;
using ASPLess3.Models;
using AutoMapper;

namespace ASPLess3.Mapper
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			CreateMap<Product, ProductDto>().ReverseMap();
			CreateMap<ProductGroup, ProductGroupDto>().ReverseMap();
		}
	}
}
