using Domain.Entities;

namespace Interfaces.Repositories.Email;

public interface IPaisRepository :
    IGetByIdAsync<Pais>,
    IGetAll<Pais>,
    ISaveAsync<Pais>,
    IRemoveAsync<Pais>
{
}

