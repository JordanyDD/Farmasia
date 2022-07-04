using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Farmasia.Migrations
{
    public partial class CreateSProduit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.CreateTable(
                name: "SProduit",
                columns: table => new
                {
                    SProduitID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Design = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PU = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QTE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SProduit", x => x.SProduitID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SProduit");

            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande", x => x.Id);
                });
        }
    }
}
