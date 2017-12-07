using System;
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
    public partial class frmMain : Form
    {
        List<HangmanGamer> gamers;
        HangmanGamerRepository gamerRepo = new HangmanGamerRepository();



        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            HangmanGamer currentGamer = new HangmanGamer(txtNewPlayer.Text);
            gamerRepo.AddGamer(currentGamer);
            gamerRepo.Save();
            PopulatePlayers();
            //Changing the combo box to select the most recent player
            cbPlayer.SelectedIndex = cbPlayer.Items.Count - 1;
            pnlCreatePlayer.Visible = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulatePlayers();
        }

        private void PopulatePlayers()
        {
            cbPlayer.Items.Clear();
            cbPlayer.Items.Add("New Player");

            
            gamers = gamerRepo.GetHangmanGamers();
            foreach (HangmanGamer gamer in gamers)
            {
                cbPlayer.Items.Add(gamer.Name);
            }
        }

        private void btnSelectPlayer_Click(object sender, EventArgs e)
        {
            if(cbPlayer.SelectedItem.ToString() =="New Player")
            {
                pnlCreatePlayer.Visible = true;
            }
            else
            {
  
            frmHangman hangman = new frmHangman(gamerRepo.GetGamerByName(cbPlayer.SelectedItem.ToString()));
            hangman.Show();
            this.Hide();
           
            }
        }//end btnSeletPlayer_CLick
    }
}
