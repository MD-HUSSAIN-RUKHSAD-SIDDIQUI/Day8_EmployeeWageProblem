using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEmployeeWage
{
    public class PartTimeEmployee
    {
        int empRate = 20;
        int fullTimeEmployee = 1;
        int partTimeEmployee = 2;
        int empHour = 0;
        int empWage = 0;
        Random rdm = new Random();
       
        public void WageCalculation()
        {
            /*int empRate = 20;
            int fullTimeEmployee = 1;
            int partTimeEmployee = 2;
            int empHour = 0;
            int empWage = 0;
            */
            //Random rdm = new Random();
            Console.WriteLine("Rate per hour for Employee is 20");

            int empCheck = rdm.Next(3);
            Console.WriteLine("random value : " + empCheck);
            
            Check();
            void Check()
            {
                if (empCheck == fullTimeEmployee)
                {
                    Console.WriteLine("Employee is working as FullTime Employee means 8 hour work");
                    empHour = 8;
                }
                else if (empCheck == partTimeEmployee)
                {
                    Console.WriteLine("Employee is working as PartTime Employee means 4 hour work");
                    empHour = 4;

                }
                else
                {
                    Console.WriteLine("Employee is not present ");
                    empHour = 0;
                }
                empWage = empHour * empRate;
                Console.WriteLine("Employee Wage : " + empWage);
            }
        }
    }
}
