using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            double salary= double.Parse(Console.ReadLine())
            string str = Console.ReadLine();

            double total = 0;
            double left = 0;
            double need = 0;
            bool bankrupt = false;

            while(str != "ACTION")
            {
                string strr = str;

                if(strr.Length <= 15)
                {
                    salary = double.Parse(Console.ReadLine());
                    budget -= salary;
                    total += salary;
                }
                if(strr.Length > 15)
                {
                    budget -= salary;
                    total = total + (budget * 0.20);
                }

                need = total - budget;
                left = budget - total;

                if(budget < total)
                {
                    Console.WriteLine("We need {0:f2} leva for our actors", need);
                    break;
                }
                str = Console.ReadLine();
            }

            if(budget >= total)
            {
                Console.WriteLine("We are left with {0:f2} leva.", left);
            }

        }
    }
}
