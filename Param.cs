using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchangeProgram
{
    class Param
    {
        public static void shareEvaluation(int shareNumber, double shareValue)
        {

            double value = shareNumber * shareValue;
            Console.WriteLine("value is : " + value);
        }
    }
}
