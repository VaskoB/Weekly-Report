using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {

            double DayOfRes = double.Parse(Console.ReadLine());
            double MonthOfRes = double.Parse(Console.ReadLine());

            double DayOfIn = double.Parse(Console.ReadLine());
            double MonthOfIn = double.Parse(Console.ReadLine());

            double DayOfOut = double.Parse(Console.ReadLine());
            double MonthOfOut = double.Parse(Console.ReadLine());

            double Cost = 30;
            double Difference = DayOfIn - DayOfRes;
            double NumOfNights = DayOfOut - DayOfIn;
            double Total = 0; ;
            double Discount = 0;


            if (Difference >= 10)
            {
                Cost = 25;
                Total = NumOfNights * Cost;
                if (MonthOfRes != MonthOfIn)
                {
                    Discount = 0.20;
                    Total = (NumOfNights * Cost) - ((NumOfNights * Cost) * Discount);


                }
                Console.WriteLine("Your stay from {0}/{1} to {2}/{3} will cost {4:f2}", DayOfIn, MonthOfIn, DayOfOut, MonthOfOut, Total);
            }
            else if (Difference < 10)
            {
                Cost = 30;
                Total = Cost * NumOfNights;
                if (MonthOfRes != MonthOfIn)
                {
                    Cost = 25;
                    Discount = 0.20;
                    Total = (NumOfNights * Cost) - ((NumOfNights * Cost) * Discount);

                }
                Console.WriteLine("Your stay from {0}/{1} to {2}/{3} will cost {4:f2}", DayOfIn, MonthOfIn, DayOfOut, MonthOfOut, Total);
            }



        }
    }
}
