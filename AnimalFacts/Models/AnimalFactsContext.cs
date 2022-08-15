using Microsoft.EntityFrameworkCore;

namespace AnimalFacts.Models
{
    public class AnimalFactsContext : DbContext
    {
        public AnimalFactsContext(DbContextOptions<AnimalFactsContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Fact>()
            .HasData(
              new Fact { FactId = 1, AnimalType = "Mammal", Species = "Otter", Description="Otters are bad, proven by science" }
            );
        }
        
        public DbSet<Fact> Facts { get; set; }
    }
}