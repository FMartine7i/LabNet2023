using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesLogic logic = new CategoriesLogic(); 
        // GET: Categories
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

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(CategoriesView categories)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Categories categoriesEntity = new Categories
                    {
                        CategoryID = categories.Id,
                        CategoryName = categories.Name,
                        Description = categories.Description
                    };

                    logic.Update(categoriesEntity);
                    return RedirectToAction("Index");
                }
                return View(categories);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}