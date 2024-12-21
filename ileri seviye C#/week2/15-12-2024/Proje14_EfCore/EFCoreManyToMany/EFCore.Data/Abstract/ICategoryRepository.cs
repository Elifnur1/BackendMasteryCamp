using System;
using EFCore.Entity.Concrete;

namespace EFCore.Data.Abstract;

public interface ICategoryRepository : IGenericRepository<Category>
{
    Task<IEnumerable<Category>> GetAllDeletedCategoriesAsync(bool isDeleted = true);
}
