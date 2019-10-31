using System;

namespace Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {

            int kozunak = int.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int kg_cookies = int.Parse(Console.ReadLine());

            double kozunak_price = kozunak * 3.20;
            double eggs_price = eggs * 4.35;
            double cookies_price = 5.40 * kg_cookies;
            double egg_paint = 0.15 * (eggs * 12);

            double total = kozunak_price + eggs_price + cookies_price + egg_paint;

            Console.WriteLine($"{total:f2}");

        }
    }
}
