using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            int Marks = 0;
            String Grade;

            Console.WriteLine("Please enter the mark of the student");
            Marks = int.Parse(Console.ReadLine());

                if (Marks >= 80 && Marks <= 100)
                    Grade = "Grade A";
                else if (Marks >= 60 && Marks <= 79)
                    Grade = "Grade B";
                else if (Marks >= 40 && Marks <= 59)
                    Grade = "Grade C";
                else if (Marks >= 0 && Marks <= 39)
                    Grade = "Grade F";
                else
                    Grade = "**ERROR**";
            
            if (Grade == "**ERROR**")
               Console.WriteLine(Grade);
            else
               Console.WriteLine("You have scored {0} Marks which is {1} ",Marks,Grade);
            
        }
    }
}