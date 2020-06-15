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

        //public IEnumerable<Root_Data> get_data()
        //{
        //    using (StreamReader json_file_reader = File.OpenText(json_file_name))
        //    {
        //        return JsonSerializer.Deserialize<Root_Data>(json_file_reader.ReadToEnd());
        //        //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
        //    }
        //}


        // ^-------------- THIS










        // Own stuff from here

        //public void parse_json_normally()
        //{
        //    JObject obj = JObject.Parse(File.ReadAllText("C:/Users/EriaS/source/repos/Personal_Website/Personal_Website/json_data.json"));

        //    string data_path = $@"C:\Users\EriaS\source\repos\Personal_Website\Personal_Website\json_data.json";

        //    TextReader reader = new StreamReader(data_path);
        //    string read_json = reader.ReadToEnd();
        //    Root_Data root = JsonConvert.DeserializeObject<Root_Data>(read_json);
        //}
    }
}
