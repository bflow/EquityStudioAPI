using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FreeFlowAPI.Controllers
{
    [Route("api/iex")]
    [ApiController]
    public class IEXController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public IEXController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory; 
        }



        // GET api/IEX
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            //return new string[] { "value1", "value2" };

            //var client = _httpClientFactory.CreateClient("github");
            var client = _httpClientFactory.CreateClient("iex");
            string result = await client.GetStringAsync("stock/AAPL/balance-sheet?token=Tpk_a07d9cb3054245e5b9415717daeca65b");
            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
