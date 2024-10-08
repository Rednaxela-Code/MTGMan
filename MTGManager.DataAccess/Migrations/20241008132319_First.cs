using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTGManager.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageUris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Small = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Normal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Large = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Png = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtCrop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderCrop = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageUris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Legalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Standard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Future = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Historic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timeless = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gladiator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pioneer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explorer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modern = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Legacy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pauper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vintage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Penny = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commander = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oathbreaker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandardBrawl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brawl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alchemy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PauperCommander = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oldschool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Premodern = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Predh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsdFoil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsdEtched = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EurFoil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tix = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseUris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tcgplayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cardmarket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cardhoarder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseUris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelatedUris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gatherer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TcgplayerInfiniteArticles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TcgplayerInfiniteDecks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edhrec = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedUris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OracleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MultiverseIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MtgoId = table.Column<int>(type: "int", nullable: true),
                    ArenaId = table.Column<int>(type: "int", nullable: true),
                    TcgplayerId = table.Column<int>(type: "int", nullable: true),
                    CardmarketId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleasedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScryfallUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Layout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighresImage = table.Column<bool>(type: "bit", nullable: true),
                    ImageStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrisId = table.Column<int>(type: "int", nullable: true),
                    ManaCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cmc = table.Column<double>(type: "float", nullable: true),
                    TypeLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OracleText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalitiesId = table.Column<int>(type: "int", nullable: false),
                    Games = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reserved = table.Column<bool>(type: "bit", nullable: true),
                    Foil = table.Column<bool>(type: "bit", nullable: true),
                    Nonfoil = table.Column<bool>(type: "bit", nullable: true),
                    Finishes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oversized = table.Column<bool>(type: "bit", nullable: true),
                    Promo = table.Column<bool>(type: "bit", nullable: true),
                    Reprint = table.Column<bool>(type: "bit", nullable: true),
                    Variation = table.Column<bool>(type: "bit", nullable: true),
                    SetId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Set = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetSearchUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScryfallSetUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RulingsUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrintsSearchUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectorNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Digital = table.Column<bool>(type: "bit", nullable: true),
                    Rarity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardBackId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtistIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IllustrationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullArt = table.Column<bool>(type: "bit", nullable: true),
                    Textless = table.Column<bool>(type: "bit", nullable: true),
                    Booster = table.Column<bool>(type: "bit", nullable: true),
                    StorySpotlight = table.Column<bool>(type: "bit", nullable: true),
                    EdhrecRank = table.Column<int>(type: "int", nullable: true),
                    PennyRank = table.Column<int>(type: "int", nullable: true),
                    PricesId = table.Column<int>(type: "int", nullable: false),
                    RelatedUrisId = table.Column<int>(type: "int", nullable: false),
                    PurchaseUrisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_ImageUris_ImageUrisId",
                        column: x => x.ImageUrisId,
                        principalTable: "ImageUris",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cards_Legalities_LegalitiesId",
                        column: x => x.LegalitiesId,
                        principalTable: "Legalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_Prices_PricesId",
                        column: x => x.PricesId,
                        principalTable: "Prices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_PurchaseUris_PurchaseUrisId",
                        column: x => x.PurchaseUrisId,
                        principalTable: "PurchaseUris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_RelatedUris_RelatedUrisId",
                        column: x => x.RelatedUrisId,
                        principalTable: "RelatedUris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ImageUrisId",
                table: "Cards",
                column: "ImageUrisId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_LegalitiesId",
                table: "Cards",
                column: "LegalitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PricesId",
                table: "Cards",
                column: "PricesId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PurchaseUrisId",
                table: "Cards",
                column: "PurchaseUrisId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_RelatedUrisId",
                table: "Cards",
                column: "RelatedUrisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "ImageUris");

            migrationBuilder.DropTable(
                name: "Legalities");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "PurchaseUris");

            migrationBuilder.DropTable(
                name: "RelatedUris");
        }
    }
}
