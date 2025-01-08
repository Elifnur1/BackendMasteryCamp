using System;
using System.Linq.Expressions;
using EShop.Data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.Concrete.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly EShopDbContext _dbcontext;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(EShopDbContext dbcontext)
    {
        _dbcontext = dbcontext;
        _dbSet = _dbcontext.Set<TEntity>();
    }

    public Task<TEntity> AddAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public void Delete(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistAyync(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TEntity>> GetAllAsync()
    {
        
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Func<IQueryable<TEntity>, IQueryable<TEntity>>[] includes)
    {
       IQueryable <TEntity>query= _dbSet;
       if (predicate != null)
       {
           query = query.Where(predicate);
       }
       if (orderBy != null)
       {
           query = orderBy(query);
       }
         if (includes != null)
         {
              query = includes.Aggregate(query, (current, include) => include(current));
         }
         return await query.ToListAsync();
    }

    public async Task<TEntity> GetAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Func<IQueryable<TEntity>, IQueryable<TEntity>>[] includes)
    {
        IQueryable<TEntity> query = _dbSet; //dbseti querye atadık
        if (predicate == null)
        {
            query = query.Where(predicate); //predicate null değilse where ekler
        }
        if (includes != null)
        {
            query = includes.Aggregate(query, (current, include) => include(current)); //include varsa querye ekler
        }
        var result = await query.FirstOrDefaultAsync(); //queryi çalıştırır ve ilk değeri döndürür
        return result;

    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
