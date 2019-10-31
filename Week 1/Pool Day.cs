using System;

namespace Pool_day
{
    class Program
    {
        static void Main(string[] args)
        {

            double people = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double lounge = double.Parse(Console.ReadLine());
            double umbrella = double.Parse(Console.ReadLine());

            double total_tax = people * tax;
            double total_umbrellas = Math.Ceiling(people / 2);
            double umbrellas_cost = total_umbrellas * umbrella;
            double total_lounge = Math.Ceiling(people * 0.75);
            double lounge_cost = total_lounge * lounge;
            

            double total = total_tax + umbrellas_cost + lounge_cost;

            Console.WriteLine("{0:f2} lv.", total);

        }
    }
}
