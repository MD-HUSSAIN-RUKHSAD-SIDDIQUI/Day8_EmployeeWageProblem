using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEmployeeWage
{
    internal class EmployeeAttendance
    {
        public  void Check()
        {
            int present = 1;
            Random rdm = new Random();
            int empCheck = rdm.Next(2);
            PresentOrAbsent();

            void PresentOrAbsent()
                
          { 
            if (empCheck == present)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }

          }
        }
    }
}
