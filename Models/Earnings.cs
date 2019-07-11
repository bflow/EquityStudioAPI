using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public partial class Earnings
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("earnings")]
        public List<EarningsData> EarningsList { get; set; }
    }

    public partial class EarningsData
    {
        [JsonProperty("actualEPS")]
        public double ActualEps { get; set; }

        [JsonProperty("consensusEPS")]
        public double ConsensusEps { get; set; }

        [JsonProperty("announceTime")]
        public string AnnounceTime { get; set; }

        [JsonProperty("numberOfEstimates")]
        public long NumberOfEstimates { get; set; }

        [JsonProperty("EPSSurpriseDollar")]
        public double EpsSurpriseDollar { get; set; }

        [JsonProperty("EPSReportDate")]
        public DateTimeOffset EpsReportDate { get; set; }

        [JsonProperty("fiscalPeriod")]
        public string FiscalPeriod { get; set; }

        [JsonProperty("fiscalEndDate")]
        public DateTimeOffset FiscalEndDate { get; set; }

        [JsonProperty("yearAgo")]
        public double YearAgo { get; set; }

        [JsonProperty("yearAgoChangePercent")]
        public double YearAgoChangePercent { get; set; }
    }
}
