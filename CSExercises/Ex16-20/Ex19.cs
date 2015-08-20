using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double TD = 0; // Total Distance
            double MD = 0.5;// minimum distance
            double CD = 8.5;// distance for which the value is 0.04 for 0.1 KM
            //double AD = 0; // Altered distance after the first 0.5 KM
            double TC = 0; // totlal cost
            double MC = 2.40; // Minimum cost
           // Double CapD = 0;

            Console.WriteLine("Please enter the total distance(km) travelled: ");
            TD = double.Parse(Console.ReadLine());

            TD = Math.Ceiling(TD*10)/10;

            if (TD <= MD)
            {
                TC = MC;
            }

            else if (TD > MD && TD <= CD)
            { 
                TC = MC + (TD - MD)*0.4;
            }
            else
            {
                TC = MC + (8.5 * 0.4) + ((TD - 9.0)*0.5);
            }
               
            Console.WriteLine("The total cost is {0:0.00}", TC);
            
        }
    }
}