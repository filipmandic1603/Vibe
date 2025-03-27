using Vibe.Core.DTO;
using Vibe.Core.ServiceContract;

namespace Vibe.Core.Services;

public class UsersService : IUsersService
{
    public async Task<AutheticationResponse> Login(LoginRequest loginRequest)
    {
        throw new NotImplementedException();
    }

    public async Task<AutheticationResponse> Register(RegisterRequest registerRequest)
    {
        throw new NotImplementedException();
    }
}
