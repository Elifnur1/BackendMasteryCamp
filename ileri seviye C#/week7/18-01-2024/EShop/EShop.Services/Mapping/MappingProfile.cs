using System;
using AutoMapper;
using EShop.Entity.Concrete;
using EShop.Shared.Dtos;

namespace EShop.Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Category
            CreateMap<Category, CategoryDto>().ReverseMap(); //ReverseMap() yazılmış olan dönüşümün tam tersi yönde de yapılabilmesini sağlayan metotur.
            CreateMap<Category, CategoryCreateDto>().ReverseMap(); //category tipindeki nesneyi , ctegoryCreateDto tipinde ki nesneye dönüşümünü sağlamış olduk.
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();

            #endregion
        }
    }
}
