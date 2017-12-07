using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_GUI
{
    public class HangmanGamer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Wins { get; set; }
        public int GamesPlayed { get; set; }
        public string LongestWordSolved { get; set; }
        public int LongestWinStreak { get; set; }
        public int CurrentWinStreak { get; set; }

        public HangmanGamer() { }

        





        /// <summary>
        /// Updates a HangmanGamer's stats with a loss. This includes updating GamesPlayed and resetting CurrentWinStreak
        /// </summary>
        public void AddLoss()
        {
            GamesPlayed++;
            CurrentWinStreak = 0;
        }


        public HangmanGamer(string name)
        {

            Name = name;
            LongestWordSolved = "";
            
        }



        /// <summary>
        /// Updates a HangmanGamer's stats with a win. This includes updating wins, gamesplayed, currentwinstreak, longestwinstreak and longest word properties.
        /// </summary>
        /// <param name="word"></param>
        public void AddWin(string word)
        {
            GamesPlayed++;
            Wins++;
            CurrentWinStreak++;

            //update longestwordsolved if necessary
            if (word.Length > LongestWordSolved.Length)
            {
                LongestWordSolved = word;
            }

            //update longestwin if necessary
            if(CurrentWinStreak > LongestWinStreak)
            {
                LongestWinStreak = CurrentWinStreak;
            }
        }

    }
}
