using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tesmon.Weather.RazorPagesApp.Models;

namespace Tesmon.Weather.RazorPagesApp.Pages
{
    public class WeatherModel : PageModel
    {
        [BindProperty]
        public double main { get; set; }
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherModel(ILogger<IndexModel> logger,
            IHttpClientFactory httpClientFactory
            )
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task OnGet()
        {
            var client = _httpClientFactory.CreateClient("BackEnd");
            var url = client.BaseAddress + "leon,mx";

            HttpResponseMessage result = await client.GetAsync(url);
            Console.WriteLine(result.StatusCode);

            string responseBody = await result.Content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<Root>(responseBody);

            main = model.main.temp;
        }
    }
}
