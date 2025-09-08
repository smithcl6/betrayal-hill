using betrayal_hill.Models.Static.Enums;

namespace betrayal_hill.Models.Static
{
    public class Card
    {
        public int Id { get; set; }
        public CardType Type { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Instruction { get; set; } = string.Empty;
    }
}
