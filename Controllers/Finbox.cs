using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EquityStudioAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using EquityStudioAPI.Utilities;
using Microsoft.Extensions.Configuration;

namespace EquityStudioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Finbox : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public Finbox(IHttpClientFactory httpClientFactory, IConfiguration config)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = config;
        }

        // GET api/Finbox
        [HttpGet("{symbol}/{function}")]
        public async Task<ActionResult> GetFinboxObject(string symbol, string function)
        {
            string getUrl = symbol + "/" + function;
            string client = _configuration["API:Finbox:Client"];
            FinboxObject finbox = Helpers.SelectEnum(function, new FinboxObject());

            switch (finbox)
            {
                case FinboxObject.dividend:
                    return Ok(await Helpers.GetJson<DividendPerShare>(getUrl, client, _httpClientFactory));
                case FinboxObject.ev_to_ebitda_ltm:
                    return Ok(await Helpers.GetJson<EnterpriseMultiple>(getUrl, client, _httpClientFactory));
                case FinboxObject.fcf_yield_ltm:
                    return Ok(await Helpers.GetJson<List<Dividends>> (getUrl, client, _httpClientFactory));
                case FinboxObject.price_to_sales_ltm:
                    return Ok(await Helpers.GetJson<PriceToSales>(getUrl, client, _httpClientFactory));
                case FinboxObject.roe:
                    return Ok(await Helpers.GetJson<ReturnOnEquity>(getUrl, client, _httpClientFactory));
                default:
                    return new BadRequestObjectResult("Finbox data for " + function + " NOT FOUND");
            }
        }
    }
}
