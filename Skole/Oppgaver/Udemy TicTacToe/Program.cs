﻿using System;

namespace Udemy_TicTacToe
{
    class Program
    {
        //the playfield
        static char[,] playField =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };
        static char[,] playFieldInitial =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };

        static void Main()
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            Setfield();

            #region 
            //check winning condition.

            char[] playerChars = {'x', 'O'};

            foreach (var playerChar in playerChars)
            {
                if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) &&
                     (playField[0, 2] == playerChar))
                    || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) &&
                        (playField[1, 2] == playerChar))
                    || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) &&
                        (playField[2, 2] == playerChar))
                    || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) &&
                        (playField[2, 0] == playerChar))
                    || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) &&
                        (playField[1, 2] == playerChar))
                    || ((playField[0, 2] == playerChar) && (playField[2, 1] == playerChar) &&
                        (playField[2, 2] == playerChar))
                    || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) &&
                        (playField[2, 2] == playerChar))
                    || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) &&
                        (playField[2, 0] == playerChar))
                    || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) &&
                        (playField[2, 1] == playerChar))
                )
                {
                    if (playerChar == 'X')
                    {
                        Console.WriteLine("Player 2 has won!");
                    }else if (playerChar == 'O')
                    {
                        Console.WriteLine("Player 1 has won!");
                    }

                    break;
                    
                }

            }
            

            #endregion

            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                Setfield();

                #region 

                

                do
                {
                    Console.WriteLine($"Player {player}: Choose your field! ");
                    try
                    {
                    input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("please enter a number");
                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("Incorect input!");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
                #endregion
                
            } while (true);
            {

            }
        }

        public static void Setfield()
        {
            Console.Clear();
            Console.WriteLine($"  {playField[0, 0]}  |   {playField[0, 1]}   |   {playField[0, 2]}   ");
            Console.WriteLine($"  {playField[1, 0]}  |   {playField[1, 1]}   |   {playField[1, 2]}   ");
            Console.WriteLine($"  {playField[2, 0]}  |   {playField[2, 1]}   |   {playField[2, 2]}   ");
        }

        public static void EnterXorO(int player ,int input)
        {
            char playerSign = ' ';
            if (player == 1)
                playerSign = 'O';
            else if (player == 2)
                playerSign = 'X';


            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }
            
        }

        public static void resetGame()
        {
            playField = playFieldInitial;
            Setfield();
        }
    }
}