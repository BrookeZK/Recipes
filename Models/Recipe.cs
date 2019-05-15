using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Recipes.Models
{

  public class Recipe
  {
    public string name { get; set; }
    public string instructions { get; set; }
    public int id { get; set; }

  }
}
