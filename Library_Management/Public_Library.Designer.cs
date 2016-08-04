namespace Library_Management
{
    partial class Public_Library
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
            this.Heder = new System.Windows.Forms.Panel();
            this.lbl_Back_To_Home = new System.Windows.Forms.Label();
            this.lbl_Log_Out = new System.Windows.Forms.Label();
            this.Heder.SuspendLayout();
            this.SuspendLayout();
            // 
            // Heder
            // 
            this.Heder.BackColor = System.Drawing.Color.Transparent;
            this.Heder.BackgroundImage = global::Library_Management.Properties.Resources.header;
            this.Heder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Heder.Controls.Add(this.lbl_Log_Out);
            this.Heder.Controls.Add(this.lbl_Back_To_Home);
            this.Heder.Location = new System.Drawing.Point(0, 1);
            this.Heder.Name = "Heder";
            this.Heder.Size = new System.Drawing.Size(987, 98);
            this.Heder.TabIndex = 6;
            // 
            // lbl_Back_To_Home
            // 
            this.lbl_Back_To_Home.AutoSize = true;
            this.lbl_Back_To_Home.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Back_To_Home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Back_To_Home.Location = new System.Drawing.Point(903, 55);
            this.lbl_Back_To_Home.Name = "lbl_Back_To_Home";
            this.lbl_Back_To_Home.Size = new System.Drawing.Size(48, 21);
            this.lbl_Back_To_Home.TabIndex = 7;
            this.lbl_Back_To_Home.Text = "Back";
            this.lbl_Back_To_Home.Click += new System.EventHandler(this.lbl_Back_To_Home_Click);
            // 
            // lbl_Log_Out
            // 
            this.lbl_Log_Out.AutoSize = true;
            this.lbl_Log_Out.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Log_Out.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Log_Out.Location = new System.Drawing.Point(878, 19);
            this.lbl_Log_Out.Name = "lbl_Log_Out";
            this.lbl_Log_Out.Size = new System.Drawing.Size(73, 21);
            this.lbl_Log_Out.TabIndex = 8;
            this.lbl_Log_Out.Text = "Log Out";
            this.lbl_Log_Out.Click += new System.EventHandler(this.lbl_Log_Out_Click);
            // 
            // Public_Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.Heder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Public_Library";
            this.Text = "Public_Library";
            this.Load += new System.EventHandler(this.Public_Library_Load);
            this.Heder.ResumeLayout(false);
            this.Heder.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel Heder;
        private System.Windows.Forms.Label lbl_Back_To_Home;
        private System.Windows.Forms.Label lbl_Log_Out;

    }
}



