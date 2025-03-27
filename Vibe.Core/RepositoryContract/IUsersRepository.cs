using Vibe.Core.Entities;
using Vibe.Core.Enums;

namespace Vibe.Core.RepositoryContract;

public interface IUsersRepository
{
    Task<User> AddUser(User user);

    Task<User> GetUserByEmailAndPassword(string? Email, string? Password);
}
