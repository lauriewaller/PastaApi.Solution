using Microsoft.EntityFrameworkCore.Migrations;

namespace PastaApi.Migrations
{
    public partial class PastaToPastas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pasta",
                table: "Pasta");

            migrationBuilder.RenameTable(
                name: "Pasta",
                newName: "Pastas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pastas",
                table: "Pastas",
                column: "PastaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pastas",
                table: "Pastas");

            migrationBuilder.RenameTable(
                name: "Pastas",
                newName: "Pasta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pasta",
                table: "Pasta",
                column: "PastaId");
        }
    }
}
