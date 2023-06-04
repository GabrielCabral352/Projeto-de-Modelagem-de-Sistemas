using Domain.Entities;

namespace Interfaces.Repositories;

public interface IGetByIdAsync<TEntity> where TEntity : Entity
{
    Task<TEntity?> Get(int id);
}
