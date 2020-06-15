using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personal_Website.Models
{
    public class Root_Data
    {
        [JsonProperty("the_data")]
        public The_Data The_data_class { get; set; }
    }
}
