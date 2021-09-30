using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
 
    public class Board
    {
        static int player;
        static char[] arr;

        public static void Layout()
        {
            //string arr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            string alphabet = "ABCDEFHGHIJ";
            char[] arr = alphabet.ToCharArray();

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[0], arr[1], arr[2]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[3], arr[4], arr[5]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[6], arr[7], arr[8]);

            Console.WriteLine("     |     |      ");
        }
    }
}

