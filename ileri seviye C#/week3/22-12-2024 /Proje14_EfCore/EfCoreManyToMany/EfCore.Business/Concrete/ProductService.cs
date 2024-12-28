using System;
using System.Security.Cryptography.X509Certificates;
using EfCore.Business.Abstract;
using EfCore.Data.Abstract;
using EfCore.Entity.Concrete;
using EfCore.Shared.Dtos;

namespace EfCore.Business.Concrete;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ProductDto> CreateAsync(ProductCreateDto productCreateDto)
    {
        var product = new Product
        {
            Name = productCreateDto.Name,
            Price = productCreateDto.Price,
            Properties = productCreateDto.Properties
        };
        await _productRepository.AddAsync(product);
        product.ProductCategories = productCreateDto
                                    .CategoryIds.Select(x=>new ProductCategory{
                                        ProductId=product.Id,
                                        CategoryId=x
                                    }).ToList();
                                    await _productRepository.UpdateAsync(product);
                                    var ProductDto=new ProductDto{
                                        Id=product.Id,
                                        Name=product.Name,
                                        Price=product.Price,
                                        Properties=product.Properties
                                    };
                                    return ProductDto;
    }

    public async Task DeleteAsync(int id)
    {
        var product=await _productRepository.GetByIdAsync(id);
        await _productRepository.DeleteAsync(product);
    }

    public async Task<ProductDto> GetByIdAsync(int id)
    {
        var product=await _productRepository.GetByIdAsync(id);
        var ProductDto=new ProductDto{
            Id=product.Id,
            Name=product.Name,
            IsDeleted=product.IsDeleted,
            Price=product.Price,
            Properties=product.Properties,
            Categories=product.ProductCategories.Select(x=>new CategoryDto{
                Id=x.CategoryId,
                Name=x.Category.Name,
                Description=x.Category.Description
            }).ToList()
        };
        return ProductDto;
    }

    public async Task<IEnumerable<ProductDto>> GetProductsAsync()
    {
        var product=await _productRepository.GetAllAsync();
        var productDtos=product
                       .Select(x=>new ProductDto
                       {
                        Id=x.Id,
                        Name=x.Name,
                        Properties=x.Properties,
                        Price=x.Price,
                        IsDeleted=x.IsDeleted
                       }).ToList();
                       return productDtos;
                       
    }
    

    public Task<IEnumerable<ProductDto>> GetProductsAsync(bool isDeleted)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductDto>> GetProductsByCategoryAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> UpdateAsync(ProductUpdateDto productUpdateDto)
    {
        throw new NotImplementedException();
    }
}
