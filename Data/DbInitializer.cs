using Multimedialny_przewodnik_po_Uczelni.Models;

namespace Multimedialny_przewodnik_po_Uczelni.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Users.Any(u => u.Username == "admin"))
            {
                var adminUser = new User
                {
                    Username = "admin",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin"),
                    Role = "Admin"
                };
                context.Users.Add(adminUser);
                context.SaveChanges();
            }
        }
    }
}