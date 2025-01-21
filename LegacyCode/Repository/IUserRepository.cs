using LegacyCode.Models;

namespace LegacyCode.Repository
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsername(string username);
    }
}
