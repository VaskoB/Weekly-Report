using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("============== GUESS THE NUMBER ===============");
            Console.WriteLine("===============================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("PLEASE SELECT LEVEL");
            Console.WriteLine();
            Console.WriteLine("1. Level 1 - guess a number from 0 to 10 in 3 trials");
            Console.WriteLine("2. Level 2 - guess a number from 0 to 20 in 6 trials");
            Console.WriteLine("3. Level 3 - guess a number from 0 to 30 in 9 trials");
            Console.WriteLine("4. Custom level 4 - you set the rules ");
            Console.WriteLine();



            int level = -1;
            int num = 0;
            int counter = 0;

            while (level > 4 || level < 0)
            {
                Console.WriteLine("Choose a level from 1-4");
                level = int.Parse(Console.ReadLine());

            }

            switch (level)
            {
                case 1:
                    num = genNum(0, 10);
                    counter = 3;
                    break;
                case 2:
                    num = genNum(0, 20);
                    counter = 6;
                    break;
                case 3:
                    num = genNum(0, 30);
                    counter = 9;
                    break;
                case 4:
                    Console.WriteLine("Enter a start number");
                    int start = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter end number");
                    int end = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of tries");
                    int trials = int.Parse(Console.ReadLine());
                    num = genNum(start, end);
                    counter = trials;
                    break;
            }

            while (counter > 0)
            {
                Console.WriteLine("Guess the number - tries {0}:", counter);
                int guess = int.Parse(Console.ReadLine());
                if (guess == num)
                {
                    Console.WriteLine("You guessed the number!");
                    break;
                }
                else
                {
                    counter--;
                }
                if (counter <= 0)
                {
                    Console.WriteLine("You couldn't guess the number");
                }
            }
        }
        static int genNum(int start, int end)
        {
            Random randomnumber = new Random();
            return randomnumber.Next(start, end);
        }
    }
}