using Domain.Entities;

namespace Interfaces.Repositories.Parents;

public interface IPaisRepository :
    IGetByIdAsync<Pais>,
    IGetAll<Pais>,
    ISaveAsync<Pais>,
    IRemoveAsync<Pais>
{
}

