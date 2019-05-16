using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your weapon: Rock, Paper, or Scissors.");
            string player = Console.ReadLine().ToLower();
        //}
        //public static string RocPapSci(string player)
        //{
            //string[] proper = { "rock", "paper", "scissors" };
            Random Choice = new Random();
            int newChoice = Choice.Next(0, 3);
            string computer;
            int scorePlayer = 0;
            int scoreCPU = 0;
            switch (newChoice)
            {
                case 0:
                    computer = "rock";
                    Console.WriteLine("Computer chose Rock");
                    if (player == "rock")
                    {
                        Console.WriteLine("Darn, it looks like we tied.");
                    }
                    else if (player == "paper")
                    {
                        Console.WriteLine("Dang, you win this round!");
                        scorePlayer++;
                    }
                    else if (player == "scissors")
                    {
                        Console.WriteLine("Hahahaha I win!");
                        scoreCPU++;
                    }
                    break;
                case 1:
                    computer = "paper";
                    Console.WriteLine("Computer chose Paper");
                    if (player == "rock")
                    {
                        Console.WriteLine("Hahahaha I win!");
                        scoreCPU++;
                    }
                    else if (player == "paper")
                    {
                        Console.WriteLine("Darn, it looks like we tied.");
                    }
                    else if (player == "scissors")
                    {
                        Console.WriteLine("Dang, you win this round!");
                        scorePlayer++;
                    }
                    break;
                case 2:
                    computer = "scissors";
                    Console.WriteLine("Computer chose Scissors");
                    if (player == "rock")
                    {
                        Console.WriteLine("Dang, you win this round!");
                        scorePlayer++;
                    }
                    else if (player == "paper")
                    {
                        Console.WriteLine("Hahahaha I win!");
                        scoreCPU++;
                    }
                    else if (player == "scissors")
                    {
                        Console.WriteLine("Darn, it looks like we tied.");
                    }
                    break;
            }
        }
    }
}
