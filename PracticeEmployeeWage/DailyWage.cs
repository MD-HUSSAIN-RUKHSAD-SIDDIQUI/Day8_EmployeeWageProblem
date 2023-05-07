using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEmployeeWage
{
    internal class DailyWage
    {
        public void Calculate()
        {
            int ratePerHour = 20;
            int present = 1;
            int empHour = 0;
            int empWage = 0;
            Random rdm = new Random();
            int empCheck = rdm.Next(2);
            Console.WriteLine("Rate per hour for Employee is 20");
            
            Check();

            void Check()
            {
                if (empCheck == present)
                {
                    Console.WriteLine("Employee is Present and he/she did 8 hour work :");
                    empHour = 8;
                }
                else
                {
                    Console.WriteLine("Employee is Absent and he/she did 0 hour work");
                    empHour = 0;

                }
                empWage = empHour * ratePerHour;
                Console.WriteLine(" Therefore Total Wage of Employee is : " + empWage);
            }
        }
    }
}
