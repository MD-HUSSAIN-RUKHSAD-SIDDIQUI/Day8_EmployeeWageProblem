using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEmployeeWage
{
    internal class SwitchCase
    {
        int empRate = 20;
        int fullTimeEmployee = 1;
        int partTimeEmployee = 2;
        int empHour = 0;
        int empWage = 0;
        public void WageCalculation()
        {
            Console.WriteLine("Rate per hour for Employee is 20");

            Random rdm = new Random();
            int empCheck = rdm.Next(3);
            Console.WriteLine("random value : " + empCheck);
            Check();
             void Check()
                {


                switch (empCheck)
                {
                    case 1:
                        Console.WriteLine("Employee is working as FullTime Employee means 8 hour work");
                        empHour = 8;
                        break;
                    case 2:
                        Console.WriteLine("Employee is working as PartTime Employee means 4 hor work");

                       empHour = 4;
                        break;
                    default:

                        Console.WriteLine("Employee is not present ");
                        empHour = 0;
                        break;
                }
                empWage = empHour * empRate;
                Console.WriteLine("Employee Wage : " + empWage);
            }
        }
    }
}
