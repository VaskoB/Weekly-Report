using System;
using System.Threading;
namespace BullsAndCowsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerOneNumber = "";
            while (true)
            {
                Console.WriteLine("Player One please select a number:");
                playerOneNumber = Console.ReadLine(); 
                bool IsOnlyNumber = true;
                bool AllAreDifferent = true;
                for (int i = 0; i < playerOneNumber.Length; i++)
                {
                    if (!Char.IsDigit(playerOneNumber[i]))
                    {
                        IsOnlyNumber = false;
                    }
                    for (int k = 0; k < playerOneNumber.Length; k++)
                    {
                        if (playerOneNumber[i] == playerOneNumber[k] && k != i)
                        {
                            AllAreDifferent = false;
                        }
                    }
                }
                if (playerOneNumber.Length == 4 && IsOnlyNumber && AllAreDifferent)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Number!");
                }
            }
            Console.WriteLine("Number confirmed!");
            Thread.Sleep(500);
            Console.Clear();
            string playerTwoNumber = "";
            while (true)
            {
                Console.WriteLine("Player Two please select a number:");
                playerTwoNumber = Console.ReadLine();
                bool IsOnlyNumber = true;
                bool AllAreDifferent = true;
                for (int i = 0; i < playerTwoNumber.Length; i++)
                {
                    if (!Char.IsDigit(playerTwoNumber[i]))
                    {
                        IsOnlyNumber = false;
                    }
                    for (int k = 0; k < playerTwoNumber.Length; k++)
                    {
                        if (playerTwoNumber[i] == playerTwoNumber[k] && k != i)
                        {
                            AllAreDifferent = false;
                        }
                    }
                }
                if (playerTwoNumber.Length == 4 && IsOnlyNumber && AllAreDifferent)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Number!");
                }
            }
            Console.WriteLine("Number confirmed!");
            Thread.Sleep(500);
            Console.Clear();
            bool inGame = true;
            while (inGame)
            {
                string playerOneGuess = "";
                while (true)
                {
                    Console.WriteLine("Player One please make a guess:");
                    playerOneGuess = Console.ReadLine();
                    bool IsOnlyNumber = true;
                    bool AllAreDifferent = true;
                    for (int i = 0; i < playerOneGuess.Length; i++)
                    {
                        if (!Char.IsDigit(playerOneGuess[i]))
                        {
                            IsOnlyNumber = false;
                        }
                        for (int k = 0; k < playerOneGuess.Length; k++)
                        {
                            if (playerOneGuess[i] == playerOneGuess[k] && k != i)
                            {
                                AllAreDifferent = false;
                            }
                        }
                    }
                    if (playerOneGuess.Length == 4 && IsOnlyNumber && AllAreDifferent)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number!");
                    }
                }
                CheckGuess(playerOneGuess, playerTwoNumber);
                if (GetBulls(playerOneGuess, playerTwoNumber) == 4)
                {
                    Console.WriteLine("Player One Wins!");
                    inGame = false;
                }
                else if (inGame)
                {
                    string playerTwoGuess = "";
                    while (true)
                    {
                        Console.WriteLine("Player Two please make a guess:");
                        playerTwoGuess = Console.ReadLine();
                        bool IsOnlyNumber = true;
                        bool AllAreDifferent = true;
                        for (int i = 0; i < playerTwoGuess.Length; i++)
                        {
                            if (!Char.IsDigit(playerTwoGuess[i]))
                            {
                                IsOnlyNumber = false;
                            }
                            for (int k = 0; k < playerTwoGuess.Length; k++)
                            {
                                if (playerTwoGuess[i] == playerTwoGuess[k] && k != i)
                                {
                                    AllAreDifferent = false;
                                }
                            }
                        }
                        if (playerTwoGuess.Length == 4 && IsOnlyNumber && AllAreDifferent)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Number!");
                        }
                    }
                    CheckGuess(playerTwoGuess, playerOneNumber);
                    if (GetBulls(playerTwoGuess, playerOneNumber) == 4)
                    {
                        Console.WriteLine("Player Two Wins!");
                        inGame = false;
                    }
                }
            }
        }
        static void CheckGuess(string guess, string number)
        {
            int bulls = 0;
            int cows = 0;
            for (int i = 0; i < number.Length; i++)
            {
                for (int k = 0; k < guess.Length; k++)
                {
                    if (number[i] == guess[k])
                    {
                        if (i == k)
                        {
                            bulls++;
                        }
                        else
                        {
                            cows++;
                        }
                    }
                }
            }
            if (bulls > 0)
            {
                Console.WriteLine("Bulls: {0};", bulls);
            }
            else
            {
                Console.WriteLine("No Bulls!");
            }
            if (cows > 0)
            {
                Console.WriteLine("Cows: {0};", cows);
            }
            else
            {
                Console.WriteLine("No Cows!");
            }
        }
        static int GetBulls(string guess, string number)
        {
            int bulls = 0;
            for (int i = 0; i < guess.Length; i++)
            {
                for (int k = 0; k < number.Length; k++)
                {
                    if (guess[i] == number[k] && k == i)
                    {
                        bulls++;
                    }
                }
            }
            return bulls;
        }
    }
}