using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            String Name, Gender, A;          
            Console.WriteLine("Please enter your Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter your Gender:");
            Gender = Console.ReadLine();

            if (Gender == "M")
            {
                A = "Mr";
                Console.WriteLine("Good Morning {0}.{1}", A, Name);

            }
            else if (Gender == "F")
            {
                A = "Ms";
                Console.WriteLine("Good Morning {0}.{1}", A, Name);

            }
            else
            {
                Console.WriteLine("Please Identify your gender Correctly :)");
            }



        }
    }
}