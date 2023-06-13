using Domain.Entities;

namespace Interfaces.Repositories;

public interface IRemoveAsync<TEntity> where TEntity : Entity
{
    Task RemoveAsync(TEntity entity);
}
