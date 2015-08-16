using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double S, A, B, C, Area, X;
            
            Console.WriteLine("Area Of a Triangle");
            Console.WriteLine("-------------------");

            Console.WriteLine("Enter the value of A");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of B");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of C");
            C = double.Parse(Console.ReadLine());

            S = (A + B + C) / 2;

            if(((A+B)>C) && ((B+C)>A) && ((A+C)>B))// triangle in-equality theorem
            {
                Area = Math.Sqrt(S * (S - A) * (S - B) * (S - C));

                Console.WriteLine("The Area of the triangle is " + Area);

            }
            else
            {
                Console.WriteLine("The input cannot form a triangle");

            }


            
            
        }
    }
}