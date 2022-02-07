using System;
using System.Windows.Forms;

namespace Activity13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            
            int?[,] Array = new int?[3, 3];
            
            bool isXWin = false; ;
            bool isOWin = false;

            
            Random r = new Random();
            
            Array[0, 0] = r.Next(0, 2);
            Array[0, 1] = r.Next(0, 2);
            Array[0, 2] = r.Next(0, 2);
            Array[1, 0] = r.Next(0, 2);
            Array[1, 1] = r.Next(0, 2);
            Array[1, 2] = r.Next(0, 2);
            Array[2, 0] = r.Next(0, 2);
            Array[2, 1] = r.Next(0, 2);
            Array[2, 2] = r.Next(0, 2);

            
            if (Array[0, 0] == Array[0, 1] && Array[0, 1] == Array[0, 2])
            {
                isXWin = Array[0, 0] == 1;
                isOWin = Array[0, 0] == 0;
            }
            else if (Array[1, 0] == Array[1, 1] && Array[1, 1] == Array[1, 2])
            {
                isXWin = Array[1, 0] == 1;
                isOWin = Array[1, 0] == 0;
            }
            else if (Array[2, 1] == Array[2, 1] && Array[2, 1] == Array[2, 2])
            {
                isXWin = Array[2, 1] == 1;
                isOWin = Array[2, 1] == 0;
            }
            else if (Array[0, 0] == Array[1, 0] && Array[1, 0] == Array[2, 0])
            {
                isXWin = Array[0, 0] == 1;
                isOWin = Array[0, 0] == 0;
            }
            else if (Array[0, 1] == Array[1, 1] && Array[1, 1] == Array[2, 1])
            {
                isXWin = Array[0, 1] == 1;
                isOWin = Array[0, 1] == 0;
            }
            else if (Array[0, 2] == Array[1, 2] && Array[1, 2] == Array[2, 2])
            {
                isXWin = Array[0, 2] == 1;
                isOWin = Array[0, 2] == 0;
            }
            else if (Array[0, 0] == Array[1, 1] && Array[1, 1] == Array[2, 2])
            {
                isXWin = Array[0, 0] == 1;
                isOWin = Array[0, 0] == 0;
            }
            else if (Array[0, 2] == Array[1, 1] && Array[1, 1] == Array[2, 0])
            {
                isXWin = Array[0, 2] == 1;
                isOWin = Array[0, 2] == 0;
            }

            
            label1.Text = Array[0, 0] == 1 ? "X" : "O";
            label2.Text = Array[0, 1] == 1 ? "X" : "O";
            label3.Text = Array[0, 2] == 1 ? "X" : "O";
            label4.Text = Array[1, 0] == 1 ? "X" : "O";
            label5.Text = Array[1, 1] == 1 ? "X" : "O";
            label6.Text = Array[1, 2] == 1 ? "X" : "O";
            label7.Text = Array[2, 0] == 1 ? "X" : "O";
            label8.Text = Array[2, 1] == 1 ? "X" : "O";
            label9.Text = Array[2, 2] == 1 ? "X" : "O";

           
            if (isXWin)
            {
                txtResult.Text = "X Wins!";
            }
           
            else if (isOWin)
            {
                txtResult.Text = "O Wins!";
            }
           
            else
            {
                txtResult.Text = "Game Draw!";
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}