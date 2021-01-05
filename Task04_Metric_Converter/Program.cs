using System;

namespace Task04_Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double distance = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            // check and output
            if (from == "mm")
            {
                if (to == "m")
                {
                    distance *= 0.001;
                    Console.WriteLine($"{distance:F3}");
                }
                else if (to == "cm")
                {
                    distance *= 0.1;
                    Console.WriteLine($"{distance:F3}");
                }
                else if (to == "mm")
                {
                    Console.WriteLine($"{distance:F3}");
                }
            }
            else if (from == "cm")
            {
                if (to == "cm")
                {
                    Console.WriteLine($"{distance:F3}");
                }
                else if (to == "m")
                {
                    distance *= 0.01;
                    Console.WriteLine($"{distance:F3}");
                }
                else if (to == "mm")
                {
                    distance *= 10;
                    Console.WriteLine($"{distance:F3}");
                }
            }
            else if (from == "m")
            {
                if (to == "m")
                {
                    Console.WriteLine($"{distance:F3}");
                }
                else if (to == "cm")
                {
                    distance *= 100;
                    Console.WriteLine($"{distance:F3}");
                }
                else if (to == "mm")
                {
                    distance *= 1000;
                    Console.WriteLine($"{distance:F3}");
                }
            }
        }
    }
}