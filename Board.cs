using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{

    public class Board
    {
        static char[] arr = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        int spotsFilled = 0;
        char matchingLetter;

        public char WinningLetter { get { return matchingLetter; } }
        public int SpotsFilled { get { return spotsFilled; } }
        public char[] BoardArray { get { return arr; } }

        public static void ShowBoard()
        {

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

        public void takeTurn(int index, char letter)
        {
            arr[index] = letter;
            spotsFilled++;
        }

        public bool FoundMatchingThree()
        {
            if (spotsFilled < 3)
                return false;   //Cant have matching three if there arent 3 spots marked

            //Check Rows
            //0-2
            if (arr[0] == arr[1] && arr[1] == arr[2])
            {
                matchingLetter = arr[0];
                return true;
            }

            //3-5
            if (arr[3] == arr[4] && arr[4] == arr[5])
            {
                matchingLetter = arr[3];
                return true;
            }

            //6-8
            if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                matchingLetter = arr[6];
                return true;
            }

            //Check Columns
            if (arr[0] == arr[3] && arr[3] == arr[6])
            {
                matchingLetter = arr[0];
                return true;
            }

            if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                matchingLetter = arr[1];
                return true;
            }

            if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                matchingLetter = arr[2];
                return true;
            }

            //Check Diagonals
            if (arr[0] == arr[4] && arr[4] == arr[8])
            {
                matchingLetter = arr[0];
                return true;
            }

            if (arr[2] == arr[4] && arr[4] == arr[6])
            {
                matchingLetter = arr[2];
                return true;
            }

            return false;
        }
    }
}

