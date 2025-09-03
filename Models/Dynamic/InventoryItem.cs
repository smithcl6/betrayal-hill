namespace betrayal_hill.Models.Dynamic
{
    public class InventoryItem
    {
        public int Id { get; set; }

        public int? PlayerId { get; set; }
        public Player? Player { get; set; }

        public int? PlacedRoomId { get; set; }
        public PlacedRoom? PlacedRoom { get; set; }

        public int CardId { get; set; }
        public Static.Card Card { get; set; } = null!;
    }
}
