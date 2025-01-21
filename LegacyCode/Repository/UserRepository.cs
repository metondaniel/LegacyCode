using LegacyCode.Models;
using Microsoft.EntityFrameworkCore;

namespace LegacyCode.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return null;
            //Avoid inject
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }
    }
}
