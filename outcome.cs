using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class outcome
    {
        public Game game;
        public Program program;
        private Result result;
        public Board Layout;
        static int player;

        public static void Outcome()
        {
            int outcome = 0;

            while (outcome != 1 && outcome != -1);

            Console.Clear();

            if (outcome == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("The Cat won");
            }

            Console.ReadLine();
        }
    }
}