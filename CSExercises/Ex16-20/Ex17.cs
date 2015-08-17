using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            String Name, Gender,A,B;
            int Age;
            Console.WriteLine("Please enter your Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter your Gender:");
            Gender = Console.ReadLine();
            Console.WriteLine("Please enter your Age:");
            Age = int.Parse(Console.ReadLine());

            if (Gender == "M")
            {
                A = "Mr.";
                if(Age > 40)
                {
                    B = "Uncle";
                    Console.WriteLine("Good Morning {0} {1}", B, Name);
                }
                else
                    Console.WriteLine("Good Morning {0}{1}", A, Name);

            }
            else if (Gender == "F")
            {
                A = "Ms.";
                if (Age > 40)
                {
                    B = "Aunty";
                    Console.WriteLine("Good Morning {0} {1}", B, Name);
                }
                else
                    Console.WriteLine("Good Morning {0}{1}", A, Name);
                
            }
            else
            {
                Console.WriteLine("Please Identify your gender Correctly :)");
            }
        }
    }
}