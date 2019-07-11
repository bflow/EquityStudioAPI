using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public partial class SectorPerformance
    {
        [JsonProperty("Meta Data")]
        public MetaData MetaData { get; set; }

        [JsonProperty("Rank A: Real-Time Performance")]
        public RankPerformance RankARealTimePerformance { get; set; }

        [JsonProperty("Rank B: 1 Day Performance")]
        public RankPerformance RankB1DayPerformance { get; set; }

        [JsonProperty("Rank C: 5 Day Performance")]
        public RankPerformance RankC5DayPerformance { get; set; }

        [JsonProperty("Rank D: 1 Month Performance")]
        public RankPerformance RankD1MonthPerformance { get; set; }

        [JsonProperty("Rank E: 3 Month Performance")]
        public RankPerformance RankE3MonthPerformance { get; set; }

        [JsonProperty("Rank F: Year-to-Date (YTD) Performance")]
        public RankPerformance RankFYearToDateYtdPerformance { get; set; }

        [JsonProperty("Rank G: 1 Year Performance")]
        public RankPerformance RankG1YearPerformance { get; set; }

        [JsonProperty("Rank H: 3 Year Performance")]
        public RankPerformance RankH3YearPerformance { get; set; }

        [JsonProperty("Rank I: 5 Year Performance")]
        public RankPerformance RankI5YearPerformance { get; set; }

        [JsonProperty("Rank J: 10 Year Performance")]
        public RankPerformance RankJ10YearPerformance { get; set; }
    }

    public partial class MetaData
    {
        [JsonProperty("Information")]
        public string Information { get; set; }

        [JsonProperty("Last Refreshed")]
        public string LastRefreshed { get; set; }
    }

    public partial class RankPerformance
    {
        [JsonProperty("Energy")]
        public string Energy { get; set; }

        [JsonProperty("Utilities")]
        public string Utilities { get; set; }

        [JsonProperty("Health Care")]
        public string HealthCare { get; set; }

        [JsonProperty("Communication Services")]
        public string CommunicationServices { get; set; }

        [JsonProperty("Financials")]
        public string Financials { get; set; }

        [JsonProperty("Consumer Staples")]
        public string ConsumerStaples { get; set; }

        [JsonProperty("Materials")]
        public string Materials { get; set; }

        [JsonProperty("Consumer Discretionary")]
        public string ConsumerDiscretionary { get; set; }

        [JsonProperty("Information Technology")]
        public string InformationTechnology { get; set; }

        [JsonProperty("Industrials")]
        public string Industrials { get; set; }

        [JsonProperty("Real Estate", NullValueHandling = NullValueHandling.Ignore)]
        public string RealEstate { get; set; }
    }
}
