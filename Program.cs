using System;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(".-----. _         .-----.             .-----.            ");
            Console.WriteLine("`-. .-':_;        `-. .-'             `-. .-'            ");
            Console.WriteLine("  : :  .-. .--.     : : .--.   .--.     : : .--.  .--.   ");
            Console.WriteLine("  : :  : :'  ..'    : :' :; ; '  ..'    : :' :; :' '_.'  ");
            Console.WriteLine("  :_;  :_;`.__.'    :_;`.__,_;`.__.'    :_;`.__.'`.__.'  ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Let's Play TicTacToe");
            Console.WriteLine("Player = O ;  Computer = X");
            Console.WriteLine("\n");
            Console.ResetColor();

            Game play = new Game();
            play.LetsPlay();

        }
    }
}
