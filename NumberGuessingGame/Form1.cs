using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int currentScore = 0;
        string guess = "";
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = guessButton;
            scoreLabel.Text = "Score: " + currentScore.ToString();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            guess = textBox1.Text;
            checkWinner(guess);
        }

        private void checkWinner(string guess)
        {
            try
            {
                int numToGuess = r.Next(1, 10);
                int guessedNum = int.Parse(guess);

                if (numToGuess == guessedNum)
                {
                    //We have won the game
                    currentScore++;
                    numberLabel.Text = "You have won the game! " + guessedNum;
                    textBox1.Text = "";
                    scoreLabel.Text = currentScore.ToString();
                }

                else
                {
                    //We have not won the game
                    numberLabel.Text = "You have lost the game! " + guessedNum;
                    textBox1.Text = "";
                }
            }
            catch (Exception e)
            {
                numberLabel.Text = "Error!";
                textBox1.Text = "";
            
            }
        }
    }
}
