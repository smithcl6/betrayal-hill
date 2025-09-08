using Microsoft.EntityFrameworkCore;
using betrayal_hill.Models.Static;
using betrayal_hill.Models.Static.Enums;

namespace betrayal_hill.Data
{
    public class CardSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().HasData(
                new Card
                {
                    Id = 1,
                    Type = CardType.Omen,
                    Name = "Bite",
                    Description = "A growl, the scent of death. Pain. Darkness. Gone.",
                    Instruction = @"When you draw this card, something bites you. The player on your right rolls a Might 4 attack against you for the mysterious something
                                    (before it runs away into the darkness). You defend against this attack as normal, by rolling dice equal to your Might.
                                    This omen can't be dropped, traded, or stolen. Make a haunt roll now."
                }, 
                new Card
                {
                    Id = 2,
                    Type = CardType.Omen,
                    Name = "Book",
                    Description = "A diary or lab notes? Ancient script or modern ravings?",
                    Instruction = @"Gain 2 Knowledge now. Lose 2 Knowledge if you lose the Book. Make a haunt roll now."
                },
                new Card
                {
                    Id = 3,
                    Type = CardType.Omen,
                    Name = "Crystal Ball",
                    Description = "Hazy images appear in the glass.",
                    Instruction = @"Once during your turn after the haunt is revealed, you can attempt a Knowledge roll to peer into the Crystal Ball:
                                    4+ You see the truth. Search the item or event stack for a card of your choice. Shuffle that stack then place that card on top.
                                    1–3 You avert your eyes. Lose 1 Sanity.
                                    0 You stare into Hell. Lose 2 Sanity.
                                    Make a haunt roll now."
                },
                new Card
                {
                    Id = 4,
                    Type = CardType.Omen,
                    Name = "Dog",
                    Description = "COMPANION This mangy dog seems friendly. At least you hope it is.",
                    Instruction = @"Gain 1 Might and 1 Sanity now. Lose 1 Might and 1 Sanity if you lose custody of the Dog.
                                    Take a small monster token to represent the Dog. Put it in your room. (Use a token of a different color from other monsters, if any.)
                                    Once during your turn, the Dog can move to any explored room up to 6 spaces away, using doors and stairs, and then return.
                                    It can pick up, carry and/or drop 1 item before it returns.
                                    The Dog isn't slowed by opponents. It can't use one-way passages or rooms that require a roll. It can't carry items that slow movement.
                                    This omen can't be dropped, traded, or stolen. Make a haunt roll now. "
                },
                new Card
                {
                    Id = 5,
                    Type = CardType.Omen,
                    Name = "Girl",
                    Description = "COMPANION A girl. Trapped. Alone. You free her!",
                    Instruction = @"Gain 1 Sanity and 1 Knowledge now. Lose 1 Sanity and 1 Knowledge if you lose custody of the Girl.
                                    This omen can't be dropped, traded, or stolen. Make a haunt roll now."
                },
                new Card
                {
                    Id = 6,
                    Type = CardType.Omen,
                    Name = "Holy Symbol",
                    Description = "A symbol of calm in an unsettling world.",
                    Instruction = @"Gain 2 Sanity now. Lose 2 Sanity if you lose the Holy Symbol. Make a haunt roll now."
                },
                new Card
                {
                    Id = 7,
                    Type = CardType.Omen,
                    Name = "Madman",
                    Description = "COMPANION A raving, frothing, madman.",
                    Instruction = @"Gain 2 Might and lose 1 Sanity now. Lose 2 Might and gain 1 Sanity if you lose custody of the Madman.
                                    This omen can't be dropped, traded, or stolen. Make a haunt roll now."
                },
                new Card
                {
                    Id = 8,
                    Type = CardType.Omen,
                    Name = "Mask",
                    Description = "A somber mask to hide your intentions.",
                    Instruction = @"Once during your turn, you can attempt a Sanity roll to use the Mask:
                                    4+ You can put on or take off the Mask. If you put on the Mask, gain 2 Knowledge and lose 2 Sanity.
                                    If you take off the Mask, gain 2 Sanity and lose 2 Knowledge.
                                    0–3 You can't use the Mask this turn.
                                    Make a haunt roll now."
                },
                new Card
                {
                    Id = 9,
                    Type = CardType.Omen,
                    Name = "Medallion",
                    Description = "A medallion inscribed with a pentagram.",
                    Instruction = @"You are immune to the effects of the Pentagram Chamber, Crypt, and Graveyard. Make a haunt roll now."
                },
                new Card
                {
                    Id = 10,
                    Type = CardType.Omen,
                    Name = "Ring",
                    Description = "A battered ring with an incomprehensible inscription.",
                    Instruction = @"If you attack an opponent that has a Sanity trait, you can attack with Sanity instead of Might.
                                    (Your opponent then defends with Sanity, and damage is mental instead of physical.) Make a haunt roll now."
                },
                new Card
                {
                    Id = 11,
                    Type = CardType.Omen,
                    Name = "Skull",
                    Description = "A skull, cracked and missing teeth.",
                    Instruction = @"If you take mental damage, you can take all of it as physical damage instead. Make a haunt roll now."
                },
                new Card
                {
                    Id = 12,
                    Type = CardType.Omen,
                    Name = "Spear",
                    Description = "WEAPON A weapon pulsing with power.",
                    Instruction = @"You roll 2 additional dice (maximum of 8 dice) when making a Might attack with this weapon.
                                    You can't use another weapon while you're using this one. Make a haunt roll now."
                },
                new Card
                {
                    Id = 13,
                    Type = CardType.Omen,
                    Name = "Spirit Board",
                    Description = "A board with letters and numbers to call the dead.",
                    Instruction = @"Before you move during your turn, you can look at the top tile of the room stack.
                                    If you use the Spirit Board after the haunt has been revealed, the traitor can move any number of monsters 1 space closer to you.
                                    (If you are the traitor, you don't have to move those monsters.) If there is no traitor, all monsters move 1 space closer to you.
                                    Make a haunt roll now."
                },
                new Card
                {
                    Id = 14,
                    Type = CardType.Item,
                    Name = "Armor",
                    Description = "It's just prop armor from a Renaissance fair, bit it's still metal.",
                    Instruction = @"Any time (not just once per turn) you take physical damage, take 1 less point of damage. This item can't be stolen."
                },
                new Card
                {
                    Id = 15,
                    Type = CardType.Event,
                    Name = "Smoke",
                    Description = "Smoke billows around you. You cough, wiping way tears.",
                    Instruction = @"Put the Smoke token in this room. The Smoke blocks line of sight from adjacent rooms.
                                    An explorer rolls 2 fewer dice (minimum of 1 die) on all trait rolls while in this room."
                }
                );
        }
    }
}
