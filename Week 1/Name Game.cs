using System;

namespace Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int best_points = 0;
            string winner = "";

            while (name != "Stop")
            {
         
                int n = name.Length;
                int current_points = 0;                      

                for(int i = 0; i < n; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if(num == name[i])
                    {
                        current_points += 10;
                    }
                    else
                    {
                        current_points += 2;
                    }

                }
                
                if (current_points >= best_points)
                {
                    best_points = current_points;
                    winner = name;

                }
                name = Console.ReadLine();
            }

            Console.WriteLine("The winner is {0} with {1} points!", winner, best_points);

        }
    }
}
