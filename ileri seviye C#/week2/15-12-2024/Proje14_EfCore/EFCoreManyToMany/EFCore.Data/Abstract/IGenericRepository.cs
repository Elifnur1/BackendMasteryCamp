using System;

namespace EFCore.Data.Abstract;
//Burada ki TEntity,Category ya da Product gibi entitylerimizden biri olablir.
public interface IGenericRepository<TEntity>
{
   Task<IEnumerable<TEntity>>GetAllAsync();
   Task<TEntity>GetByIdAsync(int id);
   Task AddAsync(TEntity entity);

   Task UpdateAsync(TEntity entity);
   Task DeleteAsync(TEntity entity);
}
