using System;

namespace Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            int guests = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            
            double discount = 0;
            double cake = budget * 0.10;
            double total = 0 + cake;

            if (guests >= 10 && guests <= 15)
            {
                discount = 0.85;
                total += (price * discount) * guests;
            }
            else if(guests > 15 && guests <= 20)
            {
                discount = 0.80;
                total += (price * discount) * guests;
            }
            else if(guests > 20)
            {
                discount = 0.75;
                total += (price * discount) * guests;
            }
            else
            {
                total += price * guests;
            }
            double left = budget - total;
            double need = total - budget;

            if(budget >= total)
            {
                Console.WriteLine("It is party time! {0:f2} leva left.", left);
            }
            else if(budget < total)
            {
                Console.WriteLine("No party! {0:f2} leva needed.", need);
            }
            

        }
    }
}
