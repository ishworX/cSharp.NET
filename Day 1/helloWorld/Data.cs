using System;

namespace Coding.Exercise 
{
    public class Exercise {
        public void RunExercise() {

            Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>() {
                {"cheese", 5.99m},
                {"carrots", 2.99m}
            }; 

            Console.WriteLine(itemPrices["cheese"].GetType());
            Console.WriteLine(itemPrices["cheese"]);
            Console.WriteLine(itemPrices["carrots"]);
        }
    }
}