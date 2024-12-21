using System;
using System.ComponentModel.DataAnnotations;
using EFCore.Data.Abstract;
using EFCore.Data.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data.Concrete.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    protected readonly AppDbContext _appDbContext;
    private readonly DbSet<TEntity>_dbSet;

    public GenericRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
        _dbSet=_appDbContext.Set<TEntity>();
    }
    public async Task AddAsync(TEntity entity)
    {
        await _appDbContext.Set<TEntity>().AddAsync(entity);
        await _appDbContext.SaveChangesAsync();
        //Buraya TEntity category olarak gönderilmişse üst satırda ki komut şöyle çalışıcak :appDbContext.Categories.AddAsync(entity);
        //Buraya TEntity Product olarak gönderilmişse üst satırdaki komut şöyle çalışacak: appDbContext.Products.AddAsync(entity);
    }

    public async Task DeleteAsync(TEntity entity)
    {
          _dbSet.Remove(entity);
         await _appDbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
          var entities= await _dbSet.ToListAsync();
          return entities;
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        var entity=await _dbSet.FindAsync(id);
        return entity;
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);
        await _appDbContext.SaveChangesAsync();
    }
}
