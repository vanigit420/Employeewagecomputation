using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage_computation
{
    internal class EmployeeWage
    {
        public void StartWageCal()
        {
            int IS_PART_TIME = 0;
            int IS_FULL_TIME = 1;
            int IS_Absent = 2;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case 0:
            IS_PART_TIME: Console.WriteLine("Employee is Present part Time");
                    empHrs = 4;
                    break;
                case 1:
            IS_FULL_TIME: Console.WriteLine("Employee is Present full Time");
                    empHrs = 8;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}