using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            string stmt;
            int count, TotalCount;
            
            string[] vowels = new string[] { "a", "e", "i", "o", "u" };
            int i,j;
            
            Console.WriteLine("Please Enter a Phrase :");
            stmt = Console.ReadLine();
            string[] phrase = new string[stmt.Length];

            for(i=0;i<stmt.Length;i++)
            {                
                    phrase[i] = stmt.Substring(i,1);                
            }
            
            /* Total count of vowels calculation*/
            count = 0;
            for (i = 0; i < vowels.Length; i++)
            {
                
                for (j = 0; j < phrase.Length; j++)
                {
                    if (vowels[i] == phrase[j])
                    {
                        count = count + 1;
                    }

                }
            }
            Console.WriteLine("Total Number of vowels: "+count);
            
            /* Individual count of vowels calculation*/

            for (i = 0; i < vowels.Length; i++)
            {
                count = 0;
                for (j = 0; j < phrase.Length; j++)
                {
                    if (vowels[i] == phrase[j])
                    {
                        count = count + 1;
                        TotalCount = count;
                    }

                }
                Console.WriteLine("Number of {0}:{1}",vowels[i],count);
            }



        }
    }
}
