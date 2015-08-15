using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            int A = 0;
            double Result = 0; // just need to store the reslt variable as double to avoin errors.

            Console.WriteLine("Please enter an Integer");
            A= int.Parse(Console.ReadLine());
            Result = Math.Sqrt(A);
            Console.WriteLine("The Square root of {0:#} is {1:##.####}  :",A,Result); 
            
            
        }
    }
}
