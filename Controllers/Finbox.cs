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

namespace EquityStudioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Finbox : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public Finbox(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory; 
        }
        
        // GET api/Finbox
        [HttpGet("{symbol}/{function}")]
        public async Task<ActionResult> GetFinboxObject(string symbol, string function)
        {
            string getUrl = symbol + "/" + function;
            FinboxObject finbox = Helpers.SelectEnum(function, new FinboxObject());

            switch (finbox)
            {
                case FinboxObject.dividend:
                    return Ok(await Helpers.GetJson<DividendPerShare>(getUrl, "finbox", _httpClientFactory));
                case FinboxObject.ev_to_ebitda_ltm:
                    return Ok(await Helpers.GetJson<EnterpriseMultiple>(getUrl, "finbox", _httpClientFactory));
                case FinboxObject.fcf_yield_ltm:
                    return Ok(await Helpers.GetJson<List<Dividends>> (getUrl, "finbox", _httpClientFactory));
                case FinboxObject.price_to_sales_ltm:
                    return Ok(await Helpers.GetJson<PriceToSales>(getUrl, "finbox", _httpClientFactory));
                case FinboxObject.roe:
                    return Ok(await Helpers.GetJson<ReturnOnEquity>(getUrl, "finbox", _httpClientFactory));
                default:
                    return new BadRequestObjectResult("Finbox data for " + function + " NOT FOUND");
            }
        }
    }
}
