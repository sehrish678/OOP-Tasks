using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shiritori
{
    internal class Program
    {
        private static string words;

        static void Main(string[] args)
        {

            Shiritori s = new Shiritori();
            Console.Write("Enter the number of words you want to enter: ");
            s.numOfWords=int.Parse(Console.ReadLine());
            string[] Words = new string[s.numOfWords];
            for(int i=0;i<s.numOfWords; i++)
            { 
                Console.Write("Enter the word: ");
                Words[i]=Console.ReadLine();
            }
            bool isValid=wordCheck(Words);
            if(isValid)
            {
                Console.Write("Game Over");
            }
            else if(!isValid)
            {
                Console.Write("You Won");
            }
            Console.ReadLine();
        }
        public static  bool wordCheck(string[] Words)
        {
            
                if (Words.Length < 2)
                {
                    return true;
                }
                for(int i=1;i<Words.Length;i++)
                {
                string currentWord = Words[i].ToLower();
                string previousWord= Words[i-1].ToLower();

                if(currentWord.StartsWith(previousWord.Substring(previousWord.Length - 1)))
                {
                    return false;
                }

                }
                return true;  
        }
    }
}
