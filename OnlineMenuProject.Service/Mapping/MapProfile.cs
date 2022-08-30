using AutoMapper;
using OnlineMenuProject.Core.Dtos;
using OnlineMenuProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMenuProject.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //Category Map Profile
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<CategoryAddDto, Category>();


            //Product Map Profile
            CreateMap<ProductAddDto, Product>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductUpdateDto, Product>();
            
        }
    }
}