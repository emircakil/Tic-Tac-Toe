using System;

namespace TicTacToeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[,] { { "1", "2", "3" }, { "4","5", "6"}, { "7", "8", "9"} };

            string input;

            string xoro;
            int inputInt;
            int selection = 1;
            bool gameFinish = false;


            while (true)
            {


                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {

                        Console.Write(board[i, j] + " | ");

                    }

                    Console.WriteLine("\n-----------");

                }

                if (selection == 1)
                {

                    Console.WriteLine("Player 1, choose number");
                    xoro = "X";
                    selection = 2;
                }
                else
                {

                    Console.WriteLine("Player 2, choose number");
                    xoro = "O";
                    selection = 1;
                }


                input = Console.ReadLine();
                if (int.TryParse(input, out inputInt))
                {


                }
                else
                {

                    Console.WriteLine("Please enter just number");
                }
                Console.Clear();



                input = Console.ReadLine();

                switch (inputInt)
                {

                    case 1:
                        board[0, 0] = xoro;
                        break;

                    case 2:
                        board[0, 1] = xoro;
                        break;

                    case 3:
                        board[0, 2] = xoro;
                        break;
                    case 4:
                        board[1, 0] = xoro;
                        break;
                    case 5:
                        board[1, 1] = xoro;
                        break;
                    case 6:
                        board[1, 2] = xoro;
                        break;
                    case 7:
                        board[2, 0] = xoro;
                        break;
                    case 8:
                        board[2, 1] = xoro;
                        break;
                    case 9:
                        board[2, 2] = xoro;
                        break;
                    default:
                        Console.WriteLine("Please enter number value of 1-9");
                        break;
                }

                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0].Equals(board[i, 1]) && board[i, 2].Equals(board[i, 1]))
                    {

                        gameFinish = true;

                    }
                    else if (board[0, i].Equals(board[1, i]) && board[1, i].Equals(board[2, i]))
                    {

                        gameFinish = true;
                    }
                }

                if (board[0, 0].Equals(board[1, 1]) && board[1, 1].Equals(board[2, 2]))
                {

                    gameFinish = true;
                }

                if (board[0, 2].Equals(board[1, 1]) && board[1, 1].Equals(board[2, 0]))
                {

                    gameFinish = true;
                }


                if (gameFinish == true)
                {

                    if (selection == 1)
                    {

                        Console.WriteLine("Congrulations! Player 1 was win!");
                        break;
                    }
                    else
                    {

                        Console.WriteLine("Congrulations! Player 2 was win!");
                        break;
                    }

                }

            }
            }

        }
    }

