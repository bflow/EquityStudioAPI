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
using Microsoft.Extensions.Configuration;

namespace EquityStudioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlphaVantage : ControllerBase
    {
       
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AlphaVantage(IHttpClientFactory httpClientFactory, IConfiguration config)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = config;
        }

        // GET api/AlphaVantage
        [HttpGet("{function}")]
        public async Task<ActionResult> GetAlphaVObject(string function = "sector")
        {
            string getUrl = "?function=" + function + "&apikey=" + _configuration["API:AlphaVantage:Token"];
            string client = _configuration["API:AlphaVantage:Client"];

            return Ok(await Helpers.GetJson<SectorPerformance>(getUrl, client, _httpClientFactory));
        }
    }
}
