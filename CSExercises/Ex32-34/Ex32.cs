using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        
        {
            int[] Sales = new int[12];
            string[] Month = new string[] {"JAN","FEB","MAR","APR","MAY","JUN","JUL","AUG","SEP","OCT","NOV","DEC" };
            int i, j, Max, Min, Total = 0;
            double A;

            for(i=0;i<12;i++)
            {
                Console.Write("Enter the sales for the month {0}: ", i);
                Sales[i] = int.Parse(Console.ReadLine());
            }

            //j = i + 1;
            Max = Sales[11];
            for (i = 0; i < 12; i++)
            {                
                if (Sales[i] > Max)
                    Max = Sales[i];
                                    
            }
           

            Min = Sales[0];
            for (j = 0; j < 12; j++)
            {
                if (Sales[j] < Min)
                    Min = Sales[j];

            }
            Console.WriteLine("Maximum Sales:" + i);
            Console.WriteLine("Minimum Sales:" + j);

            for (i = 0; i < 12; i++)
            {
                Total = Total + Sales[i];


            }

                A = Total / 12;

            
            Console.WriteLine("Average Sales:" +A);


            


        }
    }
}
