using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public class BalanceSheet
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("balancesheet")]
        public List<BalanceSheetData> BalanceSheetList { get; set; }
    }

    public class BalanceSheetData
    {
        [JsonProperty("reportDate")]
        public DateTimeOffset ReportDate { get; set; }

        [JsonProperty("currentCash")]
        public long CurrentCash { get; set; }

        [JsonProperty("shortTermInvestments")]
        public dynamic ShortTermInvestments { get; set; }

        [JsonProperty("receivables")]
        public long Receivables { get; set; }

        [JsonProperty("inventory")]
        public long Inventory { get; set; }

        [JsonProperty("otherCurrentAssets")]
        public double OtherCurrentAssets { get; set; }

        [JsonProperty("currentAssets")]
        public long CurrentAssets { get; set; }

        [JsonProperty("longTermInvestments")]
        public long LongTermInvestments { get; set; }

        [JsonProperty("propertyPlantEquipment")]
        public long PropertyPlantEquipment { get; set; }

        [JsonProperty("goodwill")]
        public long Goodwill { get; set; }

        [JsonProperty("intangibleAssets")]
        public double IntangibleAssets { get; set; }

        [JsonProperty("otherAssets")]
        public long OtherAssets { get; set; }

        [JsonProperty("totalAssets")]
        public long TotalAssets { get; set; }

        [JsonProperty("accountsPayable")]
        public long AccountsPayable { get; set; }

        [JsonProperty("currentLongTermDebt")]
        public long CurrentLongTermDebt { get; set; }

        [JsonProperty("otherCurrentLiabilities")]
        public long OtherCurrentLiabilities { get; set; }

        [JsonProperty("totalCurrentLiabilities")]
        public long TotalCurrentLiabilities { get; set; }

        [JsonProperty("longTermDebt")]
        public long LongTermDebt { get; set; }

        [JsonProperty("otherLiabilities")]
        public long OtherLiabilities { get; set; }

        [JsonProperty("minorityInterest")]
        public long MinorityInterest { get; set; }

        [JsonProperty("totalLiabilities")]
        public long TotalLiabilities { get; set; }

        [JsonProperty("commonStock")]
        public long CommonStock { get; set; }

        [JsonProperty("retainedEarnings")]
        public long RetainedEarnings { get; set; }

        [JsonProperty("treasuryStock")]
        public long TreasuryStock { get; set; }

        [JsonProperty("capitalSurplus")]
        public long CapitalSurplus { get; set; }

        [JsonProperty("shareholderEquity")]
        public long ShareholderEquity { get; set; }

        [JsonProperty("netTangibleAssets")]
        public long NetTangibleAssets { get; set; }
    }
}
