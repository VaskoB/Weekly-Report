using System;

namespace Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double m_price = double.Parse(Console.ReadLine());
            double sqm_kg = double.Parse(Console.ReadLine());

            double net = 2 * length + 2 * width;
            double p_net = net * height;
            double net_price = net * m_price;
            double net_weight = p_net * sqm_kg;

            Console.WriteLine(net);
            Console.WriteLine("{0:f2}", net_price);
            Console.WriteLine("{0:f3}", net_weight);

        }
    }
}
