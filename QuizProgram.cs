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
    public partial class QuizProgram : Form
    {
        public static int[] question;
        public static string[] questionDetails;
        public static int score;
        
        public QuizProgram()
        {
            InitializeComponent();
        }

        private void QuizProgram_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_quizTake_Click(object sender, EventArgs e)
        {
            Quiz openForm = new Quiz();
            openForm.ShowDialog();
        }
    }
}
