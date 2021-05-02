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
    public partial class Pong : Form
    {
        public Pong()
        {
            InitializeComponent();
        }

        //Creating bools for key movements.

        bool goUp;  
        bool goDown; 
        bool goUp2; 
        bool goDown2; 

        //Variables used to track speed, position, and score.

        int intSpeed = 15; 
        int intBallX = 5; 
        int intBallY = 5;  
        int intPlayerScore = 0; 
        int intPlayerTwoScore = 0; 

        // Code for detecting when keys are pressed causing movement and the opening of the scoreboard. 

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp2 = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown2 = true;
            }
            if (e.KeyCode == Keys.E)
            {
                Winner popup = new Winner();
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp2 = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown2 = false;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            // Showing the score for each player on screen.

            lblPlayerScore.Text = "" + intPlayerScore; 
            lblPlayerTwoScore.Text = "" + intPlayerTwoScore; 

            // Assigning the ball's position to the integers.

            lblBall.Top -= intBallY; 
            lblBall.Left -= intBallX; 

            // Detecting if the ball makes it past either player. Also adding a point and increasing the speed of the ball.

            if (lblBall.Left < 0) 
            {
                lblBall.Left = 434; 
                intBallX = -intBallX; 
                intBallX -= 3; 
                intPlayerTwoScore++; 
            }

            if (lblBall.Left + lblBall.Width > ClientSize.Width) 
            {
                lblBall.Left = 434; 
                intBallX = -intBallX;  
                intBallX += 3;  
                intPlayerScore++; 
            }

            // Detecting if the ball hits the top or bottom of the screen and forcing it to stay within the screen. 

            if (lblBall.Top < 0 || lblBall.Top + lblBall.Height > ClientSize.Height) 
            {
                intBallY = -intBallY; 
            }

            // Detecting if the ball hits a player and bouncing it in the opposite direction. 

            if (lblBall.Bounds.IntersectsWith(lblPlayer.Bounds) || lblBall.Bounds.IntersectsWith(lblPlayerTwo.Bounds)) 
            {
                intBallX = -intBallX; 
            }

            // Moving the players up and down based on their key presses. 

            if (goUp == true && lblPlayer.Top > 0) 
            {
                lblPlayer.Top -= 8; 
            }

            if (goDown == true && lblPlayer.Top < 455) 
            {
                lblPlayer.Top += 8; 
            }

            if (goUp2 == true && lblPlayerTwo.Top > 0) 
            {
                lblPlayerTwo.Top -= 8; 
            }

            if (goDown2 == true && lblPlayerTwo.Top < 455) 
            {
                lblPlayerTwo.Top += 8; 
            }

            // Detecting who wins the game and sending out the correct message.

            if (intPlayerScore > 10) 
            {
                myTimer.Stop();
                MessageBox.Show("Player one wins the game!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (intPlayerTwoScore > 10) 
            {
                myTimer.Stop();
                MessageBox.Show("Player two wins the game!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
