using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personal_Website.Models
{
    public class Om_Mig_Info
    {
        [JsonProperty("introduktion")]
        public string Introduktion { get; set; }

        [JsonProperty("et_eller_andet")]
        public string Et_eller_andet { get; set; }

        [JsonProperty("et_eller_andet_tredje")]
        public string Et_eller_andet_tredje { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", "{1}", "{2}", Introduktion, Et_eller_andet, Et_eller_andet_tredje);
        }
    }
}
