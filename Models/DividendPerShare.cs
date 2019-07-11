using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public class DividendPerShare
    {
        [JsonProperty("data")]
        public List<double> Data { get; set; }

        [JsonProperty("index")]
        public List<DivPerShareIndex> Index { get; set; }
    }

    public partial class DivPerShareIndex
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
