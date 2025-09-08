using betrayal_hill.Models.Dynamic;
using betrayal_hill.Models.Static;
using Microsoft.EntityFrameworkCore;

namespace betrayal_hill.Data
{
    public class BetrayalContext : DbContext
    {
        public BetrayalContext(DbContextOptions<BetrayalContext> options)
            : base(options)
        {
        }

        // Static sets
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Explorer> Explorers { get; set; }
        public DbSet<Card> Cards { get; set; }

        // Dynamic sets
        public DbSet<Game> Games { get; set; }
        public DbSet<PlacedRoom> PlacedRooms { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ExplorerSeed.Seed(modelBuilder);
            RoomSeed.Seed(modelBuilder);
            CardSeed.Seed(modelBuilder);
        }
    }
}
