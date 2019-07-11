using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public partial class CashFlow
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("cashflow")]
        public List<CashFlowData> CashFlowList { get; set; }
    }

    public class CashFlowData
    {
        [JsonProperty("reportDate")]
        public DateTimeOffset ReportDate { get; set; }

        [JsonProperty("netIncome")]
        public long NetIncome { get; set; }

        [JsonProperty("depreciation")]
        public long Depreciation { get; set; }

        [JsonProperty("changesInReceivables")]
        public long ChangesInReceivables { get; set; }

        [JsonProperty("changesInInventories")]
        public long ChangesInInventories { get; set; }

        [JsonProperty("cashChange")]
        public long CashChange { get; set; }

        [JsonProperty("cashFlow")]
        public long CashFlow { get; set; }

        [JsonProperty("capitalExpenditures")]
        public long CapitalExpenditures { get; set; }

        [JsonProperty("investments")]
        public dynamic Investments { get; set; }

        [JsonProperty("investingActivityOther")]
        public long InvestingActivityOther { get; set; }

        [JsonProperty("totalInvestingCashFlows")]
        public long TotalInvestingCashFlows { get; set; }

        [JsonProperty("dividendsPaid")]
        public long DividendsPaid { get; set; }

        [JsonProperty("netBorrowings")]
        public long NetBorrowings { get; set; }

        [JsonProperty("otherFinancingCashFlows")]
        public dynamic OtherFinancingCashFlows { get; set; }

        [JsonProperty("cashFlowFinancing")]
        public long CashFlowFinancing { get; set; }

        [JsonProperty("exchangeRateEffect")]
        public dynamic ExchangeRateEffect { get; set; }
    }

    public partial class CashFlow
    {
        public static CashFlow FromJson(string json) => JsonConvert.DeserializeObject<CashFlow>(json, EquityStudioAPI.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this CashFlow self) => JsonConvert.SerializeObject(self, EquityStudioAPI.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}