using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Guesser : Form
    {
        Random randomNumber = new Random();

        int number = 0;
        int guesses = 0;


        public Guesser()
        {
            InitializeComponent();

            loadQuestions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckNumber(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtEnterNumber.Text);

            guesses += 1;
            lblGuessed.Text = "You guessed "  + guesses + "times";

            if (i==number)
            {
                MessageBox.Show("Nice,You Guessed The Right Answer,Give it another try");
                loadQuestions();
                txtEnterNumber.Text = "";
                guesses = 0;
            }
            else if (i < number)
            {
                MessageBox.Show("Incorrect Answer,Go Higher");
            }
            else
            {
                MessageBox.Show("Go Lower");
            }
        
        }   
        private void loadQuestions()
        {
            number = randomNumber.Next(0, 10);

            lblQuestion.Text = "I am thinking of a number between: 0 and 10";

        }
    }
}