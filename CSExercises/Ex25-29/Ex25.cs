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
            /*USING INCREMENT OPERATOR*/
            int i, N, Fact;
            
            Console.WriteLine("Enter a integer for finding its factorial");
            N = int.Parse(Console.ReadLine());

            Fact = N;
            for (i = 1; i < N; i++)
            {
                Fact = Fact * i;                
            }
            Console.WriteLine("Factorial of the given Number is: " + Fact);

            /*USING DECREMENT OPERATOR
             * 
             * int i, N, Fact;

            Console.WriteLine("Enter a integer for finding its factorial");
            N = int.Parse(Console.ReadLine());

            Fact = N;
            for (i = N - 1; i >= 1; i--)
            {
                Fact = Fact * i;
            }
            Console.WriteLine("Factorial of Given Number is: " + Fact);
            Console.ReadLine();*/

        }
    }
}
