using Microsoft.AspNetCore.Hosting;
using Microsoft.CodeAnalysis.Operations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Personal_Website.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Personal_Website.Services
{
    public class Data_Info_Service
    {
        // Lånt fra dotNET ASP.NET turotial [4 of 13]
        public Data_Info_Service(IWebHostEnvironment web_host_environment)
        {
            this.web_host_environment = web_host_environment;
        }

        public IWebHostEnvironment web_host_environment { get; }

        private string json_file_name
        {
            get { return Path.Combine(web_host_environment.WebRootPath, "data", "json_data.json"); }
        }

        //public List<string> get_data_om_mig_info_subjects()
        //{
        //    StreamReader reader = File.OpenText(json_file_name);
        //    JToken data = JToken.Parse(reader.ReadToEnd());
        //    JObject om_mig_info = data["om_mig_info"].Value<JObject>();
        //    List<string> subjects = om_mig_info.Properties().Select(property => property.Name).ToList();
        //    return subjects;
        //}
        public Tuple<List<string>, List<JToken>> get_data_om_mig_info_data()
        {
            StreamReader reader = File.OpenText(json_file_name);
            JToken data = JToken.Parse(reader.ReadToEnd());
            JObject om_mig_info = data["om_mig_info"].Value<JObject>();
            List<string> subjects = om_mig_info.Properties().Select(property => property.Name).ToList();
            List<JToken> text = om_mig_info.Properties().Select(property => property.Value).ToList();

            Tuple<List<string>, List<JToken>> om_mig_data = new Tuple<List<string>, List<JToken>>(subjects, text);
            return om_mig_data;
        }
    }
}
