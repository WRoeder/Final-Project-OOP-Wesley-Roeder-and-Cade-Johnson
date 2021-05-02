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
    public partial class StarBounce : Form
    {
        // Creating the integers for moving the objects. 

        int intDirection = 0;
        int intStep = 10;
        int intUpper = 20;
        int intHorizontal = 0;
        int intRight = 400;
        int intLeft = 50;

        public StarBounce()
        {
            InitializeComponent();
        }

        // Button that starts the game.

        private void btnStart_Click(object sender, EventArgs e)
        {
            myTimer.Enabled = true;
            lblStar.Top = 20;
            this.KeyPreview = true;
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            // Detecting the position of the star and adjusting accordingly. 

            if (intDirection == 0)
            {
                lblStar.Top += intStep;

                if (lblStar.Top + lblStar.Height > lblRock.Top & lblStar.Left > lblRock.Left - lblStar.Width & lblStar.Left < lblRock.Left + lblRock.Width - lblStar.Width)
                {
                    intDirection = 1;
                }

                if (lblStar.Top == 600)
                {
                    myTimer.Stop();
                    MessageBox.Show("Game Over!", "You Lost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (intDirection == 1)
            {
                if (lblStar.Top >= intUpper)
                {
                    lblStar.Top -= intStep;
                }
                else
                {
                    intDirection = 0;
                }
            }

            if (intHorizontal == 0)
            {
                if (lblRock.Left <= intRight)
                {
                    lblRock.Left += intStep;
                }
                else
                {
                    intHorizontal = 1;
                }
            }
            else
            {
                if (lblRock.Left >= intLeft)
                {
                    lblRock.Left -= intStep;
                }
                else
                {
                    intHorizontal = 0;
                }
            }
        }

        // Moving the rock using the A and D keys.

        private void StarBounce_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'a':
                    intHorizontal = 1;
                    break;
                case 'd':
                    intHorizontal = 0;
                    break;
            }
        }
    }
}
