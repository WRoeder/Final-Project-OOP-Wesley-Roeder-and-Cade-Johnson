
namespace Final_Project_Pong
{
    partial class StarBounce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarBounce));
            this.lblStar = new System.Windows.Forms.Label();
            this.lblRock = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblStar
            // 
            this.lblStar.BackColor = System.Drawing.Color.Transparent;
            this.lblStar.Image = ((System.Drawing.Image)(resources.GetObject("lblStar.Image")));
            this.lblStar.Location = new System.Drawing.Point(250, 20);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(50, 50);
            this.lblStar.TabIndex = 0;
            // 
            // lblRock
            // 
            this.lblRock.BackColor = System.Drawing.Color.Blue;
            this.lblRock.Image = ((System.Drawing.Image)(resources.GetObject("lblRock.Image")));
            this.lblRock.Location = new System.Drawing.Point(201, 500);
            this.lblRock.Name = "lblRock";
            this.lblRock.Size = new System.Drawing.Size(142, 20);
            this.lblRock.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(459, 581);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(442, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A = Left D = Right";
            // 
            // myTimer
            // 
            this.myTimer.Interval = 75;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // StarBounce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRock);
            this.Controls.Add(this.lblStar);
            this.Name = "StarBounce";
            this.Text = "Star Bounce!";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StarBounce_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label lblRock;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer myTimer;
    }
}