using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Farmasia.Migrations
{
    public partial class CQteCPrix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateLivraison",
                table: "Commande",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "LivState",
                table: "Commande",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Commande",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "CQTE",
                table: "CommandeSProduit",
                type: "int",
                nullable: false);

            migrationBuilder.AddColumn<decimal>(
                name: "CPrix",
                table: "FournisseurSProduit",
                type: "int",
                nullable: false);


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateLivraison",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "LivState",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Commande");
        }
    }
}
