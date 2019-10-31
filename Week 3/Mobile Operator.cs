using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    class MobileOperator
    {
        static void Main(string[] args)
        {
            string contractDuration = Console.ReadLine();
            string contractType = Console.ReadLine();
            string internet = Console.ReadLine();
            var taxesForMonth = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (contractDuration == "one" && internet == "yes")
            {
                if (contractType == "Small")
                {
                    price = (9.98 + 5.50) * taxesForMonth;
                }
                else if (contractType == "Middle")
                {
                    price = (18.99 + 4.35) * taxesForMonth;
                }
                else if (contractType == "Large")
                {
                    price = (25.98 + 4.35) * taxesForMonth;
                }
                else if (contractType == "ExtraLarge")
                {
                    price = (35.99 + 3.85) * taxesForMonth;
                }
                Console.WriteLine("{0:f2} lv.", price);
            }
            else if (contractDuration == "one" && internet == "no")
            {
                if (contractType == "Small")
                {
                    price = 9.98 * taxesForMonth;
                }
                else if (contractType == "Middle")
                {
                    price = 18.99 * taxesForMonth;
                }
                else if (contractType == "Large")
                {
                    price = 25.98 * taxesForMonth;
                }
                else if (contractType == "ExtraLarge")
                {
                    price = 35.99 * taxesForMonth;
                }
                Console.WriteLine("{0:f2} lv.", price);
            }
            if (contractDuration == "two" && internet == "yes")
            {
                if (contractType == "Small")
                {
                    price = (8.58 + 5.50) * taxesForMonth;
                }
                else if (contractType == "Middle")
                {
                    price = (17.09 + 4.35) * taxesForMonth;
                }
                else if (contractType == "Large")
                {
                    price = (23.59 + 4.35) * taxesForMonth;
                }
                else if (contractType == "ExtraLarge")
                {
                    price = (31.79 + 3.85) * taxesForMonth;
                }
                Console.WriteLine("{0:f2} lv.", price = price - price * 0.0375);
            }
            else if (contractDuration == "two" && internet == "no")
            {
                if (contractType == "Small")
                {
                    price = 8.58 * taxesForMonth;
                }
                else if (contractType == "Middle")
                {
                    price = 17.09 * taxesForMonth;
                }
                else if (contractType == "Large")
                {
                    price = 23.59 * taxesForMonth;
                }
                else if (contractType == "ExtraLarge")
                {
                    price = 31.79 * taxesForMonth;
                }
                Console.WriteLine("{0:f2} lv.", price = price - price * 0.0375);
            }
        }
    }
}