using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Double A = 0;
            Double B = 0;

            Console.WriteLine("Please enter a Double precision Number");

            A = double.Parse(Console.ReadLine());
            B = A * A;

            Console.WriteLine("Answer: " + B);

        }
    }
}
