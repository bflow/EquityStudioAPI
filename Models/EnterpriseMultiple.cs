using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public class EnterpriseMultiple
    {
        [JsonProperty("data")]
        public List<double> Data { get; set; }

        [JsonProperty("index")]
        public List<EMindex> IndexList { get; set; }
    }

    public class EMindex
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
