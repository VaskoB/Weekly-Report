using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int seats = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();
            int income = 0;
            bool full = false;

            while(str != "Movie time!")
            {

                int people = int.Parse(str);

                seats -= people;
                if(seats < 0)
                {
                    Console.WriteLine("The cinema is full.");
                    full = true;
                    break;
                }

                if(people % 3 == 0)
                {
                    income += (people * 5 - 5);
                }
                else
                {
                    income += people * 5;
                }
                str = Console.ReadLine();
            }

            if(!full)
            {
                Console.WriteLine("There are {0} seats left in the cinema.", seats);
            }

            Console.WriteLine("Cinema income - {0} lv.", income);
        }
    }
}
