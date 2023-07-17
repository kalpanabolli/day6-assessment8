using System;
namespace day6_assessment
{
    public class calc
    {

        public double Calculate(double projectHandles = 1, double extras = 0)
        {
            Console.WriteLine("Enter no.of working hours per day");
            int WorkingHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no.of working Days in a month");
            int workingDays = int.Parse(Console.ReadLine());

            double result = WorkingHours * workingDays + projectHandles * 3000 + extras * 2000;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calc obj = new calc();
            Console.WriteLine("Please Enter your role");
            string role = Console.ReadLine();
            switch (role)
            {
                case "HR":
                    Console.WriteLine($"Monthly salary of the {role} is:\t" + obj.Calculate());
                    break;
                case "Admin":
                    Console.WriteLine("Please enter your projrctHandles");
                    int p1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Monthly salary of the {role} is:\t" + obj.Calculate(p1));
                    break;
                case "SoftwareDeveloper":
                    Console.WriteLine("Please enter your projrctHandles");
                    int p2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your extras");
                    int extras = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Monthly salary of the {role} is:\t" + obj.Calculate(p2, extras));
                    break;
                default:
                    Console.WriteLine("please Enter valid role");
                    break;
            }
            Console.ReadKey();
        }
    }
}