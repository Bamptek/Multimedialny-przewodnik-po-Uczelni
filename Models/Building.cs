using System.ComponentModel.DataAnnotations;

namespace Multimedialny_przewodnik_po_Uczelni.Models
{
    public class Building
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;

        public List<Floor> Floors { get; set; } = new();
    }
}