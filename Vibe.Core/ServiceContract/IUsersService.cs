using Vibe.Core.DTO;

namespace Vibe.Core.ServiceContract;

public interface IUsersService
{
    Task<AutheticationResponse> Login(LoginRequest loginRequest);
    Task<AutheticationResponse> Register(RegisterRequest registerRequest);
}
