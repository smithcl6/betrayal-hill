using Microsoft.EntityFrameworkCore;
using betrayal_hill.Models.Static;

namespace betrayal_hill.Data
{
    public class ExplorerSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Explorer>().HasData(
                new Explorer
                {
                    Id = 1,
                    Name = "Ox Bellows",
                    Age = 23,
                    Height = "6'4\"",
                    Weight = 288,
                    Hobbies = "Football, Shiny Objects",
                    Birthday = "October 18th",
                    Speed = [0, 2, 2, 2, 3, 4, 5, 5, 6],
                    Might = [0, 4, 5, 5, 6, 6, 7, 8, 8],
                    Sanity = [0, 2, 2, 3, 4, 5, 5, 6, 7],
                    Knowledge = [0, 2, 2, 3, 3, 5, 5, 6, 6],
                    StartingSpeed = 5,
                    StartingMight = 3,
                    StartingSanity = 3,
                    StartingKnowledge = 3
                },
                new Explorer
                {
                    Id = 2,
                    Name = "Darrin \"Flash\" Williams",
                    Age = 20,
                    Height = "5'11\"",
                    Weight = 188,
                    Hobbies = "Track, Music, Shakespearean Literature",
                    Birthday = "June 6th",
                    Speed = [0, 4, 4, 4, 5, 6, 7, 7, 8],
                    Might = [0, 2, 3, 3, 4, 5, 6, 6, 7],
                    Sanity = [0, 1, 2, 3, 4, 5, 5, 5, 7],
                    Knowledge = [0, 2, 3, 3, 4, 5, 5, 5, 7],
                    StartingSpeed = 5,
                    StartingMight = 3,
                    StartingSanity = 3,
                    StartingKnowledge = 3
                },
                new Explorer
                {
                    Id = 3,
                    Name = "Peter Akimoto",
                    Age = 13,
                    Height = "4'11\"",
                    Weight = 98,
                    Hobbies = "Bugs, Basketball",
                    Birthday = "September 3rd",
                    Speed = [0, 3, 3, 3, 4, 6, 6, 7, 7],
                    Might = [0, 2, 3, 3, 4, 5, 5, 6, 8],
                    Sanity = [0, 3, 4, 4, 4, 5, 6, 6, 7],
                    Knowledge = [0, 3, 4, 4, 5, 6, 7, 7, 8],
                    StartingSpeed = 4,
                    StartingMight = 3,
                    StartingSanity = 4,
                    StartingKnowledge = 3
                },
                new Explorer
                {
                    Id = 4,
                    Name = "Brandon Jaspers",
                    Age = 12,
                    Height = "5'1\"",
                    Weight = 109,
                    Hobbies = "Computers, Camping, Hockey",
                    Birthday = "May 21st",
                    Speed = [0, 3, 4, 4, 4, 5, 6, 7, 8],
                    Might = [0, 2, 3, 3, 4, 5, 6, 6, 7],
                    Sanity = [0, 3, 3, 3, 4, 5, 6, 7, 8],
                    Knowledge = [0, 1, 3, 3, 5, 5, 6, 6, 7],
                    StartingSpeed = 3,
                    StartingMight = 4,
                    StartingSanity = 4,
                    StartingKnowledge = 3
                },
                new Explorer
                {
                    Id = 5,
                    Name = "Father Rhinehardt",
                    Age = 62,
                    Height = "5'9\"",
                    Weight = 185,
                    Hobbies = "Fencing, Gardening",
                    Birthday = "April 29th",
                    Speed = [0, 2, 3, 3, 4, 5, 6, 7, 7],
                    Might = [0, 1, 2, 2, 4, 4, 5, 5, 7],
                    Sanity = [0, 3, 4, 5, 5, 6, 7, 7, 8],
                    Knowledge = [0, 1, 3, 3, 4, 5, 6, 6, 8],
                    StartingSpeed = 3,
                    StartingMight = 3,
                    StartingSanity = 5,
                    StartingKnowledge = 4
                },
                new Explorer
                {
                    Id = 6,
                    Name = "Professor Longfellow",
                    Age = 57,
                    Height = "5'11\"",
                    Weight = 153,
                    Hobbies = "Gaelic Music, Drama, Fine Wines",
                    Birthday = "July 27th",
                    Speed = [0, 2, 2, 4, 4, 5, 5, 6, 6],
                    Might = [0, 1, 2, 3, 4, 5, 5, 6, 6],
                    Sanity = [0, 1, 3, 3, 4, 5, 5, 6, 7],
                    Knowledge = [0, 4, 5, 5, 5, 5, 6, 7, 8],
                    StartingSpeed = 4,
                    StartingMight = 3,
                    StartingSanity = 3,
                    StartingKnowledge = 5
                },
                new Explorer
                {
                    Id = 7,
                    Name = "Missy Dubourde",
                    Age = 9,
                    Height = "4'2\"",
                    Weight = 62,
                    Hobbies = "Swimming, Medicine",
                    Birthday = "February 14th",
                    Speed = [0, 3, 4, 5, 6, 6, 6, 7, 7],
                    Might = [0, 2, 3, 3, 3, 4, 5, 6, 7],
                    Sanity = [0, 1, 2, 3, 4, 5, 5, 6, 7],
                    Knowledge = [0, 2, 3, 4, 4, 5, 6, 6, 8],
                    StartingSpeed = 3,
                    StartingMight = 4,
                    StartingSanity = 3,
                    StartingKnowledge = 4
                },
                new Explorer
                {
                    Id = 8,
                    Name = "Zoe Ingstrom",
                    Age = 8,
                    Height = "3'9\"",
                    Weight = 49,
                    Hobbies = "Dolls, Music",
                    Birthday = "November 5th",
                    Speed = [0, 4, 4, 4, 4, 5, 6, 8, 8],
                    Might = [0, 2, 2, 3, 3, 4, 4, 6, 7],
                    Sanity = [0, 3, 4, 5, 5, 6, 6, 7, 8],
                    Knowledge = [0, 1, 2, 3, 4, 4, 5, 5, 5],
                    StartingSpeed = 4,
                    StartingMight = 4,
                    StartingSanity = 3,
                    StartingKnowledge = 3
                },
                new Explorer
                {
                    Id = 9,
                    Name = "Heather Granville",
                    Age = 18,
                    Height = "5'2\"",
                    Weight = 120,
                    Hobbies = "Television, Shopping",
                    Birthday = "August 2nd",
                    Speed = [0, 3, 3, 4, 5, 6, 6, 7, 8],
                    Might = [0, 3, 3, 3, 4, 5, 6, 7, 8],
                    Sanity = [0, 3, 3, 3, 4, 5, 6, 6, 6],
                    Knowledge = [0, 2, 3, 3, 4, 5, 6, 7, 8],
                    StartingSpeed = 3,
                    StartingMight = 3,
                    StartingSanity = 3,
                    StartingKnowledge = 5
                },
                new Explorer
                {
                    Id = 10,
                    Name = "Jenny LeClerc",
                    Age = 21,
                    Height = "5'7\"",
                    Weight = 142,
                    Hobbies = "Reading, Soccer",
                    Birthday = "March 4th",
                    Speed = [0, 2, 3, 4, 4, 4, 5, 6, 8],
                    Might = [0, 3, 4, 4, 4, 4, 5, 6, 8],
                    Sanity = [0, 1, 1, 2, 4, 4, 4, 5, 6],
                    Knowledge = [0, 2, 3, 3, 4, 4, 5, 6, 8],
                    StartingSpeed = 4,
                    StartingMight = 3,
                    StartingSanity = 5,
                    StartingKnowledge = 3
                },
                new Explorer
                {
                    Id = 11,
                    Name = "Madame Zostra",
                    Age = 37,
                    Height = "5'0\"",
                    Weight = 150,
                    Hobbies = "Astrology, Cooking, Baseball",
                    Birthday = "December 10th",
                    Speed = [0, 2, 3, 3, 5, 5, 6, 6, 7],
                    Might = [0, 2, 3, 3, 4, 5, 5, 5, 6],
                    Sanity = [0, 4, 4, 4, 5, 6, 7, 8, 8],
                    Knowledge = [0, 1, 3, 4, 4, 4, 5, 6, 6],
                    StartingSpeed = 3,
                    StartingMight = 4,
                    StartingSanity = 3,
                    StartingKnowledge = 4
                },
                new Explorer
                {
                    Id = 12,
                    Name = "Vivian Lopez",
                    Age = 42,
                    Height = "5'5\"",
                    Weight = 142,
                    Hobbies = "Old Movies, Horses",
                    Birthday = "January 11th",
                    Speed = [0, 3, 4, 4, 4, 4, 6, 7, 8],
                    Might = [0, 2, 2, 2, 4, 4, 5, 6, 6],
                    Sanity = [0, 4, 4, 4, 5, 6, 7, 8, 8],
                    Knowledge = [0, 4, 5, 5, 5, 5, 6, 6, 7],
                    StartingSpeed = 4,
                    StartingMight = 3,
                    StartingSanity = 3,
                    StartingKnowledge = 4
                }
                );
        }
    }
}
