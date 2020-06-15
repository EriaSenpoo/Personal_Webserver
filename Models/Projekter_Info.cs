using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personal_Website.Models
{
    public class Projekter_Info
    {
        [JsonProperty("mine_projekter")]
        public string Projekter_class { get; set; }
    }
}
