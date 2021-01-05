using System;

namespace Task01_SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secontTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int allTime = firstTime + secontTime + thirdTime;
            if (allTime < 60)
            {
                if (allTime < 10)
                {
                    Console.WriteLine($"0:0{allTime}");
                }
                else
                {
                    Console.WriteLine($"0:{allTime}");
                }
            }
            else
            {
                int minutes = allTime / 60;
                int seconds = allTime % 60;
                if (seconds < 9)
                {
                    Console.WriteLine($"{minutes}:0{seconds}");
                }
                else
                {
                    Console.WriteLine($"{minutes}:{seconds}");
                }
            }
        }
    }
}
