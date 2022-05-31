using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage_computation
{
    internal class EmployeeWage
    {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        public static int monthlyEmployeeWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0, totalEmpWage;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Employee Hours : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine(company + " Total Employee Wage : " + totalEmpWage);
            return totalEmpWage;
        }
    }
}