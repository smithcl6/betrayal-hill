using Microsoft.EntityFrameworkCore;
using betrayal_hill.Models.Static;
using betrayal_hill.Models.Static.Enums;

namespace betrayal_hill.Data
{
    public class RoomSeed
    {
        public static void Seed (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = 7,
                    Name = "Creaky Hallway",
                    AllowedFloors = FloorType.Basement | FloorType.Ground | FloorType.Upper
                }
                );
        }
    }
}
