using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            string Str;
            string[] Str1 = new string[20];
            //char[] C = new char[100];
            int i;

            Console.Write("Enter the sting to convert into Title text: ");
            Str = Console.ReadLine();

           Str1 = Str.Split(' ');

           for (i = 0; i < Str1.Length; i++)
           {
               Str1[i] = Str1[i].Substring(0, 1).ToUpper() + Str1[i].Substring(1, Str1[i].Length-1);
               Console.WriteLine("{0} ", Str1[i]);

           }
           
           

        }
    }
}
