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
        
        public Quiz()
        {
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            QuizProgram.question = qs.selectQuestions();
        }
    }
}
