using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            //Random r = new Random();
            //int RandomNo = r.Next(0, 10);
            int RandomNo = 5;
            int A;

            Console.WriteLine("Please enter a number to guess: ");
            A = int.Parse(Console.ReadLine());

            for(int i = 0; i<10; i++)
            {
                if(A == RandomNo)
                    Console.WriteLine("Congrats You guessed the number in {0} attempts", i);
                else
                {
                  Console.WriteLine("Sorry Please Try Again, Please enter it again:");
                  Console.ReadLine();
                }

            }


        }
    }
}
