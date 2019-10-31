using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            double games = double.Parse(Console.ReadLine());

            double total_volleyball = 0;
            double total_tennis = 0;
            double total_badminton = 0;


            double counter_volley = 0;
            double counter_tennis = 0;
            double counter_badminton = 0;

            double average_volleyball = 0;
            double average_tennis = 0;
            double average_badminton = 0;

            double total = 0;


            for (double i = 0; i < games; i++)
            {
                string game_names = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());


                if (game_names == "volleyball")
                {
                    total_volleyball = total_volleyball + points + (points * 0.07);
                    counter_volley++;
                    average_volleyball = total_volleyball / counter_volley;
                }
                else if (game_names == "tennis")
                {
                    total_tennis = total_tennis + points + (points * 0.05);
                    counter_tennis++;
                    average_tennis = total_tennis / counter_tennis;
                }
                else if (game_names == "badminton")
                {
                    total_badminton = total_badminton + points + (points * 0.02);
                    counter_badminton++;
                    average_badminton = total_badminton / counter_badminton;
                }
            }
            if (average_volleyball >= 75 && average_tennis >= 75 && average_badminton >= 75)
            {
                total = Math.Floor(total_volleyball + total_tennis + total_badminton);
                Console.WriteLine("Congratulations, {0}! You won the cruise games with {1} points.", name, total);
            }
            else
            {
                total = Math.Floor(total_volleyball + total_tennis + total_badminton);
                Console.WriteLine("Sorry, {0}, you lost. Your points are only {1}.", name, total);
            }


        }
    }
}
