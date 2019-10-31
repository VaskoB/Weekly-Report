﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {

            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double humanheight = double.Parse(Console.ReadLine());

            double V = width * length * height;
            double room = (1.70 + 0.40) * 2 * 2;
            double space = Math.Floor(V / room);

            if(space > 3 && space <= 10)
            {
                Console.WriteLine("The spacecraft holds {0} astronauts.", space);
            }
            else if(space < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if(space > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
    

        }
    }
}
