using System;

namespace Lets_be_kind
{
    class Program
    {
        static void Main(string[] args)
        {
            double desired = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double total = 0;

            while(command != "End" )
            {
                double income = double.Parse(command);
                total += income;

                if(total >= desired)
                {
                    Console.WriteLine("We collected the entire amount of {0:f2} lv.", total);
                    break;
                }
                command = Console.ReadLine();
            }
            double need = desired - total;
            if(total < desired)
            {
                Console.WriteLine("We collected {0:f2} lv. - {1:f2} lv. less than the necessary amount.", total, need);
            }
        }
    }
}
