using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTheory
{
    public partial class Form1 : Form
    {
        int player1;
        int player2;
        int round;

        public Form1()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void buttonStartOver_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void buttonDove_Click(object sender, EventArgs e)
        {
            int[] arr = new int[5] { 2, 2, 2, 3, 3 };
            Random random = new Random();
            int temp = random.Next(0, arr.Length);

            // 2, 2
            if (arr[temp] == 2)
            {
                player1 += 2;
                player2 += 2;
                round += 1;

                ddLabel.BackColor = Color.Red;
                dhLabel.BackColor = Color.Yellow;
                hdLabel.BackColor = Color.Yellow;
                hhLabel.BackColor = Color.Yellow;
            }
            
            // 1, 3
            else if (arr[temp] == 3)
            {
                player1 += 1;
                player2 += 3;
                round += 1;

                dhLabel.BackColor = Color.Red;
                ddLabel.BackColor = Color.Yellow;
                hdLabel.BackColor = Color.Yellow;
                hhLabel.BackColor = Color.Yellow;
            }

            player1score.Text = player1.ToString();
            player2score.Text = player2.ToString();
            roundLabel.Text = round.ToString();
        }

        private void buttonHawk_Click(object sender, EventArgs e)
        {
            int[] arr = new int[5] { 0, 0, 0, 1, 1 };
            Random random = new Random();
            int temp = random.Next(0, arr.Length);

            if (arr[temp] == 0)
            {
                player1 += 0;
                player2 += 0;
                round += 1;

                hhLabel.BackColor = Color.Red;
                ddLabel.BackColor = Color.Yellow;
                hdLabel.BackColor = Color.Yellow;
                dhLabel.BackColor = Color.Yellow;
            }

            else if (arr[temp] == 1)
            {
                player1 += 3;
                player2 += 1;
                round += 1;

                hdLabel.BackColor = Color.Red;
                ddLabel.BackColor = Color.Yellow;
                hhLabel.BackColor = Color.Yellow;
                dhLabel.BackColor = Color.Yellow;
            }

            player1score.Text = player1.ToString();
            player2score.Text = player2.ToString();
            roundLabel.Text = round.ToString();
        }

        private void buttonShowWinner_Click(object sender, EventArgs e)
        {
            if (player1 > player2)
            {
                MessageBox.Show("Congrats! You Win!");
            }
            else if (player2 > player1)
            {
                MessageBox.Show("Sorry! Your Opponent Wins!");
            }
            else if (player1 == player2)
            {
                MessageBox.Show("It's a tie!");
            }
        }
    }
}
