using Domain.Entities;
using Interfaces.Repositories;
using Repository.Context;

namespace Repository.Repositories;

public class Repository<T> : ReaderRepository<T>, ISaveAsync<T>, IRemoveAsync<T> where T : Entity
{
    public Repository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<T?> SaveAsync(T entity)
    {

        if (entity.Id > 0)
        {
            _context.Set<T>().Update(entity);
        }
        else
        {
            _context.Set<T>().Add(entity);
        }

        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task RemoveAsync(T entity)
    {
        _context.Set<T>().Remove(entity);

        await _context.SaveChangesAsync();
    }
}
