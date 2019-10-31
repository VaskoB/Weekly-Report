using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_premiere
{
    class Program
    {
        static void Main(string[] args)
        {

            string projection = Console.ReadLine();
            string packet = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double total = 0;

            if(projection == "John Wick")
            {
                if(packet == "Drink")
                {
                    total = tickets * 12;
                }
                else if(packet == "Popcorn")
                {
                    total = tickets * 15;
                }
                else if(packet == "Menu")
                {
                    total = tickets * 19;
                }
            }
            else if (projection == "Star Wars")
            {
                if (packet == "Drink")
                {
                    total = tickets * 18;
                }
                else if (packet == "Popcorn")
                {
                    total = tickets * 25;
                }
                else if (packet == "Menu")
                {
                    total = tickets * 30;
                }
                if(tickets >= 4)
                {
                    total = total * 0.70;
                }
            }
            else if (projection == "Jumanji")
            {
                if (packet == "Drink")
                {
                    total = tickets * 9;
                }
                else if (packet == "Popcorn")
                {
                    total = tickets * 11;
                }
                else if (packet == "Menu")
                {
                    total = tickets * 14;
                }
                if(tickets == 2)
                {
                    total = total * 0.85;
                }
            }

            Console.WriteLine("Your bill is {0:f2} leva.", total);

        }
    }
}
