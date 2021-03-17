using Info_tavla.Models;
using Info_tavla.Models.Departure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Info_tavla.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public HttpClient client = new HttpClient();
        public Stops hpl { get; set; }

        //[BindProperty(SupportsGet = true)]
        public string siteID { get; set; }
        public Departures departure { get; set; }
        public Weather weather { get; set; }
        public News news { get; set; }

        [BindProperty(SupportsGet =true)]
        public string location { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            if (location != null)
            {
                HttpContext.Session.SetString("location", location);
            }
            else
            {
                if (HttpContext.Session.GetString("location") != null)
                {
                    location = HttpContext.Session.GetString("location");
                }
                else
                {
                    location = "";
                }
            }
            departure = await GetDeparturesAsync();
            weather = await GetWeatherAsync();
            news = await GetNewsAsync();
            return Page();
        }
        public async Task<Departures> GetDeparturesAsync()
        {
            siteID = "7560";
            string link = $"https://api.sl.se/api2/realtimedeparturesV4.json?key=acf6c15d6216484c8c4895597d6b9797&siteid={siteID}&timewindow=15";
            Task<string> getDeparturesStringTask = client.GetStringAsync(link);
            string departureString = await getDeparturesStringTask;
            departure = JsonSerializer.Deserialize<Departures>(departureString);
            return departure;
        }
        public async Task<Weather> GetWeatherAsync()
        {
            string link = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/17.62525/lat/59.19554/data.json";
            Task<string> getWeatherStringTask = client.GetStringAsync(link);
            string weatherString = await getWeatherStringTask;
            weather = JsonSerializer.Deserialize<Weather>(weatherString);
            return weather;
        }
        public async Task<News> GetNewsAsync()
        {
            string link = "http://api.sr.se/api/v2/programs/index?format=json";
            Task<string> getNewsStringTask = client.GetStringAsync(link);
            string newsString = await getNewsStringTask;
            news = JsonSerializer.Deserialize<News>(newsString);
            return news;
        }
    }
}
