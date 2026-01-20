using System.ComponentModel.DataAnnotations;

namespace Multimedialny_przewodnik_po_Uczelni.Models
{
    public enum NodeType
    {
        Corridor, Room, Elevator, Stairs, StartPoint
    }

    public class LocationNode
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string AudioUrl { get; set; } = string.Empty;
        public Direction BaseOrientation { get; set; } = Direction.Forward;
        [Required]
        public string AltText { get; set; } = string.Empty;
        public NodeType Type { get; set; } = NodeType.Corridor;
        public int X { get; set; }
        public int Y { get; set; }
        public int FloorId { get; set; }
        public Floor Floor { get; set; } = null!;
        public List<Edge> OutgoingEdges { get; set; } = new();
    }
}