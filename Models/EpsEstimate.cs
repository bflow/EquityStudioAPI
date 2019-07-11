using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public class EpsEstimate
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("estimates")]
        public List<EpsEstimateData> EpsEstimateList { get; set; }
    }

    public partial class EpsEstimateData
    {
        [JsonProperty("consensusEPS")]
        public double ConsensusEps { get; set; }

        [JsonProperty("announceTime")]
        public string AnnounceTime { get; set; }

        [JsonProperty("numberOfEstimates")]
        public long NumberOfEstimates { get; set; }

        [JsonProperty("reportDate")]
        public DateTimeOffset ReportDate { get; set; }

        [JsonProperty("fiscalPeriod")]
        public string FiscalPeriod { get; set; }

        [JsonProperty("fiscalEndDate")]
        public DateTimeOffset FiscalEndDate { get; set; }
    }
}
