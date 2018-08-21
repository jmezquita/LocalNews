using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalNews.Models
{
        public partial class ResponseSources
        {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("sources")]
        public List<Source> Source { get; set; }

  
    }
}
