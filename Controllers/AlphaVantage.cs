using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EquityStudioAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;
using EquityStudioAPI.Utilities;

namespace EquityStudioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlphaVantage : ControllerBase
    {
       
        private readonly IHttpClientFactory _httpClientFactory;

        public AlphaVantage(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory; 
        }

        // GET api/AlphaVantage
        [HttpGet("{function}")]
        public async Task<ActionResult> GetAlphaVObject(string function = "sector", string apikey = "demo")
        {
            string getUrl = "?function=" + function + "&apikey=" + apikey;

            return Ok(await Helpers.GetJson<SectorPerformance>(getUrl, "alphavantage", _httpClientFactory));
        }
    }
}
