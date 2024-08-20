using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PokemonApi.Migrations
{
    /// <inheritdoc />
    public partial class populandotabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokedex",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Height = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type1 = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Type2 = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    EvolutionLevel = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    ImageShiny = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokedex", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuperEffective",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type1 = table.Column<int>(type: "int", nullable: true),
                    Type2 = table.Column<int>(type: "int", nullable: true),
                    Type3 = table.Column<int>(type: "int", nullable: true),
                    Type4 = table.Column<int>(type: "int", nullable: true),
                    Type5 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperEffective", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Weaknesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type1 = table.Column<int>(type: "int", nullable: true),
                    Type2 = table.Column<int>(type: "int", nullable: true),
                    Type3 = table.Column<int>(type: "int", nullable: true),
                    Type4 = table.Column<int>(type: "int", nullable: true),
                    Type5 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weaknesses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PokeTypes",
                columns: new[] { "Id", "TypeName" },
                values: new object[,]
                {
                    { 1, "Normal" },
                    { 2, "Fire" },
                    { 3, "Fighting" },
                    { 4, "Water" },
                    { 5, "Flying" },
                    { 6, "Grass" },
                    { 7, "Poison" },
                    { 8, "Electric" },
                    { 9, "Ground" },
                    { 10, "Psychic" },
                    { 11, "Rock" },
                    { 12, "Ice" },
                    { 13, "Bug" },
                    { 14, "Dragon" },
                    { 15, "Ghost" },
                    { 16, "Dark" },
                    { 17, "Steel" },
                    { 18, "Fairy" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "UserActive", "UserName", "UserPassword" },
                values: new object[,]
                {
                    { 1, "alessandro@hotmail.com", 1, "alessandro", "123456" },
                    { 2, "allan@hotmail.com", 1, "allan", "456789" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokedex");

            migrationBuilder.DropTable(
                name: "PokeTypes");

            migrationBuilder.DropTable(
                name: "SuperEffective");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Weaknesses");
        }
    }
}
