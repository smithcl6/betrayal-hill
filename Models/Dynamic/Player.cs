using betrayal_hill.Models.Static;

namespace betrayal_hill.Models.Dynamic
{
    public class Player
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; } = null!;
        public int CharacterId { get; set; }
        public Character Character { get; set; } = null!;
        // Current stats (not the full track; just current values)
        public int Might { get; set; }
        public int Speed { get; set; }
        public int Knowledge { get; set; }
        public int Sanity { get; set; }
        public ICollection<InventoryItem> Inventory { get; set; } = [];
    }
}
