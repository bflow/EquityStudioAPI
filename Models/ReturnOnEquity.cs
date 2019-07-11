using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public partial class ReturnOnEquity
    {
        [JsonProperty("data")]
        public List<double> Data { get; set; }

        [JsonProperty("index")]
        public List<ROEindex> Index { get; set; }
    }

    public class ROEindex
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }
    }
}
