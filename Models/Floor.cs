using System.ComponentModel.DataAnnotations;

namespace Multimedialny_przewodnik_po_Uczelni.Models
{
    public class Floor
    {
        public int Id { get; set; }
        public int LevelNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public int BuildingId { get; set; }
        public Building Building { get; set; } = null!;
        public List<LocationNode> Nodes { get; set; } = new();
    }
}