using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public class KeyStats
    {
        [JsonProperty("week52change")]
        public double Week52Change { get; set; }

        [JsonProperty("week52high")]
        public double Week52High { get; set; }

        [JsonProperty("week52low")]
        public double Week52Low { get; set; }

        [JsonProperty("marketcap")]
        public long Marketcap { get; set; }

        [JsonProperty("employees")]
        public long Employees { get; set; }

        [JsonProperty("day200MovingAvg")]
        public double Day200MovingAvg { get; set; }

        [JsonProperty("day50MovingAvg")]
        public double Day50MovingAvg { get; set; }

        [JsonProperty("float")]
        public long Float { get; set; }

        [JsonProperty("avg10Volume")]
        public double Avg10Volume { get; set; }

        [JsonProperty("avg30Volume")]
        public double Avg30Volume { get; set; }

        [JsonProperty("ttmEPS")]
        public double TtmEps { get; set; }

        [JsonProperty("ttmDividendRate")]
        public double TtmDividendRate { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("sharesOutstanding")]
        public long SharesOutstanding { get; set; }

        [JsonProperty("maxChangePercent")]
        public double MaxChangePercent { get; set; }

        [JsonProperty("year5ChangePercent")]
        public double Year5ChangePercent { get; set; }

        [JsonProperty("year2ChangePercent")]
        public double Year2ChangePercent { get; set; }

        [JsonProperty("year1ChangePercent")]
        public double Year1ChangePercent { get; set; }

        [JsonProperty("ytdChangePercent")]
        public double YtdChangePercent { get; set; }

        [JsonProperty("month6ChangePercent")]
        public double Month6ChangePercent { get; set; }

        [JsonProperty("month3ChangePercent")]
        public double Month3ChangePercent { get; set; }

        [JsonProperty("month1ChangePercent")]
        public double Month1ChangePercent { get; set; }

        [JsonProperty("day30ChangePercent")]
        public double Day30ChangePercent { get; set; }

        [JsonProperty("day5ChangePercent")]
        public double Day5ChangePercent { get; set; }

        [JsonProperty("nextDividendDate")]
        public dynamic NextDividendDate { get; set; }

        [JsonProperty("dividendYield")]
        public double DividendYield { get; set; }

        [JsonProperty("nextEarningsDate")]
        public DateTimeOffset NextEarningsDate { get; set; }

        [JsonProperty("exDividendDate")]
        public DateTimeOffset ExDividendDate { get; set; }

        [JsonProperty("peRatio")]
        public double PeRatio { get; set; }

        [JsonProperty("beta")]
        public double Beta { get; set; }
    }
}
