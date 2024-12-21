using System;
using EFCore.Data.Abstract;
using EFCore.Data.Concrete.Contexts;
using EFCore.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data.Concrete.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<IEnumerable<Category>> GetAllDeletedCategoriesAsync(bool isDeleted = true)
    {
        var Categories=await _appDbContext
                       .Categories
                       .Where(x=>x.IsDeleted==isDeleted)
                       .ToListAsync();
                       return Categories;
    }
}
