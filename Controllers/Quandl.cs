using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EquityStudioAPI.Models;
using EquityStudioAPI.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;

namespace EquityStudioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Quandl : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public Quandl(IHttpClientFactory httpClientFactory, IConfiguration config)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = config;
        }

        // GET api/Quandl
        [HttpGet("{symbol}/{function}")]
        public async Task<ActionResult> GetQuandlObject(string function, string symbol = "MULTPL")
        {
            string getUrl = symbol + "/" + function + ".json?api_key=" + _configuration["API:Quandl:Token"];
            string client = _configuration["API:Quandl:Client"];
            QuandlObject quandl = Helpers.SelectEnum(function, new QuandlObject());
            
            switch (quandl)
            {
                case QuandlObject.SP500_DIV_GROWTH_YEAR:
                    return Ok(await Helpers.GetJson<Sp500DivGrowthYearly>(getUrl, client, _httpClientFactory));
                case QuandlObject.SP500_DIV_YIELD_YEAR:
                    return Ok(await Helpers.GetJson<Sp500DivYieldYearly>(getUrl, client, _httpClientFactory));
                case QuandlObject.SP500_PSR_YEAR:
                    return Ok(await Helpers.GetJson<Sp500PriceSalesYearly>(getUrl, client, _httpClientFactory));
                case QuandlObject.YIELD:
                    return Ok(await Helpers.GetJson<TBillYield>(getUrl, client, _httpClientFactory));
                default:
                    return new BadRequestObjectResult("Quandl data for " + function + " NOT FOUND");
            }
        }
    }
}
