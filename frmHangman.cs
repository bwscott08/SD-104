﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_GUI
{
    public partial class frmHangman : Form
    {
        List<PictureBox> SecretWordTiles = new List<PictureBox>();
        HangmanGamer currentGamer;
        string SecretWord;
        int WrongGuesses;

        public frmHangman(HangmanGamer Gamer)
        {
            InitializeComponent();
            currentGamer = Gamer;
            menuStrip1.Items[0].Text = currentGamer.Name + "'s stats";
        }    

        private void Form1_Load(object sender, EventArgs e)
        {

            NewGame();

        }

        private void NewGame()
        {
            WrongGuesses = 0;
            LoadSecretWord();
            EnableButtons();
            UpdateStatusStrip();
            pbGallows.Image = Properties.Resources.Stage0;

        }

        private void EnableButtons()
        {
            foreach(Control control in this.Controls)
            {
                control.Enabled = true;
            }
        }

        private void LoadSecretWord()
        {
            try
            {

                FileAccessor wordBank = new FileAccessor("wordbank.txt");
                SecretWord = wordBank.GetRandomLine();

                //remove old word files from form
                foreach (PictureBox pbWord in SecretWordTiles)
                {
                    this.Controls.RemoveByKey(pbWord.Name);
                }

                SecretWordTiles.Clear();
                InitializeWordDisplay();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading a new word. " + ex.ToString(), "Sorry. The game cannot continue");

            }
        }

        private void InitializeWordDisplay()
        {

            //create a picture boxes for the secret word.
            for (int n = 0; n < SecretWord.Length; n++)
            {
                PictureBox nextLetter = new PictureBox();
                nextLetter.Name = "pbWord" + n;
                if (SecretWord[n] == '-')
                {
                    nextLetter.Image = Properties.Resources._;
                }
                else
                {
                    nextLetter.Image = Properties.Resources.BLANK;
                    nextLetter.Tag = SecretWord[n].ToString().ToUpper();
                }
                nextLetter.Tag = SecretWord[n].ToString().ToUpper();
                nextLetter.Image = Properties.Resources.BLANK;
                nextLetter.Size = new System.Drawing.Size(60, 59);
                nextLetter.Location = new System.Drawing.Point(12 + (85 * n), 50);
                this.Controls.Add(nextLetter);
                SecretWordTiles.Add(nextLetter);
            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {

            Button pushedButton = (Button)sender;
            pushedButton.Enabled = false;
            ProcessGuess((string)pushedButton.Tag);




        }

        private void ProcessGuess(string strPlayerGuess)
        {
            int nWrongGuesses = 1;//assume guess is wrong

            //search through the secret word tiles looking for a match
            foreach(PictureBox pbWord in SecretWordTiles.Where(pb=> (string)pb.Tag ==strPlayerGuess))
            {
                    pbWord.Image = GetTileImage(strPlayerGuess);
                    pbWord.Tag = "#";
                    nWrongGuesses = 0;

            }



            //increment WrongGuesses
            WrongGuesses += nWrongGuesses;
            pbGallows.Image = HangmanGallows.GetGallowImage(WrongGuesses);
            CheckForWinLoss();

            
        }//End ProcessGuess

        private void CheckForWinLoss()
        {
            string strMessage = "";
            
            
            //check for loss
            if (WrongGuesses == 10)
            {
                strMessage = "You lost...";
                currentGamer.AddLoss();
            }
            else if (GuessedIt())
            {

                strMessage = "You won!!!";
                currentGamer.AddWin(SecretWord);

            }
            else
            {
                return;
            }
            UpdateStatusStrip();
            UpdateGamer();


            DialogResult dr = MessageBox.Show(strMessage + " The word was " + SecretWord + ". Would you like to play again?", "Play again?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                NewGame();
            }
            else
            {
                Application.Exit();
            }


        }

        private void UpdateGamer()
        {
            HangmanGamerRepository _db = new HangmanGamerRepository();
            _db.UpdateGamer(currentGamer);
            _db.Save();
        }

        private void UpdateStatusStrip()
        {
            tsslName.Text = "Hello, " + currentGamer.Name;
            tsslWins.Text = "Wins: " + currentGamer.Wins;
            tsslStreak.Text = "Current Strak: " + currentGamer.CurrentWinStreak;
                
        }

        private bool GuessedIt()
        {
            //check all SecretWordFile picture boxes
            foreach(PictureBox pbWord in SecretWordTiles.Where(pb=> (string)pb.Tag !=  "#"))
            {
                //if tag doesn't have a#, then the word hasn't been guessed yet
                {
                    return false;
                }
            }
            //if every picture box was checkes and this method didn't return false
            return true;
        }





        private Image GetTileImage(string strPlayerGuess)
        {
            switch (strPlayerGuess)
            {
                case "A": return Properties.Resources.A;
                case "B": return Properties.Resources.B;
                case "C": return Properties.Resources.C;
                case "D": return Properties.Resources.D;
                case "E": return Properties.Resources.E;
                case "F": return Properties.Resources.F;
                case "G": return Properties.Resources.G;
                case "H": return Properties.Resources.H;
                case "I": return Properties.Resources.I;
                case "J": return Properties.Resources.J;
                case "K": return Properties.Resources.K;
                case "L": return Properties.Resources.L;
                case "M": return Properties.Resources.M;
                case "N": return Properties.Resources.N;
                case "O": return Properties.Resources.O;
                case "P": return Properties.Resources.P;
                case "Q": return Properties.Resources.Q;
                case "R": return Properties.Resources.R;
                case "S": return Properties.Resources.S;
                case "T": return Properties.Resources.T;
                case "U": return Properties.Resources.U;
                case "V": return Properties.Resources.V;
                case "W": return Properties.Resources.W;
                case "X": return Properties.Resources.X;
                case "Y": return Properties.Resources.Y;
                case "Z": return Properties.Resources.Z;
                default: return Properties.Resources.BLANK;
             
                
            }
        }

        private void frmHangman_KeyPress(object sender, KeyPressEventArgs e)
        {
            //disable button
            foreach(Control control in this.Controls.Find("btn" + e.KeyChar.ToString().ToUpper(),true))
            {
                
                {
                    if (control.Enabled)
                        control.Enabled = false;
                    else
                        return;
                }

                    
            }


            ProcessGuess(e.KeyChar.ToString().ToUpper());
        }

        private void playerStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + currentGamer.Name + "\nWins: " + currentGamer.Wins + "\nGames Played: " + currentGamer.GamesPlayed + "\nLongest Word: " + currentGamer.LongestWordSolved + "\nLongest Win Streak: " + currentGamer.LongestWinStreak + "\nCurrent Win Streak: " + currentGamer.CurrentWinStreak);
       }

        private void frmHangman_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
