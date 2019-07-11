using EquityStudioAPI.Models;
using EquityStudioAPI.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace EquityStudioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IEX : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public IEX(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory; 
        }

        // GET api/IEX
        [HttpGet("{symbol}/{function}")]
        public async Task<ActionResult> GetIEXObject(string symbol, string function, string token = "Tpk_a07d9cb3054245e5b9415717daeca65b")
        {
            string getUrl = "stock/" + symbol + "/" + function + "?token=" + token;
            IexObject iex = Helpers.SelectEnum(function, new IexObject());

            switch (iex)
            {
                case IexObject.balancesheet:
                    return Ok(await Helpers.GetJson<BalanceSheet>(getUrl, "iex", _httpClientFactory));
                case IexObject.cashflow:
                    return Ok(await Helpers.GetJson<CashFlow>(getUrl, "iex", _httpClientFactory));
                case IexObject.company:
                    return Ok(await Helpers.GetJson<Company>(getUrl, "iex", _httpClientFactory));
                case IexObject.dividends:
                    return Ok(await Helpers.GetJson<List<Dividends>>(getUrl, "iex", _httpClientFactory));
                case IexObject.earnings:
                    return Ok(await Helpers.GetJson<Earnings>(getUrl, "iex", _httpClientFactory));
                case IexObject.estimates:
                    return Ok(await Helpers.GetJson<EpsEstimate>(getUrl, "iex", _httpClientFactory));
                case IexObject.financials:
                    return Ok(await Helpers.GetJson<Financials>(getUrl, "iex", _httpClientFactory));
                case IexObject.income:
                    return Ok(await Helpers.GetJson<Income>(getUrl, "iex", _httpClientFactory));
                case IexObject.stats:
                    return Ok(await Helpers.GetJson<KeyStats>(getUrl, "iex", _httpClientFactory));
                case IexObject.news:
                    return Ok(await Helpers.GetJson<List<News>>(getUrl, "iex", _httpClientFactory));
                case IexObject.peers:
                    return Ok(await Helpers.GetJson<List<string>>(getUrl, "iex", _httpClientFactory));
                case IexObject.recommendationtrends:
                    return Ok(await Helpers.GetJson<List<RecommendationTrends>>(getUrl, "iex", _httpClientFactory));
                default:
                    return new BadRequestObjectResult("IEX data for " + function + " NOT FOUND");
            }
        }

        // POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
