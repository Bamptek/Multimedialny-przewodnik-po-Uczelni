using Multimedialny_przewodnik_po_Uczelni.Data;
using Multimedialny_przewodnik_po_Uczelni.Models;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace Multimedialny_przewodnik_po_Uczelni.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> RegisterUserAsync(string username, string password, string role = "User")
        {
            if (await _context.Users.AnyAsync(u => u.Username == username))
            {
                return false;
            }

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            var newUser = new User
            {
                Username = username,
                PasswordHash = passwordHash,
                Role = role
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<User?> LoginUserAsync(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (user == null) return null;

            bool isValid = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);

            if (isValid) return user;
            return null;
        }
    }
}