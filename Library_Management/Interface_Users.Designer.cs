namespace Library_Management
{
    partial class Interface_Users
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
            this.btn_Add_New_User = new System.Windows.Forms.Button();
            this.btn_Change_Password = new System.Windows.Forms.Button();
            this.btn_Forget_Password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Add_New_User
            // 
            this.btn_Add_New_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Add_New_User.BackgroundImage = global::Library_Management.Properties.Resources.New_User_Account;
            this.btn_Add_New_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add_New_User.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_User.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Add_New_User.Location = new System.Drawing.Point(302, 161);
            this.btn_Add_New_User.Name = "btn_Add_New_User";
            this.btn_Add_New_User.Size = new System.Drawing.Size(103, 196);
            this.btn_Add_New_User.TabIndex = 53;
            this.btn_Add_New_User.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Add_New_User.UseVisualStyleBackColor = false;
            this.btn_Add_New_User.Click += new System.EventHandler(this.btn_Add_New_User_Click);
            // 
            // btn_Change_Password
            // 
            this.btn_Change_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Change_Password.BackgroundImage = global::Library_Management.Properties.Resources.Change_Password;
            this.btn_Change_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Change_Password.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change_Password.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Change_Password.Location = new System.Drawing.Point(437, 161);
            this.btn_Change_Password.Name = "btn_Change_Password";
            this.btn_Change_Password.Size = new System.Drawing.Size(103, 196);
            this.btn_Change_Password.TabIndex = 54;
            this.btn_Change_Password.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Change_Password.UseVisualStyleBackColor = false;
            this.btn_Change_Password.Click += new System.EventHandler(this.btn_Change_Password_Click);
            // 
            // btn_Forget_Password
            // 
            this.btn_Forget_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Forget_Password.BackgroundImage = global::Library_Management.Properties.Resources.Foegor_Pasword;
            this.btn_Forget_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Forget_Password.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Forget_Password.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Forget_Password.Location = new System.Drawing.Point(571, 161);
            this.btn_Forget_Password.Name = "btn_Forget_Password";
            this.btn_Forget_Password.Size = new System.Drawing.Size(103, 196);
            this.btn_Forget_Password.TabIndex = 55;
            this.btn_Forget_Password.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Forget_Password.UseVisualStyleBackColor = false;
            this.btn_Forget_Password.Click += new System.EventHandler(this.btn_Forget_Password_Click);
            // 
            // Interface_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.btn_Forget_Password);
            this.Controls.Add(this.btn_Change_Password);
            this.Controls.Add(this.btn_Add_New_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interface_Users";
            this.Text = "Interface_Users";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_New_User;
        private System.Windows.Forms.Button btn_Change_Password;
        private System.Windows.Forms.Button btn_Forget_Password;
    }
}