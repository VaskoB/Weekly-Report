using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {

            string city = Console.ReadLine();
            string bundle = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0;

            if(days > 7)
            {
                days += 1;
            }

            if (city == "Bansko" || city == "Borovets")
            {
                if (bundle == "withEquipment")
                {
                    price = 100 * days;
                    if (vip == "yes")
                    {
                        price = 100 * 0.90;
                        price = price * days;
                    }
                }
                else if (bundle == "noEquipment")
                {
                    price = 80 * days;
                    if (vip == "yes")
                    {
                        price = 80 * 0.95;
                        price = price * days;
                    }
                }
            }
            else if (city == "Varna" || city == "Burgas")
            {
                if (bundle == "withBreakfast")
                {
                    price = 130 * days;
                    if (vip == "yes")
                    {
                        price = 130 * 0.88;
                        price = price * days;
                    }
                    
                  
                }
                else if (bundle == "noBreakfast")
                {
                    price = 100 * days;

                    if (vip == "yes")
                    {
                        price = 100 * 0.93;
                        price = price * days;
                    }
                }


            }

            if (days < 1 && city == "Borovets" || city == "Bansko" || city == "Varna" || city == "Burgas" && bundle == "noEquipment" || bundle == "withEquipment" || bundle == "noBreakfast" || bundle == "withBreakfast")
            {
                Console.WriteLine("Days must be positive number");
            }
            else  if (days > 0 && city == "Borovets" || city == "Bansko" || city == "Varna" || city == "Burgas" && bundle == "noEquipment" || bundle == "withEquipment" || bundle == "noBreakfast" || bundle == "withBreakfast") 
            {
                Console.WriteLine("The price is {0:f2}lv! Have a nice time!", price);
            }
            else if(days > 0 && city != "Borovets" || city != "Bansko" || city != "Varna" || city != "Burgas" && bundle != "noEquipment" || bundle != "withEquipment" || bundle != "noBreakfast" || bundle != "withBreakfast")
            {
                Console.WriteLine("Invalid input!");
            }
            else if (days < 1 && city != "Borovets" || city != "Bansko" || city != "Varna" || city != "Burgas" && bundle != "noEquipment" || bundle != "withEquipment" || bundle != "noBreakfast" || bundle != "withBreakfast")
            {
                Console.WriteLine("Invalid input!");
            }
            
        }
    }
}
