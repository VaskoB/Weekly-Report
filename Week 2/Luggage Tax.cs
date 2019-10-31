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

            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double depth = double.Parse(Console.ReadLine());
            string ticket = Console.ReadLine();

            double V = width * height * depth;
            double Tax = 0;

            if (ticket == "true")
            {
                if (V < 50)
                {
                    Tax = 0;
                }
                else if (V > 50 && V <= 100)
                {
                    Tax = 0;
                }
                else if (V > 100 && V <= 200)
                {
                    Tax = 10;
                }
                else if (V > 200 && V <= 300)
                {
                    Tax = 20;
                }
            }
            else if (ticket == "false")
            {
                if (V < 50)
                {
                    Tax = 0;
                }
                else if (V > 50 && V <= 100)
                {
                    Tax = 25;
                }
                else if (V > 100 && V <= 200)
                {
                    Tax = 50;
                }
                else if (V > 200 && V <= 300)
                {
                    Tax = 100;
                }
            }

            Console.WriteLine("Luggage tax: {0:f2}", Tax);

        }
    }
}