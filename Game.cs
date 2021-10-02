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

        public void letsPlay()
        {
            board = new Board();

            while (board.SpotsFilled < 9 && !GameOver())    //do this process until the board is filled
            {
                Board.ShowBoard();           //show the board
                SwitchPlayer();                     //switch turns
            }

            if (board.WinningLetter == '\0')
            {
                Board.ShowBoard();
                Console.WriteLine("It was a tie, better luck next time");
            }
            else
            {
                if (board.WinningLetter == 'X')
                {
                    Console.WriteLine("The computer won....womp");
                }
                else
                    Console.WriteLine("YOU WON!");
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

                Letter = char.Parse(Console.ReadLine());        //get what spot is being taken now

                int spot = Array.IndexOf(board.BoardArray, Letter);
                board.takeTurn(spot, 'O');
            }
        }

        private void ComputerTakesTurn()
        {
            int t = rnd.Next(0, 9);
            if (board.BoardArray[t] == 'O' || board.BoardArray[t] == 'X')
            {
                ComputerTakesTurn();    //Find another random spot
            }
            else
            {
                board.takeTurn(t, 'X');
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
