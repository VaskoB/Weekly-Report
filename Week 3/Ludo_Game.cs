using System;

namespace Coin
{
    class Program
    {
        static void Main(string[] args)
        {

            int turn = 1;
            int[] Blue = new int[4] { 0, 0, 0, 0 };
            int[] Red = new int[4] { 0, 0, 0, 0 };
            int[] Green = new int[4] { 0, 0, 0, 0 };
            int[] Yellow = new int[4] { 0, 0, 0, 0 };
            Random dice = new Random();
            bool game = true;

            while (game)
            {
                //Blue Player (Human)2  
                if (turn == 1)//Player(Blue) turn
                {
                start:
                    Console.WriteLine("what is u doing now?");
                    string input = Console.ReadLine().ToLower();//Get input

                    //Show the position of all the pieces
                    if (input == "positions")
                    {
                        int num = 4;
                        for (int i = 0; i < 4; i++)
                        {
                            if (Blue[i] != 0)
                            {
                                Console.WriteLine("You have a Piece on: " + Blue[i]);
                                num--;
                            }
                        }
                        Console.WriteLine("You have " + num + " Pieces in storage.");
                        Console.WriteLine();
                        Console.WriteLine();

                        int numTwo = 4;
                        for (int i = 0; i < 4; i++)
                        {
                            if (Red[i] != 0)
                            {
                                Console.WriteLine("The Red player has a Piece on: " + Red[i]);
                                numTwo--;
                            }
                        }
                        Console.WriteLine("The Red Player has " + numTwo + " Pieces in storage.");
                        Console.WriteLine();
                        Console.WriteLine();

                        int numThree = 4;
                        for (int i = 0; i < 4; i++)
                        {
                            if (Green[i] != 0)
                            {
                                Console.WriteLine("The Green player has a Piece on: " + Green[i]);
                                numThree--;
                            }
                        }
                        Console.WriteLine("The Green Player has " + numThree + " Pieces in storage.");
                        Console.WriteLine();
                        Console.WriteLine();

                        int numFour = 4;
                        for (int i = 0; i < 4; i++)
                        {
                            if (Yellow[i] != 0)
                            {
                                Console.WriteLine("The Yellow player has a Piece on: " + Yellow[i]);
                                numFour--;
                            }
                        }
                        Console.WriteLine("The Yellow Player has " + numFour + " Pieces in storage.");
                        Console.WriteLine();
                        Console.WriteLine();
                        goto start;
                    }

                    else
                    {
                    reRoll:
                        int roll = dice.Next(1, 7);//Roll Dice
                        Console.WriteLine("You roll a: " + roll);
                        bool PiecesOut = false;//Are there (blue) pieces on the board
                        bool PiecesIn = false;//Are there (blue) pieces in storage

                        //Set the booleans
                        int pi = 0;
                        for (int i = 0; i < 4; i++)
                        {
                            if (Blue[i] == 0)
                            {
                                pi++;
                                PiecesIn = true;
                            }
                            else
                            {
                                PiecesOut = true;
                                Console.WriteLine("Piece " + i + " is on: " + Blue[i]);
                            }
                        }
                        Console.WriteLine("You have " + pi + " Pieces left in storage.");


                        //If you roll a 6
                        if (roll == 6)
                        {
                            if (PiecesOut && PiecesIn)
                            {
                                int num = 4;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Blue[i] != 0)
                                    {
                                        Console.WriteLine("You have Piece " + (i + 1) + " on: " + Blue[i]);
                                        num--;
                                    }
                                }
                                Console.WriteLine("You have " + num + " Pieces in storage.");
                                Console.WriteLine("Do you want to move a piece or take another one out?   Move/Take out");
                                string decision = Console.ReadLine().ToLower();
                                if (decision == "take out")
                                {
                                    for (int i = 0; i < 4; i++)
                                    {
                                        if (Blue[i] == 0) { Blue[i] = 1; Console.WriteLine("You take out a piece!"); break; }
                                    }
                                }
                                else
                                {
                                mover:
                                    Console.WriteLine("What do you want to move?");
                                    string move = Console.ReadLine();//take input

                                    if (move == "positions")
                                    {
                                        int numTwo = 4;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            if (Red[i] != 0)
                                            {
                                                Console.WriteLine("The Red player has a Piece on: " + Red[i]);
                                                numTwo--;
                                            }
                                        }
                                        Console.WriteLine("The Red Player has " + numTwo + " Pieces in storage.");
                                        Console.WriteLine();
                                        Console.WriteLine();

                                        int numThree = 4;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            if (Green[i] != 0)
                                            {
                                                Console.WriteLine("The Green player has a Piece on: " + Green[i]);
                                                numThree--;
                                            }
                                        }
                                        Console.WriteLine("The Green Player has " + numThree + " Pieces in storage.");
                                        Console.WriteLine();
                                        Console.WriteLine();

                                        int numFour = 4;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            if (Yellow[i] != 0)
                                            {
                                                Console.WriteLine("The Yellow player has a Piece on: " + Yellow[i]);
                                                numFour--;
                                            }
                                        }
                                        Console.WriteLine("The Yellow Player has " + numFour + " Pieces in storage.");
                                        Console.WriteLine();
                                        Console.WriteLine();

                                        goto mover;
                                    }
                                    else if (Blue[int.Parse(move)] == 0 || Blue[int.Parse(move)] > 56) { Console.WriteLine("You can't move that Piece"); goto mover; }
                                    else
                                    {//move the piece
                                        int piece = int.Parse(move);
                                        Blue[piece] += roll;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            if (Blue[piece] == Red[i])
                                            {
                                                Console.WriteLine("You take a Red piece!");
                                                Red[i] = 0;
                                                break;
                                            }
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            if (Blue[piece] == Green[i])
                                            {
                                                Console.WriteLine("You take a Green piece!");
                                                Green[i] = 0;
                                                break;
                                            }
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            if (Blue[piece] == Yellow[i])
                                            {
                                                Console.WriteLine("You take a Yellow piece!");
                                                Yellow[i] = 0;
                                                break;
                                            }
                                        }
                                        if (Blue[piece] > 56) Blue[piece] = 69;
                                    }
                                }
                            }
                            else if (PiecesIn)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Blue[i] == 0) { Blue[i] = 1; Console.WriteLine("You take out a piece!"); break; }
                                }
                            }
                            else
                            {
                            mover:
                                Console.WriteLine("What do you want to move?");
                                string move = Console.ReadLine();//take input

                                if (move == "positions")
                                {
                                    int numTwo = 4;
                                    for (int i = 0; i < 4; i++)
                                    {
                                        if (Red[i] != 0)
                                        {
                                            Console.WriteLine("The Red player has a Piece on: " + Red[i]);
                                            numTwo--;
                                        }
                                    }
                                    Console.WriteLine("The Red Player has " + numTwo + " Pieces in storage.");
                                    Console.WriteLine();
                                    Console.WriteLine();

                                    int numThree = 4;
                                    for (int i = 0; i < 4; i++)
                                    {
                                        if (Green[i] != 0)
                                        {
                                            Console.WriteLine("The Green player has a Piece on: " + Green[i]);
                                            numThree--;
                                        }
                                    }
                                    Console.WriteLine("The Green Player has " + numThree + " Pieces in storage.");
                                    Console.WriteLine();
                                    Console.WriteLine();

                                    int numFour = 4;
                                    for (int i = 0; i < 4; i++)
                                    {
                                        if (Yellow[i] != 0)
                                        {
                                            Console.WriteLine("The Yellow player has a Piece on: " + Yellow[i]);
                                            numFour--;
                                        }
                                    }
                                    Console.WriteLine("The Yellow Player has " + numFour + " Pieces in storage.");
                                    Console.WriteLine();
                                    Console.WriteLine();

                                    goto mover;
                                }
                                else if (Blue[int.Parse(move)] == 0 || Blue[int.Parse(move)] > 56) { Console.WriteLine("You can't move that Piece"); goto mover; }
                                else
                                {//move the piece
                                    int piece = int.Parse(move);
                                    Blue[piece] += roll;
                                    for (int i = 0; i < 4; i++)
                                    {
                                        if (Blue[piece] == Red[i])
                                        {
                                            Console.WriteLine("You take a Red piece!");
                                            Red[i] = 0;
                                            break;
                                        }
                                    }
                                    for (int i = 0; i < 4; i++)
                                    {
                                        if (Blue[piece] == Green[i])
                                        {
                                            Console.WriteLine("You take a Green piece!");
                                            Green[i] = 0;
                                            break;
                                        }
                                    }
                                    for (int i = 0; i < 4; i++)
                                    {
                                        if (Blue[piece] == Yellow[i])
                                        {
                                            Console.WriteLine("You take a Yellow piece!");
                                            Yellow[i] = 0;
                                            break;
                                        }
                                    }
                                    if (Blue[piece] > 56) Blue[piece] = 69;
                                }
                            }

                        }
                        //If you don't roll a 6
                        else if (PiecesOut)//if you roll something else
                        {
                            for (int i = 0; i < 4; i++)//tells you what pieces you can move
                            {
                                if (Blue[i] != 0)
                                {
                                    Console.WriteLine("You can move piece: " + (i + 1) + ". Which is on position: " + Blue[i]);
                                }
                            }
                        mover:
                            Console.WriteLine("What do you want to move?");
                            string move = Console.ReadLine();//take input

                            if (move == "positions")
                            {
                                int numTwo = 4;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Red[i] != 0)
                                    {
                                        Console.WriteLine("The Red player has a Piece on: " + Red[i]);
                                        numTwo--;
                                    }
                                }
                                Console.WriteLine("The Red Player has " + numTwo + " Pieces in storage.");
                                Console.WriteLine();
                                Console.WriteLine();

                                int numThree = 4;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Green[i] != 0)
                                    {
                                        Console.WriteLine("The Green player has a Piece on: " + Green[i]);
                                        numThree--;
                                    }
                                }
                                Console.WriteLine("The Green Player has " + numThree + " Pieces in storage.");
                                Console.WriteLine();
                                Console.WriteLine();

                                int numFour = 4;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Yellow[i] != 0)
                                    {
                                        Console.WriteLine("The Yellow player has a Piece on: " + Yellow[i]);
                                        numFour--;
                                    }
                                }
                                Console.WriteLine("The Yellow Player has " + numFour + " Pieces in storage.");
                                Console.WriteLine();
                                Console.WriteLine();

                                goto mover;
                            }
                            else if (Blue[int.Parse(move)] == 0 || Blue[int.Parse(move)] > 56) { Console.WriteLine("You can't move that Piece"); goto mover; }
                            else
                            {//move the piece
                                int piece = int.Parse(move);
                                Blue[piece] += roll;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Blue[piece] == Red[i])
                                    {
                                        Console.WriteLine("You take a Red piece!");
                                        Red[i] = 0;
                                        break;
                                    }
                                }
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Blue[piece] == Green[i])
                                    {
                                        Console.WriteLine("You take a Green piece!");
                                        Green[i] = 0;
                                        break;
                                    }
                                }
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Blue[piece] == Yellow[i])
                                    {
                                        Console.WriteLine("You take a Yellow piece!");
                                        Yellow[i] = 0;
                                        break;
                                    }
                                }
                                if (Blue[piece] > 56) Blue[piece] = 69;
                            }

                        }

                        if (roll == 6) { goto reRoll; }
                    }
                }

                //Red Player (AI)
                else if (turn == 2)
                {
                reRoll:
                    int roll = dice.Next(1, 7);
                    Console.WriteLine();
                    Console.WriteLine("The Red Player rolls a " + roll + ".");
                    bool PiecesOut = false;//Are there (red) pieces on the board
                    bool PiecesIn = false;//Are there (red) pieces in storage

                    //Set the booleans
                    for (int i = 0; i < 4; i++)
                    {
                        if (Red[i] == 0)
                        {
                            PiecesIn = true;
                        }
                        else
                        {
                            PiecesOut = true;
                        }
                    }
                    //If AI rolls a 6
                    if (roll == 6)
                    {
                        if (PiecesIn)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (Red[i] == 0) { Red[i] = 15; break; }
                            }
                            int pi = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                if (Red[i] != 0) { pi++; }
                            }
                            Console.WriteLine("Another Red piece is in the game!");
                            Console.WriteLine("That makes a total of " + pi + " Pieces on the board");
                        }
                        else
                        {
                            int[] blue = new int[2];
                            int[] green = new int[2];
                            int[] yellow = new int[2];
                            //fills the arrays with the position of them Red piece on slot 0 and of the opposind piece on slot 1
                            for (int i = 0; i < 4; i++)
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    if (Red[i] + roll == Blue[k] || Red[i] + roll == Blue[k] + 56)
                                    {
                                        blue[0] = i;
                                        blue[1] = k;
                                    }
                                }
                                for (int k = 0; k < 4; k++)
                                {
                                    if (Red[i] + roll == Green[k] || Red[i] + roll == Green[k] + 56)
                                    {
                                        green[0] = i;
                                        green[1] = k;
                                    }
                                }
                                for (int k = 0; k < 4; k++)
                                {
                                    if (Red[i] + roll == Yellow[k] || Red[i] + roll == Yellow[k] + 56)
                                    {
                                        yellow[0] = i;
                                        yellow[1] = k;
                                    }
                                }
                            }

                            if (blue[0] != 0)
                            {
                                bool almostThere = true;
                                if (Red[blue[0]] > 15) { almostThere = false; }
                                Red[blue[0]] += roll;
                                Blue[blue[1]] = 0;
                                Console.WriteLine("A red Piece takes one of yours!");
                                int pi = 0;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Blue[i] != 0) { pi++; }
                                }
                                Console.WriteLine("You have " + pi + "Pieces left on the board");
                            }
                            else if (green[0] != 0)
                            {
                                Red[green[0]] += roll;
                                Green[green[1]] = 0;
                                Console.WriteLine("A red Piece takes a green one!");
                                int pi = 0;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Green[i] != 0) { pi++; }
                                }
                                Console.WriteLine("There are " + pi + " green Pieces left on the board");
                            }
                            else if (yellow[0] != 0)
                            {
                                Red[yellow[0]] += roll;
                                Yellow[yellow[1]] = 0;
                                Console.WriteLine("A red Piece takes a yellow one!");
                                int pi = 0;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Yellow[i] != 0) { pi++; }
                                }
                                Console.WriteLine("There are " + pi + " yellow Pieces left on the board");
                            }
                            else
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Red[i] != 0)
                                    {
                                        Red[i] += roll;
                                        if (Red[i] > 56) Red[i] = Red[i] - 56;
                                        Console.WriteLine("The red player moves a piece!");
                                        Console.WriteLine("The piece is now on: " + Red[i]);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else if (PiecesOut)
                    {
                        int[] blue = new int[2];
                        int[] green = new int[2];
                        int[] yellow = new int[2];
                        //fills the arrays with the position of them Red piece on slot 0 and of the opposind piece on slot 1
                        for (int i = 0; i < 4; i++)
                        {
                            for (int k = 0; k < 4; k++)
                            {
                                if (Red[i] + roll == Blue[k] || Red[i] + roll == Blue[k] + 56)
                                {
                                    blue[0] = i;
                                    blue[1] = k;
                                }
                            }
                            for (int k = 0; k < 4; k++)
                            {
                                if (Red[i] + roll == Green[k] || Red[i] + roll == Green[k] + 56)
                                {
                                    green[0] = i;
                                    green[1] = k;
                                }
                            }
                            for (int k = 0; k < 4; k++)
                            {
                                if (Red[i] + roll == Yellow[k] || Red[i] + roll == Yellow[k] + 56)
                                {
                                    yellow[0] = i;
                                    yellow[1] = k;
                                }
                            }
                        }

                        if (blue[0] != 0)
                        {
                            Red[blue[0]] += roll;
                            Blue[blue[1]] = 0;
                            Console.WriteLine("A red Piece takes one of yours!");
                            int pi = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                if (Blue[i] != 0) { pi++; }
                            }
                            Console.WriteLine("You have " + pi + "Pieces left on the board");
                        }
                        else if (green[0] != 0)
                        {
                            Red[green[0]] += roll;
                            Green[green[1]] = 0;
                            Console.WriteLine("A red Piece takes a green one!");
                            int pi = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                if (Green[i] != 0) { pi++; }
                            }
                            Console.WriteLine("There are " + pi + " green Pieces left on the board");
                        }
                        else if (yellow[0] != 0)
                        {
                            Red[yellow[0]] += roll;
                            Yellow[yellow[1]] = 0;
                            Console.WriteLine("A red Piece takes a yellow one!");
                            int pi = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                if (Yellow[i] != 0) { pi++; }
                            }
                            Console.WriteLine("There are " + pi + " yellow Pieces left on the board");
                        }
                        else
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (Red[i] != 0)
                                {
                                    Red[i] += roll;
                                    if (Red[i] > 56) Red[i] = Red[i] - 56;
                                    Console.WriteLine("The red player moves a piece!");
                                    Console.WriteLine("The piece is now on: " + Red[i]);
                                    break;
                                }
                            }
                        }
                    }
                    else { Console.WriteLine("But they don't have any pieces out so they can't do anything!"); }
                    if (roll == 6) { Console.WriteLine("The Red Player get's another roll!"); goto reRoll; }

                }

                //Green Player (AI)
                else if (turn == 3)
                {
                reRoll:
                    int roll = dice.Next(1, 7);
                    Console.WriteLine();
                    Console.WriteLine("The Green Player rolls a " + roll + ".");
                    bool PiecesOut = false;//Are there (green) pieces on the board
                    bool PiecesIn = false;//Are there (green) pieces in storage

                    //Set the booleans
                    for (int i = 0; i < 4; i++)
                    {
                        if (Green[i] == 0)
                        {
                            PiecesIn = true;
                        }
                        else
                        {
                            PiecesOut = true;
                        }
                    }
                    //If AI rolls a 6
                    if (roll == 6)
                    {
                        if (PiecesIn)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (Green[i] == 0) { Green[i] = 29; break; }
                            }
                            int pi = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                if (Green[i] != 0) { pi++; }
                            }
                            Console.WriteLine("Another Green piece is in the game!");
                            Console.WriteLine("That makes a total of " + pi + " Pieces on the board");
                        }
                        else
                        {
                            int[] blue = new int[2];
                            int[] red = new int[2];
                            int[] yellow = new int[2];
                            //fills the arrays with the position of them Green piece on slot 0 and of the opposind piece on slot 1
                            for (int i = 0; i < 4; i++)
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    if (Green[i] + roll == Blue[k] || Green[i] + roll == Blue[k] + 56)
                                    {
                                        blue[0] = i;
                                        blue[1] = k;
                                    }
                                }
                                for (int k = 0; k < 4; k++)
                                {
                                    if (Green[i] + roll == Red[k] || Green[i] + roll == Red[k] + 56)
                                    {
                                        red[0] = i;
                                        red[1] = k;
                                    }
                                }
                                for (int k = 0; k < 4; k++)
                                {
                                    if (Green[i] + roll == Yellow[k] || Green[i] + roll == Yellow[k] + 56)
                                    {
                                        yellow[0] = i;
                                        yellow[1] = k;
                                    }
                                }
                            }

                            if (blue[0] != 0)
                            {
                                Green[blue[0]] += roll;
                                Blue[blue[1]] = 0;
                                Console.WriteLine("A green Piece takes one of yours!");
                                int pi = 0;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Blue[i] != 0) { pi++; }
                                }
                                Console.WriteLine("You have " + pi + "Pieces left on the board");
                            }
                            else if (red[0] != 0)
                            {
                                Green[red[0]] += roll;
                                Red[red[1]] = 0;
                                Console.WriteLine("A green Piece takes a red one!");
                                int pi = 0;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Red[i] != 0) { pi++; }
                                }
                                Console.WriteLine("There are " + pi + " red Pieces left on the board");
                            }
                            else if (yellow[0] != 0)
                            {
                                Green[yellow[0]] += roll;
                                Yellow[yellow[1]] = 0;
                                Console.WriteLine("A green Piece takes a yellow one!");
                                int pi = 0;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Yellow[i] != 0) { pi++; }
                                }
                                Console.WriteLine("There are " + pi + " yellow Pieces left on the board");
                            }
                            else
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Green[i] != 0)
                                    {
                                        Green[i] += roll;
                                        if (Green[i] > 56) { Green[i] = Green[i] - 56; }
                                        Console.WriteLine("The green player moves a piece!");
                                        Console.WriteLine("The piece is now on: " + Green[i]);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else if (PiecesOut)
                    {
                        int[] blue = new int[2];
                        int[] red = new int[2];
                        int[] yellow = new int[2];
                        //fills the arrays with the position of them Green piece on slot 0 and of the opposind piece on slot 1
                        for (int i = 0; i < 4; i++)
                        {
                            for (int k = 0; k < 4; k++)
                            {
                                if (Green[i] + roll == Blue[k] || Green[i] + roll == Blue[k] + 56)
                                {
                                    blue[0] = i;
                                    blue[1] = k;
                                }
                            }
                            for (int k = 0; k < 4; k++)
                            {
                                if (Green[i] + roll == Red[k] || Green[i] + roll == Red[k] + 56)
                                {
                                    red[0] = i;
                                    red[1] = k;
                                }
                            }
                            for (int k = 0; k < 4; k++)
                            {
                                if (Green[i] + roll == Yellow[k] || Green[i] + roll == Yellow[k] + 56)
                                {
                                    yellow[0] = i;
                                    yellow[1] = k;
                                }
                            }
                        }

                        if (blue[0] != 0)
                        {
                            Green[blue[0]] += roll;
                            Blue[blue[1]] = 0;
                            Console.WriteLine("A greeen Piece takes one of yours!");
                            int pi = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                if (Blue[i] != 0) { pi++; }
                            }
                            Console.WriteLine("You have " + pi + "Pieces left on the board");
                        }
                        else if (red[0] != 0)
                        {
                            Green[red[0]] += roll;
                            Red[red[1]] = 0;
                            Console.WriteLine("A Green Piece takes a Red one!");
                            int pi = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                if (Red[i] != 0) { pi++; }
                            }
                            Console.WriteLine("There are " + pi + " red Pieces left on the board");
                        }
                        else if (yellow[0] != 0)
                        {
                            Green[yellow[0]] += roll;
                            Yellow[yellow[1]] = 0;
                            Console.WriteLine("A green Piece takes a yellow one!");
                            int pi = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                if (Yellow[i] != 0) { pi++; }
                            }
                            Console.WriteLine("There are " + pi + " yellow Pieces left on the board");
                        }
                        else
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (Green[i] != 0)
                                {
                                    Green[i] += roll;
                                    if (Green[i] > 56) Green[i] = Green[i] - 56;
                                    Console.WriteLine("The green player moves a piece!");
                                    Console.WriteLine("The piece is now on: " + Green[i]);
                                    break;
                                }
                            }
                        }
                    }
                    else { Console.WriteLine("But they have no pieces out so they can't move!"); }
                    if (roll == 6) { Console.WriteLine("The Green Player get's another roll!"); goto reRoll; }
                }

                //Yellow Player (AI)
                else if (turn == 4)
                {
                reRoll:
                    int roll = dice.Next(1, 7);
                    Console.WriteLine();
                    Console.WriteLine("The Yellow Player rolls a " + roll + ".");
                    bool PiecesOut = false;//Are there (yellow) pieces on the board
                    bool PiecesIn = false;//Are there (yellow) pieces in storage

                    //Set the booleans
                    for (int i = 0; i < 4; i++)
                    {
                        if (Yellow[i] == 0)
                        {
                            PiecesIn = true;
                        }
                        else
                        {
                            PiecesOut = true;
                        }
                    }
                    //If AI rolls a 6
                    if (roll == 6)
                    {
                        if (PiecesIn)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (Yellow[i] == 0) { Yellow[i] = 43; break; }
                            }
                            int pi = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                if (Yellow[i] != 0) { pi++; }
                            }
                            Console.WriteLine("Another Yellow piece is in the game!");
                            Console.WriteLine("That makes a total of " + pi + " Pieces on the board");
                        }
                        else
                        {
                            int[] blue = new int[2];
                            int[] red = new int[2];
                            int[] green = new int[2];

                            //fills the arrays with the position of them Yellow piece on slot 0 and of the opposind piece on slot 1
                            for (int i = 0; i < 4; i++)
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    if (Yellow[i] + roll == Blue[k] || Yellow[i] + roll == Blue[k] + 56)
                                    {
                                        blue[0] = i;
                                        blue[1] = k;
                                    }
                                }
                                for (int k = 0; k < 4; k++)
                                {
                                    if (Yellow[i] + roll == Red[k] || Yellow[i] + roll == Red[k] + 56)
                                    {
                                        red[0] = i;
                                        red[1] = k;
                                    }
                                }
                                for (int k = 0; k < 4; k++)
                                {
                                    if (Yellow[i] + roll == Green[k] || Yellow[i] + roll == Green[k] + 56)
                                    {
                                        green[0] = i;
                                        green[1] = k;
                                    }
                                }
                            }

                            if (blue[0] != 0)
                            {
                                Yellow[blue[0]] += roll;
                                if (Yellow[blue[0]] > 56) { Yellow[blue[0]] = Yellow[blue[0]] - 56; }
                                Blue[blue[1]] = 0;
                                Console.WriteLine("A yellow Piece takes one of yours!");
                                int pi = 0;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Blue[i] != 0) { pi++; }
                                }
                                Console.WriteLine("You have " + pi + "Pieces left on the board");
                            }
                            else if (red[0] != 0)
                            {
                                Yellow[red[0]] += roll;
                                if (Yellow[red[0]] > 56) { Yellow[red[0]] = Yellow[red[0]] - 56; }
                                Red[red[1]] = 0;
                                Console.WriteLine("A yellow Piece takes a red one!");
                                int pi = 0;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Red[i] != 0) { pi++; }
                                }
                                Console.WriteLine("There are " + pi + " red Pieces left on the board");
                            }
                            else if (green[0] != 0)
                            {
                                Yellow[green[0]] += roll;
                                if (Yellow[green[0]] > 56) { Yellow[green[0]] = Yellow[green[0]] - 56; }
                                Green[green[1]] = 0;
                                Console.WriteLine("A yellow Piece takes a green one!");
                                int pi = 0;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Green[i] != 0) { pi++; }
                                }
                                Console.WriteLine("There are " + pi + " green Pieces left on the board");
                            }
                            else
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (Yellow[i] != 0)
                                    {
                                        Yellow[i] += roll;
                                        if (Yellow[i] > 56) { Yellow[i] = Yellow[i] - 56; }

                                        Console.WriteLine("The yellow player moves a piece!");
                                        Console.WriteLine("The piece is now on: " + Yellow[i]);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else if (PiecesOut)
                    {
                        int[] blue = new int[2];
                        int[] red = new int[2];
                        int[] green = new int[2];
                        //fills the arrays with the position of them Yellow piece on slot 0 and of the opposind piece on slot 1
                        for (int i = 0; i < 4; i++)
                        {
                            for (int k = 0; k < 4; k++)
                            {
                                if (Yellow[i] + roll == Blue[k] || Yellow[i] + roll == Blue[k] + 56)
                                {
                                    blue[0] = i;
                                    blue[1] = k;
                                }
                            }
                            for (int k = 0; k < 4; k++)
                            {
                                if (Yellow[i] + roll == Red[k] || Yellow[i] + roll == Red[k] + 56)
                                {
                                    red[0] = i;
                                    red[1] = k;
                                }
                            }
                            for (int k = 0; k < 4; k++)
                            {
                                if (Yellow[i] + roll == Green[k] || Yellow[i] + roll == Green[k] + 56)
                                {
                                    green[0] = i;
                                    green[1] = k;
                                }
                            }
                        }

                        if (blue[0] != 0)
                        {
                            Yellow[blue[0]] += roll;
                            if (Yellow[blue[0]] > 56) { Yellow[blue[0]] = Yellow[blue[0]] - 56; }
                            Blue[blue[1]] = 0;
                            Console.WriteLine("A yellow Piece takes one of yours!");
                            int pi = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                if (Blue[i] != 0) { pi++; }
                            }
                            Console.WriteLine("You have " + pi + "Pieces left on the board");
                        }
                        else if (red[0] != 0)
                        {
                            Yellow[red[0]] += roll;
                            if (Yellow[red[0]] > 56) { Yellow[red[0]] = Yellow[red[0]] - 56; }
                            Red[red[1]] = 0;
                            Console.WriteLine("A yellow Piece takes a Red one!");
                            int pi = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                if (Red[i] != 0) { pi++; }
                            }
                            Console.WriteLine("There are " + pi + " red Pieces left on the board");
                        }
                        else if (green[0] != 0)
                        {
                            Yellow[green[0]] += roll;
                            if (Yellow[green[0]] > 56) { Yellow[green[0]] = Yellow[green[0]] - 56; }
                            Green[green[1]] = 0;
                            Console.WriteLine("A yellow Piece takes a green one!");
                            int pi = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                if (Yellow[i] != 0) { pi++; }
                            }
                            Console.WriteLine("There are " + pi + " green Pieces left on the board");
                        }
                        else
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (Yellow[i] != 0)
                                {
                                    Yellow[i] += roll;
                                    if (Yellow[i] > 56) { Yellow[i] = Yellow[i] - 56; }
                                    Console.WriteLine("The yellow player moves a piece!");
                                    Console.WriteLine("The piece is now on: " + Yellow[i]);
                                    break;
                                }
                            }
                        }
                    }
                    else { Console.WriteLine("But they don't have Pieces out so they can't fo anything!"); }
                    if (roll == 6) { Console.WriteLine("The Yellow Player get's another roll!"); goto reRoll; }
                }

                turn++;
                if (turn > 4) turn = 1;
            }
        }
    }
}