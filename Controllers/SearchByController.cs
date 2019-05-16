using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;

namespace Recipes.Controllers
{
    public class SearchByController : Controller
    {
        [HttpGet("/search-by")]
        public IActionResult Index()
        {
            Dictionary<string, object> model = new Dictionary<string, object>{};
            return View(model);
        }

        [HttpPost("/search-by")]
        public IActionResult Search(string searchQuery)
        {
            var db = new RecipeContext();
            Dictionary<string, object> model = new Dictionary<string, object>{};
            List<Category> foundCategories = db.categories.Where(j => j.name.Contains(searchQuery)).ToList();
            List<Recipe> foundRecipes = db.recipes.Where(j => j.name.Contains(searchQuery) || j.instructions.Contains(searchQuery)).ToList();
            model.Add("categories", foundCategories);
            model.Add("recipes", foundRecipes);
            model.Add("search-query", searchQuery);
            return View("Index", model);
        }

    }
}
