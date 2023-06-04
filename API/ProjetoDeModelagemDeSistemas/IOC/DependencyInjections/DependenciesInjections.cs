using Repository.Transaction;
using Microsoft.Extensions.DependencyInjection;
using Repository.Repositories.Email;
using Interfaces.Repositories.Email;
using Interfaces.Transactions;

namespace IOC.DependencyInjections;

internal static class DependenciesInjections
{
    internal static IServiceCollection AddInjections(this IServiceCollection services)
    {
        services.AddTransaction()
                .AddRepositories();

        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPaisRepository, PaisRepository>();

        return services;
    }

    private static IServiceCollection AddTransaction(this IServiceCollection services)
    {
        services.AddScoped<ITransaction, Transaction>();

        return services;
    }
}
