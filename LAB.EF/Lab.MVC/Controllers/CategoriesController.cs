using Lab.EF.Data;
using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class CategoriesController : Controller
    {
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

                if (categoriesView.Name == null)
                {
                    throw new ArgumentNullException("Name", "El campo de nombre no puede estar nulo.");
                }
                else if (categoriesView.Description == null)
                {
                    throw new ArgumentNullException("Description", "El campo de descripción no puede estar nulo.");
                }
                else
                {
                    logic.Add(categoriesEntity);
                    return RedirectToAction("Index");
                }
            }
            catch (ArgumentNullException ex)
            {
                ViewBag.ErrorMessage = ex.Message; // Configura el mensaje de error
                return RedirectToAction("Index", "Error");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Hubo un error.";
                ViewBag.ExceptionMessage = ex.Message; // Configura el mensaje de excepción
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            try
            {
                Categories categories = logic.GetCategoryID(id);
                CategoriesView categoriesView = new CategoriesView
                {
                    Id = categories.CategoryID,
                    Name = categories.CategoryName,
                    Description = categories.Description,
                };

                return View(categoriesView);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        [HttpPost]
        public ActionResult Update(CategoriesView categoriesView)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            try 
            {
                var categoriesEntity = new Categories
                {
                    CategoryID = categoriesView.Id,
                    CategoryName = categoriesView.Name,
                    Description = categoriesView.Description
                };

                logic.Update(categoriesEntity);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
            
        }
    }
}