using System;

namespace Еxercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int number = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            
            // first bonus system
            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number >= 1000)
                 {
                    bonus = number * 0.1;
                 }  
                 else
                 {
                    bonus = number * 0.2;
                 }
            
            // second bonus system
            if (number % 2 == 0)
            {
                bonus += 1;
            }
            else if (number % 10 == 5)
                 {
                    bonus += 2;
                 }

            // output
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
