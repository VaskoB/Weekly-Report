using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_without_reminder
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }
            double pp1 = p1 / n * 100;
            double pp2 = p2 / n * 100;
            double pp3 = p3 / n * 100;

            Console.WriteLine("{0:f2}", pp1);
            Console.WriteLine("{0:f2}", pp2);
            Console.WriteLine("{0:f2}", pp3);
        }
    }
}
