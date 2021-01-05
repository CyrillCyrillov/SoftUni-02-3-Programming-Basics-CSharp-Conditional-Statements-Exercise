using System;

namespace Task05_Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double hour = double.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int plusMinutes = minutes + 15;
            //check and output
            if (plusMinutes < 60)
            {
                Console.WriteLine($"{hour}:{plusMinutes}");
            }
            else if (plusMinutes == 60)
            {
                hour += 1;
                if (hour == 24) 
                {
                  hour = 0;
                }
                Console.WriteLine($"{hour}:00");
            }
            else if (plusMinutes > 60)
            {
                hour += 1;
                if (hour == 24)
                {
                  hour = 0; ;
                }
                plusMinutes -= 60;
                if (plusMinutes < 10)
                {
                    Console.WriteLine($"{hour}:0{plusMinutes}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{plusMinutes}");
                }
            }
        }
    }
}
