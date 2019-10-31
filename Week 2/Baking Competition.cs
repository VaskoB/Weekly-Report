using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {

            double players = double.Parse(Console.ReadLine());
            double total_food = 0;
            double total_sum = 0;

            for (int i = 0; i < players; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                double price = 0;

                double count_cookies = 0;
                double count_cakes = 0;
                double count_waffles = 0;

                while (type != "Stop baking!")
                {
                    double count_food = double.Parse(Console.ReadLine());

                    if (type == "cookies")
                    {
                        price = 1.50;
                        price = count_food * price;
                        count_cookies += count_food;
                    }
                    else if (type == "cakes")
                    {
                        price = 7.80;
                        price = count_food * price;
                        count_cakes += count_food;
                    }
                    else if (type == "waffles")
                    {
                        price = 2.30;
                        price = count_food * price;
                        count_waffles += count_food;
                    }

                    total_food += count_food;
                    total_sum += price;
                    type = Console.ReadLine();

                }

                Console.WriteLine("{0} baked {1} cookies, {2} cakes and {3} waffles.", name, count_cookies, count_cakes, count_waffles);

            }
            Console.WriteLine("All bakery sold: {0}", total_food);
            Console.WriteLine("Total sum for charity: {0:f2} lv.", total_sum);

        }
    }
}
