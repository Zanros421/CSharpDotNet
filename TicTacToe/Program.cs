using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        string currentPlayer = " ";
        static string[,] board = new string[3, 3];
        static void Main(string[] args)
        {
            PrintBoard();
            Console.Read();
        }
        static void PrintBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("-------");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("|" + board[i, j].ToString());
                }
                Console.Write("|");
            }
            Console.WriteLine("-------");
        }
    }
}
