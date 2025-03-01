using System;
using EShop.MVC.Models;

namespace EShop.MVC.Services.Interfaces;

public interface IProductService
{
    Task<ResponseModel<List<ProductModel>>> GetAllActivesAsync();
    Task<ResponseModel<List<ProductModel>>> GetAllAsync();
    Task<ResponseModel<List<ProductModel>>> GetAllDeletedAsync();
    Task<ResponseModel<List<ProductModel>>> GetByIdAsync(int id);
    Task<ResponseModel<List<ProductModel>>> CreateAsync(ProductModel productCreateModel);
    Task<ResponseModel<List<ProductModel>>> CreateAsync(ProductModel productCreateModel);
    Task<ResponseModel<List<ProductModel>>> CreateAsync(ProductModel productCreateModel);
}
