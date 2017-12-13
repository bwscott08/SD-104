using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyFooball_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //declare variables
            double npassingYds, npassingTds, nInterceptions, nrushingYds, nrushingTds, nreceivingYds, nreceivingTds, nTotal;

            //promt user for statistics
            
            npassingYds = Convert.ToInt32(txbPassYds.Text);

            
            npassingTds = Convert.ToInt32(txbPassTds.Text);

            
            nInterceptions = Convert.ToInt32(txbInterceptions.Text);

            
            nrushingYds = Convert.ToInt32(txbRushingYds.Text);

            
            nrushingTds = Convert.ToInt32(txbRushTds.Text);
            
            nreceivingYds = Convert.ToInt32(txbRecYds.Text);

            
            nreceivingTds = Convert.ToInt32(txbPassTds.Text);

            //Calculations
            nTotal = npassingYds / 25;
            nTotal += npassingTds * 6;
            nTotal += nrushingTds * 6;
            nTotal += nrushingYds / 10;
            nTotal += nreceivingYds / 10;
            nTotal += nreceivingTds * 6;
            nTotal -= nInterceptions * 2;

            //print results
            txtDisplay.Text = "Your Fantasy total for the week is " + nTotal.ToString() + "!";
            
        }
 
    }
}
