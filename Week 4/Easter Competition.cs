using System;

namespace Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int participants = int.Parse(Console.ReadLine());
            int best_points = 0; ;
            string best_baker = "";

            for(int i = 0; i < participants; i++)
            {
                string baker = Console.ReadLine();
                int points = 0;
                string command = Console.ReadLine();

                while(command != "Stop")
                {
                    points += int.Parse(command);
                    command = Console.ReadLine();
                }
                Console.WriteLine("{0} has {1} points.", baker, points);
                if(points > best_points)
                {
                    best_points = points;
                    best_baker = baker;
                    Console.WriteLine("{0} is the new number 1!", baker);
                }
            }
            Console.WriteLine("{0} won competition with {1} points!", best_baker, best_points); 
        }
    }
}
