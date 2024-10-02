using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT2_ANORE_JOHN_KARL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your word: ");
            string palindromeWord = Console.ReadLine();

            palindrome(palindromeWord);

          
        }

        static void palindrome(string word)
        {
            string emptyString = "";
            string lowerCase = word.ToLower();
            bool palin = false;


            for (int i = word.Length - 1; i >= 0; i--)
            {
                emptyString = emptyString + lowerCase[i];


            }

            if (lowerCase == emptyString)
            {
                palin = true;
            }
           

            Console.WriteLine(palin);
            Console.WriteLine(emptyString);
            Console.ReadKey(true);

        }


    }
}
