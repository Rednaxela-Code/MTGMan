using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTGManager.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class WorkingModel : Migration
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
                    Paupercommander = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Object = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OracleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MultiverseIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MtgoId = table.Column<int>(type: "int", nullable: true),
                    MtgoFoilId = table.Column<int>(type: "int", nullable: true),
                    TcgplayerId = table.Column<int>(type: "int", nullable: true),
                    CardMarketId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleasedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScryfallUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Layout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighresImage = table.Column<bool>(type: "bit", nullable: true),
                    ImageStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrisId = table.Column<int>(type: "int", nullable: true),
                    ManaCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cmc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TypeLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OracleText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Toughness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalitiesId = table.Column<int>(type: "int", nullable: true),
                    Games = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reserved = table.Column<bool>(type: "bit", nullable: true),
                    Foil = table.Column<bool>(type: "bit", nullable: true),
                    NonFoil = table.Column<bool>(type: "bit", nullable: true),
                    Finishes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oversized = table.Column<bool>(type: "bit", nullable: true),
                    Promo = table.Column<bool>(type: "bit", nullable: true),
                    Reprint = table.Column<bool>(type: "bit", nullable: true),
                    SetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    FlavorText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardBackId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtistIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IllustrationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BorderColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullArt = table.Column<bool>(type: "bit", nullable: true),
                    Textless = table.Column<bool>(type: "bit", nullable: true),
                    Booster = table.Column<bool>(type: "bit", nullable: true),
                    StorySpotlight = table.Column<bool>(type: "bit", nullable: true),
                    EdhrecRank = table.Column<int>(type: "int", nullable: true),
                    PennyRank = table.Column<int>(type: "int", nullable: true),
                    RelatedUrisId = table.Column<int>(type: "int", nullable: true),
                    PurchaseUrisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_ImageUris_ImageUrisId",
                        column: x => x.ImageUrisId,
                        principalTable: "ImageUris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Cards_Legalities_LegalitiesId",
                        column: x => x.LegalitiesId,
                        principalTable: "Legalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Cards_PurchaseUris_PurchaseUrisId",
                        column: x => x.PurchaseUrisId,
                        principalTable: "PurchaseUris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Cards_RelatedUris_RelatedUrisId",
                        column: x => x.RelatedUrisId,
                        principalTable: "RelatedUris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ImageUrisId",
                table: "Cards",
                column: "ImageUrisId",
                unique: true,
                filter: "[ImageUrisId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_LegalitiesId",
                table: "Cards",
                column: "LegalitiesId",
                unique: true,
                filter: "[LegalitiesId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PurchaseUrisId",
                table: "Cards",
                column: "PurchaseUrisId",
                unique: true,
                filter: "[PurchaseUrisId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_RelatedUrisId",
                table: "Cards",
                column: "RelatedUrisId",
                unique: true,
                filter: "[RelatedUrisId] IS NOT NULL");
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
                name: "PurchaseUris");

            migrationBuilder.DropTable(
                name: "RelatedUris");
        }
    }
}
