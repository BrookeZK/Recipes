using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Recipes.Models
{

  public class Ingredient
  {
    public string name { get; set; }
    public string description { get; set; }
    public int id { get; set; }

  }
}
