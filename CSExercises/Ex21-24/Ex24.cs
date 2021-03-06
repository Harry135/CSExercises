using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Double N = 0;

            Console.Write("Please enter a number to guess: ");
            N = double.Parse(Console.ReadLine());

            Random r = new Random();
            double RandomNo = r.NextDouble() * N;

            do
            {
                RandomNo = (RandomNo + N / RandomNo) / 2;
            } while ((RandomNo * RandomNo >= N + 0.00001)||(RandomNo * RandomNo <= N - 0.00001));

            Console.WriteLine("The square root of {0} is {1: ##.00000}",N,RandomNo);
        }
    }
}
