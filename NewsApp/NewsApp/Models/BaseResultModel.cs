using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsApp.Models
{
   public class BaseResultModel<T>
    {
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("totalResults")]
        public int totalResults { get; set; }
        [JsonProperty("articles")]
        public List<T> articles { get; set; }
    }
    
}
