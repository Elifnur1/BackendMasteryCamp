using System;
using EFCore.Entity.Concrete;
using EFCore.Shared.Dtos;

namespace EFCore.Buissnes.Abstract;

public interface IProductService
{
   Task<ProductDto>CreateAsync(ProductCreateDto productCreateDto);
   Task<ProductDto>UpdateAsync(ProductUpdateDto productUpdateDto);
    Task<ProductDto> UpdateAsync(CategoryUpdateDto categoryCreateDto);
    Task DeleteAsync(int id);
    Task<IEnumerable<ProductDto>> GetProductAsync(bool isDeleted);
    Task<IEnumerable<ProductDto>>GetProductsByCategoryAsync(int CategoryId);
    Task<ProductDto> GetByIdAsync(int id);

}
