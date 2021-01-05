using System;

namespace Task06_Godzilla_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double budget = double.Parse(Console.ReadLine());
            int numberExtras = int.Parse(Console.ReadLine());
            double dressPrice = double.Parse(Console.ReadLine());
            // math
            double decor = budget * 0.1;
            double dressSum = dressPrice * numberExtras;
            // check and output
            if (numberExtras > 150)
            {
                dressSum = dressSum - dressSum * 0.1;
            }
            double allSum = decor + dressSum;
            if (allSum > budget)
            {
                double rest = allSum - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {rest:F2} leva more.");
            }
            else
            {
                double rest = budget - allSum;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {rest:F2} leva left.");
            }
            
        }
    }
}
