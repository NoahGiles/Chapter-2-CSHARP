using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaises
{
    class Program
    {
        static void Main(string[] args)
        {
            int userSalary = 60000;
            int userSalary2 = 50000;
            int userSalary3 = 80000;
            const double ANTICIPATED_RAISE = .04;
            double userSalaryChanged;
            userSalaryChanged = userSalary + userSalary * ANTICIPATED_RAISE;
            Console.WriteLine("The projected changed salary for next year will be ${0} " +
                "from an employee who makes ${1} with a change of {2}%.",
                userSalaryChanged, userSalary2, ANTICIPATED_RAISE);
            
            userSalaryChanged = userSalary2 + userSalary2 * ANTICIPATED_RAISE;
            Console.WriteLine("The projected changed salary for next year will be ${0} " +
               "from an employee who makes ${1} with a change of {2}%.",
               userSalaryChanged, userSalary2, ANTICIPATED_RAISE);

            userSalaryChanged = userSalary3 + userSalary3 * ANTICIPATED_RAISE;
            Console.WriteLine("The projected changed salary for next year will be ${0} " +
               "from an employee who makes ${1} with a change of {2}%.",
               userSalaryChanged, userSalary3, ANTICIPATED_RAISE);


            DisplayInteractiveRaises();
        }
        public static void DisplayInteractiveRaises()
        {
            int userSalary;
            const double ANTICIPATED_RAISE = .04;
            double userSalaryChanged;
            Console.WriteLine("Enter your salary >>> ");

            userSalary = Convert.ToInt32(Console.ReadLine());
            userSalaryChanged = userSalary + userSalary * ANTICIPATED_RAISE;

            Console.WriteLine("The projected changed salary for next year would be ${0} " +
                "from your current salary of ${1} with a change of {2}%.",
                userSalaryChanged, userSalary, ANTICIPATED_RAISE);




        }
    }
}