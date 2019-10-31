using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double total = 0;
            double left = 0;
            double need = 0;

            for(int i = 0; i < n; i++)
            {
                
                string show = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                if(show == "Thrones")
                {
                    price = price * 0.50;
                    total += price;
                }
                else if(show == "Lucifer")
                {
                    price = price * 0.60;
                    total += price;
                }
                else if(show == "Protector")
                {
                    price = price * 0.70;
                    total += price;
                }
                else if(show == "TotalDrama")
                {
                    price = price * 0.80;
                    total += price;
                }
                else if(show == "Area")
                {
                    price = price * 0.90;
                    total += price;
                }
                else
                {
                    total += price;
                }
                left = budget - total;
                need = total - budget;
                price = 0;
            }

            if(budget >= total)
            {
                Console.WriteLine("You bought all the series and left with {0:f2} lv.", left);
            }
            else if(budget < total)
            {
                Console.WriteLine("You need {0:f2} lv. more to buy the series!", need);
            }

            
            

        }
    }
}
