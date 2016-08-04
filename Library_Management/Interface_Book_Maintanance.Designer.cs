namespace Library_Management
{
    partial class Interface_Book_Maintanance
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
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_Catagory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Book
            // 
            this.btn_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Book.BackgroundImage = global::Library_Management.Properties.Resources.Book_Manege;
            this.btn_Book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Book.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Book.Location = new System.Drawing.Point(347, 150);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(103, 196);
            this.btn_Book.TabIndex = 56;
            this.btn_Book.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Book.UseVisualStyleBackColor = false;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // btn_Catagory
            // 
            this.btn_Catagory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Catagory.BackgroundImage = global::Library_Management.Properties.Resources.Book_Catagorys;
            this.btn_Catagory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Catagory.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Catagory.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Catagory.Location = new System.Drawing.Point(486, 150);
            this.btn_Catagory.Name = "btn_Catagory";
            this.btn_Catagory.Size = new System.Drawing.Size(103, 196);
            this.btn_Catagory.TabIndex = 57;
            this.btn_Catagory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Catagory.UseVisualStyleBackColor = false;
            this.btn_Catagory.Click += new System.EventHandler(this.btn_Catagory_Click);
            // 
            // Interface_Book_Maintanance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(963, 521);
            this.Controls.Add(this.btn_Catagory);
            this.Controls.Add(this.btn_Book);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interface_Book_Maintanance";
            this.Text = "Interface_Book_Maintanance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_Catagory;
    }
}