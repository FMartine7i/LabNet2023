using Lab.MVC.Models;
using Lab.MVC.SwapiService;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class SwapiController : Controller
    {
        private readonly SwapiServices _swapiService;

        public SwapiController()
        {
            _swapiService = new SwapiServices();
        }

        public async Task<ActionResult> Index()
        {
            var data = await _swapiService.GetPerson();

            if (!string.IsNullOrEmpty(data))
            {
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<PersonModel>>(data);
                var people = apiResponse.Results;
                return View("Index", people);
            }
            else
            {
                // Manejar el caso de respuesta vacía o error.
                return View("Error");
            }
        }
    }
}