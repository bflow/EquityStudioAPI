using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public class Income
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("income")]
        public List<IncomeData> IncomeList { get; set; }
    }

    public class IncomeData
    {
        [JsonProperty("reportDate")]
        public DateTimeOffset ReportDate { get; set; }

        [JsonProperty("totalRevenue")]
        public long TotalRevenue { get; set; }

        [JsonProperty("costOfRevenue")]
        public long CostOfRevenue { get; set; }

        [JsonProperty("grossProfit")]
        public long GrossProfit { get; set; }

        [JsonProperty("researchAndDevelopment")]
        public dynamic ResearchAndDevelopment { get; set; }

        [JsonProperty("sellingGeneralAndAdmin")]
        public dynamic SellingGeneralAndAdmin { get; set; }

        [JsonProperty("operatingExpense")]
        public long OperatingExpense { get; set; }

        [JsonProperty("operatingIncome")]
        public long OperatingIncome { get; set; }

        [JsonProperty("otherIncomeExpenseNet")]
        public double OtherIncomeExpenseNet { get; set; }

        [JsonProperty("ebit")]
        public long Ebit { get; set; }

        [JsonProperty("interestIncome")]
        public long InterestIncome { get; set; }

        [JsonProperty("pretaxIncome")]
        public long PretaxIncome { get; set; }

        [JsonProperty("incomeTax")]
        public long IncomeTax { get; set; }

        [JsonProperty("minorityInterest")]
        public long MinorityInterest { get; set; }

        [JsonProperty("netIncome")]
        public long NetIncome { get; set; }

        [JsonProperty("netIncomeBasic")]
        public long NetIncomeBasic { get; set; }
    }
}
