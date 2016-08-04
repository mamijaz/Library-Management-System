namespace Library_Management
{
    partial class Create_New_User
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
            this.cbo_NIC = new System.Windows.Forms.ComboBox();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.cbo_Security_Question = new System.Windows.Forms.ComboBox();
            this.lbl_Security_Question = new System.Windows.Forms.Label();
            this.lbl_Staff_NIC = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.txt_Confirm_Password = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_User_Name = new System.Windows.Forms.TextBox();
            this.lbl_Confirm_Password = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.lbl_User_Level = new System.Windows.Forms.Label();
            this.cbo_User_Level = new System.Windows.Forms.ComboBox();
            this.gbo_Create_New_User = new System.Windows.Forms.GroupBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gbo_Create_New_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_NIC
            // 
            this.cbo_NIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_NIC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_NIC.FormattingEnabled = true;
            this.cbo_NIC.Location = new System.Drawing.Point(159, 36);
            this.cbo_NIC.Name = "cbo_NIC";
            this.cbo_NIC.Size = new System.Drawing.Size(244, 25);
            this.cbo_NIC.TabIndex = 54;
            // 
            // txt_Answer
            // 
            this.txt_Answer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Answer.Location = new System.Drawing.Point(159, 282);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(244, 25);
            this.txt_Answer.TabIndex = 53;
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Answer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Answer.Location = new System.Drawing.Point(24, 285);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(55, 17);
            this.lbl_Answer.TabIndex = 52;
            this.lbl_Answer.Text = "Answer";
            // 
            // cbo_Security_Question
            // 
            this.cbo_Security_Question.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Security_Question.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Security_Question.FormattingEnabled = true;
            this.cbo_Security_Question.Items.AddRange(new object[] {
            "What is your first school",
            "When did you first joined he job"});
            this.cbo_Security_Question.Location = new System.Drawing.Point(159, 234);
            this.cbo_Security_Question.Name = "cbo_Security_Question";
            this.cbo_Security_Question.Size = new System.Drawing.Size(244, 25);
            this.cbo_Security_Question.TabIndex = 51;
            // 
            // lbl_Security_Question
            // 
            this.lbl_Security_Question.AutoSize = true;
            this.lbl_Security_Question.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Security_Question.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Security_Question.Location = new System.Drawing.Point(23, 233);
            this.lbl_Security_Question.Name = "lbl_Security_Question";
            this.lbl_Security_Question.Size = new System.Drawing.Size(112, 17);
            this.lbl_Security_Question.TabIndex = 50;
            this.lbl_Security_Question.Text = "Security Question";
            // 
            // lbl_Staff_NIC
            // 
            this.lbl_Staff_NIC.AutoSize = true;
            this.lbl_Staff_NIC.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Staff_NIC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_NIC.Location = new System.Drawing.Point(24, 38);
            this.lbl_Staff_NIC.Name = "lbl_Staff_NIC";
            this.lbl_Staff_NIC.Size = new System.Drawing.Size(71, 17);
            this.lbl_Staff_NIC.TabIndex = 49;
            this.lbl_Staff_NIC.Text = "Staff NIC ";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(228, 387);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 32);
            this.btn_Clear.TabIndex = 48;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(147, 387);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 32);
            this.btn_Register.TabIndex = 46;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // txt_Confirm_Password
            // 
            this.txt_Confirm_Password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Confirm_Password.Location = new System.Drawing.Point(159, 182);
            this.txt_Confirm_Password.Name = "txt_Confirm_Password";
            this.txt_Confirm_Password.PasswordChar = '*';
            this.txt_Confirm_Password.Size = new System.Drawing.Size(244, 25);
            this.txt_Confirm_Password.TabIndex = 45;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(159, 133);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(244, 25);
            this.txt_Password.TabIndex = 44;
            // 
            // txt_User_Name
            // 
            this.txt_User_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User_Name.Location = new System.Drawing.Point(159, 82);
            this.txt_User_Name.Name = "txt_User_Name";
            this.txt_User_Name.Size = new System.Drawing.Size(244, 25);
            this.txt_User_Name.TabIndex = 43;
            // 
            // lbl_Confirm_Password
            // 
            this.lbl_Confirm_Password.AutoSize = true;
            this.lbl_Confirm_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Confirm_Password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm_Password.Location = new System.Drawing.Point(23, 185);
            this.lbl_Confirm_Password.Name = "lbl_Confirm_Password";
            this.lbl_Confirm_Password.Size = new System.Drawing.Size(118, 17);
            this.lbl_Confirm_Password.TabIndex = 42;
            this.lbl_Confirm_Password.Text = "Confirm Password";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(23, 136);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(66, 17);
            this.lbl_Password.TabIndex = 41;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.AutoSize = true;
            this.lbl_User_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_User_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Name.Location = new System.Drawing.Point(23, 85);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(77, 17);
            this.lbl_User_Name.TabIndex = 40;
            this.lbl_User_Name.Text = "User Name";
            // 
            // lbl_User_Level
            // 
            this.lbl_User_Level.AutoSize = true;
            this.lbl_User_Level.BackColor = System.Drawing.Color.Transparent;
            this.lbl_User_Level.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Level.Location = new System.Drawing.Point(24, 339);
            this.lbl_User_Level.Name = "lbl_User_Level";
            this.lbl_User_Level.Size = new System.Drawing.Size(74, 17);
            this.lbl_User_Level.TabIndex = 55;
            this.lbl_User_Level.Text = "User Level";
            // 
            // cbo_User_Level
            // 
            this.cbo_User_Level.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_User_Level.FormattingEnabled = true;
            this.cbo_User_Level.Items.AddRange(new object[] {
            "Admin",
            "Lending Section",
            "Multimedia Section",
            "Reference Section",
            "Children Section",
            "Member Registration"});
            this.cbo_User_Level.Location = new System.Drawing.Point(159, 339);
            this.cbo_User_Level.Name = "cbo_User_Level";
            this.cbo_User_Level.Size = new System.Drawing.Size(244, 25);
            this.cbo_User_Level.TabIndex = 56;
            // 
            // gbo_Create_New_User
            // 
            this.gbo_Create_New_User.Controls.Add(this.cbo_User_Level);
            this.gbo_Create_New_User.Controls.Add(this.lbl_User_Level);
            this.gbo_Create_New_User.Controls.Add(this.cbo_NIC);
            this.gbo_Create_New_User.Controls.Add(this.txt_Answer);
            this.gbo_Create_New_User.Controls.Add(this.lbl_Answer);
            this.gbo_Create_New_User.Controls.Add(this.cbo_Security_Question);
            this.gbo_Create_New_User.Controls.Add(this.lbl_Security_Question);
            this.gbo_Create_New_User.Controls.Add(this.lbl_Staff_NIC);
            this.gbo_Create_New_User.Controls.Add(this.btn_Clear);
            this.gbo_Create_New_User.Controls.Add(this.btn_Register);
            this.gbo_Create_New_User.Controls.Add(this.txt_Confirm_Password);
            this.gbo_Create_New_User.Controls.Add(this.txt_Password);
            this.gbo_Create_New_User.Controls.Add(this.txt_User_Name);
            this.gbo_Create_New_User.Controls.Add(this.lbl_Confirm_Password);
            this.gbo_Create_New_User.Controls.Add(this.lbl_Password);
            this.gbo_Create_New_User.Controls.Add(this.lbl_User_Name);
            this.gbo_Create_New_User.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Create_New_User.Location = new System.Drawing.Point(265, 89);
            this.gbo_Create_New_User.Name = "gbo_Create_New_User";
            this.gbo_Create_New_User.Size = new System.Drawing.Size(428, 445);
            this.gbo_Create_New_User.TabIndex = 57;
            this.gbo_Create_New_User.TabStop = false;
            this.gbo_Create_New_User.Text = "Create New User";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(283, 20);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(406, 46);
            this.lbl_Header.TabIndex = 93;
            this.lbl_Header.Text = "Create New User Account";
            // 
            // Create_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.gbo_Create_New_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Create_New_User";
            this.Text = "Create_New_User";
            this.gbo_Create_New_User.ResumeLayout(false);
            this.gbo_Create_New_User.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_NIC;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.ComboBox cbo_Security_Question;
        private System.Windows.Forms.Label lbl_Security_Question;
        private System.Windows.Forms.Label lbl_Staff_NIC;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox txt_Confirm_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_User_Name;
        private System.Windows.Forms.Label lbl_Confirm_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.Label lbl_User_Level;
        private System.Windows.Forms.ComboBox cbo_User_Level;
        private System.Windows.Forms.GroupBox gbo_Create_New_User;
        private System.Windows.Forms.Label lbl_Header;
    }
}