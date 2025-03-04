using HauiRedo.Domain.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HauiRedo.Infrastructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly MainDbContext _context;

    public GenericRepository(MainDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>>? predicate = null)
    {
        return predicate != null
            ? await _context.Set<T>().Where(predicate).ToListAsync()
            : await _context.Set<T>().ToListAsync();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
    }

    public Task UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);
        return Task.CompletedTask;
    }

    public Task RemoveAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        return Task.CompletedTask;
    }
}
