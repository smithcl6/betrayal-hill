using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace betrayal_hill.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Instruction = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Explorers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<string>(type: "TEXT", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    Hobbies = table.Column<string>(type: "TEXT", nullable: false),
                    Birthday = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Speed = table.Column<string>(type: "TEXT", nullable: false),
                    Might = table.Column<string>(type: "TEXT", nullable: false),
                    Sanity = table.Column<string>(type: "TEXT", nullable: false),
                    Knowledge = table.Column<string>(type: "TEXT", nullable: false),
                    StartingSpeed = table.Column<int>(type: "INTEGER", nullable: false),
                    StartingMight = table.Column<int>(type: "INTEGER", nullable: false),
                    StartingSanity = table.Column<int>(type: "INTEGER", nullable: false),
                    StartingKnowledge = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Explorers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    OmenCount = table.Column<int>(type: "INTEGER", nullable: false),
                    HauntTriggered = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AllowedFloors = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GameId = table.Column<int>(type: "INTEGER", nullable: false),
                    ExplorerId = table.Column<int>(type: "INTEGER", nullable: false),
                    Might = table.Column<int>(type: "INTEGER", nullable: false),
                    Speed = table.Column<int>(type: "INTEGER", nullable: false),
                    Knowledge = table.Column<int>(type: "INTEGER", nullable: false),
                    Sanity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Explorers_ExplorerId",
                        column: x => x.ExplorerId,
                        principalTable: "Explorers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlacedRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GameId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomId = table.Column<int>(type: "INTEGER", nullable: false),
                    X = table.Column<int>(type: "INTEGER", nullable: false),
                    Y = table.Column<int>(type: "INTEGER", nullable: false),
                    Floor = table.Column<int>(type: "INTEGER", nullable: false),
                    Orientation = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacedRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlacedRooms_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlacedRooms_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: true),
                    PlacedRoomId = table.Column<int>(type: "INTEGER", nullable: true),
                    CardId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryItems_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryItems_PlacedRooms_PlacedRoomId",
                        column: x => x.PlacedRoomId,
                        principalTable: "PlacedRooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InventoryItems_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Description", "Instruction", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "A growl, the scent of death. Pain. Darkness. Gone.", "When you draw this card, something bites you. The player on your right rolls a Might 4 attack against you for the mysterious something\r\n                                    (before it runs away into the darkness). You defend against this attack as normal, by rolling dice equal to your Might.\r\n                                    This omen can't be dropped, traded, or stolen. Make a haunt roll now.", "Bite", 2 },
                    { 2, "A diary or lab notes? Ancient script or modern ravings?", "Gain 2 Knowledge now. Lose 2 Knowledge if you lose the Book. Make a haunt roll now.", "Book", 2 },
                    { 3, "Hazy images appear in the glass.", "Once during your turn after the haunt is revealed, you can attempt a Knowledge roll to peer into the Crystal Ball:\r\n                                    4+ You see the truth. Search the item or event stack for a card of your choice. Shuffle that stack then place that card on top.\r\n                                    1–3 You avert your eyes. Lose 1 Sanity.\r\n                                    0 You stare into Hell. Lose 2 Sanity.\r\n                                    Make a haunt roll now.", "Crystal Ball", 2 },
                    { 4, "COMPANION This mangy dog seems friendly. At least you hope it is.", "Gain 1 Might and 1 Sanity now. Lose 1 Might and 1 Sanity if you lose custody of the Dog.\r\n                                    Take a small monster token to represent the Dog. Put it in your room. (Use a token of a different color from other monsters, if any.)\r\n                                    Once during your turn, the Dog can move to any explored room up to 6 spaces away, using doors and stairs, and then return.\r\n                                    It can pick up, carry and/or drop 1 item before it returns.\r\n                                    The Dog isn't slowed by opponents. It can't use one-way passages or rooms that require a roll. It can't carry items that slow movement.\r\n                                    This omen can't be dropped, traded, or stolen. Make a haunt roll now. ", "Dog", 2 },
                    { 5, "COMPANION A girl. Trapped. Alone. You free her!", "Gain 1 Sanity and 1 Knowledge now. Lose 1 Sanity and 1 Knowledge if you lose custody of the Girl.\r\n                                    This omen can't be dropped, traded, or stolen. Make a haunt roll now.", "Girl", 2 },
                    { 6, "A symbol of calm in an unsettling world.", "Gain 2 Sanity now. Lose 2 Sanity if you lose the Holy Symbol. Make a haunt roll now.", "Holy Symbol", 2 },
                    { 7, "COMPANION A raving, frothing, madman.", "Gain 2 Might and lose 1 Sanity now. Lose 2 Might and gain 1 Sanity if you lose custody of the Madman.\r\n                                    This omen can't be dropped, traded, or stolen. Make a haunt roll now.", "Madman", 2 },
                    { 8, "A somber mask to hide your intentions.", "Once during your turn, you can attempt a Sanity roll to use the Mask:\r\n                                    4+ You can put on or take off the Mask. If you put on the Mask, gain 2 Knowledge and lose 2 Sanity.\r\n                                    If you take off the Mask, gain 2 Sanity and lose 2 Knowledge.\r\n                                    0–3 You can't use the Mask this turn.\r\n                                    Make a haunt roll now.", "Mask", 2 },
                    { 9, "A medallion inscribed with a pentagram.", "You are immune to the effects of the Pentagram Chamber, Crypt, and Graveyard. Make a haunt roll now.", "Medallion", 2 },
                    { 10, "A battered ring with an incomprehensible inscription.", "If you attack an opponent that has a Sanity trait, you can attack with Sanity instead of Might.\r\n                                    (Your opponent then defends with Sanity, and damage is mental instead of physical.) Make a haunt roll now.", "Ring", 2 },
                    { 11, "A skull, cracked and missing teeth.", "If you take mental damage, you can take all of it as physical damage instead. Make a haunt roll now.", "Skull", 2 },
                    { 12, "WEAPON A weapon pulsing with power.", "You roll 2 additional dice (maximum of 8 dice) when making a Might attack with this weapon.\r\n                                    You can't use another weapon while you're using this one. Make a haunt roll now.", "Spear", 2 },
                    { 13, "A board with letters and numbers to call the dead.", "Before you move during your turn, you can look at the top tile of the room stack.\r\n                                    If you use the Spirit Board after the haunt has been revealed, the traitor can move any number of monsters 1 space closer to you.\r\n                                    (If you are the traitor, you don't have to move those monsters.) If there is no traitor, all monsters move 1 space closer to you.\r\n                                    Make a haunt roll now.", "Spirit Board", 2 },
                    { 14, "It's just prop armor from a Renaissance fair, bit it's still metal.", "Any time (not just once per turn) you take physical damage, take 1 less point of damage. This item can't be stolen.", "Armor", 1 },
                    { 15, "Smoke billows around you. You cough, wiping way tears.", "Put the Smoke token in this room. The Smoke blocks line of sight from adjacent rooms.\r\n                                    An explorer rolls 2 fewer dice (minimum of 1 die) on all trait rolls while in this room.", "Smoke", 0 }
                });

            migrationBuilder.InsertData(
                table: "Explorers",
                columns: new[] { "Id", "Age", "Birthday", "Height", "Hobbies", "ImageUrl", "Knowledge", "Might", "Name", "Sanity", "Speed", "StartingKnowledge", "StartingMight", "StartingSanity", "StartingSpeed", "Weight" },
                values: new object[,]
                {
                    { 1, 23, "October 18th", "6'4\"", "Football, Shiny Objects", null, "[0,2,2,3,3,5,5,6,6]", "[0,4,5,5,6,6,7,8,8]", "Ox Bellows", "[0,2,2,3,4,5,5,6,7]", "[0,2,2,2,3,4,5,5,6]", 3, 3, 3, 5, 288 },
                    { 2, 20, "June 6th", "5'11\"", "Track, Music, Shakespearean Literature", null, "[0,2,3,3,4,5,5,5,7]", "[0,2,3,3,4,5,6,6,7]", "Darrin \"Flash\" Williams", "[0,1,2,3,4,5,5,5,7]", "[0,4,4,4,5,6,7,7,8]", 3, 3, 3, 5, 188 },
                    { 3, 13, "September 3rd", "4'11\"", "Bugs, Basketball", null, "[0,3,4,4,5,6,7,7,8]", "[0,2,3,3,4,5,5,6,8]", "Peter Akimoto", "[0,3,4,4,4,5,6,6,7]", "[0,3,3,3,4,6,6,7,7]", 3, 3, 4, 4, 98 },
                    { 4, 12, "May 21st", "5'1\"", "Computers, Camping, Hockey", null, "[0,1,3,3,5,5,6,6,7]", "[0,2,3,3,4,5,6,6,7]", "Brandon Jaspers", "[0,3,3,3,4,5,6,7,8]", "[0,3,4,4,4,5,6,7,8]", 3, 4, 4, 3, 109 },
                    { 5, 62, "April 29th", "5'9\"", "Fencing, Gardening", null, "[0,1,3,3,4,5,6,6,8]", "[0,1,2,2,4,4,5,5,7]", "Father Rhinehardt", "[0,3,4,5,5,6,7,7,8]", "[0,2,3,3,4,5,6,7,7]", 4, 3, 5, 3, 185 },
                    { 6, 57, "July 27th", "5'11\"", "Gaelic Music, Drama, Fine Wines", null, "[0,4,5,5,5,5,6,7,8]", "[0,1,2,3,4,5,5,6,6]", "Professor Longfellow", "[0,1,3,3,4,5,5,6,7]", "[0,2,2,4,4,5,5,6,6]", 5, 3, 3, 4, 153 },
                    { 7, 9, "February 14th", "4'2\"", "Swimming, Medicine", null, "[0,2,3,4,4,5,6,6,8]", "[0,2,3,3,3,4,5,6,7]", "Missy Dubourde", "[0,1,2,3,4,5,5,6,7]", "[0,3,4,5,6,6,6,7,7]", 4, 4, 3, 3, 62 },
                    { 8, 8, "November 5th", "3'9\"", "Dolls, Music", null, "[0,1,2,3,4,4,5,5,5]", "[0,2,2,3,3,4,4,6,7]", "Zoe Ingstrom", "[0,3,4,5,5,6,6,7,8]", "[0,4,4,4,4,5,6,8,8]", 3, 4, 3, 4, 49 },
                    { 9, 18, "August 2nd", "5'2\"", "Television, Shopping", null, "[0,2,3,3,4,5,6,7,8]", "[0,3,3,3,4,5,6,7,8]", "Heather Granville", "[0,3,3,3,4,5,6,6,6]", "[0,3,3,4,5,6,6,7,8]", 5, 3, 3, 3, 120 },
                    { 10, 21, "March 4th", "5'7\"", "Reading, Soccer", null, "[0,2,3,3,4,4,5,6,8]", "[0,3,4,4,4,4,5,6,8]", "Jenny LeClerc", "[0,1,1,2,4,4,4,5,6]", "[0,2,3,4,4,4,5,6,8]", 3, 3, 5, 4, 142 },
                    { 11, 37, "December 10th", "5'0\"", "Astrology, Cooking, Baseball", null, "[0,1,3,4,4,4,5,6,6]", "[0,2,3,3,4,5,5,5,6]", "Madame Zostra", "[0,4,4,4,5,6,7,8,8]", "[0,2,3,3,5,5,6,6,7]", 4, 4, 3, 3, 150 },
                    { 12, 42, "January 11th", "5'5\"", "Old Movies, Horses", null, "[0,4,5,5,5,5,6,6,7]", "[0,2,2,2,4,4,5,6,6]", "Vivian Lopez", "[0,4,4,4,5,6,7,8,8]", "[0,3,4,4,4,4,6,7,8]", 4, 3, 3, 4, 142 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "AllowedFloors", "Name" },
                values: new object[] { 7, 7, "Creaky Hallway" });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItems_CardId",
                table: "InventoryItems",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItems_PlacedRoomId",
                table: "InventoryItems",
                column: "PlacedRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItems_PlayerId",
                table: "InventoryItems",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacedRooms_GameId",
                table: "PlacedRooms",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacedRooms_RoomId",
                table: "PlacedRooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_ExplorerId",
                table: "Players",
                column: "ExplorerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_GameId",
                table: "Players",
                column: "GameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryItems");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "PlacedRooms");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Explorers");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
