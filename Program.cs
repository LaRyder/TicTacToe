using System;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
           // char[] arr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(".-----. _         .-----.             .-----.            ");
            Console.WriteLine("`-. .-':_;        `-. .-'             `-. .-'            ");
            Console.WriteLine("  : :  .-. .--.     : : .--.   .--.     : : .--.  .--.   ");
            Console.WriteLine("  : :  : :'  ..'    : :' :; ; '  ..'    : :' :; :' '_.'  ");
            Console.WriteLine("  :_;  :_;`.__.'    :_;`.__,_;`.__.'    :_;`.__.'`.__.'  ");
            Console.ResetColor();

            Console.WriteLine("Let's Play TicTacToe");
            Console.WriteLine(" Player = O;  Computer = X ");
            Console.WriteLine("\n");
            Board.Layout();

            Game game = new Game();
            Game.LetsPlay();
        }
    }
}
