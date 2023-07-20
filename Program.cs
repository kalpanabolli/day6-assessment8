using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;

            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine(" HR");
            Console.WriteLine(" Admin");
            Console.WriteLine("Software Developer");
            do
            {
                Console.Write("Enter the employee type : ");
                string employeeType = Console.ReadLine().ToUpper();
                //string str = employeeType.ToUpper();
                // Console.WriteLine(employeeType);
                int wHour, nWDays, projectHandles, extras;
                double monthlySalary;


                try
                {

                    switch (employeeType)
                    {
                        case "HR":
                            Console.Write("Enter working hours: ");
                            wHour = int.Parse(Console.ReadLine());
                            Console.Write("Enter number of working days: ");
                            nWDays = int.Parse(Console.ReadLine());
                            monthlySalary = CalculateSalary(wHour, nWDays);
                            Console.WriteLine("Monthly Salary: $" + monthlySalary);
                            break;

                        case "ADMIN":
                            Console.Write("Enter working hours: ");
                            wHour = int.Parse(Console.ReadLine());
                            Console.Write("Enter number of working days: ");
                            nWDays = int.Parse(Console.ReadLine());
                            Console.Write("Enter project handles: ");
                            projectHandles = int.Parse(Console.ReadLine());

                            monthlySalary = CalculateSalary(wHour, nWDays, projectHandles);
                            Console.WriteLine("Monthly Salary: $" + monthlySalary);
                            break;

                        case "SOFTWARE DEVELOPER":
                            Console.Write("Enter working hours: ");
                            wHour = int.Parse(Console.ReadLine());
                            Console.Write("Enter number of working days: ");
                            nWDays = int.Parse(Console.ReadLine());
                            Console.Write("Enter project handles: ");
                            projectHandles = int.Parse(Console.ReadLine());
                            Console.Write("Enter extras: ");
                            extras = int.Parse(Console.ReadLine());

                            monthlySalary = CalculateSalary(wHour, nWDays, projectHandles, extras);
                            Console.WriteLine("Monthly Salary: $" + monthlySalary);
                            break;

                        default:
                            Console.WriteLine("Invalid employee type!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error!" + ex.Message);
                }
                Console.WriteLine("Do you want any other Role \n If yes press y \n to exit press any key");
                choice = Console.ReadLine().ToLower();
            }
            while (choice == "y");

        }
        static double CalculateSalary(int wHour, int nWDays, int projectHandles = 0, int extras = 0)
        {
            double total = wHour * nWDays * 100 + projectHandles * 3000 + extras * 2000;
            return total;
        }
    }
}