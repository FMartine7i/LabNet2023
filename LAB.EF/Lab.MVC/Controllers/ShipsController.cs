using Lab.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class ShipsController : Controller
    {
        // GET: Ships
        public async Task<ActionResult> GetShip(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://swapi.dev/api/ships/{id}/";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    ShipsModel ship = JsonConvert.DeserializeObject<ShipsModel>(json);

                    return View(ship);
                }
                else
                {
                    ViewBag.ErrorMessage = "No se pudo obtener los datos de la nave";
                    return View("Error");
                }
            }
        }
    }
}