using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public class Financials
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("financials")]
        public List<FinancialsData> FinancialList { get; set; }
    }

    public class FinancialsData
    {
        [JsonProperty("reportDate")]
        public DateTimeOffset ReportDate { get; set; }

        [JsonProperty("grossProfit")]
        public long GrossProfit { get; set; }

        [JsonProperty("costOfRevenue")]
        public long CostOfRevenue { get; set; }

        [JsonProperty("operatingRevenue")]
        public long OperatingRevenue { get; set; }

        [JsonProperty("totalRevenue")]
        public long TotalRevenue { get; set; }

        [JsonProperty("operatingIncome")]
        public long OperatingIncome { get; set; }

        [JsonProperty("netIncome")]
        public long NetIncome { get; set; }

        [JsonProperty("researchAndDevelopment")]
        public dynamic ResearchAndDevelopment { get; set; }

        [JsonProperty("operatingExpense")]
        public long OperatingExpense { get; set; }

        [JsonProperty("currentAssets")]
        public long CurrentAssets { get; set; }

        [JsonProperty("totalAssets")]
        public long TotalAssets { get; set; }

        [JsonProperty("totalLiabilities")]
        public long TotalLiabilities { get; set; }

        [JsonProperty("currentCash")]
        public long CurrentCash { get; set; }

        [JsonProperty("currentDebt")]
        public long CurrentDebt { get; set; }

        [JsonProperty("shortTermDebt")]
        public long ShortTermDebt { get; set; }

        [JsonProperty("longTermDebt")]
        public long LongTermDebt { get; set; }

        [JsonProperty("totalCash")]
        public long TotalCash { get; set; }

        [JsonProperty("totalDebt")]
        public double TotalDebt { get; set; }

        [JsonProperty("shareholderEquity")]
        public long ShareholderEquity { get; set; }

        [JsonProperty("cashChange")]
        public long CashChange { get; set; }

        [JsonProperty("cashFlow")]
        public long CashFlow { get; set; }
    }
}