using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public class News
    {
        //[JsonProperty("datetime")]
        public long Datetime { get; set; }

        //[JsonProperty("headline")]
        public string Headline { get; set; }

        //[JsonProperty("source")]
        public string Source { get; set; }

        //[JsonProperty("url")]
        public string Url { get; set; }

        //[JsonProperty("summary")]
        public string Summary { get; set; }

        //[JsonProperty("related")]
        public string Related { get; set; }

        //[JsonProperty("image")]
        public string Image { get; set; }

        //[JsonProperty("lang")]
       //public Lang Lang { get; set; }

        //[JsonProperty("hasPaywall")]
        public bool HasPaywall { get; set; }
    }
}
