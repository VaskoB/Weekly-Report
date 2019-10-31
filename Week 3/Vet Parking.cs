using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double total = 0;
            double counter = 0;
            double tax = 0;
            double daily = 0;

            for (int i = 0; i < days; i++)
            {
                double day = i + 1;
                daily = 0;
                counter = 0;
                while (counter < hours)
                {
                    counter++;
                    if (day % 2 == 0)
                    {
                        if (counter % 2 != 0)
                        {
                            tax = 2.50;
                            daily += tax;
                        }
                        else
                        {
                            tax = 1;
                            daily += tax;
                        }
                    }
                    else if (day % 2 != 0)
                    {
                        if (counter % 2 == 0)
                        {
                            tax = 1.25;
                            daily += tax;
                        }
                        else
                        {
                            tax = 1;
                            daily += tax;
                        }

                    }
                }
                total += daily;
                Console.WriteLine("Day: {0} - {1:f2} leva", day, daily);
            }
            Console.WriteLine("Total: {0:f2} leva", total);

        }
    }
}
