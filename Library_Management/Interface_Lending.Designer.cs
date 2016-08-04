namespace Library_Management
{
    partial class Interface_Lending
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
            this.btn_Lending = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Lost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Lending
            // 
            this.btn_Lending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Lending.BackgroundImage = global::Library_Management.Properties.Resources.Book_Lendings;
            this.btn_Lending.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Lending.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lending.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Lending.Location = new System.Drawing.Point(282, 132);
            this.btn_Lending.Name = "btn_Lending";
            this.btn_Lending.Size = new System.Drawing.Size(103, 196);
            this.btn_Lending.TabIndex = 51;
            this.btn_Lending.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Lending.UseVisualStyleBackColor = false;
            this.btn_Lending.Click += new System.EventHandler(this.btn_Lending_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Return.BackgroundImage = global::Library_Management.Properties.Resources.Book_Return;
            this.btn_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Return.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Return.Location = new System.Drawing.Point(419, 132);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(103, 196);
            this.btn_Return.TabIndex = 52;
            this.btn_Return.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Lost
            // 
            this.btn_Lost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Lost.BackgroundImage = global::Library_Management.Properties.Resources.Book_Lost;
            this.btn_Lost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Lost.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lost.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Lost.Location = new System.Drawing.Point(558, 132);
            this.btn_Lost.Name = "btn_Lost";
            this.btn_Lost.Size = new System.Drawing.Size(103, 196);
            this.btn_Lost.TabIndex = 53;
            this.btn_Lost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Lost.UseVisualStyleBackColor = false;
            this.btn_Lost.Click += new System.EventHandler(this.btn_Lost_Click);
            // 
            // Interface_Lending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(963, 521);
            this.Controls.Add(this.btn_Lost);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_Lending);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interface_Lending";
            this.Text = "Interface_Lending";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Lending;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Lost;
    }
}