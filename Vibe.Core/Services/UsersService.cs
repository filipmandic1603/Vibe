using Vibe.Core.DTO;
using Vibe.Core.Entities;
using Vibe.Core.RepositoryContract;
using Vibe.Core.ServiceContract;

namespace Vibe.Core.Services;

public class UsersService : IUsersService
{
    private readonly IUsersRepository _usersRepository;

    public UsersService(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public async Task<AutheticationResponse> Login(LoginRequest loginRequest)
    {
        User? userStorage = await _usersRepository.GetUserByEmailAndPassword(loginRequest.Email, loginRequest.Password);

        if(userStorage == null)
        {
            return null;
        }

        return new AutheticationResponse(userStorage.UserId, userStorage.Email, userStorage.Username, userStorage.Password, userStorage.FirstName, userStorage.LastName, userStorage.Gender, userStorage.DateOfBirth, userStorage.City, userStorage.ImageUrl, "token", Success: true);
    }

    public async Task<AutheticationResponse> Register(RegisterRequest registerRequest)
    {
        User? userStorage = new User()
        {
            UserId = new Guid(),
            Email = registerRequest.Email,
            Username = registerRequest.Username,
            Password = registerRequest.Password,
            FirstName = registerRequest.FirstName,
            LastName = registerRequest.LastName,
            Gender = registerRequest.Gender,
            DateOfBirth = registerRequest.DateOfBirth,
            City = registerRequest.City,
            ImageUrl = registerRequest.ImageUrl,
        };

        User? registratedUser = await _usersRepository.AddUser(userStorage);

        if(registratedUser == null)
        {
            return null;
        }

        return new AutheticationResponse(userStorage.UserId, userStorage.Email, userStorage.Username, userStorage.Password, userStorage.FirstName, userStorage.LastName, userStorage.Gender, userStorage.DateOfBirth, userStorage.City, userStorage.ImageUrl, "token", Success: true);
    }
}
