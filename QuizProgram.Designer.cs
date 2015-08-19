namespace Enviormental_Issues_Quiz_Program
{
    partial class QuizProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizProgram));
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_quizTake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(15, 39);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(125, 13);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Enviromental Issues Quiz";
            // 
            // btn_quizTake
            // 
            this.btn_quizTake.Location = new System.Drawing.Point(15, 65);
            this.btn_quizTake.Name = "btn_quizTake";
            this.btn_quizTake.Size = new System.Drawing.Size(125, 23);
            this.btn_quizTake.TabIndex = 1;
            this.btn_quizTake.Text = "Take the Quiz";
            this.btn_quizTake.UseVisualStyleBackColor = true;
            // 
            // QuizProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(388, 181);
            this.Controls.Add(this.btn_quizTake);
            this.Controls.Add(this.lbl_title);
            this.Name = "QuizProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviromental Issues Quiz Program";
            this.Load += new System.EventHandler(this.QuizProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_quizTake;
    }
}

