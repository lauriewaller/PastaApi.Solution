using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PastaApi.Models
{
  public class PastaApiContext : DbContext
  {
    public PastaApiContext(DbContextOptions<PastaApiContext> options)
        : base(options)
    {
    }

    public DbSet<Pasta> Pastas { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Pasta>() //We then call the builder's Entity<Type>() method which returns an EntityTypeBuilder object that allows us to configure the type we specify in the method call.
          .HasData( //We can then call the HasData() method of the returned EntityTypeBuilder and pass the method any manner of entries we'd like to use to seed the database.
              new Pasta { PastaId = 1, Name = "Fettucini Alfredo", NoodleType = "Fettucini", GlutenFree = false, SauceType = "Creamy", Ingredients = "Pasta, tomatoes", Origin = "Italy", Url = "https://www.allrecipes.com/recipe/23431/to-die-for-fettuccine-alfredo/", ImageUrl = "https://www.modernhoney.com/wp-content/uploads/2018/08/Fettuccine-Alfredo-Recipe-1.jpg" },
              new Pasta { PastaId = 2, Name = "Cacio E Pepe", NoodleType = "Dinosaur", GlutenFree = true, SauceType = "Tomatoey", Ingredients = "Pasta tomatoes", Origin = "Italy", Url = "www.url.com", ImageUrl = "www.url.com/image"  },
              new Pasta { PastaId = 3, Name = "Spaghetti", NoodleType = "Fettucini", GlutenFree = false, SauceType = "Tomato Basil", Ingredients = "fettucini, tomato, basil, ground beef, parmesan", Origin = "Italy", Url = "https://www.allrecipes.com/recipe/158140/spaghetti-sauce-with-ground-beef/", ImageUrl = "www.url.com/image"  }
              // new Pasta { PastaId = 4, Name = "this should break", GlutenFree = false, SauceType = "Creamy", Ingredients = "Pasta, tomatoes", Origin = "Italy", Url = "www.url.com", ImageUrl = "www.url.com/image" }
          );
    }
  }
}

  // PastaId: 1;
  // r Name: "Fetticini Alfredo";
  // r NoodleType: "Fetticini";
  // r GlutenFree: No;
  // SauceType: "Cream";
  // Ingredients: [cream, butter, garlic, wine, herbs, cheese];
  // r Origin: "Lazio";
  // Url: "recipes.com";
  // r ImGlutenFreeUrl: "recipes.com/imGlutenFreeoffetticine";