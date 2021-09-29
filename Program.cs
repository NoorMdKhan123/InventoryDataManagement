using System;

namespace InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            FetchJsonForRice fetchJsonForRice = new FetchJsonForRice();

            var data = fetchJsonForRice.Read("C:/Users/md048/Rice.json,Pulses.json,Wheat.json");

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(data));
        }
    }
}
