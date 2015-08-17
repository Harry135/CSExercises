using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            double OrderAmt = 0, Discount = 0, NewAmt = 0;
            int TV, DVD, MP3;

            Console.WriteLine("Price Calculator");
            Console.WriteLine("-----------------");

            Console.Write("TV: ");
            TV = int.Parse(Console.ReadLine());

            Console.Write("DVD: ");
            DVD = int.Parse(Console.ReadLine());

            Console.Write("MP3: ");
            MP3 = int.Parse(Console.ReadLine());

            OrderAmt = TV * 900 + DVD * 500 + MP3 * 700;

            if (OrderAmt > 10000)
            {
                Discount = (0.15 * TV * 900) + (0.15 * DVD * 500);
                NewAmt = OrderAmt - Discount;
            }
            else if (OrderAmt > 5000 && OrderAmt <= 10000)
            {
                Discount = (0.10 * TV * 900) + (0.10 * DVD * 500);
                NewAmt = OrderAmt - Discount;
            }

            else NewAmt = OrderAmt;

            Console.WriteLine("Total Price of this order os ${0:##.00}", NewAmt);


        }
    }
}