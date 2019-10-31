using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushi = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int servings = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double total = 0;

            if(sushi == "sashimi")
            {
                if(restaurant == "Sushi Zone")
                {
                    total = 4.99 * servings;
                }
                else if (restaurant == "Sushi Time")
                {
                    total = 5.49 * servings;
                }
                else if (restaurant == "Sushi Bar")
                {
                    total = 5.25 * servings;
                }
                else if (restaurant == "Asian Pub")
                {
                    total = 4.50 * servings;
                }
                if(symbol == "Y")
                {
                    total = total + (total * 0.20);
                }
                else if(symbol == "N")
                {
                    total = total;
                }
            }
            else if (sushi == "maki")
            {
                if (restaurant == "Sushi Zone")
                {
                    total = 5.29 * servings;
                }
                else if (restaurant == "Sushi Time")
                {
                    total = 4.69 * servings;
                }
                else if (restaurant == "Sushi Bar")
                {
                    total = 5.55 * servings;
                }
                else if (restaurant == "Asian Pub")
                {
                    total = 4.80 * servings;
                }
                if (symbol == "Y")
                {
                    total = total + (total * 0.20);
                }
                else if (symbol == "N")
                {
                    total = total;
                }
            }
            else if (sushi == "uramaki")
            {
                if (restaurant == "Sushi Zone")
                {
                    total = 5.99 * servings;
                }
                else if (restaurant == "Sushi Time")
                {
                    total = 4.49 * servings;
                }
                else if (restaurant == "Sushi Bar")
                {
                    total = 6.25 * servings;
                }
                else if (restaurant == "Asian Pub")
                {
                    total = 5.50 * servings;
                }
                if (symbol == "Y")
                {
                    total = total + (total * 0.20);
                }
                else if (symbol == "N")
                {
                    total = total;
                }
            }
            else if (sushi == "temaki")
            {
                if (restaurant == "Sushi Zone")
                {
                    total = 4.29 * servings;
                }
                else if (restaurant == "Sushi Time")
                {
                    total = 5.19 * servings;
                }
                else if (restaurant == "Sushi Bar")
                {
                    total = 4.75 * servings;
                }
                else if (restaurant == "Asian Pub")
                {
                    total = 5.50 * servings;
                }
                if (symbol == "Y")
                {
                    total = total + (total * 0.20);
                }
                else if (symbol == "N")
                {
                    total = total;
                }
            }

            if (restaurant == "Sushi Zone" || restaurant == "Sushi Time" || restaurant == "Sushi Bar" || restaurant == "Asian Pub")
            {
                Console.WriteLine("Total price: {0} lv.", Math.Ceiling(total));
            }
            else
            {
                Console.WriteLine("{0} is invalid restaurant.", restaurant);
            }
            
        }
    }
}
