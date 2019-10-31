using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            double towel = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double umbrella = (towel / 3) * 2;
            double gucci_flip_flops = umbrella * 0.75;
            double bag = (towel + gucci_flip_flops) / 3;

            double discountt = discount / 100;
            double total = towel + umbrella + gucci_flip_flops + bag;
            double grandtotal = total - (total * discountt);
            double leftover = budget - grandtotal;
            double needs = grandtotal - budget;

            if (budget >= grandtotal)
            {
                Console.WriteLine("Annie's sum is {0:f2} lv. She has {1:f2} lv. left.", grandtotal, leftover);
            }
            else
            {
                Console.WriteLine("Annie's sum is {0:f2} lv. She needs {1:f2} lv. more.", grandtotal, needs);
            }
        }
    }
}
