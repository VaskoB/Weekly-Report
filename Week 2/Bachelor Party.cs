using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            int singer = int.Parse(Console.ReadLine());
            string people = Console.ReadLine();

            double income = 0;
            double need = 0;
            double left = 0;
            double guests = 0;

            while(people != "The restaurant is full")
            {
                int perroom = int.Parse(people);
                guests += perroom;

                if(perroom < 5)
                {
                    income += (perroom * 100);
                }
                else if(perroom >= 5)
                {
                    income += (perroom * 70);
                }
                people = Console.ReadLine();
            }
            need = singer - income;
            left = income - singer;

            if(income > singer)
            {
                Console.WriteLine("You have {0} guests and {1} leva left.", guests, left);
            }
            else if(income < singer)
            {
                Console.WriteLine("You have {0} guests and {1} leva income, but no singer.", guests, income);
            }


        }
    }
}
