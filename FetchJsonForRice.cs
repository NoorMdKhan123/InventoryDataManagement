using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InventoryDataManagement
{
    class FetchJsonForRice
    {
        public Rice Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    var searializerSettings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };
                    Console.WriteLine(json);
                    return JsonConvert.DeserializeObject<Rice>(json, searializerSettings);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem Reading file");
                    return null;
                }
            }
        }
    }
}