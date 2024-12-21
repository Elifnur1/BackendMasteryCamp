using System;
using System.Runtime.CompilerServices;
using EFCore.Data.Abstract;
using EFCore.Data.Concrete.Contexts;
using EFCore.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data.Concrete.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<IEnumerable<Product>> GetAllDeletedProductsAsync(bool isDeleted = true)
    {
      var Products=await _appDbContext
                   .Products
                   .Where(x=>x.IsDeleted==isDeleted)
                   .ToListAsync();
                   return Products;
    }

    public async Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId)
    {
        //Include, içermek anlamına gelir ve ef core join yapmak yerine bu kavramı kullanmamızı       öneriyor sebebi daha işlevli ,performanslı olmasıdır.
        var Products =await _appDbContext
                    .Products
                    .Include(x=>x.ProductCategories)
                    .ThenInclude(y=>y.category)
                    .Where(x=>x.ProductCategories.Any(y=>y.categoryId==categoryId))
                    .ToListAsync();
                    return Products;
    }
}
