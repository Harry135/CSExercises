using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int N, i, Fact = 0;

            Console.WriteLine("Perfect Number between 1 & 1000");
            Console.WriteLine("--------------------------------");

            for (N = 1; N < 1000; N++)
            {
                for (i = 1; i < N - 1; i++)
                {
                    if (N % i == 0)
                    {
                        Fact = Fact+i;
                    }
                    
                }
                if (N == Fact)
                {
                    Console.WriteLine("Perfect Number: " + Fact);
                }
                Fact = 0;
                
            }
                
        }
    }
}
