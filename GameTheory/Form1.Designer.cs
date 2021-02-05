namespace GameTheory
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDove = new System.Windows.Forms.Button();
            this.buttonHawk = new System.Windows.Forms.Button();
            this.buttonShowWinner = new System.Windows.Forms.Button();
            this.buttonStartOver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ddLabel = new System.Windows.Forms.Label();
            this.hhLabel = new System.Windows.Forms.Label();
            this.dhLabel = new System.Windows.Forms.Label();
            this.hdLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.player1score = new System.Windows.Forms.Label();
            this.player2score = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDove
            // 
            this.buttonDove.Location = new System.Drawing.Point(204, 319);
            this.buttonDove.Name = "buttonDove";
            this.buttonDove.Size = new System.Drawing.Size(75, 46);
            this.buttonDove.TabIndex = 0;
            this.buttonDove.Text = "Dove";
            this.buttonDove.UseVisualStyleBackColor = true;
            this.buttonDove.Click += new System.EventHandler(this.buttonDove_Click);
            // 
            // buttonHawk
            // 
            this.buttonHawk.Location = new System.Drawing.Point(329, 319);
            this.buttonHawk.Name = "buttonHawk";
            this.buttonHawk.Size = new System.Drawing.Size(75, 46);
            this.buttonHawk.TabIndex = 1;
            this.buttonHawk.Text = "Hawk";
            this.buttonHawk.UseVisualStyleBackColor = true;
            this.buttonHawk.Click += new System.EventHandler(this.buttonHawk_Click);
            // 
            // buttonShowWinner
            // 
            this.buttonShowWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowWinner.Location = new System.Drawing.Point(506, 303);
            this.buttonShowWinner.Name = "buttonShowWinner";
            this.buttonShowWinner.Size = new System.Drawing.Size(75, 46);
            this.buttonShowWinner.TabIndex = 2;
            this.buttonShowWinner.Text = "Show Winner";
            this.buttonShowWinner.UseVisualStyleBackColor = true;
            this.buttonShowWinner.Click += new System.EventHandler(this.buttonShowWinner_Click);
            // 
            // buttonStartOver
            // 
            this.buttonStartOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartOver.Location = new System.Drawing.Point(617, 303);
            this.buttonStartOver.Name = "buttonStartOver";
            this.buttonStartOver.Size = new System.Drawing.Size(66, 46);
            this.buttonStartOver.TabIndex = 3;
            this.buttonStartOver.Text = "Start Over";
            this.buttonStartOver.UseVisualStyleBackColor = true;
            this.buttonStartOver.Click += new System.EventHandler(this.buttonStartOver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dove";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hawk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "_______________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "_______________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "_______________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(9, 221);
            this.label6.TabIndex = 9;
            this.label6.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 221);
            this.label7.TabIndex = 10;
            this.label7.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(9, 221);
            this.label8.TabIndex = 11;
            this.label8.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Dove";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Hawk";
            // 
            // ddLabel
            // 
            this.ddLabel.AutoSize = true;
            this.ddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddLabel.Location = new System.Drawing.Point(260, 134);
            this.ddLabel.Name = "ddLabel";
            this.ddLabel.Size = new System.Drawing.Size(35, 24);
            this.ddLabel.TabIndex = 14;
            this.ddLabel.Text = "2,2";
            // 
            // hhLabel
            // 
            this.hhLabel.AutoSize = true;
            this.hhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hhLabel.Location = new System.Drawing.Point(367, 225);
            this.hhLabel.Name = "hhLabel";
            this.hhLabel.Size = new System.Drawing.Size(35, 24);
            this.hhLabel.TabIndex = 15;
            this.hhLabel.Text = "0,0";
            this.hhLabel.Click += new System.EventHandler(this.label12_Click);
            // 
            // dhLabel
            // 
            this.dhLabel.AutoSize = true;
            this.dhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhLabel.Location = new System.Drawing.Point(367, 134);
            this.dhLabel.Name = "dhLabel";
            this.dhLabel.Size = new System.Drawing.Size(35, 24);
            this.dhLabel.TabIndex = 16;
            this.dhLabel.Text = "1,3";
            // 
            // hdLabel
            // 
            this.hdLabel.AutoSize = true;
            this.hdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdLabel.Location = new System.Drawing.Point(260, 225);
            this.hdLabel.Name = "hdLabel";
            this.hdLabel.Size = new System.Drawing.Size(35, 24);
            this.hdLabel.TabIndex = 17;
            this.hdLabel.Text = "3,1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(470, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(268, 144);
            this.label15.TabIndex = 18;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Player 1:";
            // 
            // player1score
            // 
            this.player1score.AutoSize = true;
            this.player1score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1score.Location = new System.Drawing.Point(97, 149);
            this.player1score.Name = "player1score";
            this.player1score.Size = new System.Drawing.Size(21, 24);
            this.player1score.TabIndex = 20;
            this.player1score.Text = "0";
            // 
            // player2score
            // 
            this.player2score.AutoSize = true;
            this.player2score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2score.Location = new System.Drawing.Point(97, 204);
            this.player2score.Name = "player2score";
            this.player2score.Size = new System.Drawing.Size(21, 24);
            this.player2score.TabIndex = 22;
            this.player2score.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(35, 212);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Player 2:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label20.Location = new System.Drawing.Point(33, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 25);
            this.label20.TabIndex = 23;
            this.label20.Text = "ROUND";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roundLabel.Location = new System.Drawing.Point(132, 33);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(25, 25);
            this.roundLabel.TabIndex = 24;
            this.roundLabel.Text = "1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(156, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(289, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "_______________________________________________";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(156, 77);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(9, 208);
            this.label23.TabIndex = 26;
            this.label23.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 394);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.player2score);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.player1score);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.hdLabel);
            this.Controls.Add(this.dhLabel);
            this.Controls.Add(this.hhLabel);
            this.Controls.Add(this.ddLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStartOver);
            this.Controls.Add(this.buttonShowWinner);
            this.Controls.Add(this.buttonHawk);
            this.Controls.Add(this.buttonDove);
            this.Name = "Form1";
            this.Text = "Chicken Game Theory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDove;
        private System.Windows.Forms.Button buttonHawk;
        private System.Windows.Forms.Button buttonShowWinner;
        private System.Windows.Forms.Button buttonStartOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ddLabel;
        private System.Windows.Forms.Label hhLabel;
        private System.Windows.Forms.Label dhLabel;
        private System.Windows.Forms.Label hdLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label player1score;
        private System.Windows.Forms.Label player2score;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}

