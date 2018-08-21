using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalNews.Models
{
    public partial class ResponseTopHeadLines
    {

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("totalResults")]
        public long TotalResults { get; set; }

        [JsonProperty("articles")]
        public List<TopHeadlines> TopHeadlines { get; set; }

    }
}
