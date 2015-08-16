using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {

            float X = 0;
            float Y = 0;

            Console.WriteLine("Enter the value of X: ");
            X = float.Parse(Console.ReadLine());

            Y =((2 * (X * X)) - (4 * X) + 3);

            Console.WriteLine("The Value of Y is {0:#.##} ",Y);

            
        }
    }
}
