using Microsoft.EntityFrameworkCore;

namespace AnimalFacts.Models
{
  public class AnimalFactsContextV2 : DbContext
  {
    public AnimalFactsContextV2(DbContextOptions<AnimalFactsContextV2> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Fact>()
        .HasData(
          new Fact { FactId = 1, AnimalType = "Mammal", Species = "Otter", Description="River otters will ATTACK PEOPLE", Nsfw= "false" },
          new Fact { FactId = 2, AnimalType = "Mammal", Species = "Otter", Description="Sea otters will KILL FOR A GOOD TIME", Nsfw= "false" },
          new Fact { FactId = 3, AnimalType = "Amphibian", Species = "Poison Dart Frog", Description="Just touching the golden poison dart frog WILL KILL YOU", Nsfw= "false" }
        );

    }
          public DbSet<Fact> Facts { get; set; }
      
  }
}