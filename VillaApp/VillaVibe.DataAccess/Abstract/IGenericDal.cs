using System;
using System.Linq.Expressions;
using MongoDB.Bson;

namespace VillaVibe.DataAccess.Abstract;

public interface IGenericDal<T> where T : class
{
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(ObjectId id);
    Task<List<T>> GetListAsync();
    Task<T> GetByIdAsync(ObjectId id);

    Task<int> CountAsync();
    Task<List<T>> GetFilteredListAsync(Expression<Func<T, bool>> predicate);
}
