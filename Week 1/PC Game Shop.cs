using System;

namespace PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            int sold_games = int.Parse(Console.ReadLine());

            int hearth_counter = 0;
            int fort_counter = 0;
            int overwatch_counter = 0;
            int other_counter = 0;

            for (int i = 0; i < sold_games; i++)
            {
                string game = Console.ReadLine();

                switch (game)
                {
                    case "Hearthstone":
                        hearth_counter++;
                        break;
                    case "Fornite":
                        fort_counter++;
                        break;
                    case "Overwatch":
                        overwatch_counter++;
                        break;
                    default:
                        other_counter++;
                        break;

                }
            }

            Console.WriteLine($"Hearthstone - {(hearth_counter * 1.0 / sold_games * 100):F2}%");
            Console.WriteLine($"Fornite - {(fort_counter * 1.0 / sold_games * 100):F2}%");
            Console.WriteLine($"Overwatch - {(overwatch_counter * 1.0 / sold_games * 100):F2}%");
            Console.WriteLine($"Others - {(other_counter * 1.0 / sold_games * 100):F2}%");


        }
    }
}
