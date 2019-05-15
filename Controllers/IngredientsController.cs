using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;

namespace Recipes.Controllers
{
    public class IngredientsController : Controller
    {
        [HttpGet("/ingredients")]
        public IActionResult Index()
        {
            var db = new RecipeContext();
            return View(db.ingredients.ToList());
        }

        [HttpGet("/ingredients/new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("/ingredients")]
        public IActionResult Create(string ingredientName, string ingredientDescription)
        {
            var db = new RecipeContext();
            var ingredient = new Ingredient {name = ingredientName, description = ingredientDescription};
            db.ingredients.Add(ingredient);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("/ingredients/{id}")]
        public IActionResult Show(int id)
        {
            var db = new RecipeContext();
            return View(db.ingredients.Find(id));
        }

    }
}
