﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Models
{
    public partial class Sp500DivGrowthYearly
    {
        [JsonProperty("dataset")]
        public DivGrowthDataset Dataset { get; set; }
    }

    public partial class DivGrowthDataset
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("dataset_code")]
        public string DatasetCode { get; set; }

        [JsonProperty("database_code")]
        public string DatabaseCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("refreshed_at")]
        public DateTimeOffset RefreshedAt { get; set; }

        [JsonProperty("newest_available_date")]
        public DateTimeOffset NewestAvailableDate { get; set; }

        [JsonProperty("oldest_available_date")]
        public DateTimeOffset OldestAvailableDate { get; set; }

        [JsonProperty("column_names")]
        public List<string> ColumnNames { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("premium")]
        public bool Premium { get; set; }

        [JsonProperty("limit")]
        public dynamic Limit { get; set; }

        [JsonProperty("transform")]
        public dynamic Transform { get; set; }

        [JsonProperty("column_index")]
        public dynamic ColumnIndex { get; set; }

        [JsonProperty("start_date")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTimeOffset EndDate { get; set; }

        [JsonProperty("data")]
        public List<List<Datum>> Data { get; set; }

        [JsonProperty("collapse")]
        public dynamic Collapse { get; set; }

        [JsonProperty("order")]
        public dynamic Order { get; set; }

        [JsonProperty("database_id")]
        public long DatabaseId { get; set; }
    }

    public partial struct DivGrowthDatum
    {
        public DateTimeOffset? DateTime;
        public double? Double;

        public static implicit operator DivGrowthDatum(DateTimeOffset DateTime) => new DivGrowthDatum { DateTime = DateTime };
        public static implicit operator DivGrowthDatum(double Double) => new DivGrowthDatum { Double = Double };
    }
}
