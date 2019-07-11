using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public class RecommendationTrends
    {
        [JsonProperty("ratingBuy")]
        public long RatingBuy { get; set; }

        [JsonProperty("ratingOverweight")]
        public long RatingOverweight { get; set; }

        [JsonProperty("ratingHold")]
        public long RatingHold { get; set; }

        [JsonProperty("ratingUnderweight")]
        public long RatingUnderweight { get; set; }

        [JsonProperty("ratingSell")]
        public long RatingSell { get; set; }

        [JsonProperty("ratingNone")]
        public long RatingNone { get; set; }

        [JsonProperty("ratingScaleMark")]
        public double RatingScaleMark { get; set; }

        [JsonProperty("consensusStartDate")]
        public long ConsensusStartDate { get; set; }

        [JsonProperty("consensusEndDate")]
        public long? ConsensusEndDate { get; set; }

        [JsonProperty("corporateActionsAppliedDate")]
        public long CorporateActionsAppliedDate { get; set; }
    }
}
