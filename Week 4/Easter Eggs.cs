using System;

namespace Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int painted_eggs = int.Parse(Console.ReadLine());

            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;

            int max = int.MinValue; ;
            string maxegg = string.Empty;


            for (int i = 0; i < painted_eggs; i++)
            {
                string color = Console.ReadLine();

                switch (color)
                {
                    case "red": red++; break;
                    case "orange": orange++; break;
                    case "blue": blue++; break;
                    case "green": green++; break;
                }
            }
            
            if(red >= max)
            {
                max = red;
                maxegg = "red";
            }
            if (orange >= max)
            {
                max = orange;
                maxegg = "orange";
            }
            if (blue >= max)
            {
                max = blue;
                maxegg = "blue";
            }
            if (green >= max)
            {
                max = green;
                maxegg = "green";
            }

            Console.WriteLine("Red eggs: {0}", red);
            Console.WriteLine("Orange eggs: {0}", orange);
            Console.WriteLine("Blue eggs: {0}", blue);
            Console.WriteLine("Green eggs: {0}", green);
            Console.WriteLine("Max eggs: {0} -> {1}", max, maxegg);

        }
    }
}
