using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int A,B,max,min, HCF,LCM;

            Console.WriteLine("Enter the First number: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second number: ");
            B = int.Parse(Console.ReadLine());

            /* Using Do While*/
            do 
            {
                max = Math.Max(A, B);
                min = Math.Min(A, B);

                max = max - min;

            } while (max != min);
            
            HCF = max;
            LCM = A * B / HCF;

            Console.WriteLine("HCF: " + HCF);
            Console.WriteLine("LCM: " + LCM);

        }
    }
}
