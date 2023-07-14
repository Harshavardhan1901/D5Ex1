using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the No of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());

            int[][] employeeSalaries = new int[numEmployees][];

            for (int i = 0; i < numEmployees; i++)
            {
                Console.Write($"Enter the No of working days for Employee {i + 1}: ");
                int numDays = int.Parse(Console.ReadLine());

                employeeSalaries[i] = new int[numDays];

                Console.WriteLine($"Enter the salary for each day of Employee {i + 1}:");
                for (int j = 0; j < numDays; j++)
                {
                    Console.Write($"Enter Salary of Day {j + 1}: of Employee {i + 1}: ");
                    employeeSalaries[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nDay1\tDay2\tDay3\tDay4\tDay5\ttotalSalary");

            for (int i = 0; i < numEmployees; i++)
            {
                int totalSalary = 0;

                for (int j = 0; j < employeeSalaries[i].Length; j++)
                {
                    totalSalary += employeeSalaries[i][j];
                }

                Console.WriteLine($"Employee {i + 1}\t\t\t\t{totalSalary}");
            }

            Console.ReadLine();
        }
    }
}
