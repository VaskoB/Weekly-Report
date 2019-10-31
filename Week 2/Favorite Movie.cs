using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int counter = 0;
            int Max = int.MinValue;
            string best = "";
            while(movie != "STOP")
            {
                counter++;
                int sum = 0;

                for(int i = 0; i < movie.Length; i++)
                {
                    char letter = movie[i];
                    if(letter >= 97 && letter <= 122)
                    {
                        sum += (letter - 2 * movie.Length);
                    }
                    else if(letter >= 65 && letter <= 90)
                    {
                        sum += letter - movie.Length;
                    }
                    else
                    {
                        sum += letter;
                    }
                }
                if(sum > Max)
                {
                    Max = sum;
                    best = movie;
                }
                if(counter == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }
                movie = Console.ReadLine();
            }
            Console.WriteLine("The best movie for you is {0} with {1} ASCII sum.", best, Max);
        }
    }
}
