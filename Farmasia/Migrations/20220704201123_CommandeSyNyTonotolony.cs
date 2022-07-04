using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Farmasia.Migrations
{
    public partial class CommandeSyNyTonotolony : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    CommandeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NumFacture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande", x => x.CommandeID);
                });

            migrationBuilder.CreateTable(
                name: "Fournisseur",
                columns: table => new
                {
                    FournisseurID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseur", x => x.FournisseurID);
                });

            migrationBuilder.CreateTable(
                name: "CommandeSProduit",
                columns: table => new
                {
                    CommandesCommandeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SProduitsSProduitID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandeSProduit", x => new { x.CommandesCommandeID, x.SProduitsSProduitID });
                    table.ForeignKey(
                        name: "FK_CommandeSProduit_Commande_CommandesCommandeID",
                        column: x => x.CommandesCommandeID,
                        principalTable: "Commande",
                        principalColumn: "CommandeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommandeSProduit_SProduit_SProduitsSProduitID",
                        column: x => x.SProduitsSProduitID,
                        principalTable: "SProduit",
                        principalColumn: "SProduitID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FournisseurSProduit",
                columns: table => new
                {
                    FournisseursFournisseurID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SProduitsSProduitID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FournisseurSProduit", x => new { x.FournisseursFournisseurID, x.SProduitsSProduitID });
                    table.ForeignKey(
                        name: "FK_FournisseurSProduit_Fournisseur_FournisseursFournisseurID",
                        column: x => x.FournisseursFournisseurID,
                        principalTable: "Fournisseur",
                        principalColumn: "FournisseurID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FournisseurSProduit_SProduit_SProduitsSProduitID",
                        column: x => x.SProduitsSProduitID,
                        principalTable: "SProduit",
                        principalColumn: "SProduitID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommandeSProduit_SProduitsSProduitID",
                table: "CommandeSProduit",
                column: "SProduitsSProduitID");

            migrationBuilder.CreateIndex(
                name: "IX_FournisseurSProduit_SProduitsSProduitID",
                table: "FournisseurSProduit",
                column: "SProduitsSProduitID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommandeSProduit");

            migrationBuilder.DropTable(
                name: "FournisseurSProduit");

            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.DropTable(
                name: "Fournisseur");
        }
    }
}
