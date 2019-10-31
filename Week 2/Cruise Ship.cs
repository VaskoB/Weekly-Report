using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {

            string cruise_type = Console.ReadLine();
            string cabin_type = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());

            double cost = 0;

            if (cruise_type == "Mediterranean")
            {
                if (cabin_type == "standard cabin")
                {
                    cost = 27.50 * days * 4;
                    if (days > 7)
                    {
                        cost = cost - (cost * 0.25);
                    }
                }
                else if (cabin_type == "cabin with balcony")
                {
                    cost = 30.20 * days * 4;
                    if (days > 7)
                    {
                        cost = cost - (cost * 0.25);
                    }
                }
                else if (cabin_type == "apartment")
                {
                    cost = 40.50 * days * 4;
                    if (days > 7)
                    {
                        cost = cost - (cost * 0.25);
                    }
                }
            }
            else if (cruise_type == "Adriatic")
            {
                if (cabin_type == "standard cabin")
                {
                    cost = 22.99 * days * 4;
                    if (days > 7)
                    {
                        cost = cost - (cost * 0.25);
                    }
                }
                else if (cabin_type == "cabin with balcony")
                {
                    cost = 25.00 * days * 4;
                    if (days > 7)
                    {
                        cost = cost - (cost * 0.25);
                    }
                }
                else if (cabin_type == "apartment")
                {
                    cost = 34.99 * days * 4;
                    if (days > 7)
                    {
                        cost = cost - (cost * 0.25);
                    }
                }
            }
            else if (cruise_type == "Aegean")
            {
                if (cabin_type == "standard cabin")
                {
                    cost = 23.00 * days * 4;
                    if (days > 7)
                    {
                        cost = cost - (cost * 0.25);
                    }
                }
                else if (cabin_type == "cabin with balcony")
                {
                    cost = 26.60 * days * 4;
                    if (days > 7)
                    {
                        cost = cost - (cost * 0.25);
                    }
                }
                else if (cabin_type == "apartment")
                {
                    cost = 39.80 * days * 4;
                    if (days > 7)
                    {
                        cost = cost - (cost * 0.25);
                    }
                }
            }

            Console.WriteLine("Annie's holiday in the {0} sea costs {1:f2} lv.", cruise_type, cost);
        }
    }
}
