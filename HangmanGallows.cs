using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_GUI
{
    class HangmanGallows
    {

        /// <summary>
        /// Clears the console window and draws the hangman gallows in the stage passed in.
        /// There are 10 stages.
        /// </summary>
        /// <param name="wrongGuesses"> Indicates which stage of the Hangman gallows to draw</param>
        public static Image GetGallowImage(int stage)
        {
            //clear screen for new gallow.
            

            switch (stage)
            {
                case 0: return Properties.Resources.Stage0;
                case 1: return Properties.Resources.Stage1;
                case 2: return Properties.Resources.Stage2;
                case 3: return Properties.Resources.Stage3;
                case 4: return Properties.Resources.Stage4;
                case 5: return Properties.Resources.Stage5;
                case 6: return Properties.Resources.Stage6;
                case 7: return Properties.Resources.Stage7;
                case 8: return Properties.Resources.Stage8;
                case 9: return Properties.Resources.Stage9;
                case 10: return Properties.Resources.StageFinal;
                default: return Properties.Resources.Stage0;
            }
        }

    }
}
