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
            return View(new RecipeContext().recipes.ToList());
        }

        [HttpPost("/categories")]
        public IActionResult Create(string categoryName, int recipeId)
        {
            var db = new RecipeContext();
            var category = new Category {name = categoryName};
            db.categories.Add(category);
            db.SaveChanges();
            if (recipeId > 0)
            {
            var join = new Join {recipe_id = recipeId, category_id = category.id};
            db.join.Add(join);
            db.SaveChanges();
            }
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

        [HttpGet("/categories/{id}/edit")]
        public IActionResult Edit(int id)
        {
            var db = new RecipeContext();
            var category = db.categories.Find(id);
            return View(category);
        }

        [HttpPost("/categories/{id}")]
        public IActionResult Update(int id, string categoryName)
        {
            var db = new RecipeContext();
            var category = db.categories.Find(id);
            if (categoryName != null)
            {
              category.name = categoryName;
            }
            db.SaveChanges();
            return RedirectToAction("Show", new {id = id});
        }

        [HttpPost("/categories/{id}/add")]
        public IActionResult AddRecipe(int id, int recipeId)
        {
            var db = new RecipeContext();
            var category = db.categories.Find(id);
            if (recipeId > 0)
            {
              var newJoin = new Join{recipe_id = recipeId, category_id = category.id};
              db.join.Add(newJoin);
            }
            db.SaveChanges();
            return RedirectToAction("Show", new {id = id});
        }

        [HttpPost("/categories/{id}/delete-recipe")]
        public IActionResult DeleteRecipe(int id, int recipeId)
        {
            var db = new RecipeContext();
            var category = db.categories.Find(id);
            if (recipeId > 0)
            {
              Join thisEntry = db.join.Where( j => j.category_id == id && j.recipe_id == recipeId).FirstOrDefault();

              db.join.Remove(thisEntry);
            }
            db.SaveChanges();
            return RedirectToAction("Show", new {id = id});
        }

    }
}
