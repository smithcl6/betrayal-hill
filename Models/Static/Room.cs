using betrayal_hill.Models.Static.Enums;

namespace betrayal_hill.Models.Static
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Bit flag for allowed floors
        public FloorType AllowedFloors { get; set; }
    }
}
