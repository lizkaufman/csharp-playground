using System;
using System.Collections.Generic;

namespace guess_the_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guesser, cover your eyes while the other player writes a word now.");
            string secretWord = "";
            bool isTypingSecretWord = true;
            while (isTypingSecretWord)
            {
                char letter = Console.ReadKey(true).KeyChar;
                    if (letter == '\r')
                    {
                        isTypingSecretWord = false;
                    }
                    else
                    {
                        secretWord += letter.ToString();
                    }
            }
            Console.WriteLine("The game begins!");
            Console.WriteLine("Guess the word: ");
            int guessCount = 1;
            string guess = Console.ReadLine();
            while (guess != secretWord)
            {
                guessCount++;
                Console.WriteLine("Nope! Give the guesser a hint.");
                Console.WriteLine("Guesser, guess again: ");
                guess = Console.ReadLine();
            }
            Console.WriteLine($"Well done, guesser! You've guessed the word in {guessCount} guesses.");
        }
    }
}