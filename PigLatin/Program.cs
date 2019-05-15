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
            string PigLatin = ToPigLatin(word).ToLower();
            Console.WriteLine(PigLatin);
            Console.Read();
        }
        public static string ToPigLatin(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            int firstVowel = word.LastIndexOf(vowels);


            foreach (string s in word.Split(' '))
            {
                if (firstVowel == -1)
                {
                    Console.WriteLine(word + "ay");
                }
                else
                {
                    char firstLet = word[0];
                    char lastLet = word[word.Length - 1];
                    if (vowels.Contains(firstLet) && vowels.Contains(lastLet))
                    {
                        Console.WriteLine(word + "yay");
                    }
                    else
                    {
                        string half1 = word.Substring(0, firstVowel);
                        string half2 = word.Substring(firstVowel);
                        return (half2 + half1 + "ay");
                    }
                }
            }          
        }
    }
}
