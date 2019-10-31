using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {

            double lemons = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());

            double lemon_juice = lemons * 980;
            double litres = water * 1000;
            double sugarr = sugar * 0.30;

            double total = lemon_juice + litres + sugarr;

            double cups = Math.Floor(total / 150);
            double cashcash = cups * 1.20;

            Console.WriteLine("All cups sold: {0}", cups);
            Console.WriteLine("Money earned: {0:f2}", cashcash);



        }
    }
}
