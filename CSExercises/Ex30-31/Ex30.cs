using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int N = 0, i, Flag = 0;

            Console.WriteLine("Prime Number between 5 and 1000");
            Console.WriteLine("--------------------------------");

            for (N = 5; N < 10000; N++)
            {
                for (i = 2; i <= N / 2; i++)
                {
                    if (N % i == 0)
                    {
                        Flag = 1;
                    }
                }
                if (Flag == 0)
                    Console.WriteLine("Prime No: "+N);
                Flag = 0;
            
            }
                
        }
    }
}
