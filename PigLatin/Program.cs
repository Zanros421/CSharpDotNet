using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a word/sentence in the English, so I may convert it to Pig Latin.");
            string word = Console.ReadLine();
            string PigLatin = ToPigLatin(word);
            Console.WriteLine(PigLatin);
            Console.Read();
        }
        public static string ToPigLatin(string word)
        {
            const string vowels = "AEIOUaeiou;";
            const string consonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
            List<string> PigLatinWords = new List<string>();

            foreach (string s in word.Split(' '))
            {
                string firstLetter = s.Substring(0, 1);
                string PigLatin = s.Substring(1) + firstLetter + "ay";
                int vowelIndex = vowels.IndexOf(firstLetter);
                if (s.Length > 1)
                {
                    string TwoLetters = s.Substring(0, 2);
                    string SecondLetter = s.Substring(1, 1);
                    string DoubleConsPigLatin = s.Substring(2) + TwoLetters + "ay";
                    int DoubleConsIndex = consonants.IndexOf(SecondLetter);

                    if (vowelIndex == -1 && DoubleConsIndex > -1)
                    {
                        PigLatinWords.Add(DoubleConsPigLatin);
                    }
                    else if (vowelIndex == -1)
                    {
                        PigLatinWords.Add(PigLatin);
                    }
                    else if (vowelIndex > -1)
                    {
                        PigLatinWords.Add(s + "way");
                    }
                    else
                    {
                        Console.WriteLine("please Try again");
                    }
                }
                else
                {
                    if (vowelIndex == -1)
                    {
                        PigLatinWords.Add(PigLatin);
                    }
                    else if (vowelIndex > -1)
                    {
                        PigLatinWords.Add(s + "ay");
                    }
                    else
                    {
                        Console.WriteLine("Invalid. Try again.");
                    }
                }
            }
            return string.Join(" ", PigLatinWords);                      
        }
    }
}
