using StrategyPatternDemo.Context;
using StrategyPatternDemo.Implementations;
using System;

namespace StrategyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateClient minusClient = new CalculateClient(new Minus());
            Console.WriteLine("Minus: " + minusClient.Calculate(7, 1).ToString());

            CalculateClient plusClient = new CalculateClient(new Plus());
            Console.WriteLine("Plus: " + plusClient.Calculate(7, 1).ToString());

            // Wait for user  
            Console.ReadKey();
        }
    }
}
