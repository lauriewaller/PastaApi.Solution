using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PastaApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pastas",
                columns: table => new
                {
                    PastaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    NoodleType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    GlutenFree = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SauceType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Ingredients = table.Column<string>(type: "varchar(1000) CHARACTER SET utf8mb4", maxLength: 1000, nullable: true),
                    Origin = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Url = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ImageUrl = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pastas", x => x.PastaId);
                });

            migrationBuilder.InsertData(
                table: "Pastas",
                columns: new[] { "PastaId", "GlutenFree", "ImageUrl", "Ingredients", "Name", "NoodleType", "Origin", "SauceType", "Url" },
                values: new object[] { 1, false, "https://www.modernhoney.com/wp-content/uploads/2018/08/Fettuccine-Alfredo-Recipe-1.jpg", "Pasta, tomatoes", "Fettucini Alfredo", "Fettucini", "Italy", "Creamy", "https://www.allrecipes.com/recipe/23431/to-die-for-fettuccine-alfredo/" });

            migrationBuilder.InsertData(
                table: "Pastas",
                columns: new[] { "PastaId", "GlutenFree", "ImageUrl", "Ingredients", "Name", "NoodleType", "Origin", "SauceType", "Url" },
                values: new object[] { 2, true, "www.url.com/image", "Pasta tomatoes", "Cacio E Pepe", "Dinosaur", "Italy", "Tomatoey", "www.url.com" });

            migrationBuilder.InsertData(
                table: "Pastas",
                columns: new[] { "PastaId", "GlutenFree", "ImageUrl", "Ingredients", "Name", "NoodleType", "Origin", "SauceType", "Url" },
                values: new object[] { 3, false, "www.url.com/image", "fettucini, tomato, basil, ground beef, parmesan", "Spaghetti", "Fettucini", "Italy", "Tomato Basil", "https://www.allrecipes.com/recipe/158140/spaghetti-sauce-with-ground-beef/" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pastas");
        }
    }
}
