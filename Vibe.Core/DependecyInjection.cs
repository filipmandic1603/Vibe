using Microsoft.Extensions.DependencyInjection;
using Vibe.Core.ServiceContract;
using Vibe.Core.Services;

namespace Vibe.Core;

public static class DependecyInjection
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        services.AddScoped<IUsersService, UsersService>();
        return services;
    }
}
