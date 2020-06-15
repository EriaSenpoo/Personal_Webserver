using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personal_Website.Models
{
    public class Fritid_Info
    {
        [JsonProperty("after_effects")]
        public string After_effects { get; set; }

        [JsonProperty("blender")]
        public string Blender { get; set; }

        [JsonProperty("godot")]
        public string Godot { get; set; }
    }
}
