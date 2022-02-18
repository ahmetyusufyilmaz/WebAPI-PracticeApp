using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Practices.Entities;
using WebAPI_Practices.Entities.ViewModels;

namespace WebAPI_Practices.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, GetProductViewModel>().ForMember(dest => dest.Category,
                opt => opt.MapFrom(src => src.Category.CategoryName));

            CreateMap<PostProductQueryViewModel, Product>();
        }
    }
}
