using System.ComponentModel.DataAnnotations;

namespace Multimedialny_przewodnik_po_Uczelni.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = "User";
        public bool IsHighContrast { get; set; } = false;
    }
}