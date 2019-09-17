namespace Xml_Create_Read_Update
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.listboxQuestions = new System.Windows.Forms.ListBox();
            this.listboxAnswers = new System.Windows.Forms.ListBox();
            this.btnaddQuestion = new System.Windows.Forms.Button();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.btnCreateXML = new System.Windows.Forms.Button();
            this.BtnReadXML = new System.Windows.Forms.Button();
            this.listBoxSelectedQuestions = new System.Windows.Forms.ListBox();
            this.listBoxSelectedAnswers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(124, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD QUESTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(735, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADD ANSWER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter your question here...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(597, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter your answer here...";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(8, 214);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(422, 26);
            this.txtQuestion.TabIndex = 4;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(602, 214);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(422, 26);
            this.txtAnswer.TabIndex = 5;
            // 
            // listboxQuestions
            // 
            this.listboxQuestions.FormattingEnabled = true;
            this.listboxQuestions.ItemHeight = 20;
            this.listboxQuestions.Location = new System.Drawing.Point(8, 270);
            this.listboxQuestions.Name = "listboxQuestions";
            this.listboxQuestions.Size = new System.Drawing.Size(422, 584);
            this.listboxQuestions.TabIndex = 6;
            // 
            // listboxAnswers
            // 
            this.listboxAnswers.FormattingEnabled = true;
            this.listboxAnswers.ItemHeight = 20;
            this.listboxAnswers.Location = new System.Drawing.Point(602, 270);
            this.listboxAnswers.Name = "listboxAnswers";
            this.listboxAnswers.Size = new System.Drawing.Size(422, 584);
            this.listboxAnswers.TabIndex = 7;
            // 
            // btnaddQuestion
            // 
            this.btnaddQuestion.Location = new System.Drawing.Point(285, 138);
            this.btnaddQuestion.Name = "btnaddQuestion";
            this.btnaddQuestion.Size = new System.Drawing.Size(155, 56);
            this.btnaddQuestion.TabIndex = 8;
            this.btnaddQuestion.Text = "Add Question";
            this.btnaddQuestion.UseVisualStyleBackColor = true;
            this.btnaddQuestion.Click += new System.EventHandler(this.btnaddQuestion_Click);
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Location = new System.Drawing.Point(856, 138);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(168, 56);
            this.btnAddAnswer.TabIndex = 9;
            this.btnAddAnswer.Text = "Add Answer";
            this.btnAddAnswer.UseVisualStyleBackColor = true;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
            // 
            // btnCreateXML
            // 
            this.btnCreateXML.Location = new System.Drawing.Point(448, 401);
            this.btnCreateXML.Name = "btnCreateXML";
            this.btnCreateXML.Size = new System.Drawing.Size(128, 162);
            this.btnCreateXML.TabIndex = 10;
            this.btnCreateXML.Text = "Create XML";
            this.btnCreateXML.UseVisualStyleBackColor = true;
            this.btnCreateXML.Click += new System.EventHandler(this.BtnXML_Click);
            // 
            // BtnReadXML
            // 
            this.BtnReadXML.Location = new System.Drawing.Point(448, 582);
            this.BtnReadXML.Name = "BtnReadXML";
            this.BtnReadXML.Size = new System.Drawing.Size(128, 162);
            this.BtnReadXML.TabIndex = 11;
            this.BtnReadXML.Text = "Read from XML";
            this.BtnReadXML.UseVisualStyleBackColor = true;
            this.BtnReadXML.Click += new System.EventHandler(this.BtnReadXML_Click);
            // 
            // listBoxSelectedQuestions
            // 
            this.listBoxSelectedQuestions.FormattingEnabled = true;
            this.listBoxSelectedQuestions.ItemHeight = 20;
            this.listBoxSelectedQuestions.Location = new System.Drawing.Point(1069, 270);
            this.listBoxSelectedQuestions.Name = "listBoxSelectedQuestions";
            this.listBoxSelectedQuestions.Size = new System.Drawing.Size(333, 584);
            this.listBoxSelectedQuestions.TabIndex = 12;
            // 
            // listBoxSelectedAnswers
            // 
            this.listBoxSelectedAnswers.FormattingEnabled = true;
            this.listBoxSelectedAnswers.ItemHeight = 20;
            this.listBoxSelectedAnswers.Location = new System.Drawing.Point(1434, 270);
            this.listBoxSelectedAnswers.Name = "listBoxSelectedAnswers";
            this.listBoxSelectedAnswers.Size = new System.Drawing.Size(333, 584);
            this.listBoxSelectedAnswers.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1076, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Selected Questions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1443, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Selected Answers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1271, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(429, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = "SELECTED INFORMATIONS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1774, 869);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxSelectedAnswers);
            this.Controls.Add(this.listBoxSelectedQuestions);
            this.Controls.Add(this.BtnReadXML);
            this.Controls.Add(this.btnCreateXML);
            this.Controls.Add(this.btnAddAnswer);
            this.Controls.Add(this.btnaddQuestion);
            this.Controls.Add(this.listboxAnswers);
            this.Controls.Add(this.listboxQuestions);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.ListBox listboxQuestions;
        private System.Windows.Forms.ListBox listboxAnswers;
        private System.Windows.Forms.Button btnaddQuestion;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.Button btnCreateXML;
        private System.Windows.Forms.Button BtnReadXML;
        private System.Windows.Forms.ListBox listBoxSelectedQuestions;
        private System.Windows.Forms.ListBox listBoxSelectedAnswers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

