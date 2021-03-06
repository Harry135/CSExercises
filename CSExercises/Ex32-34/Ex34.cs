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
            int[,] Marks = new int[12, 4] { {56,84,68,29},
                                            {94,73,31,89},
                                            {41,63,36,90},
                                            {99,9,18,17},
                                            {62,3,65,75},
                                            {40,96,53,23},
                                            {81,15,27,30},
                                            {21,70,100,22},
                                            {88,50,13,12},
                                            {48,54,52,78},
                                            {64,71,67,25},
                                            {16,93,46,72}}; ;
            //int[,] Total = new int[12, 2];
            int[] Total = new int[12];
            double[] ClassAvg = new double[4];
            double Variance, Avg;
            double[] SD = new double[4];
            int i, j, ClassTotal,ClassTotalAll ;

            

            /*for (i = 0; i < Marks.Length; i++)
            {
                for (j = 0; j < Marks.Length; j++)
                {
                    Console.Write("Please Enter the Marks of Student{0}: ", i);
                    Marks[i, j] = int.Parse(Console.ReadLine());
                }
            }*/

            /*
             * 
             * TO CALCULATE TOTAL*/
            for (i = 0; i < Marks.GetLength(0); i++)
            {
                for (j = 0; j < Marks.GetLength(1); j++)
                {
                    Total[i] = Total[i] + Marks[i, j];
                }
                Console.WriteLine("Total Marks of Student {0}: {1} ",i,Total[i]);
            }
            Console.WriteLine("===================================================");
            /*
             * 
             * TO CALCULATE AVERAGE*/

            for (j = 0; j < Marks.GetLength(1); j++)
            {
                ClassTotal = 0;
                for (i = 0; i < Marks.GetLength(0); i++)
                {
                    ClassTotal = ClassTotal + Marks[i, j];                    
                }
                ClassAvg[j] = Convert.ToDouble(ClassTotal)/12.0;
                Console.WriteLine("Class Avg of Subject {0}: {1:00.00} ", j, ClassAvg[j]);
                
            }
            Console.WriteLine("===================================================");

            /*
             * 
             * TO CALCULATE VARIANCE AND STABNDARD DEVIATION*/
            for (j = 0; j < Marks.GetLength(1); j++)
            {
                Variance = 0;
                for (i = 0; i < Marks.GetLength(0); i++)
                {
                    Variance = Variance + ((Marks[i, j] - ClassAvg[j]) * (Marks[i, j] - ClassAvg[j])) / 12;

                }

                SD[j] = Math.Sqrt(Variance);
                Console.WriteLine("Standard Deviation of Subject {0}: {1:00.00} ", j, SD[j]);

            }
            Console.WriteLine("===================================================");

            /*
             * 
             * TO CALCULATE TOTAL CLASS AVERAGE -  Could have done with different formula*/
            ClassTotalAll = 0;
            for (i = 0; i < Marks.GetLength(0); i++)
            {
                for (j = 0; j < Marks.GetLength(1); j++)
                {
                    ClassTotalAll = ClassTotalAll + Marks[i, j];
                }
                
            }
            Avg = ClassTotalAll/48.0;
            Console.WriteLine("Total Class  Avg for all subject {0:00.00} ",Avg);

            Console.WriteLine("===================================================");



            

        }
    }
}
