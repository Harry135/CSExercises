using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            float D;

            Console.WriteLine("Enter the X coordinate of the first point(X1): ");
            x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Y coordinate of the first point(Y1): ");
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the X coordinate of the first point(X2): ");
            x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Y coordinate of the first point(Y2): ");
            y2 = int.Parse(Console.ReadLine());

            D = ((x2 - x1)*(x2 - x1)) + ((y2 - y1)*(y2 - y1));
            Console.WriteLine("The distance between ({0},{1}) and ({2},{3}) is {4}  ",x1, y1, x2, y2,D);
            
            
        }
    }
}
