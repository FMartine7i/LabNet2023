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
    public class PlanetsController : Controller
    {
        public async Task<ActionResult> GetPlanet(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://swapi.dev/api/planets/{id}/";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    PlanetModel planet = JsonConvert.DeserializeObject<PlanetModel>(json);

                    return View(planet);
                }
                else
                {
                    ViewBag.ErrorMessage = "No se pudo obtener los datos del planeta";
                    return View("Error");
                }
            }
        }
    }
}