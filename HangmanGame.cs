using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_GUI
{
    class HangmanGame
    {
        static string strLettersGuessed;
        
       
        static string[] WordDisplay;
        static bool guessedIt = false;

        public HangmanGame()
        {
            guessedIt = false;
            nWrongGuesses = 0;
            strLettersGuessed = " ";


            
        }
        
        /// <summary>
        /// Plays the game of hangman
        /// </summary>
        public void Play()
        {
            //display all gallows
            while (!guessedIt && nWrongGuesses < 10)
            {
                HangmanGallows.DrawGallow(nWrongGuesses);
                //print wordDisplay

                PrintSecretWord(WordDisplay);
                Console.WriteLine("Letters guessed: " + strLettersGuessed);

                nWrongGuesses += PlayerGuess(WordDisplay, strSecretWord);
                guessedIt = GuessedWord(WordDisplay);

            }//end While

            if (guessedIt)
            {
                Console.WriteLine("You got it!! " + strSecretWord);
            }
            else
            {
                Console.WriteLine("Executed!! The word was " + strSecretWord);
            }
           
        }

        private static bool GuessedWord(string[] WordDisplay)
        {
            //loop throufh Worddisplay and see if the word is guessed
            for (int n = 0; n < WordDisplay.Length; n++)
            {

                if (WordDisplay[n] == " _ ")
                {
                    return false;
                }//end if

            }//end for loop

            return true;

        }//end GuessedWord





        private static int PlayerGuess(string[] WordDisplay, string strSecretWord)
        {
            string strUserGuess;
            int nWrongGuess = 1;

            //prompt user
            Console.Write("\nGuess a letter:");
            strUserGuess = Console.ReadLine();
            strLettersGuessed += strUserGuess;

            //process guess
            for (int n = 0; n < strSecretWord.Length; n++)
            {

                if (strSecretWord[n].ToString() == strUserGuess)
                {
                    WordDisplay[n] = strUserGuess;
                    nWrongGuess = 0;
                }

            }

            return nWrongGuess;
        }



        private static void PrintSecretWord(string[] wordDisplay)
        {
            for (int n = 0; n < wordDisplay.Length; n++)
            {

                Console.Write(wordDisplay[n]);

            }

            Console.WriteLine();

        }




        private static string[] InitializeWordDisplay(string strSecretWord)
        {

            string[] wordDisplay = new string[strSecretWord.Length];

            //fill wordDisplay array with _
            for (int n = 0; n < wordDisplay.Length; n++)
            {

                wordDisplay[n] = " _ ";

            }

            return wordDisplay;
        }

    }
}
