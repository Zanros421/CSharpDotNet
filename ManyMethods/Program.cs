using System;

namespace ManyMethods
{
    internal class Program
    {
        private static void Main(string[] args) //for calling function, code does not go in here.
        {
            Hello();
            Addition();
            CatDog();
            OddEven();
            Inches();
            Echo();
            KillGrams();
            Date();
            Age();
            Guess();
        }

        public static void Hello()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Goodbye " + name);
            Console.Read();
        }

        public static void Addition()
        {
            Console.WriteLine("Please enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); //int.Parse
            Console.WriteLine("Please enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The Sum is " + sum);
            Console.Read();
        }

        public static void CatDog()
        {
            Console.WriteLine("Do you prefer cats or dogs?");
            string animal = Console.ReadLine();
            if (animal == "cats")
            {
                Console.WriteLine("Meow");
            }
            else
            {
                Console.WriteLine("Bark");
            }
            Console.Read();
        }

        public static void OddEven()
        {
            Console.WriteLine("Enter a number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 % 2 == 0)
            {
                Console.WriteLine("Number is even.");
            }
            else
            {
                Console.WriteLine("Number is odd.");
            }
            Console.Read();
        }

        public static void Inches()
        {
            Console.WriteLine("Give me your height in feet, and I'll turn it to inches");
            double num4 = Convert.ToDouble(Console.ReadLine());
            double inches = num4 * 12;
            Console.WriteLine("Your height in inches is " + inches);
            Console.Read();
        }

        public static void Echo()
        {
            Console.WriteLine("Say something: ");
            string peat = Console.ReadLine();
            string upperpeat = peat.ToUpper();
            string lowerpeat = peat.ToLower();
            Console.WriteLine(upperpeat + " " + lowerpeat + " " + lowerpeat);
            //Console.WriteLine(lowerpeat);
            //Console.WriteLine(lowerpeat);
            Console.Read();
        }

        public static void KillGrams()
        {
            Console.WriteLine("Give me your weight in pounds, and I'll tell you your weight in killograms.");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            decimal kg = weight / 2.205M;
            decimal f = (Math.Round(kg, 3));
            Console.WriteLine("Your weight is " + f + " killograms.");
            Console.Read();
        }

        public static void Date()
        {
            DateTime thisDay = DateTime.Today;
            Console.WriteLine(thisDay.ToString("d"));
            Console.Read();
        }

        public static void Age()
        {
            Console.WriteLine("What is your birth year?");
            int year = Convert.ToInt32(Console.ReadLine());
            int age = 2019 - year;
            Console.WriteLine("You age is " + age + "!");
            Console.Read();
        }

        public static void Guess()
        {
            Console.WriteLine("Guess a word that is 6 letters long, starts with C and ends with a P: ");
            string question = Console.ReadLine();
            string lowerquestion = question.ToLower();
            string answer = "chsarp";
            if (lowerquestion == answer)
            {
                Console.WriteLine("CORRECT!!");
            }
            else
            {
                Console.WriteLine("WRONG!!");
            }
            Console.Read();
        }
    }
}