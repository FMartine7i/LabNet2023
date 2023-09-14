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
    public class PeopleController : Controller
    {
        // GET: People
        public async Task<ActionResult> GetPerson(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://swapi.dev/api/people/{id}/";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    PersonModel people = JsonConvert.DeserializeObject<PersonModel>(json);

                    return View(people);
                }
                else
                {
                    ViewBag.ErrorMessage = "No se pudo obtener los datos de la persona";
                    return View("Error");
                }
            }
        }
    }
}