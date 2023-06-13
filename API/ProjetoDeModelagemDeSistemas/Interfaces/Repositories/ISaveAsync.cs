using Domain.Entities;

namespace Interfaces.Repositories;

public interface ISaveAsync<TEntity> where TEntity : Entity
{
    Task<TEntity?> SaveAsync(TEntity entity);
}
