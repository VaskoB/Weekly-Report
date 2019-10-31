using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Profit
{
    class Program
    {
        static void Main(string[] args)
        {

            string show = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double daily = tickets * price;
            double total = days * daily;
            double percentage = total * percent / 100;
            double income = total - percentage;

            Console.WriteLine("The profit from the movie {0} is {1:f2} lv.", show, income);

        }
    }
}
