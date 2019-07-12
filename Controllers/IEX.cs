using EquityStudioAPI.Models;
using EquityStudioAPI.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        private readonly IConfiguration _configuration;

        public IEX(IHttpClientFactory httpClientFactory, IConfiguration config)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = config;
        }

        // GET api/IEX
        [HttpGet("{symbol}/{function}")]
        public async Task<ActionResult> GetIEXObject(string symbol, string function)
        {
            string getUrl = "stock/" + symbol + "/" + function + "?token=" + _configuration["API:IEXSandbox:Token"];
            string client = _configuration["API:IEXSandbox:Client"];
            IexObject iex = Helpers.SelectEnum(function, new IexObject());

            switch (iex)
            {
                case IexObject.balancesheet:
                    return Ok(await Helpers.GetJson<BalanceSheet>(getUrl, client, _httpClientFactory));
                case IexObject.cashflow:
                    return Ok(await Helpers.GetJson<CashFlow>(getUrl, client, _httpClientFactory));
                case IexObject.company:
                    return Ok(await Helpers.GetJson<Company>(getUrl, client, _httpClientFactory));
                case IexObject.dividends:
                    return Ok(await Helpers.GetJson<List<Dividends>>(getUrl, client, _httpClientFactory));
                case IexObject.earnings:
                    return Ok(await Helpers.GetJson<Earnings>(getUrl, client, _httpClientFactory));
                case IexObject.estimates:
                    return Ok(await Helpers.GetJson<EpsEstimate>(getUrl, client, _httpClientFactory));
                case IexObject.financials:
                    return Ok(await Helpers.GetJson<Financials>(getUrl, client, _httpClientFactory));
                case IexObject.income:
                    return Ok(await Helpers.GetJson<Income>(getUrl, client, _httpClientFactory));
                case IexObject.stats:
                    return Ok(await Helpers.GetJson<KeyStats>(getUrl, client, _httpClientFactory));
                case IexObject.news:
                    return Ok(await Helpers.GetJson<List<News>>(getUrl, client, _httpClientFactory));
                case IexObject.peers:
                    return Ok(await Helpers.GetJson<List<string>>(getUrl, client, _httpClientFactory));
                case IexObject.recommendationtrends:
                    return Ok(await Helpers.GetJson<List<RecommendationTrends>>(getUrl, client, _httpClientFactory));
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
