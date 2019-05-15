using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Recipes.Models
{

  public class Category
  {
    public string name { get; set; }
    public int id { get; set; }

    public List<Recipe> ShowRecipes()
    {
      List<Recipe> theList = new List<Recipe> {};
      var db = new RecipeContext();
      List<Join> joinList = db.join.ToList();
      foreach (var item in joinList)
      {
        if (item.category_id == id && item.recipe_id > 0)
        {
          theList.Add(db.recipes.Find(item.recipe_id));
        }
      }
      return theList;
    }

  }
}
