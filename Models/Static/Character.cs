namespace betrayal_hill.Models.Static
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Birthday { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Height { get; set; } = string.Empty; // feet/inches
        public int Weight { get; set; } // lbs
        public string Hobbies { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }

        // Stat tracks — stored as arrays for now
        public int[] Speed { get; set; } = [];
        public int[] Might { get; set; } = [];
        public int[] Sanity { get; set; } = [];
        public int[] Knowledge { get; set; } = [];

        // Define starting positions for each stat
        public int StartingMight { get; set; }
        public int StartingSpeed { get; set; }
        public int StartingKnowledge { get; set; }
        public int StartingSanity { get; set; }
    }
}
