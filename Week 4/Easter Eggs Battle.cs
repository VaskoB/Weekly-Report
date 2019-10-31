using System;

namespace Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs_p1 = int.Parse(Console.ReadLine());
            int eggs_p2 = int.Parse(Console.ReadLine());
            string winner = Console.ReadLine();

            while (winner != "End of battle")
            {
                if (winner == "one")
                {
                    eggs_p2 -= 1;
                }
                else if(winner == "two")
                {
                    eggs_p1 -= 1;
                }
                if(eggs_p1 == 0)
                {
                    Console.WriteLine("Player one is out of eggs. Player two has {0} eggs left.", eggs_p2);
                    break;
                }
                else if (eggs_p2 == 0)
                {
                    Console.WriteLine("Player two is out of eggs. Player one has {0} eggs left.", eggs_p1);
                    break;
                }
                winner = Console.ReadLine();
            }
            if (winner == "End of battle")
            {
                Console.WriteLine("Player one has {0} eggs left.", eggs_p1);
                Console.WriteLine("Player two has {0} eggs left.", eggs_p2);
            }
        }
    }
}
