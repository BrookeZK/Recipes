using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;

namespace Recipes.Controllers
{
    public class RecipesController : Controller
    {
        [HttpGet("/recipes")]
        public IActionResult Index()
        {
            var db = new RecipeContext();
            return View(db.recipes.ToList());
        }

        [HttpGet("/recipes/new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("/recipes")]
        public IActionResult Create(string recipeName, string recipeInstructions)
        {
            var db = new RecipeContext();
            var recipe = new Recipe {name = recipeName, instructions = recipeInstructions};
            db.recipes.Add(recipe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("/recipes/{id}")]
        public IActionResult Show(int id)
        {
            var db = new RecipeContext();
            return View(db.recipes.Find(id));
        }

        [HttpPost("/recipes/{id}/delete")]
        public IActionResult DeleteRecipe(int id)
        {
            var db = new RecipeContext();
            var recipe = db.recipes.Find(id);
            db.recipes.Remove(recipe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
