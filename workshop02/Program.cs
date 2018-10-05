using System;
using System.Collections.Generic;
using System.Linq;

namespace workshop02
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "onomatopoetikon";
            var triedLetters = new List<char>();
            var visibleLetters = new bool[word.Length];

            while(visibleLetters.Any(v => v == false)){
                Console.WriteLine("Gjett ordet eller en bokstav:");

                var guess = Console.ReadLine();

                if(guess.Length > 1 && guess != word){
                    Console.WriteLine("Feil, prøv igjen :P");
                }
                else if(guess.Length > 1 && guess == word){
                    Console.WriteLine("Korrekt! :D");
                    visibleLetters = Enumerable.Repeat(true,visibleLetters.Length).ToArray();
                }
                else if(guess.Length == 1){
                    RevealLetter(ref visibleLetters,word,guess.ToCharArray().First());
                }

                PrintWord(word,visibleLetters);
            }
        }
        
        private static void PrintWord(string word, bool[] visibleLetters){
            for(int i = 0; i< word.Length; i++){
                if(visibleLetters[i])
                    Console.Write(word[i]);
                else
                    Console.Write("_");
            }
            Console.WriteLine();
        }

        private static void RevealLetter(ref bool[] visibleLetters, string word, char letter){
            for(int i = 0;i < word.Length; i++){
                if(word[i] == letter)
                    visibleLetters[i] = true;
            }
        }
    }
}
