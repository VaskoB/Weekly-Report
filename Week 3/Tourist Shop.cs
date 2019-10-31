using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfProducts = 0;
            int productsBought = 0;
            double sum = 0;

            while (true)
            {
                string productName = Console.ReadLine();
                if (productName == "Stop")
                {
                    Console.WriteLine($"You bought {productsBought} products for {sum:f2} leva.");
                    break;
                }
                else
                {
                    double productPrice = double.Parse(Console.ReadLine());
                    numberOfProducts++;

                    if (numberOfProducts % 3 == 0)
                    {
                        productPrice /= 2;
                    }

                    if (productPrice > budget)
                    {
                        Console.WriteLine($"You don't have enough money!");
                        Console.WriteLine($"You need {productPrice - budget:f2} leva!");
                        break;
                    }

                    productsBought++;
                    sum += productPrice;
                    budget -= productPrice;
                }
            }
        }
    }
}