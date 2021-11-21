using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
            .HasData(
            new Animal { AnimalId = 1, Name = "Spot", Species = "Dog", Age = 2, Gender = "Female" },
            new Animal { AnimalId = 2, Name = "Molly", Species = "Cat", Age = 1, Gender = "Female" },
            new Animal { AnimalId = 3, Name = "Ribsy", Species = "Dog", Age = 2, Gender = "Male" },
            new Animal { AnimalId = 4, Name = "Spiffy", Species = "Dog", Age = 3, Gender = "Male" },
            new Animal { AnimalId = 5, Name = "Underdog", Species = "Cat", Age = 22, Gender = "Male" }
      );
    }   
        public DbSet<Animal> Animals { get; set; }
  }
}