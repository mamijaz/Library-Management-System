namespace Library_Management
{
    partial class Interface_Member
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
            this.btn_Outsid_Members = new System.Windows.Forms.Button();
            this.btn_Tax_Paying_Members = new System.Windows.Forms.Button();
            this.btn_Student_Members = new System.Windows.Forms.Button();
            this.btn_Government_Members = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Outsid_Members
            // 
            this.btn_Outsid_Members.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Outsid_Members.BackgroundImage = global::Library_Management.Properties.Resources.Member_Outsider;
            this.btn_Outsid_Members.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Outsid_Members.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Outsid_Members.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Outsid_Members.Location = new System.Drawing.Point(226, 178);
            this.btn_Outsid_Members.Name = "btn_Outsid_Members";
            this.btn_Outsid_Members.Size = new System.Drawing.Size(103, 196);
            this.btn_Outsid_Members.TabIndex = 50;
            this.btn_Outsid_Members.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Outsid_Members.UseVisualStyleBackColor = false;
            this.btn_Outsid_Members.Click += new System.EventHandler(this.btn_Outsid_Members_Click);
            // 
            // btn_Tax_Paying_Members
            // 
            this.btn_Tax_Paying_Members.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Tax_Paying_Members.BackgroundImage = global::Library_Management.Properties.Resources.Member_Tax_Payer;
            this.btn_Tax_Paying_Members.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Tax_Paying_Members.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tax_Paying_Members.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Tax_Paying_Members.Location = new System.Drawing.Point(373, 178);
            this.btn_Tax_Paying_Members.Name = "btn_Tax_Paying_Members";
            this.btn_Tax_Paying_Members.Size = new System.Drawing.Size(103, 196);
            this.btn_Tax_Paying_Members.TabIndex = 51;
            this.btn_Tax_Paying_Members.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Tax_Paying_Members.UseVisualStyleBackColor = false;
            this.btn_Tax_Paying_Members.Click += new System.EventHandler(this.btn_Tax_Paying_Members_Click);
            // 
            // btn_Student_Members
            // 
            this.btn_Student_Members.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Student_Members.BackgroundImage = global::Library_Management.Properties.Resources.Member_Student;
            this.btn_Student_Members.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Student_Members.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_Members.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Student_Members.Location = new System.Drawing.Point(516, 178);
            this.btn_Student_Members.Name = "btn_Student_Members";
            this.btn_Student_Members.Size = new System.Drawing.Size(103, 196);
            this.btn_Student_Members.TabIndex = 52;
            this.btn_Student_Members.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Student_Members.UseVisualStyleBackColor = false;
            this.btn_Student_Members.Click += new System.EventHandler(this.btn_Student_Members_Click);
            // 
            // btn_Government_Members
            // 
            this.btn_Government_Members.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Government_Members.BackgroundImage = global::Library_Management.Properties.Resources.Member_Government_Staff;
            this.btn_Government_Members.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Government_Members.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Government_Members.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Government_Members.Location = new System.Drawing.Point(669, 178);
            this.btn_Government_Members.Name = "btn_Government_Members";
            this.btn_Government_Members.Size = new System.Drawing.Size(103, 196);
            this.btn_Government_Members.TabIndex = 53;
            this.btn_Government_Members.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Government_Members.UseVisualStyleBackColor = false;
            this.btn_Government_Members.Click += new System.EventHandler(this.btn_Government_Members_Click);
            // 
            // Interface_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.btn_Government_Members);
            this.Controls.Add(this.btn_Student_Members);
            this.Controls.Add(this.btn_Tax_Paying_Members);
            this.Controls.Add(this.btn_Outsid_Members);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interface_Member";
            this.Text = "Interface_Member";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Outsid_Members;
        private System.Windows.Forms.Button btn_Tax_Paying_Members;
        private System.Windows.Forms.Button btn_Student_Members;
        private System.Windows.Forms.Button btn_Government_Members;
    }
}