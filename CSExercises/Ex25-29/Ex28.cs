using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {

            int N, i, Flag = 0;
            
            Console.WriteLine("Program to Check Prime Number");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Enter a number: ");
            N = int.Parse(Console.ReadLine());
            
            for (i = 2; i <= N/2; i++)
            {
                if (N % i == 0)
                {
                    Flag = 1;
                }
            }
            if (Flag == 0)
               Console.WriteLine("The given Number is Prime");
            else
               Console.WriteLine("The given Number is Not Prime");

            
           
        }
    }
}
