using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Int32 A;
            
            Console.WriteLine("Enter a integer for finding its factorial");
            A = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < A; i++)
            {
                A = A*i;                
            }
            Console.WriteLine("Factorial :" +A);

        }
    }
}
