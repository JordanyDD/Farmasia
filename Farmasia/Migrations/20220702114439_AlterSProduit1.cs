using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Farmasia.Migrations
{
    public partial class AlterSProduit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "SProduit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "SProduit");
        }
    }
}
