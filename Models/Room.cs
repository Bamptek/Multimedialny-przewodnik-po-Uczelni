namespace Multimedialny_przewodnik_po_Uczelni.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int LocationNodeId { get; set; }
        public LocationNode LocationNode { get; set; } = null!;
    }
}