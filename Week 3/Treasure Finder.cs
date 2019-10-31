using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            string message = "okfklu(ivsk(c{C82P>7^@";
            string key = "72277";
            int keyCounter = 0;

            int newChar;

            foreach(char c in message)
            {
               // Console.WriteLine("c: " + c);
                //Console.WriteLine("c int: " + (int)c);


                if(keyCounter >= key.Length)
                {
                    keyCounter = 0;
                }

                //Console.WriteLine("KEY: " + key[keyCounter]);
                newChar = (int)c - int.Parse(Char.ToString(key[keyCounter]));

                Console.WriteLine("newChar int: " + newChar);
                Console.WriteLine("newChar char: " + (char)newChar);

                keyCounter++;
            }

        }
    }
}
