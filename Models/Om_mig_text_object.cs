using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personal_Website.Models
{
    public class Om_mig_text_object
    {
        public List<string> subjects { get; set; }
        public List<JToken> text { get; set; }

        public Om_mig_text_object(List<string> subjects, List<JToken> text)
        {
            this.subjects = subjects;
            this.text = text;
        }

        public override string ToString()
        {
            //return string.Format("{0}", "{1}", subjects, text);
            return $"{subjects}, {text}";
        }
    }
}
