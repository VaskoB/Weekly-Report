using System;

namespace Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {

            double desired_income = double.Parse(Console.ReadLine());
            string Cocktail = Console.ReadLine();

            double income = 0;
            double need = 0;
            
            while(Cocktail != "Party!")
            {
                string cocktail = Cocktail;
                double cocktail_num = double.Parse(Console.ReadLine());

                double price = cocktail.Length;
                double total = cocktail_num * price;            

                if(total % 2 != 0)
                {
                    total = total * 0.75;
   
                }
                income = income + total;
                desired_income = desired_income - total;

                if (desired_income <= 0)
                {
                    break;
                }

                Cocktail = Console.ReadLine();
            }

            if (Cocktail == "Party!")
            {
                Console.WriteLine("We need {0:f2} leva more.", desired_income);              
            }
            else
            {
                Console.WriteLine("Target acquired.");
            }
            Console.WriteLine("Club income - {0:f2} leva.", income);



        }
    }
}
