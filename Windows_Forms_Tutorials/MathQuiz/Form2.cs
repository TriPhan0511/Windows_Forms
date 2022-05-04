using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form2 : Form
    {
        private Random randomizer = new Random();

        private int addLeftInt;
        private int addRightInt;
        private int subtractLeftInt;
        private int subtractRightInt;
        private int multiplicationLeftInt;
        private int multiplicationRightInt;
        private int divisionLeftInt;
        private int divisionRightInt;

        private int timeLeft;

        public Form2()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();

            // Start timer
            timeLeft = 20;
            timeLabel.Text = timeLeft.ToString();
            timer1.Start();
            startButton.Enabled = false;
        }

        private void StartTheQuiz()
        {
            // Addition problem
            addLeftInt = randomizer.Next(51);
            addRightInt = randomizer.Next(addLeftInt);
            addLeftLabel.Text = addLeftInt.ToString();
            addRightLabel.Text = addRightInt.ToString();
            addResult.Value = 0;

            // Subtraction problem
            subtractRightInt = randomizer.Next(51);
            subtractLeftInt = randomizer.Next(subtractLeftInt, 101);
            subtractLeftLabel.Text = subtractLeftInt.ToString();
            subtractRightLabel.Text = subtractRightInt.ToString();
            subtractResult.Value = 0;

            // Multiplication problem
            multiplicationLeftInt = randomizer.Next(11);
            multiplicationRightInt = randomizer.Next(11);
            multiplicationLeftLabel.Text = multiplicationLeftInt.ToString();
            multiplicationRightLabel.Text = multiplicationRightInt.ToString();
            multiplicationResult.Value = 0;

            // Division problem
            int quotient = randomizer.Next(10);
            divisionRightInt = randomizer.Next(20);
            divisionLeftInt = quotient * divisionRightInt;
            divisionLeftLabel.Text = divisionLeftInt.ToString();
            divisionRightLabel.Text = divisionRightInt.ToString();
            divisionResult.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                timeLabel.Text = "";
                MessageBox.Show("Correct!", "Congratulation");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Sorry!", "Time out!");
                addResult.Value = addLeftInt + addRightInt;
                subtractResult.Value = subtractLeftInt + subtractRightInt;
                multiplicationResult.Value = multiplicationLeftInt * multiplicationRightInt;
                divisionResult.Value = divisionLeftInt / divisionRightInt;
            }
        }

        private bool CheckTheAnswer()
        {
            if ((addLeftInt + addRightInt == addResult.Value)
                && (subtractLeftInt - subtractRightInt == subtractResult.Value)
                && (multiplicationLeftInt * multiplicationRightInt == multiplicationResult.Value)
                && (divisionLeftInt / divisionRightInt == divisionResult.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
