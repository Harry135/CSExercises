using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double Salary = 0;
            double HA = 0;
            double TA = 0;
            double Income = 0;

            Console.WriteLine("Enter the salary of the employee: ");
            Salary = double.Parse(Console.ReadLine());

            HA = (Salary * 0.10);
            TA = (Salary * 0.03);
            Income = Salary + HA + TA;

            Console.WriteLine("Housing Allowance = "+HA);
            Console.WriteLine("Transport Allowance ="+TA);
            Console.WriteLine("Total Income = "+Income);

        }
    }
}
