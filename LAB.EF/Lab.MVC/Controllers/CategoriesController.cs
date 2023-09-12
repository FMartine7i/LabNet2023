using Lab.EF.Data;
using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        protected readonly NorthwindContext context;

        public CategoriesController()
        {
            context = new NorthwindContext();
        }
        CategoriesLogic logic = new CategoriesLogic(); 

        public ActionResult Index()
        {
            List<Categories> categorias = logic.GetAll();

            List<CategoriesView> categoriesViews = categorias.Select(c => new CategoriesView
            {
                Id = c.CategoryID,
                Name = c.CategoryName,
                Description = c.Description,
            })
            .ToList();

            return View(categoriesViews);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CategoriesView categoriesView)
        {
            try
            {
                Categories categoriesEntity = new Categories
                {
                    CategoryName = categoriesView.Name,
                    Description = categoriesView.Description,
                };

                logic.Add(categoriesEntity);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }


        public ActionResult Update(int id)
        {
            Categories categoriesEntity = context.Categories.Find(id);

            if (categoriesEntity == null)
            {
                return HttpNotFound();
            }

            CategoriesView categoriesView = new CategoriesView
            {
                Id = categoriesEntity.CategoryID,
                Name = categoriesEntity.CategoryName,
                Description = categoriesEntity.Description
            };

            return View(categoriesView);
        }

        [HttpPost]
        public ActionResult Update(CategoriesView categoriesView)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Categories categoriesEntity = new Categories
                    {
                        CategoryID = categoriesView.Id,
                        CategoryName = categoriesView.Name,
                        Description = categoriesView.Description,
                    };

                    logic.Update(categoriesEntity);
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Excepción de la base de datos: {ex.Message}");
                return RedirectToAction("Index", "Error");
            }
        }
    }
}