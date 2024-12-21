using System;
using EFCore.Entity.Concrete;

namespace EFCore.Data.Abstract;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId);
    Task<IEnumerable<Product>> GetAllDeletedProductsAsync(bool isDeleted = true);
}
