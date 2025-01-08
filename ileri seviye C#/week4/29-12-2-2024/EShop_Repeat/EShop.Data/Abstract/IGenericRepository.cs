using System;
using System.Linq.Expressions;

namespace EShop.Data.Abstract;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<TEntity> GetAsync(int id);
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate,
     params Func<IQueryable<TEntity>, IQueryable<TEntity>>[] includes); //params kullanmamızın amacı birden fazla include alabilmemizi sağlamak
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<IEnumerable<TEntity>> GetAllAsync(
        Expression<Func<TEntity, bool>> predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        params Func<IQueryable<TEntity>, IQueryable<TEntity>>[] includes);
    Task<bool> ExistAyync(Expression<Func<TEntity, bool>> predicate); //predicate var mı yok mu kontrolü
    Task<int> CountAsync(); //tüm entity sayısını döndürür
    Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate); //predicate a göre sayma işlemi
    Task<TEntity> AddAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);


}
