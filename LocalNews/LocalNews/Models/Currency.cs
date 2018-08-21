using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalNews.Models
{
    public partial class Currency
    {
        [JsonProperty("code", Required = Required.AllowNull)]
        public string Code { get; set; }

        [JsonProperty("name", Required = Required.AllowNull)]
        public string Name { get; set; }

        [JsonProperty("symbol", Required = Required.AllowNull)]
        public string Symbol { get; set; }
    }
}
