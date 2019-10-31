using System;

namespace Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double expenses = double.Parse(Console.ReadLine());


            double cost = nights * price;
            double other_expenses = budget * (expenses / 100);
            double total = cost + other_expenses;
            double left = budget - total;
            double needs = total - budget;


            if (nights > 7)
            {
                price = price * 0.95;
                cost = nights * price;
                total = cost + other_expenses;
                left = budget - total;
                needs = total - budget;

            }
            
            if (budget >= total)
            {
                Console.WriteLine("Ivanovi will be left with {0:f2} leva after vacation.", left);
            }
            else if(budget < total)
            {
                Console.WriteLine("{0:f2} leva needed.", needs);
            }


            
            

        }
    }
}
