using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double i, N, I, SR, S;
            Console.WriteLine("NO  |  INVERSE  |  SQUARE ROOT  |  SQUARE");
            Console.WriteLine("------------------------------------------");

            N = 10.0;
            for (i = 1; i <= N; i++)
            {
                I = 1/i;
                SR = Math.Sqrt(i);
                S = i*i;
                Console.WriteLine("{0:0.0}  |  {1:0.000}  |  {2:0.000   }  |  {3:0.000  }",i,I,SR,S);
            }
        }
    }
}
