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
            int[] SALES = new int[] {1000,1350,1250,4500,3000,2000,980,1200,2300,4000,3200,1180};
            string[] Months = new string[] {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sept","Oct","Nov","Dec" };

            int Max = 0, Min = 0, i, j,  temp=0;

            /* Max = SALES.Max();
            Min = SALES.Min();*/

            //Console.WriteLine(Max);
            Max = SALES[0];
            for (i = 0; i < 11; i++)
            {
                if (Max < SALES[i+1])
                {
                    temp = 0;
                    Max = SALES[i+1];
                    temp = i+1;
                }

                else
                {
                    temp = 0;
                    Max = SALES[i+1];
                    temp = i+1;
                }
            
            }
            Console.WriteLine("{0}, {1}", temp, Max);

        }
    }
}
