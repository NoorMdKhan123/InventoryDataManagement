using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StockExchangeProgram
{
    class StockJson
    {
        public StockGroup Read(String Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    return Newtonsoft.Json.JsonConvert.DeserializeObject<StockGroup>(json);
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
