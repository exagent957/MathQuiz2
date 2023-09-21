using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz2
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int addend1, addend2;
        int minuend, subtrahend;
        int multiplicand, multiplier;
        int dividend, divisor;
        int timeLeft;
        DateTime localDate = DateTime.Today;
        bool addPlayed = false;
        bool minusPlayed = false;
        bool timesPlayed = false;
        bool divPlayed = false;
        SoundPlayer playSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");

        public Form1()
        {
            InitializeComponent();
            todayDate.Text = localDate.ToString("dd MMM yyyy");
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
            SoundCorrect();
        }

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            plusLeft.Text = addend1.ToString();
            plusRight.Text = addend2.ToString();
            sum.Value = 0;

            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeft.Text = minuend.ToString();
            minusRight.Text = subtrahend.ToString();
            difference.Value = 0;

            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeft.Text = multiplicand.ToString();
            timesRight.Text = multiplier.ToString();
            product.Value = 0;

            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeft.Text = dividend.ToString();
            dividedRight.Text = divisor.ToString();
            quotient.Value = 0;

            // Set and Start the timer.
            timeLeft = 30;
            timeLabel.Text = timeLeft.ToString() + " seconds";
            quizTimer.Start();

            // Re-Set play sound for correct answer for each new game
             addPlayed = false;
             minusPlayed = false;
             timesPlayed = false;
             divPlayed = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        private bool SoundCorrect()
        {            
            if (addend1 + addend2 == sum.Value && !addPlayed) {playSound.Play(); return addPlayed = true;}
            else if (minuend - subtrahend == difference.Value && !minusPlayed){playSound.Play(); return minusPlayed = true;}
            else if (multiplicand * multiplier == product.Value && !timesPlayed) {playSound.Play(); return timesPlayed = true;}
            else if (dividend / divisor == quotient.Value && !divPlayed) {playSound.Play(); return divPlayed = true;}
            else { return false; }
        }

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                quizTimer.Stop();
                if (timeLeft < 6)
                {
                    timeLabel.BackColor = DefaultBackColor;
                }
                MessageBox.Show("Correct!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() returns false, keep counting down
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
                if (timeLeft < 6)
                {
                    timeLabel.BackColor = Color.IndianRed;
                }
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                quizTimer.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("Sorry, time ran out. Try Again");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                timeLabel.BackColor = DefaultBackColor;
                startButton.Enabled = true;
            }
        }


    }
}
