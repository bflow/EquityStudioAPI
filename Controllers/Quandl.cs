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

namespace EquityStudioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Quandl : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public Quandl(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory; 
        }
        
        // GET api/Quandl
        [HttpGet("{symbol}/{function}")]
        public async Task<ActionResult> GetQuandlObject(string function, string symbol = "MULTPL", string token = "r1ZdF_L5HKMx4Gx1R91s")
        {
            string getUrl = symbol + "/" + function + ".json?api_key=" + token;
            QuandlObject quandl = Helpers.SelectEnum(function, new QuandlObject());
            
            switch (quandl)
            {
                case QuandlObject.SP500_DIV_GROWTH_YEAR:
                    return Ok(await Helpers.GetJson<Sp500DivGrowthYearly>(getUrl, "quandl", _httpClientFactory));
                case QuandlObject.SP500_DIV_YIELD_YEAR:
                    return Ok(await Helpers.GetJson<Sp500DivYieldYearly>(getUrl, "quandl", _httpClientFactory));
                case QuandlObject.SP500_PSR_YEAR:
                    return Ok(await Helpers.GetJson<Sp500PriceSalesYearly>(getUrl, "quandl", _httpClientFactory));
                case QuandlObject.YIELD:
                    return Ok(await Helpers.GetJson<TBillYield>(getUrl, "quandl", _httpClientFactory));
                default:
                    return new BadRequestObjectResult("Quandl data for " + function + " NOT FOUND");
            }
        }
    }
}
