using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] SortList = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };           
            
            int i, j,p, temp;
            Console.WriteLine(" Program to sort");
            Console.WriteLine(" ---------------");
            
            for (i = 0; i < SortList.Length; i++)
            {
                for (j = 0; j < SortList.Length; j++)
                {
                    if (SortList[i] > SortList[j])
                    {
                        temp = SortList[j];
                        SortList[j] = SortList[i];
                        SortList[i] = temp;
                        
                    }
                    
                }
                for (p = 0; p < SortList.Length; p++)
                {
                    Console.Write(" "+SortList[p]);
                }
                Console.Write("\n");
            }

          

        }
    }
}
