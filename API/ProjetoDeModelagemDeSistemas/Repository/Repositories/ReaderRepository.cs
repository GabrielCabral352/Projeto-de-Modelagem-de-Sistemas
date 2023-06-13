using Domain.Entities;
using Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Repository.Context;

namespace Repository.Repositories;

public class ReaderRepository<T> : IGetAll<T>, IGetByIdAsync<T> where T : Entity
{
    protected readonly ApplicationDbContext _context;

    public ReaderRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<T?> Get(int id)
    {
        return await _context.Set<T>().Where(x => x.Id == id).SingleOrDefaultAsync();
    }

    public IQueryable<T> Get()
    {
        return _context.Set<T>().AsQueryable();
    }
}
