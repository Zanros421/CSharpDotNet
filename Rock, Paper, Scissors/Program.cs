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
            string Weapon = Console.ReadLine().ToLower();
            string Winner = RocPapSci(Weapon);
            Console.WriteLine(Winner);
            Console.Read();
        }
        public static string RocPapSci(string Weapon)
        {
            string result = " ";
            string[] Proper = { "rock", "paper", "scissors" };
            Random Choice = new Random();
            int newChoice = Choice.Next(0, 3);
            if (newChoice == 0)
            {
                string Computer1 = "rock";
            }
            else if (newChoice == 1)
            {
                string Computer2 = "paper";
            }
            else
            {
                string Computer3 = "scissors";
            }


            if (Proper.Contains(Weapon))
            {
                if (Proper == Computer1)
                {
                    Console.WriteLine("We tied, lets try again!");
                }
                else if (Proper && Computer2)
                {
                    Console.WriteLine("Haha I win!");
                }
                else if (Proper && Computer3)
                {
                    Console.WriteLine("Darn, you are the winner!");
                }
            }
            else
            {
                Console.WriteLine("Not a valid answer");
            }
            return result;
        }
    }
}
