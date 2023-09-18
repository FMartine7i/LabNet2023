using Lab.MVC.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class SwapiController : Controller
    {
        // GET: Swapi
        public async Task<ActionResult> Index()
        {
            return await GetPerson();
        }

        public async Task<ActionResult> GetPerson()
        {
            HttpClient client = new HttpClient();
            string url = $"https://swapi.dev/api/people";

            HttpResponseMessage response = await client.GetAsync(url);
            List<PersonModel> people = null;

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apiResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<PersonModel>>(content);
                people = apiResponse.Results;
            }
            return View("Index", people);
        }
    }
}