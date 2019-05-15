using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;

namespace Recipes.Controllers
{
    public class CategoriesController : Controller
    {
        [HttpGet("/categories")]
        public IActionResult Index()
        {
            var db = new RecipeContext();
            return View(db.categories.ToList());
        }

        [HttpGet("/categories/new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("/categories")]
        public IActionResult Create(string categoryName)
        {
            var db = new RecipeContext();
            var category = new Category {name = categoryName};
            db.categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("/categories/{id}")]
        public IActionResult Show(int id)
        {
            var db = new RecipeContext();
            return View(db.categories.Find(id));
        }

        [HttpPost("/categories/{id}/delete")]
        public IActionResult DeleteCategory(int id)
        {
            var db = new RecipeContext();
            var category = db.categories.Find(id);
            db.categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
