using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Recipes.Models
{

  public class Join
  {
    public int id { get; set; }
    public int recipe_id { get; set; }
    public int category_id { get; set; }
    public int ingredient_id { get; set; }

    
  }


}
