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
        private Program program;
        private Board board;
        private Result result;


        static int player = 1;
        static int choice;
        static char[] arr;

        public static void LetsPlay()
        {

            if (player % 2 == 0)
            {
                Console.WriteLine("Now it is the computers turn...");
            }
            else
            {
                Console.WriteLine("Player, it is your turn...");

            }
            Console.WriteLine("\n");

            choice = char.Parse(Console.ReadLine());

            if (Array.IndexOf(arr, choice) >= 0 )
            {
                if (player % 2 == 0)
                {
                    var index = Array.IndexOf(arr, choice);

                    arr[index] = 'O';
                    player++;
                }
                else
                {
                    var index = Array.IndexOf(arr, choice);
                    arr[index] = 'X';
                    player++;
                }
            }
            else
            {
                Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                Console.WriteLine("\n");
                Console.WriteLine("Please wait a few seconds while the board is reloading...");
                Thread.Sleep(2000);
            }
        }
    }
}
