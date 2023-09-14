using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class SwapiController : Controller
    {
        // GET: Swapi
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowPlanet(int id)
        {
            return RedirectToAction("GetPlanet", "Planets", new { id = id});
        }

        public ActionResult ShowPeople(int id)
        {
            return RedirectToAction("GetPerson", "People", new { id = id });
        }

        public ActionResult ShowSpecies(int id)
        {
            return RedirectToAction("GetSpecies", "Species", new { id = id });
        }

        public ActionResult ShowShip(int id)
        {
            return RedirectToAction("GetShip", "Ships", new { id = id });
        }
    }
}