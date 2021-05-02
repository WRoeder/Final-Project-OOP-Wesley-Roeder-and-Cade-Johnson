namespace Final_Project_Pong
{
    partial class Pong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblBall = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.lblPlayerTwoScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.BackColor = System.Drawing.Color.Maroon;
            this.lblPlayer.Location = new System.Drawing.Point(12, 186);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(27, 127);
            this.lblPlayer.TabIndex = 0;
            // 
            // lblBall
            // 
            this.lblBall.BackColor = System.Drawing.Color.SlateGray;
            this.lblBall.ForeColor = System.Drawing.Color.Transparent;
            this.lblBall.Location = new System.Drawing.Point(434, 239);
            this.lblBall.Name = "lblBall";
            this.lblBall.Size = new System.Drawing.Size(27, 26);
            this.lblBall.TabIndex = 1;
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblPlayerTwo.Location = new System.Drawing.Point(897, 230);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(27, 127);
            this.lblPlayerTwo.TabIndex = 2;
            // 
            // myTimer
            // 
            this.myTimer.Enabled = true;
            this.myTimer.Interval = 20;
            this.myTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // lblPlayerTwoScore
            // 
            this.lblPlayerTwoScore.AutoSize = true;
            this.lblPlayerTwoScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwoScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoScore.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPlayerTwoScore.Location = new System.Drawing.Point(837, 524);
            this.lblPlayerTwoScore.Name = "lblPlayerTwoScore";
            this.lblPlayerTwoScore.Size = new System.Drawing.Size(38, 25);
            this.lblPlayerTwoScore.TabIndex = 4;
            this.lblPlayerTwoScore.Text = "00";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPlayerScore.Location = new System.Drawing.Point(52, 526);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(100, 23);
            this.lblPlayerScore.TabIndex = 5;
            this.lblPlayerScore.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "W = Up S= Down for Red, Up and Down Arrows Control Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(142, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(675, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Press E to Access Winner Record/Report Score (saves on exit)";
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblPlayerTwoScore);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.lblBall);
            this.Controls.Add(this.lblPlayer);
            this.Name = "Pong";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblBall;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Label lblPlayerTwoScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

