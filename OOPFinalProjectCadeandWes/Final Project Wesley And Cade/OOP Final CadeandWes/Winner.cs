using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Pong
{
    public partial class Winner : Form
    {
        // Making integers for counting up the score.

        int counterPlayerOne = 0;
        int counterPlayerTwo = 0;

        public Winner()
        {
            InitializeComponent();
        }

        //increments count up by 1 when button is clicked.

        private void btnPlayerOne_Click(object sender, EventArgs e)
        {
            counterPlayerOne++;
            lblPlayerOne.Text = counterPlayerOne.ToString();
        }

        private void btnPlayerTwo_Click(object sender, EventArgs e)
        {
            counterPlayerTwo++;
            lblPlayerTwo.Text = counterPlayerTwo.ToString();
        }

        //Saves winning record when program is closed.

        private void Winner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.lblUser = lblPlayerOne.Text;
            Properties.Settings.Default.Save();

            Properties.Settings.Default.lblCPU = lblPlayerTwo.Text;
            Properties.Settings.Default.Save();
        }

        //Loads winner record that was previously saved.

        private void Winner_Load(object sender, EventArgs e)
        {
            lblPlayerOne.Text = Properties.Settings.Default.lblUser;
            int.TryParse(label1.Text, out counterPlayerOne);

            lblPlayerTwo.Text = Properties.Settings.Default.lblCPU;
            int.TryParse(label1.Text, out counterPlayerOne);
        }

        //Resets counters back down to 0.

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblPlayerOne.Text = "0";
            lblPlayerTwo.Text = "0";
        }

       
    }
}
