using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {

            string Str, Str1 = "";
            
            Console.Write("Enter the sting to check the Palindrome: ");
            Str = Console.ReadLine();

            for (int i = Str.Length - 1; i >= 0; i--)
            {
               Str1 += Str[i];
            }

            if (Str == Str1)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");


            
 
        }
    }
}
