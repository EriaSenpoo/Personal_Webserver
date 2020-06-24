using Microsoft.AspNetCore.Hosting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Personal_Website.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        //public Tuple<List<string>, List<JToken>> get_data_om_mig_info_data()
        //{
        //    StreamReader reader = File.OpenText(json_file_name);
        //    JToken data = JToken.Parse(reader.ReadToEnd());
        //    JObject om_mig_info = data["om_mig_info"].Value<JObject>();
        //    List<string> subjects = om_mig_info.Properties().Select(property => property.Name).ToList();
        //    List<JToken> text = om_mig_info.Properties().Select(property => property.Value).ToList();

        //    Tuple<List<string>, List<JToken>> om_mig_data = new Tuple<List<string>, List<JToken>>(subjects, text);
        //    return om_mig_data;
        //}
        public List<Om_mig_text_object> get_data_om_mig_info_data()
        {
            StreamReader reader = File.OpenText(json_file_name);
            JToken data = JToken.Parse(reader.ReadToEnd());
            JObject om_mig_info = data["om_mig_info"].Value<JObject>();
            List<string> subject = om_mig_info.Properties().Select(property => property.Name).ToList();
            List<JToken> text = om_mig_info.Properties().Select(property => property.Value).ToList();
            List<Om_mig_text_object> om_mig_data = new List<Om_mig_text_object>();
            for (int i = 0; i < subject.Count; i++)
            {
                om_mig_data.Add(new Om_mig_text_object(subject[i], text[i]));
            }
            return om_mig_data;
        }
    }
}
