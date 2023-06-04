using Domain.Entities;

namespace Interfaces.Repositories;

public interface IGetAll<TEntity> where TEntity : Entity
{
    IQueryable<TEntity> Get();
}
