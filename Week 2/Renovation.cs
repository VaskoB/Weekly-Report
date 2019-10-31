using System;

namespace P04_Renovation
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());

            int points = 0;

            int counterW = 0;
            int counterD = 0;
            int counterL = 0;


            for (int i = 0; i < games; i++)
            {
                string chr = Console.ReadLine();

                if (chr == "W")
                {
                    points += 3;
                    counterW++;
                }
                else if(chr == "D")
                {
                    points += 1;
                    counterD++;
                }
                else if(chr == "L")
                {
                    points += 0;
                    counterL++;
                }             
            }
            double total = counterW + counterD + counterL;
            double percent = (counterW * 1.0 / total) * 100;

            if (games == 0)
            {
                Console.WriteLine("{0} hasn't played any games during this season.", name);
            }
            else if(games >= 1)
            {
                Console.WriteLine("{0} has won {1} points during this season.", name, points);
                Console.WriteLine("Total stats:");
                Console.WriteLine("## W: {0}", counterW);
                Console.WriteLine("## D: {0}", counterD);
                Console.WriteLine("## L: {0}", counterL);
                Console.WriteLine("Win rate: {0:f2}%", percent);
            }



        }
    }
}
