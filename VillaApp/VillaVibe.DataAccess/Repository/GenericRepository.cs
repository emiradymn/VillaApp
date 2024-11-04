using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;
using VillaVibe.DataAccess.Abstract;
using VillaVibe.DataAccess.Context;

namespace VillaVibe.DataAccess.Repository;

public class GenericRepository<T> : IGenericDal<T> where T : class
{

    private readonly VillaContext _context;

    public GenericRepository(VillaContext context)
    {
        _context = context;
    }

    public async Task<int> CountAsync()
    {
        return await _context.Set<T>().CountAsync();
    }

    public async Task CreateAsync(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(ObjectId id)
    {
        var value = await GetByIdAsync(id);
        _context.Remove(value);
        await _context.SaveChangesAsync();
    }

    public async Task<T> GetByIdAsync(ObjectId id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<List<T>> GetFilteredListAsync(Expression<Func<T, bool>> predicate)
    {
        return await _context.Set<T>().Where(predicate).ToListAsync();
    }

    public async Task<List<T>> GetListAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
    }
}
