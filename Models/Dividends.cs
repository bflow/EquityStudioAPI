using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
   
   
    public class Dividends //Data
    {
        //[JsonProperty("exDate")]
        public DateTimeOffset ExDate { get; set; }

        //[JsonProperty("paymentDate")]
        public DateTimeOffset PaymentDate { get; set; }

        //[JsonProperty("recordDate")]
        public DateTimeOffset RecordDate { get; set; }

        //[JsonProperty("declaredDate")]
        public DateTimeOffset DeclaredDate { get; set; }

        //[JsonProperty("amount")]
        public double Amount { get; set; }

        //[JsonProperty("flag")]
        public string Flag { get; set; }

        //[JsonProperty("currency")]
        public string Currency { get; set; }

        //[JsonProperty("description")]
        public string Description { get; set; }

        //[JsonProperty("frequency")]
        public string Frequency { get; set; }

        //[JsonProperty("date")]
        public DateTimeOffset Date { get; set; }
    }
}
