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
            int IS_ABSENT = 2;
            int NUM_OF_WORKING_DAYS = 20;
            int EMP_RATE_PER_HOUR = 20;
            int MAX_HRS_IN_MONTH = 100;

            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}