using Vibe.Core.Entities;
using Vibe.Core.Enums;
using Vibe.Core.RepositoryContract;

namespace Vibe.Infrastructure.Repositories;

public class UsersRepository : IUsersRepository
{
    public async Task<User?> AddUser(User user)
    {
        user.UserId = Guid.NewGuid();
        return user;
    }

    public async Task<User> GetUserByEmailAndPassword(string? Email, string? Username, string? Password, string? FirstName, string? LastName, Gender? Gender, DateTime? DateOfBirth, string? City, byte[]? ImageUrl)
    {
        return new User()
        {
            UserId = Guid.NewGuid(),
            Email = Email,
            Username = Username,
            Password = Password,
            FirstName = FirstName,
            LastName = LastName,
            Gender = Gender,
            DateOfBirth = DateOfBirth,
            City = City,
            ImageUrl = ImageUrl
        };
    }
}
