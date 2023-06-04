using Interfaces.Repositories.Email;
using Domain.Entities;
using Repository.Context;

namespace Repository.Repositories.Email;

public class PaisRepository : Repository<Pais>, IPaisRepository
{

    public PaisRepository(ApplicationDbContext context) : base(context)
    {
    }
}
