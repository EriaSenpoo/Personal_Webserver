using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personal_Website.Models
{
    public class The_Data
    {
        [JsonProperty("om_mig_info")]
        public Om_Mig_Info Om_mig_info_class { get; set; }

        [JsonProperty("projekter")]
        public Projekter_Info Projekter_info_class { get; set; }

        [JsonProperty("fritid")]
        public Fritid_Info Fritid_info_class { get; set; }
    }
}
