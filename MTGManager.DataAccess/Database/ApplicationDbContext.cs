using Microsoft.EntityFrameworkCore;
using MTGManager.Shared.Models;

namespace MTGManager.DataAccess.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet for ScryfallCard and related entities
        public DbSet<ScryfallCard> Cards { get; set; }
        public DbSet<ImageUris> ImageUris { get; set; }
        public DbSet<Legalities> Legalities { get; set; }
        public DbSet<RelatedUris> RelatedUris { get; set; }
        public DbSet<PurchaseUris> PurchaseUris { get; set; }
        public DbSet<Collection> Collections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure decimal precision for 'Cmc'
            modelBuilder.Entity<ScryfallCard>()
                .Property(c => c.Cmc)
                .HasColumnType("decimal(18,2)");

            // Define relationships between ScryfallCard and related entities

            // ImageUris relationship
            modelBuilder.Entity<ScryfallCard>()
                .HasOne(c => c.ImageUris)
                .WithOne()  // No navigation back to ScryfallCard from ImageUris
                .HasForeignKey<ScryfallCard>(c => c.ImageUrisId)
                .OnDelete(DeleteBehavior.SetNull); // Optional: adjust delete behavior

            // Legalities relationship
            modelBuilder.Entity<ScryfallCard>()
                .HasOne(c => c.Legalities)
                .WithOne()  // No navigation back to ScryfallCard from Legalities
                .HasForeignKey<ScryfallCard>(c => c.LegalitiesId)
                .OnDelete(DeleteBehavior.SetNull); // Optional: adjust delete behavior

            //// Prices relationship
            //modelBuilder.Entity<ScryfallCard>()
            //    .HasOne(c => c.Prices)
            //    .WithOne()  // No navigation back to ScryfallCard from Prices
            //    .HasForeignKey<ScryfallCard>(c => c.PricesId)
            //    .OnDelete(DeleteBehavior.SetNull); // Optional: adjust delete behavior

            // RelatedUris relationship
            modelBuilder.Entity<ScryfallCard>()
                .HasOne(c => c.RelatedUris)
                .WithOne()  // No navigation back to ScryfallCard from RelatedUris
                .HasForeignKey<ScryfallCard>(c => c.RelatedUrisId)
                .OnDelete(DeleteBehavior.SetNull); // Optional: adjust delete behavior

            // PurchaseUris relationship
            modelBuilder.Entity<ScryfallCard>()
                .HasOne(c => c.PurchaseUris)
                .WithOne()  // No navigation back to ScryfallCard from PurchaseUris
                .HasForeignKey<ScryfallCard>(c => c.PurchaseUrisId)
                .OnDelete(DeleteBehavior.SetNull); // Optional: adjust delete behavior
        }
    }
}
