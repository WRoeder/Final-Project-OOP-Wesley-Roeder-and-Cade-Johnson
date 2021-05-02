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
    public partial class Pickagame : Form
    {
        public Pickagame()
        {
            InitializeComponent();
        }

        // Launching a game based on what button is pressed.

        private void btnPong_Click(object sender, EventArgs e)
        {
            var m = new Pong();
            m.Show();

         
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStarBounce_Click(object sender, EventArgs e)
        {
            var m = new StarBounce();
            m.Show();
        }

        private void btnSnake_Click(object sender, EventArgs e)
        {
            var m = new SpaceSnake();
            m.Show();
        }
    }
}
