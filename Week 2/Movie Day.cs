using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {

            int time = int.Parse(Console.ReadLine());
            int scenes = int.Parse(Console.ReadLine());
            int scenetime = int.Parse(Console.ReadLine());

            double practice = time * 0.15;
            double shooting_time = scenes * scenetime;
            double total = shooting_time + practice;

            double left = time - total;
            double need = total - time;

            if(time >= total)
            {
                Console.WriteLine("You managed to finish the movie on time! You have {0:f0} minutes left!", left);
            }
            else if(time < total)
            {
                Console.WriteLine("Time is up! To complete the movie you need {0:f0} minutes.", need);
            }

        }
    }
}
