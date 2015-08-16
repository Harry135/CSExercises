using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            double D = 0; // The distance travelled in KM
            double TC = 0;// the total cost
            double FC = 2.40; // fixed charge
            double CPKM = 0.40; // cost per KM travelled
            Console.WriteLine("Enter the distance travelled: ");
            
            D = double.Parse(Console.ReadLine());

            TC = FC + (D * CPKM);
            Console.WriteLine("The Total cost for the journey: ${0} ",TC);
                     

        }
    }
}
