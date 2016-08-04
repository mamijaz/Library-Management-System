namespace Library_Management
{
    partial class Reset_Password
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cbo_Security_Question = new System.Windows.Forms.ComboBox();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.txt_User_Name = new System.Windows.Forms.TextBox();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.lbl_Security_Question = new System.Windows.Forms.Label();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(471, 314);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(56, 23);
            this.btn_Submit.TabIndex = 16;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // cbo_Security_Question
            // 
            this.cbo_Security_Question.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Security_Question.FormattingEnabled = true;
            this.cbo_Security_Question.Items.AddRange(new object[] {
            "What is your first school"});
            this.cbo_Security_Question.Location = new System.Drawing.Point(447, 198);
            this.cbo_Security_Question.Name = "cbo_Security_Question";
            this.cbo_Security_Question.Size = new System.Drawing.Size(263, 25);
            this.cbo_Security_Question.TabIndex = 15;
            // 
            // txt_Answer
            // 
            this.txt_Answer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Answer.Location = new System.Drawing.Point(447, 246);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(263, 25);
            this.txt_Answer.TabIndex = 14;
            // 
            // txt_User_Name
            // 
            this.txt_User_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User_Name.Location = new System.Drawing.Point(447, 148);
            this.txt_User_Name.Name = "txt_User_Name";
            this.txt_User_Name.Size = new System.Drawing.Size(263, 25);
            this.txt_User_Name.TabIndex = 13;
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Answer.Location = new System.Drawing.Point(318, 249);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(55, 17);
            this.lbl_Answer.TabIndex = 12;
            this.lbl_Answer.Text = "Answer";
            // 
            // lbl_Security_Question
            // 
            this.lbl_Security_Question.AutoSize = true;
            this.lbl_Security_Question.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Security_Question.Location = new System.Drawing.Point(318, 200);
            this.lbl_Security_Question.Name = "lbl_Security_Question";
            this.lbl_Security_Question.Size = new System.Drawing.Size(112, 17);
            this.lbl_Security_Question.TabIndex = 11;
            this.lbl_Security_Question.Text = "Security Question";
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.AutoSize = true;
            this.lbl_User_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Name.Location = new System.Drawing.Point(318, 151);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(77, 17);
            this.lbl_User_Name.TabIndex = 10;
            this.lbl_User_Name.Text = "User Name";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(342, 26);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(257, 46);
            this.lbl_Header.TabIndex = 94;
            this.lbl_Header.Text = "Reset Password";
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cbo_Security_Question);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.txt_User_Name);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.lbl_Security_Question);
            this.Controls.Add(this.lbl_User_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reset_Password";
            this.Text = "Reset_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ComboBox cbo_Security_Question;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.TextBox txt_User_Name;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.Label lbl_Security_Question;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.Label lbl_Header;
    }
}