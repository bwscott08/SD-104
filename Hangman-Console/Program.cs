using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Console
{
    class Program
    {

        static string strLettersGuessed;
        static string strSecretWord = GetWord();
        static int nWrongGuesses = 0;
        static string[] WordDisplay = InitializeWordDisplay(strSecretWord);
        static bool guessedIt = false;

        static void Main(string[] args)
        {
            
            
            
            //display all gallows
            while(!guessedIt && nWrongGuesses < 10)
            {
                DrawGallow(nWrongGuesses);
                //print wordDisplay
                
                PrintSecretWord(WordDisplay);
                Console.WriteLine("Letters guessed: " + strLettersGuessed);

                nWrongGuesses += PlayerGuess(WordDisplay, strSecretWord);
                guessedIt = GuessedWord(WordDisplay);

            }//end While

            if(guessedIt)
            {
                Console.WriteLine("You got it!! " + strSecretWord);
            }
            else
            {
                Console.WriteLine("Executed!! The word was " + strSecretWord);
            }
            Console.ReadLine();
        }// end Main



        private static string GetWord()
        {
            StreamReader textIn = new StreamReader("wordbank.txt");

            //get random word
            Random random = new Random();
            int randNum = random.Next(1, 479781);

            //read through file to get that word
            for (int n = 0; n < randNum; n++)
            {

                textIn.ReadLine();

            }

            return textIn.ReadLine();
            
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

                if(strSecretWord[n].ToString() == strUserGuess)
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




        public static void DrawGallow(int wrongGuesses)
        {
            //clear screen for new gallow.
            Console.Clear();

            switch (wrongGuesses)
            {
                case 0: Stage0(); break;
                case 1: Stage1(); break;
                case 2: Stage2(); break;
                case 3: Stage3(); break;
                case 4: Stage4(); break;
                case 5: Stage5(); break;
                case 6: Stage6(); break;
                case 7: Stage7(); break;
                case 8: Stage8(); break;
                case 9: Stage9(); break;
                case 10: StageFinal(); break;
            }
        }

        private static void Stage0()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage1()
        {

            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |    |     |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage2()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |    |     |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |              ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage3()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |    |     |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage4()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |    |     |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage5()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @      |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage6()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @       @  ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage7()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @   \'   @ ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage8()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @   \"   @ ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }
        private static void Stage9()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @   \"   @ ");
            Console.WriteLine("              |    \\__~__/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void StageFinal()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    / x x \\  ");
            Console.WriteLine("              |   @   \"   @ ");
            Console.WriteLine("              |    \\__~__/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }
    }
}
