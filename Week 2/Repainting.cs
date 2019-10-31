using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {

            int naylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());

            double naylonn = (naylon + 2) * 1.50;
            double paintt = (paint + (paint * 0.10)) * 14.50;
            double dileuntt = diluent * 5;

            double materials = naylonn + paintt + dileuntt + 0.40;
            double workers = time * (materials * 0.30);

            double total = materials + workers;

            Console.WriteLine("Total expenses: {0:f2} lv.", total);
        }
    }
}
