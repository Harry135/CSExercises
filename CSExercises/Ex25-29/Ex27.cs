using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            int X = 0;
            int Y = 0;
            int i = 0;
            
            /*
             * 
             * PART 1 
            Console.WriteLine("X    |   Y   ");
            Console.WriteLine("--------------");

            for (X = -4; X < 5; X++)
            {
                Y = ((2 * (X * X)) - (4 * X) + 3);
                Console.WriteLine(" {0:0.0}  |   {1:0.0}",X,Y);
            }*/

            /*
             * 
             * PART 2 */
            for (X = -4; X < 5; X++)
            {
                Y = ((2 * (X * X)) - (4 * X) + 3);
                for (i = 1; i < Y; i++)
                {
                    Console.Write("*");

                } Console.Write("\n");
            }

        }
    }
}
