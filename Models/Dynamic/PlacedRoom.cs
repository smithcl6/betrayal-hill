using betrayal_hill.Models.Static.Enums;

namespace betrayal_hill.Models.Dynamic
{
    public class PlacedRoom
    {
        public int Id { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; } = null!;
        public int RoomId { get; set; }
        public Static.Room Room { get; set; } = null!;
        public int X { get; set; }
        public int Y { get; set; }
        public FloorType Floor { get; set; }
        public Orientation Orientation { get; set; }
    }
}
