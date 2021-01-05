using System;

namespace Task08_Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
                           // input
            double income = double.Parse(Console.ReadLine());
            double avarageGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialScholarship = 0;
            double successScholarship = 0;
            //1.53 Check and Output
            if (income < minSalary && avarageGrade > 4.5)
            {
                socialScholarship = Math.Floor(minSalary * 0.35);
            }
            if (avarageGrade >= 5.5)
            {
                successScholarship = Math.Floor(avarageGrade * 25); 
            }
            if (socialScholarship == 0 && successScholarship == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (socialScholarship > 0 && successScholarship == 0)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (successScholarship > 0 && socialScholarship == 0)
            {
                Console.WriteLine($"You get a scholarship for excellent results {successScholarship} BGN");
            }
            else if (successScholarship > 0 && socialScholarship > 0)
            {
                if (successScholarship >= socialScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {successScholarship} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
            }
        }
    }
}
