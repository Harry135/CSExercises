using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Enter a number: ");
            i = int.Parse(Console.ReadLine());

            while (i != 88) /*Using While*/
            {
                Console.WriteLine("Sorry, Please enter the number again: ");
                i = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Lucky You...");
        }
    }
}
