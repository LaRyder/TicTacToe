using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        //need to know if it was a win loss or draw
        private Board board;

        Random rnd = new Random();
        static int player = 0;
        static char Letter;

        public void LetsPlay()
        {
            board = new Board();

            while (board.SpotsFilled < 9 && !GameOver())  //do this process until the board is filled
            {
                Board.ShowBoard();  //show the board
                SwitchPlayer();     //switch turns
            }

            if (board.WinningLetter == '\0')
            {
                Board.ShowBoard();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("It was a tie, better luck next time");
                Console.ResetColor();
            }
            else
            {
                if (board.WinningLetter == 'X')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" :( The computer won....WOMP WOMP WOOOMMMMMPPPP :( ");
                    Console.ResetColor();
                }

                else if (board.WinningLetter == 'O')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.WriteLine(" ÛÛÛÛÛ ÛÛÛÛÛ                        ÛÛÛÛÛ   ÛÛÛ   ÛÛÛÛÛ                       ||  ||   ");
                    Console.WriteLine("°°ÛÛÛ °°ÛÛÛ                        °°ÛÛÛ   °ÛÛÛ  °°ÛÛÛ                        ||  ||   ");
                    Console.WriteLine(" °°ÛÛÛ ÛÛÛ    ÛÛÛÛÛÛ  ÛÛÛÛÛ ÛÛÛÛ    °ÛÛÛ   °ÛÛÛ   °ÛÛÛ   ÛÛÛÛÛÛ  ÛÛÛÛÛÛÛÛ     ||  ||   ");
                    Console.WriteLine("  °°ÛÛÛÛÛ    ÛÛÛ°°ÛÛÛ°°ÛÛÛ °ÛÛÛ     °ÛÛÛ   °ÛÛÛ   °ÛÛÛ  ÛÛÛ°°ÛÛÛ°°ÛÛÛ°°ÛÛÛ    ||  ||   ");
                    Console.WriteLine("   °°ÛÛÛ    °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ     °°ÛÛÛ  ÛÛÛÛÛ  ÛÛÛ  °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ    ||  ||   ");
                    Console.WriteLine("    °ÛÛÛ    °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ      °°°ÛÛÛÛÛ°ÛÛÛÛÛ°   °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ    ||  ||   ");
                    Console.WriteLine("    ÛÛÛÛÛ   °°ÛÛÛÛÛÛ  °°ÛÛÛÛÛÛÛÛ       °°ÛÛÛ °°ÛÛÛ     °°ÛÛÛÛÛÛ  ÛÛÛÛ ÛÛÛÛÛ            ");
                    Console.WriteLine("    °°°°°     °°°°°°    °°°°°°°°         °°°   °°°       °°°°°°  °°°° °°°°°   °°  °°   ");
                    Console.ResetColor();
                }
            }
        }

        private void SwitchPlayer()
        {
            player++;
            if (player % 2 == 0)
            {
                Console.WriteLine("Now it is the computers turn...");
                ComputerTakesTurn();
            }
            else
            {
                Console.WriteLine("Player, it is your turn...");

                Letter = char.Parse(Console.ReadLine().ToLower());        //get what spot is being taken now

                int spot = Array.IndexOf(board.BoardArray, Letter);
                board.takeTurn(spot, 'O');
                Console.Clear();
                Thread.Sleep(500);
            }
        }

        private void ComputerTakesTurn()
        {
            int t = rnd.Next(0, 9);
            if (board.BoardArray[t] == 'O' || board.BoardArray[t] == 'X')
            {
                ComputerTakesTurn();
            }
            else
            {
                board.takeTurn(t, 'X');
                Console.Clear();
                Thread.Sleep(500);
            }
        }

        private bool GameOver()
        {
            if (board.FoundMatchingThree())
                return true;

            //check if full board
            if (board.SpotsFilled >= 9)
                return true;

            return false;
        }
    }
}
