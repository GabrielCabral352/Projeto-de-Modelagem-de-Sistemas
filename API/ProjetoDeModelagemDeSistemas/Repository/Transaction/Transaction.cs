using Interfaces.Transactions;
using Repository.Context;

namespace Repository.Transaction;

public class Transaction : ITransaction
{

    private readonly ApplicationDbContext _applicationDbContext;
    public Transaction(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public void BeginTransaction()
    {
        _applicationDbContext.Database.BeginTransaction();
    }

    public void CommitTransaction()
    {
        _applicationDbContext.Database.CommitTransaction();
    }

    public void RollbackTransaction()
    {
        _applicationDbContext.Database.RollbackTransaction();
    }
}
