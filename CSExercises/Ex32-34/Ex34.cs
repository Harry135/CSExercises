using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] Marks = new int[12, 4];
            int[,] Total = new int[12, 2];
            int i,j;

            for (i = 0; i < Marks.Length; i++)
            {
                for (j = 0; j < Marks.Length; j++)
                {
                    Console.Write("Please Enter the Marks of Student{0}: ", i);
                    Marks[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for()
            
        }
    }
}
