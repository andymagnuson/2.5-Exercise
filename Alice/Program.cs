using System;
using System.Security.Cryptography.X509Certificates;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?";
            Console.WriteLine("Enter a word to find out if it's in the first sentence of Alice:");
            string userInput = Console.ReadLine().ToLower();
            int strInd = text.ToLower().IndexOf(userInput);
            if (strInd >=0)
            {
                string text1 = text.Substring(0, strInd);
                string text2 = text.Substring(strInd+ userInput.Length);
                Console.WriteLine(text1 + text2);
               Console.WriteLine("True");
            }
        }
    }
}
