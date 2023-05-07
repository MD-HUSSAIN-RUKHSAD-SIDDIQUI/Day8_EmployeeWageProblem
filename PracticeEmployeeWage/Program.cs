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

            DailyWage dailyWage = new DailyWage();
            dailyWage.Calculate();
            Console.ReadKey();
        }
    }
}
