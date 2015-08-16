using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double C = 0;
            double F = 0;

           // float C = 0;
            //float F = 0;
            
            Console.WriteLine("Please enter the Temperature in centigrade: ");
            C = float.Parse(Console.ReadLine());
            F = (1.8 * C) + 32;

            Console.WriteLine("The temperature in Farenheit is " + F);


        }
    }
}
