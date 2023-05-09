using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEmployeeWage
{
    internal class WageForMultipleCompany
    {
        public void Calculation(string company,int empRatePerHour,int numOfWorkingDays,int maxHourPerMonth)
        {

            
            int fullTImeEmployee = 1;
            int partTimeEmployee = 2;
            int empHour = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHour = 0;
            int totalWorkingDays = 0;
            int totalWorkingHours = 0;
            Random rdm = new Random();

            while ((totalWorkingDays < numOfWorkingDays) && (totalWorkingHours < maxHourPerMonth))
            {
                totalWorkingDays++;
                int empCheck = rdm.Next(3);
                Console.WriteLine("Random value is : " + empCheck);

                switch (empCheck)
                {
                    case 1:  //Employee is working as FullTime
                        empHour = 8;
                        
                        break;
                    case 2:   //Employee is working as PartTime
                        empHour = 4;
                        break;
                    default: //Employee is Absent
                        empHour = 0;
                        break;
                }
                totalEmpHour += empHour;
                empWage = empHour * empRatePerHour;
                totalEmpWage += empWage;
            }
            Console.WriteLine("Employee is Working in :" + company);
            Console.WriteLine("Employee rate per hour =" + empRatePerHour);
            Console.WriteLine("Total Working Days=" + totalWorkingDays);
            Console.WriteLine("Total Working Hours=" + totalEmpHour);
            Console.WriteLine("Total Employee Wage=" + totalEmpWage);
        }
    }
}
