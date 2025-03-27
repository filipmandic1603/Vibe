using Microsoft.Extensions.DependencyInjection;
using Vibe.Core.RepositoryContract;
using Vibe.Infrastructure.Repositories;

namespace Vibe.Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IUsersRepository, UsersRepository>();
        return services;
    }
}
