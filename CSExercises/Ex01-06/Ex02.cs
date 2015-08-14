using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
             int A = 0;
             int B = 0;
          

            Console.WriteLine("Please enter a integer: ");

            A = int.Parse(Console.ReadLine());
            B = A*A;
            Console.WriteLine("Answer: " +B);

            
        }
    }
}
