using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Double A = 0;
            Double B = 0;

            Console.WriteLine("Please enter a double precision number");
            A = Double.Parse(Console.ReadLine());
            B = Math.Sqrt(A);
            Console.WriteLine("Answer : " + B);
            
        }
    }
}
