using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEmployeeWage
{
    internal class MonthlyWage
    {
        int perHourRate = 20;
        int fullTimeEmployee = 1;
        int partTimeEmployee = 2;
        int empHour = 0;
        int empWage = 0;
        int totalEmpWage = 0;
        int totalEmpHour = 0;
        int totalWorkingDays = 0;
        
        public void Calculation()
        {
            
            Console.WriteLine("Rate per hour for Employee is 20");
            int totalWorkingHours = 0;
            Random rdm = new Random();

            Check();

            void Check()
            {

                while (totalWorkingDays < 20)
                {
                    totalWorkingDays++;
                    int empCheck = rdm.Next(3);
                    switch (empCheck)
                    {
                        case 1:
                            Console.WriteLine("Employee is working as FullTime Employee means 8 hour work");
                            empHour = 8;
                            break;
                        case 2:
                            Console.WriteLine("Employee is working as PartTime Employee means 4 hour work");
                            empHour = 4;
                            break;
                        default:
                            Console.WriteLine("Employee is not Present");
                            empHour = 0;
                            break;
                    }
                    totalEmpHour += empHour;
                    empWage = empHour * perHourRate;
                    totalEmpWage += empWage;
                }
                Console.WriteLine("Per hour Rate=" + perHourRate);
                Console.WriteLine("Total Working Days=" + totalWorkingDays);
                Console.WriteLine("Total Working Hours=" + totalEmpHour);
                Console.WriteLine("Total Employee Wage =" + totalEmpWage);
            }
        }
    }
}
