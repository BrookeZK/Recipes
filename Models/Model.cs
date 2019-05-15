
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Recipes.Models
{

  public class RecipeContext : DbContext
  {
    public DbSet<Recipe> recipes { get; set; }
    public DbSet<Category> categories { get; set; }
    public DbSet<Ingredient> ingredients { get; set; }
    public DbSet<Join> join { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=recipes;user=root;password=root;port=8889;");
    }

  }
}
