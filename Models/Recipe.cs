using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Recipes.Models
{

  public class Recipe
  {
    public string name { get; set; }
    public string instructions { get; set; }
    public int id { get; set; }


    public List<Category> ShowCategories()
    {
      List<Category> theList = new List<Category> {};
      var db = new RecipeContext();

      List<Join> joiner = db.join.ToList();
      foreach (var item in joiner)
      {

        if(item.recipe_id == id && item.category_id > 0 )
        {
          theList.Add(db.categories.Find(item.category_id));
        }
      }
      return theList;
    }
  }
}
