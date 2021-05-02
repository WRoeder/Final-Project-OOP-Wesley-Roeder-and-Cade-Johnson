
namespace Final_Project_Pong
{
    partial class Winner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winner));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.btnPlayerOne = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.btnPlayerTwo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Winning Record!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Red";
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerOne.Location = new System.Drawing.Point(17, 133);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(76, 25);
            this.lblPlayerOne.TabIndex = 2;
            this.lblPlayerOne.Text = "label3";
            // 
            // btnPlayerOne
            // 
            this.btnPlayerOne.Location = new System.Drawing.Point(22, 190);
            this.btnPlayerOne.Name = "btnPlayerOne";
            this.btnPlayerOne.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerOne.TabIndex = 3;
            this.btnPlayerOne.Text = "Add a Win!";
            this.btnPlayerOne.UseVisualStyleBackColor = true;
            this.btnPlayerOne.Click += new System.EventHandler(this.btnPlayerOne_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(263, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Blue";
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPlayerTwo.Location = new System.Drawing.Point(265, 134);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(66, 24);
            this.lblPlayerTwo.TabIndex = 5;
            this.lblPlayerTwo.Text = "label5";
            // 
            // btnPlayerTwo
            // 
            this.btnPlayerTwo.Location = new System.Drawing.Point(264, 190);
            this.btnPlayerTwo.Name = "btnPlayerTwo";
            this.btnPlayerTwo.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerTwo.TabIndex = 6;
            this.btnPlayerTwo.Text = "Add a Win!";
            this.btnPlayerTwo.UseVisualStyleBackColor = true;
            this.btnPlayerTwo.Click += new System.EventHandler(this.btnPlayerTwo_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(144, 190);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset to 0-0";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(365, 269);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlayerTwo);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPlayerOne);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Winner";
            this.Text = "Winner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Winner_FormClosed);
            this.Load += new System.EventHandler(this.Winner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Button btnPlayerOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.Button btnPlayerTwo;
        private System.Windows.Forms.Button btnReset;
    }
}