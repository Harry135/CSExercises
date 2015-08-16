using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int number, remainder, sum = 0;

            Console.WriteLine("To find if it is Armstrong Number");
            Console.WriteLine("----------------------------------");
            
            Console.WriteLine("Enter a three digit number:");
            number = int.Parse(Console.ReadLine());

            
            if ((number < 100) || (number >= 1000))
            {
                Console.WriteLine("Please enter a three digit number");

            }
            else
            {
                int A = number;
                for (int i = 0; i < 3; i++)
                {
                    remainder = A % 10;
                    sum = sum + (remainder * remainder * remainder);
                    A = A / 10;
                }

                if (sum == number)
                {
                    Console.WriteLine("Entered Number is an Armstrong Number");
                }
                else
                    Console.WriteLine("Entered Number is not an Armstrong Number");
                
           }
        }
    }
}