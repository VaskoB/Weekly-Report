using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string show = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            int breakk = int.Parse(Console.ReadLine());

            double lunch = breakk/ 8.0;
            double rest = breakk / 4.0;
            double left = breakk - (lunch + rest);

            if (left >= episode)
            {
                Console.WriteLine($"You have enough time to watch {show} and left with {Math.Ceiling(left - episode)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {show}, you need {Math.Ceiling(episode - left)} more minutes.");
            }
        }
    }
}
