using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enviormental_Issues_Quiz_Program
{
    public partial class Quiz : Form
    {
        QuestionSelection qs = new QuestionSelection();
        int currentQuestion;
        int currentAnswer;
        int previousAnswer;
        int count = 0;
        int score = 0;
        
        public Quiz()
        {
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            QuizProgram.question = qs.selectQuestions();
            currentQuestion = QuizProgram.question[count];
            count = count + 1;
            QuizProgram.questionDetails = qs.getQuestion(currentQuestion);
            lbl_question.Text = QuizProgram.questionDetails[0];
            lbl_option1.Text = QuizProgram.questionDetails[1];
            lbl_option2.Text = QuizProgram.questionDetails[2];
            lbl_option3.Text = QuizProgram.questionDetails[3];
            lbl_option4.Text = QuizProgram.questionDetails[4];
            currentAnswer = Convert.ToInt32(QuizProgram.questionDetails[5]);
        }

        private void btn_option1_Click(object sender, EventArgs e)
        {
            if (count < 9)
            {
                previousAnswer = currentAnswer;
                currentQuestion = QuizProgram.question[count];
                count = count + 1;
                QuizProgram.questionDetails = qs.getQuestion(currentQuestion);
                lbl_question.Text = QuizProgram.questionDetails[0];
                lbl_option1.Text = QuizProgram.questionDetails[1];
                lbl_option2.Text = QuizProgram.questionDetails[2];
                lbl_option3.Text = QuizProgram.questionDetails[3];
                lbl_option4.Text = QuizProgram.questionDetails[4];
                currentAnswer = Convert.ToInt32(QuizProgram.questionDetails[5]);

                if (previousAnswer == 1)
                {
                    score = score + 1;
                    lbl_error.Text = "You have answered the previous question correctly! Your score is now " + score + "!";
                }
                else
                {
                    lbl_error.Text = "You have answered the previous question incorrectly... Your score is currently " + score + ".";
                }
            }
            else
            {
                MessageBox.Show("You have completed the quiz! Your score was " + score + "!", "Quiz Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void btn_option2_Click(object sender, EventArgs e)
        {
            if (count < 9)
            {
                previousAnswer = currentAnswer;
                currentQuestion = QuizProgram.question[count];
                count = count + 1;
                QuizProgram.questionDetails = qs.getQuestion(currentQuestion);
                lbl_question.Text = QuizProgram.questionDetails[0];
                lbl_option1.Text = QuizProgram.questionDetails[1];
                lbl_option2.Text = QuizProgram.questionDetails[2];
                lbl_option3.Text = QuizProgram.questionDetails[3];
                lbl_option4.Text = QuizProgram.questionDetails[4];
                currentAnswer = Convert.ToInt32(QuizProgram.questionDetails[5]);

                if (previousAnswer == 2)
                {
                    score = score + 1;
                    lbl_error.Text = "You have answered the previous question correctly! Your score is now " + score + "!";
                }
                else
                {
                    lbl_error.Text = "You have answered the previous question incorrectly... Your score is currently " + score + ".";
                }
            }
            else
            {
                MessageBox.Show("You have completed the quiz! Your score was " + score + "!", "Quiz Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void btn_option3_Click(object sender, EventArgs e)
        {
            if (count < 9)
            {
                previousAnswer = currentAnswer;
                currentQuestion = QuizProgram.question[count];
                count = count + 1;
                QuizProgram.questionDetails = qs.getQuestion(currentQuestion);
                lbl_question.Text = QuizProgram.questionDetails[0];
                lbl_option1.Text = QuizProgram.questionDetails[1];
                lbl_option2.Text = QuizProgram.questionDetails[2];
                lbl_option3.Text = QuizProgram.questionDetails[3];
                lbl_option4.Text = QuizProgram.questionDetails[4];
                currentAnswer = Convert.ToInt32(QuizProgram.questionDetails[5]);

                if (previousAnswer == 3)
                {
                    score = score + 1;
                    lbl_error.Text = "You have answered the previous question correctly! Your score is now " + score + "!";
                }
                else
                {
                    lbl_error.Text = "You have answered the previous question incorrectly... Your score is currently " + score + ".";
                }
            }
            else
            {
                MessageBox.Show("You have completed the quiz! Your score was " + score + "!", "Quiz Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void btn_option4_Click(object sender, EventArgs e)
        {
            if (count < 9)
            {
                previousAnswer = currentAnswer;
                currentQuestion = QuizProgram.question[count];
                count = count + 1;
                QuizProgram.questionDetails = qs.getQuestion(currentQuestion);
                lbl_question.Text = QuizProgram.questionDetails[0];
                lbl_option1.Text = QuizProgram.questionDetails[1];
                lbl_option2.Text = QuizProgram.questionDetails[2];
                lbl_option3.Text = QuizProgram.questionDetails[3];
                lbl_option4.Text = QuizProgram.questionDetails[4];
                currentAnswer = Convert.ToInt32(QuizProgram.questionDetails[5]);

                if (previousAnswer == 4)
                {
                    score = score + 1;
                    lbl_error.Text = "You have answered the previous question correctly! Your score is now " + score + "!";
                }
                else
                {
                    lbl_error.Text = "You have answered the previous question incorrectly... Your score is currently " + score + ".";
                }
            }
            else
            {
                MessageBox.Show("You have completed the quiz! Your score was " + score + "!", "Quiz Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

       
    }
}
