using System;
using EFCore.Entity.Concrete;
using EFCore.Shared.Dtos;

namespace EFCore.Buissnes.Abstract;

public interface ICategoryService
{
   Task<Category>CreateAsync(Category category);
    Task<CategoryDto> CreateAsync(CategoryCreateDto categoryCreateDto);
   Task<CategoryDto> UpdateAsync(CategoryUpdateDto categoryCreateDto);
   Task DeleteAsync(int id);
   Task<IEnumerable<CategoryDto>>GetCategoriesAsync(bool isDeleted);
   Task<CategoryDto>GetByIdAsync(int id);
}
