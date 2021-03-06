// <auto-generated />
using System;
using Farmasia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Farmasia.Migrations
{
    [DbContext(typeof(FarmasiaContext))]
    partial class FarmasiaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CommandeSProduit", b =>
                {
                    b.Property<string>("CommandesCommandeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SProduitsSProduitID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CommandesCommandeID", "SProduitsSProduitID");

                    b.HasIndex("SProduitsSProduitID");

                    b.ToTable("CommandeSProduit");
                });

            modelBuilder.Entity("Farmasia.Models.Commande", b =>
                {
                    b.Property<string>("CommandeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateLivraison")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LivState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("NumFacture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("CommandeID");

                    b.ToTable("Commande");
                });

            modelBuilder.Entity("Farmasia.Models.Fournisseur", b =>
                {
                    b.Property<string>("FournisseurID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FournisseurID");

                    b.ToTable("Fournisseur");
                });

            modelBuilder.Entity("Farmasia.Models.Produit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Produit");
                });

            modelBuilder.Entity("Farmasia.Models.SProduit", b =>
                {
                    b.Property<string>("SProduitID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Design")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PU")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QTE")
                        .HasColumnType("int");

                    b.Property<string>("SProduitIDa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SProduitID");

                    b.ToTable("SProduit");
                });

            modelBuilder.Entity("FournisseurSProduit", b =>
                {
                    b.Property<string>("FournisseursFournisseurID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SProduitsSProduitID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FournisseursFournisseurID", "SProduitsSProduitID");

                    b.HasIndex("SProduitsSProduitID");

                    b.ToTable("FournisseurSProduit");
                });

            modelBuilder.Entity("CommandeSProduit", b =>
                {
                    b.HasOne("Farmasia.Models.Commande", null)
                        .WithMany()
                        .HasForeignKey("CommandesCommandeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Farmasia.Models.SProduit", null)
                        .WithMany()
                        .HasForeignKey("SProduitsSProduitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FournisseurSProduit", b =>
                {
                    b.HasOne("Farmasia.Models.Fournisseur", null)
                        .WithMany()
                        .HasForeignKey("FournisseursFournisseurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Farmasia.Models.SProduit", null)
                        .WithMany()
                        .HasForeignKey("SProduitsSProduitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
