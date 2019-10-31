using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {

            double min = double.MaxValue;
            string finalticket = "";
            double finalprice = 0;
            string tickett = Console.ReadLine();

            while (tickett != "End")
            {

                string ticket = tickett;
                double price = double.Parse(Console.ReadLine());
                double minutes = double.Parse(Console.ReadLine());


                if (minutes < min)
                {
                    min = minutes;
                    finalticket = ticket;
                    finalprice = price;
                }
                tickett = Console.ReadLine();
            }

            Console.WriteLine("Ticket found for flight {0} costs {1:f2} leva with {2}h {3}m stay", finalticket, finalprice * 1.96, (Math.Floor(min / 60)), min % 60);

        }
    }
}