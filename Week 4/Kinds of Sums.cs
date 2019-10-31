using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinds_of_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = new int[10];
            double even_sum = 0;
            double biggest = 0;
            double lowest = 0;

            for (int i = 0; i < 10; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if(n % 2 != 0 || n == 0)
                {
                    sum += n;
                }
                else if(n % 2 == 0)
                {
                    arr[i] = n;
                }
                even_sum = arr.Sum();
            }

            if(even_sum > sum)
            {
                biggest = even_sum;
                lowest = sum;
            }
            else if(even_sum < sum)
            {
                biggest = sum;
                lowest = even_sum;
            }
            double difference = biggest - lowest;
            if(sum == even_sum)
            {
                Console.WriteLine("Both sums equal {0}.", sum);
            }
            else if(sum > even_sum || sum < even_sum)
            {
                Console.WriteLine("The difference between the sums is {0}.", difference);
            }

        }
    }
}
