namespace Multimedialny_przewodnik_po_Uczelni.Models
{
    public class Edge
    {
        public int Id { get; set; }
        public int FromNodeId { get; set; }
        public LocationNode FromNode { get; set; } = null!;
        public int ToNodeId { get; set; }
        public LocationNode ToNode { get; set; } = null!;

        public Direction Direction { get; set; }
        public int DistanceWeight { get; set; }

        public bool IsStairs { get; set; }
        public bool IsElevator { get; set; }
    }

    public enum Direction
    {
        Forward,
        Backward,
        Left,
        Right,
        Up,
        Down
    }
}