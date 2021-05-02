
namespace Final_Project_Pong
{
    partial class Pickagame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pickagame));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPong = new System.Windows.Forms.Button();
            this.btnStarBounce = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSnake = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Arcade!";
            // 
            // btnPong
            // 
            this.btnPong.BackColor = System.Drawing.SystemColors.Control;
            this.btnPong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPong.Location = new System.Drawing.Point(155, 60);
            this.btnPong.Name = "btnPong";
            this.btnPong.Size = new System.Drawing.Size(85, 23);
            this.btnPong.TabIndex = 1;
            this.btnPong.Text = "Play Pong!";
            this.btnPong.UseVisualStyleBackColor = false;
            this.btnPong.Click += new System.EventHandler(this.btnPong_Click);
            // 
            // btnStarBounce
            // 
            this.btnStarBounce.Location = new System.Drawing.Point(152, 100);
            this.btnStarBounce.Name = "btnStarBounce";
            this.btnStarBounce.Size = new System.Drawing.Size(97, 23);
            this.btnStarBounce.TabIndex = 2;
            this.btnStarBounce.Text = "Play Star Bounce";
            this.btnStarBounce.UseVisualStyleBackColor = true;
            this.btnStarBounce.Click += new System.EventHandler(this.btnStarBounce_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(275, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(155, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit Arcade";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSnake
            // 
            this.btnSnake.Location = new System.Drawing.Point(152, 139);
            this.btnSnake.Name = "btnSnake";
            this.btnSnake.Size = new System.Drawing.Size(114, 25);
            this.btnSnake.TabIndex = 6;
            this.btnSnake.Text = "Play Space Snake";
            this.btnSnake.UseVisualStyleBackColor = true;
            this.btnSnake.Click += new System.EventHandler(this.btnSnake_Click);
            // 
            // Pickagame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(387, 262);
            this.Controls.Add(this.btnSnake);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStarBounce);
            this.Controls.Add(this.btnPong);
            this.Controls.Add(this.label1);
            this.Name = "Pickagame";
            this.Text = "Pickagame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPong;
        private System.Windows.Forms.Button btnStarBounce;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSnake;
    }
}