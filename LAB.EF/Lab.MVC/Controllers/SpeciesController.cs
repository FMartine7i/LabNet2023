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
    public class SpeciesController : Controller
    {
        // GET: Species
        public async Task<ActionResult> GetSpecies(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://swapi.dev/api/species/{id}/";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    SpeciesModel species = JsonConvert.DeserializeObject<SpeciesModel>(json);

                    return View(species);
                }
                else
                {
                    ViewBag.ErrorMessage = "No se pudo obtener los datos de la especie";
                    return View("Error");
                }
            }
        }
    }
}