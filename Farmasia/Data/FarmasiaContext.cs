using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Farmasia.Models;

namespace Farmasia.Data
{
    public class FarmasiaContext : DbContext
    {
        public FarmasiaContext (DbContextOptions<FarmasiaContext> options)
            : base(options)
        {
        }

        public DbSet<Farmasia.Models.Produit>? Produit { get; set; }
      
        public  DbSet<Farmasia.Models.SProduit>? SProduit { get; set; }
        public DbSet<Farmasia.Models.Commande>? Commande { get; set; }
        public DbSet<Farmasia.Models.Fournisseur>? Fournisseur { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commande>()
                .Property(b => b.LivState)
                .HasDefaultValue(false);
            modelBuilder.Entity<Commande>()
                .Property(b => b.ReleaseDate)
                .HasDefaultValueSql("getdate()");
        }


          
    }
}
