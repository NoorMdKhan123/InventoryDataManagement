using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;



namespace InventoryDataManagement
{
    class FetchJsonGrains
    {
        public Grains Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    
                    
                    return JsonConvert.DeserializeObject<Grains>(json);
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