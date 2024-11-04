using System;
using System.Linq.Expressions;
using MongoDB.Bson;
using VillaVibe.Business.Abstract;
using VillaVibe.DataAccess.Abstract;
using ZstdSharp.Unsafe;

namespace VillaVibe.Business.Concrete;

public class GenericManager<T> : IGenericService<T> where T : class
{
    private readonly IGenericDal<T> _genericDal;

    public GenericManager(IGenericDal<T> genericDal)
    {
        _genericDal = genericDal;
    }

    public Task<int> TCountAsync()
    {
        return _genericDal.CountAsync();
    }

    public async Task TCreateAsync(T entity)
    {
        await _genericDal.CreateAsync(entity);

    }

    public async Task TDeleteAsync(ObjectId id)
    {
        await _genericDal.DeleteAsync(id);
    }

    public async Task<T> TGetByIdAsync(ObjectId id)
    {
        return await _genericDal.GetByIdAsync(id);
    }

    public async Task<List<T>> TGetFilteredListAsync(Expression<Func<T, bool>> predicate)
    {
        return await _genericDal.GetFilteredListAsync(predicate);
    }

    public async Task<List<T>> TGetListAsync()
    {
        return await _genericDal.GetListAsync();
    }

    public Task TUpdateAsync(T entity)
    {
        return _genericDal.UpdateAsync(entity);

    }
}
