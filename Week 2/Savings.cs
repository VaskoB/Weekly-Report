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

            double Income = double.Parse(Console.ReadLine());
            double Months = double.Parse(Console.ReadLine());
            double Expenses = double.Parse(Console.ReadLine());

            double Unexpected = Income * 0.30;
            double Left = Income - (Unexpected + Expenses);
            double Total = Months * Left;

            double Percentage = (Left / Income) * 100;

            Console.WriteLine("She can save {0:f2}%", Percentage);
            Console.WriteLine("{0:f2}", Total);


        }
    }
}
