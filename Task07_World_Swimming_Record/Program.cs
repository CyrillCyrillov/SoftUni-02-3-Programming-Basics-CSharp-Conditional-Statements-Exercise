using System;

namespace Task07_World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerOneMeter = double.Parse(Console.ReadLine());
            // math
            double addSeconds = Math.Floor(distance / 15) * 12.5;
            double time = distance * timePerOneMeter + addSeconds;
                        // check and output
            if (time < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:F2} seconds.");
            }
            else
            {
                double margin = time - worldRecord;
                Console.WriteLine($"No, he failed! He was {margin:F2} seconds slower.");
            }
        }
    }
}
