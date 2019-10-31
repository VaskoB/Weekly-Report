using System;

namespace End_Result
{
    class Program
    {
        static void Main(string[] args)
        {

            int turns = int.Parse(Console.ReadLine());

            double total = 0;

            for(int i = 0; i < turns; i++)
            {
               double each_turn = double.Parse(Console.ReadLine());

               if(each_turn >= 0 && each_turn <= 9)
                {
                    total += each_turn * 0.20;
                }
               else if(each_turn >= 10 && each_turn <= 19)
                {
                    total += each_turn * 0.30;
                }
                else if (each_turn >= 20 && each_turn <= 29)
                {
                    total += each_turn * 0.40;
                }
                else if (each_turn >= 30 && each_turn <= 39)
                {
                    total += 50;
                }
                else if (each_turn >= 40 && each_turn <= 50)
                {
                    total += 100;
                }
               else if(each_turn > 50 || each_turn < 0)
                {
                    total = total / 2;
                }
            }
            Console.WriteLine("{0:f2}", total);
        }
    }
}
