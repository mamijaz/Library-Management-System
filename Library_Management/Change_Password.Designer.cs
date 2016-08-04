namespace Library_Management
{
    partial class Change_Password
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
            this.txt_User_Name = new System.Windows.Forms.TextBox();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.txt_Confirm_New_Password = new System.Windows.Forms.TextBox();
            this.txt_New_Password = new System.Windows.Forms.TextBox();
            this.txt_Old_Password = new System.Windows.Forms.TextBox();
            this.lbl_Confirm_New_Password = new System.Windows.Forms.Label();
            this.lbl_New_Password = new System.Windows.Forms.Label();
            this.lbl_Old_Password = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_User_Name
            // 
            this.txt_User_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User_Name.Location = new System.Drawing.Point(461, 151);
            this.txt_User_Name.Name = "txt_User_Name";
            this.txt_User_Name.Size = new System.Drawing.Size(146, 25);
            this.txt_User_Name.TabIndex = 17;
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.AutoSize = true;
            this.lbl_User_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Name.Location = new System.Drawing.Point(295, 158);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(77, 17);
            this.lbl_User_Name.TabIndex = 16;
            this.lbl_User_Name.Text = "User Name";
            // 
            // btn_Change
            // 
            this.btn_Change.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.Location = new System.Drawing.Point(419, 341);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 15;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // txt_Confirm_New_Password
            // 
            this.txt_Confirm_New_Password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Confirm_New_Password.Location = new System.Drawing.Point(461, 292);
            this.txt_Confirm_New_Password.Name = "txt_Confirm_New_Password";
            this.txt_Confirm_New_Password.PasswordChar = '*';
            this.txt_Confirm_New_Password.Size = new System.Drawing.Size(146, 25);
            this.txt_Confirm_New_Password.TabIndex = 14;
            // 
            // txt_New_Password
            // 
            this.txt_New_Password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_New_Password.Location = new System.Drawing.Point(461, 244);
            this.txt_New_Password.Name = "txt_New_Password";
            this.txt_New_Password.PasswordChar = '*';
            this.txt_New_Password.Size = new System.Drawing.Size(146, 25);
            this.txt_New_Password.TabIndex = 13;
            // 
            // txt_Old_Password
            // 
            this.txt_Old_Password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Old_Password.Location = new System.Drawing.Point(461, 198);
            this.txt_Old_Password.Name = "txt_Old_Password";
            this.txt_Old_Password.PasswordChar = '*';
            this.txt_Old_Password.Size = new System.Drawing.Size(146, 25);
            this.txt_Old_Password.TabIndex = 12;
            // 
            // lbl_Confirm_New_Password
            // 
            this.lbl_Confirm_New_Password.AutoSize = true;
            this.lbl_Confirm_New_Password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm_New_Password.Location = new System.Drawing.Point(294, 295);
            this.lbl_Confirm_New_Password.Name = "lbl_Confirm_New_Password";
            this.lbl_Confirm_New_Password.Size = new System.Drawing.Size(151, 17);
            this.lbl_Confirm_New_Password.TabIndex = 11;
            this.lbl_Confirm_New_Password.Text = "New Confirm Password";
            // 
            // lbl_New_Password
            // 
            this.lbl_New_Password.AutoSize = true;
            this.lbl_New_Password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Password.Location = new System.Drawing.Point(294, 247);
            this.lbl_New_Password.Name = "lbl_New_Password";
            this.lbl_New_Password.Size = new System.Drawing.Size(103, 17);
            this.lbl_New_Password.TabIndex = 10;
            this.lbl_New_Password.Text = "New Password ";
            // 
            // lbl_Old_Password
            // 
            this.lbl_Old_Password.AutoSize = true;
            this.lbl_Old_Password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Old_Password.Location = new System.Drawing.Point(294, 201);
            this.lbl_Old_Password.Name = "lbl_Old_Password";
            this.lbl_Old_Password.Size = new System.Drawing.Size(91, 17);
            this.lbl_Old_Password.TabIndex = 9;
            this.lbl_Old_Password.Text = "Old Password";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(331, 23);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(291, 46);
            this.lbl_Header.TabIndex = 93;
            this.lbl_Header.Text = "Change Password";
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.txt_User_Name);
            this.Controls.Add(this.lbl_User_Name);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.txt_Confirm_New_Password);
            this.Controls.Add(this.txt_New_Password);
            this.Controls.Add(this.txt_Old_Password);
            this.Controls.Add(this.lbl_Confirm_New_Password);
            this.Controls.Add(this.lbl_New_Password);
            this.Controls.Add(this.lbl_Old_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Change_Password";
            this.Text = "Change_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_User_Name;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.TextBox txt_Confirm_New_Password;
        private System.Windows.Forms.TextBox txt_New_Password;
        private System.Windows.Forms.TextBox txt_Old_Password;
        private System.Windows.Forms.Label lbl_Confirm_New_Password;
        private System.Windows.Forms.Label lbl_New_Password;
        private System.Windows.Forms.Label lbl_Old_Password;
        private System.Windows.Forms.Label lbl_Header;
    }
}