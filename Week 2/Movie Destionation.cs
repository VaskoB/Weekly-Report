using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Destionation
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double priceforday = 0;

            if(destination == "Dubai")
            {
                if(season == "Winter")
                {
                    priceforday = 45000;
                }
                else if(season == "Summer")
                {
                    priceforday = 40000;
                }
                priceforday = priceforday * 0.70;
            }
            else if(destination == "Sofia")
            {
                if(season == "Winter")
                {
                    priceforday = 17000;
                }
                else if(season == "Summer")
                {
                    priceforday = 12000;
                }
                priceforday = priceforday * 1.25;
            }
            else if(destination == "London")
            {
                if(season == "Winter")
                {
                    priceforday = 24000;
                }
                else if(season == "Summer")
                {
                    priceforday = 20250;
                }
            }

            double total = priceforday * days;
            double left = budget - total;
            double need = total - budget;

            if(budget >= total)
            {
                Console.WriteLine("The budget for the movie is enough! We have {0:f2} leva left!", left);
            }
            else
            {
                Console.WriteLine("The director needs {0:f2} leva more!", need);
            }

        }
    }
}
