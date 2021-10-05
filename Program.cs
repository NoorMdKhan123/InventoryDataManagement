using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace InventoryDataManagement
{

    class Program
    {
        static void Main(string[] args)
        {
            FetchJsonGrains fetchJsonForGrains = new FetchJsonGrains();

            Grains data = fetchJsonForGrains.Read("C:/Users/md048/Grains.json");
            for (int i = 0; i < data.TypesOfRice.Count; i++)
            {
                Console.WriteLine(data.TypesOfRice[i].name);
                Console.WriteLine(data.TypesOfRice[i].weight);
                Console.WriteLine(data.TypesOfRice[i].Price);
                Evaluation.InventoryEvaluation(data.TypesOfRice[i].name,
                    data.TypesOfRice[i].weight, data.TypesOfRice[i].Price);
                Console.WriteLine("------");
            }


            for (int i = 0; i < data.TypesOfPulses.Count; i++)
            {
                Console.WriteLine(data.TypesOfPulses[i].name);
                Console.WriteLine(data.TypesOfPulses[i].Price);
                Console.WriteLine(data.TypesOfPulses[i].weight);
                Evaluation.InventoryEvaluation(data.TypesOfPulses[i].name,
                    data.TypesOfPulses[i].weight, data.TypesOfPulses[i].Price);
                Console.WriteLine("------");
            }


            for (int i = 0; i < data.TypesOfWheats.Count; i++)
            {
                Console.WriteLine(data.TypesOfWheats[i].name);
                Console.WriteLine(data.TypesOfWheats[i].Price);
                Console.WriteLine(data.TypesOfWheats[i].weight);
                Evaluation.InventoryEvaluation(data.TypesOfWheats[i].name,
                   data.TypesOfWheats[i].weight, data.TypesOfWheats[i].Price);
                Console.WriteLine("------");
            }
        }
    }
}