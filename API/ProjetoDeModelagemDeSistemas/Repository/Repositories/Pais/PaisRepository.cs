using Domain.Entities;
using Interfaces.Repositories.Parents;
using Repository.Context;

namespace Repository.Repositories.Parents;

public class PaisRepository : Repository<Pais>, IPaisRepository
{

    public PaisRepository(ApplicationDbContext context) : base(context)
    {
    }
}
