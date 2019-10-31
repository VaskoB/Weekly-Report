using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

class CharacterMultiplier
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        string first = input[0];
        string second = input[1];

        long sum = CalculateSum(first, second);

        Console.WriteLine(sum);
    }

    public static long CalculateSum(string first, string second)
    {

        char[] firstArr = first.ToCharArray();
        char[] secondArr = second.ToCharArray();
        long sum = 0;
        int minLength = Math.Min(firstArr.Length, secondArr.Length);
        int maxLength = Math.Max(firstArr.Length, secondArr.Length);
        if (minLength == maxLength)
        {
            for (int i = 0; i < minLength; i++)
            {

                sum += firstArr[i] * secondArr[i];
            }
        }
        else
        {
            for (int i = 0; i < minLength; i++)
            {

                sum += firstArr[i] * secondArr[i];
            }
            if (maxLength == firstArr.Length)
            {
                for (int i = minLength; i <= maxLength - minLength; i++)
                {
                    sum += firstArr[i];
                }
            }
            else
            {
                for (int i = minLength; i <= maxLength - minLength; i++)
                {
                    sum += secondArr[i];
                }
            }
        }
        return sum;
    }
}