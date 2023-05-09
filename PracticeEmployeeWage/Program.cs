using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program:");
           /* EmployeeAttendance attendance = new EmployeeAttendance();
            attendance.Check();
           */

           /* DailyWage dailyWage = new DailyWage();
            dailyWage.Calculate();
           */
           
            /* PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.WageCalculation();
            */

          /* SwitchCase sw = new SwitchCase();
            sw.WageCalculation();
          */

            /*
             * MonthlyWage monthlyWage = new MonthlyWage();
               monthlyWage.Calculation();
            */
           
            /*
             * WageTillCondition wageTillCondition = new WageTillCondition();
               wageTillCondition.Calculation();
            */


            WageForMultipleCompany wageForMultipleCompany1 = new WageForMultipleCompany();
            wageForMultipleCompany1.Calculation("TCS", 200, 22, 176);

            WageForMultipleCompany wageForMultipleCompany2 = new WageForMultipleCompany();
            wageForMultipleCompany2.Calculation("Amazon", 600, 20, 160);

            WageForMultipleCompany wageForMultipleCompany3 = new WageForMultipleCompany();
            wageForMultipleCompany3.Calculation("MicroSoft", 500, 20, 150);

            Console.ReadKey();
        }
    }
}
