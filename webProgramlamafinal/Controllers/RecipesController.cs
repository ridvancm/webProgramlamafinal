using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using webProgramlamafinal.Models;

namespace webProgramlamafinal.Controllers
{
    public class RecipesController : Controller
    {
        private static List<Recipe> _recipes = new List<Recipe>
        {
            new Recipe { Id = 1, Name = "Sushi", Ingredients = "Rice, Fish, Seaweed", Instructions = "Roll ingredients together.", Category = "EastAsianCuisine" },
            new Recipe { Id = 2, Name = "Ramen", Ingredients = "Noodles, Broth, Meat", Instructions = "Cook noodles and add broth.", Category = "EastAsianCuisine" }
        };

        public IActionResult EastAsianCuisine()
        {
            var eastAsianRecipes = _recipes.FindAll(r => r.Category == "EastAsianCuisine");
            return View(eastAsianRecipes);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Recipe model)
        {
            if (ModelState.IsValid)
            {
                model.Id = _recipes.Count + 1;
                _recipes.Add(model);
                return RedirectToAction("EastAsianCuisine");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recipe = _recipes.Find(r => r.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }

        [HttpPost]
        public IActionResult Edit(Recipe model)
        {
            if (ModelState.IsValid)
            {
                var recipe = _recipes.Find(r => r.Id == model.Id);
                if (recipe != null)
                {
                    recipe.Name = model.Name;
                    recipe.Ingredients = model.Ingredients;
                    recipe.Instructions = model.Instructions;
                    recipe.Category = model.Category;
                    return RedirectToAction("EastAsianCuisine");
                }
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var recipe = _recipes.Find(r => r.Id == id);
            if (recipe != null)
            {
                _recipes.Remove(recipe);
                return RedirectToAction("EastAsianCuisine");
            }
            return NotFound();
        }
    }
}
