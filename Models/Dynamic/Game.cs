namespace betrayal_hill.Models.Dynamic
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int OmenCount { get; set; } = 0;
        // The rooms currently placed in this game
        public ICollection<PlacedRoom> PlacedRooms { get; set; } = [];
        public bool HauntTriggered { get; set; } = false;
        public ICollection<Player> Players { get; set; } = [];
    }
}
