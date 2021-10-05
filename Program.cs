using System;

namespace StockExchangeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            StockJson stockJson = new StockJson();
            
            StockGroup stockData = stockJson.Read("C:/Users/md048/Stock.json");
            for (int i = 0; i < stockData.PrimaryGroupStock.Count; i++)
            {
                Console.WriteLine(stockData.PrimaryGroupStock[i].shareName);
                Console.WriteLine(stockData.PrimaryGroupStock[i].shareValue);
                Console.WriteLine(stockData.PrimaryGroupStock[i].shareNumber);
                Param.shareEvaluation(stockData.PrimaryGroupStock[i].shareNumber,
                    stockData.PrimaryGroupStock[i].shareValue);

                
                Console.WriteLine("------");
            }


            for (int i = 0; i < stockData.SecondaryGroupStock.Count; i++)
            {
                Console.WriteLine(stockData.SecondaryGroupStock[i].shareName);
                Console.WriteLine(stockData.SecondaryGroupStock[i].shareValue);
                Console.WriteLine(stockData.SecondaryGroupStock[i].shareNumber);
                Param.shareEvaluation(stockData.PrimaryGroupStock[i].shareNumber,
                   stockData.PrimaryGroupStock[i].shareValue);
                Console.WriteLine("------");
            }


            for (int i = 0; i < stockData.TertiaryGroupStock.Count; i++)
            {
                Console.WriteLine(stockData.TertiaryGroupStock[i].shareName);
                Console.WriteLine(stockData.TertiaryGroupStock[i].shareValue);
                Console.WriteLine(stockData.TertiaryGroupStock[i].shareNumber);
                Param.shareEvaluation(stockData.PrimaryGroupStock[i].shareNumber,
                   stockData.PrimaryGroupStock[i].shareValue);
                Console.WriteLine("------");
            }
        }
    }
    
}
