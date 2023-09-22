using Lab.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lab.MVC.SwapiService
{
    public class SwapiServices
    {
        public async Task<string> GetPerson()
        {
            HttpClient client = new HttpClient();
            string url = $"https://swapi.dev/api/people";

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return null;
        }
    }
}