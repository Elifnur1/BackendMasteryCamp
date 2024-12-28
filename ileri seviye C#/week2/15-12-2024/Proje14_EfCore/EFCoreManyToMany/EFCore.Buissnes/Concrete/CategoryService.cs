using System;
using EFCore.Buissnes.Abstract;
using EFCore.Entity.Concrete;
using EFCore.Shared.Dtos;

namespace EFCore.Buissnes.Concrete;

public class CategoryService : ICategoryService
{
    public Task<Category> CreateAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryDto> CreateAsync(CategoryCreateDto categoryCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CategoryDto>> GetCategoriesAsync(bool isDeleted)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryDto> UpdateAsync(CategoryUpdateDto categoryCreateDto)
    {
        throw new NotImplementedException();
    }
}
