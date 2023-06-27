using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Word Jumble

            Console.WriteLine("Welcome to Word Jumble!");
            Console.WriteLine("Unscramble the letters to form a word. Can you solve all 10 puzzles?");

            // list of words to be jumbled
            List<string> words = new List<string> { "python", "computer", "keyboard", "mouse", "monitor", "program", "code", "algorithm", "variable", "debug" };

            while (words.Count > 0)
            {
                // randomly select a word from the list
                Random random = new Random();
                int index = random.Next(words.Count);
                string word = words[index];

                // create a jumbled version of the word
                char[] letters = word.ToCharArray();
                random = new Random();
                for (int i = 0; i < letters.Length; i++)
                {
                    int j = random.Next(i, letters.Length);
                    char temp = letters[i];
                    letters[i] = letters[j];
                    letters[j] = temp;
                }
                string jumbledWord = new string(letters);

                // remove the selected word from the list
                words.RemoveAt(index);

                // initialize the number of guesses to 0
                int numGuesses = 0;

                while (true)
                {
                    // display the jumbled word and get the user's guess
                    Console.WriteLine($"Unscramble the word: {jumbledWord}");
                    Console.Write("Enter your guess: ");
                    string guess = Console.ReadLine().ToLower();

                    // increment the number of guesses
                    numGuesses++;

                    // check if the guess is correct
                    if (guess == word)
                    {
                        Console.WriteLine($"Congratulations! You unscrambled the word in {numGuesses} guesses.\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that's not correct. Try again.\n");
                    }
                }
            }



        }
    }
}