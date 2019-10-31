using System;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double taxi = 0.70;
            double bus = 0.09 * km;
            double train = 0.06 * km;
            double cheapest = 0;

            if(time == "day")
            {
                taxi += 0.79 * km;
            }
            else if(time == "night")
            {
                taxi += 0.90 * km;
            }
            
            if (km < 20)
            {
                cheapest = taxi;
            }
            else if (km < 100)
            {
                cheapest = Math.Min(taxi, bus);
            }
            else if(km >= 100)
            {
                cheapest = Math.Min(taxi, Math.Min(bus, train));
            }

            Console.WriteLine("{0:f2}", cheapest);
            
        }
    }
}
