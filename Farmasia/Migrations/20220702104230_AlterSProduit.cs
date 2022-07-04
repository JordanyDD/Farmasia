using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Farmasia.Migrations
{
    public partial class AlterSProduit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SProduitIDa",
                table: "SProduit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SProduitIDa",
                table: "SProduit");
        }
    }
}
