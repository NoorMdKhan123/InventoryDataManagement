using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataManagement
{
    class Evaluation
    {
        public static void InventoryEvaluation(string name, int weight, int price)
        {
            int value = weight * price;
            Console.WriteLine("Total price of " +name+ " is : " + value);
        }
    }
}
