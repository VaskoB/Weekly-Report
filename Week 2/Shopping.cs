using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double gpus = gpu * 250;
            double cpus = cpu * (gpus * 0.35);
            double rams = ram * (gpus * 0.10);

            double total = gpus + cpus + rams;

            if(gpu > cpu)
            {
                total = total * 0.85;
            }

            double left = budget - total;
            double need = total - budget;

            if(budget >= total)
            {
                Console.WriteLine("You have {0:f2} leva left!", left);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva more!", need);
            }
        }
    }
}
