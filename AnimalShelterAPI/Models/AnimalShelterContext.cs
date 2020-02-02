using Microsoft.EntityFrameworkCore;
using System;
namespace AnimalShelterAPI.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
           protected override void OnModelCreating(ModelBuilder builder)
            {
            builder.Entity<Animal>()
                .HasData(
                    
                    new Animal { AnimalId = 1, AnimalName = "Tom", AnimalType = "Dog", ArrivalDate = new DateTime(2019,12,10) },
                    new Animal { AnimalId = 2, AnimalName = "Jerry",AnimalType = "Cat",ArrivalDate = new DateTime(2018,11,10)   },
                    new Animal { AnimalId = 3, AnimalName = "Lessy",AnimalType = "Cat",ArrivalDate = new DateTime(2017,08,10)  },
                    new Animal { AnimalId = 4, AnimalName = "Jim", AnimalType = "Dog", ArrivalDate = new DateTime(2016,10,10) },
                    new Animal { AnimalId = 5, AnimalName = "Trace",AnimalType = "Cat",ArrivalDate = new DateTime(2018,11,10)  }
                );
            }
  
    }
}