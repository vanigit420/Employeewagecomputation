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
            Random random = new Random();
            const int present = 1;
            const int absent = 0;


            int ispresent = random.Next(2);

            if (ispresent == present)
            {
                Console.WriteLine(" Employee is Present ");

            }
            else
            {
                Console.WriteLine(" Employee is Absent");
            }
        }
    }
}