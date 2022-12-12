using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_Game
{
    public partial class Form1 : Form
    {
        bool turn = true;//true = x  false = o
        int turnCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Arian", "X O About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCounter = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn == true)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            turnCounter++;
            checkForWinner();

        }
        private void checkForWinner()
        {
            bool isWinner = false;
            if (A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled)
            {
                isWinner = true;
            }
            else if (B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled)
            {
                isWinner = true;
            }
            else if (C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled)
            {
                isWinner = true;
            }



            if (A1.Text == B1.Text && B1.Text == C1.Text && !A1.Enabled)
            {
                isWinner = true;
            }
            else if (A2.Text == B2.Text && B2.Text == C2.Text && !A2.Enabled)
            {
                isWinner = true;
            }
            else if (A3.Text == B3.Text && B3.Text == C3.Text && !A3.Enabled)
            {
                isWinner = true;
            }



            if (A1.Text == B2.Text && B2.Text == C3.Text && !A1.Enabled)
            {
                isWinner = true;
            }
            else if (A3.Text == B2.Text && B2.Text == C1.Text && !C1.Enabled)
            {
                isWinner = true;
            }
            




            if (isWinner == true)
            {
                disableButtons();
                string Winner;
                if (turn == true)
                {
                    Winner = "O";
                }
                else
                {
                    Winner = "X";
                }
                MessageBox.Show("**********Our winner is : " + Winner + "   ***********","Congrajulation "+Winner);
            }
            else
            {
                if (turnCounter == 9)
                {
                    MessageBox.Show("Tie Game!", "Thank you for your participation");
                }
            }
        }
        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }
    }
}
