namespace Library_Management
{
    partial class Interface_Search
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
            this.btn_Search_Books = new System.Windows.Forms.Button();
            this.btn_Search_Specific_Book = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Search_Books
            // 
            this.btn_Search_Books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Search_Books.BackgroundImage = global::Library_Management.Properties.Resources.search_Books;
            this.btn_Search_Books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search_Books.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Books.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Search_Books.Location = new System.Drawing.Point(353, 157);
            this.btn_Search_Books.Name = "btn_Search_Books";
            this.btn_Search_Books.Size = new System.Drawing.Size(103, 196);
            this.btn_Search_Books.TabIndex = 59;
            this.btn_Search_Books.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Search_Books.UseVisualStyleBackColor = false;
            this.btn_Search_Books.Click += new System.EventHandler(this.btn_Search_Books_Click);
            // 
            // btn_Search_Specific_Book
            // 
            this.btn_Search_Specific_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Search_Specific_Book.BackgroundImage = global::Library_Management.Properties.Resources.Search_Specific_Book;
            this.btn_Search_Specific_Book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search_Specific_Book.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Specific_Book.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Search_Specific_Book.Location = new System.Drawing.Point(498, 157);
            this.btn_Search_Specific_Book.Name = "btn_Search_Specific_Book";
            this.btn_Search_Specific_Book.Size = new System.Drawing.Size(103, 196);
            this.btn_Search_Specific_Book.TabIndex = 60;
            this.btn_Search_Specific_Book.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Search_Specific_Book.UseVisualStyleBackColor = false;
            this.btn_Search_Specific_Book.Click += new System.EventHandler(this.btn_Search_Specific_Book_Click);
            // 
            // Interface_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(963, 521);
            this.Controls.Add(this.btn_Search_Specific_Book);
            this.Controls.Add(this.btn_Search_Books);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interface_Search";
            this.Text = "Interface_Search";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Search_Books;
        private System.Windows.Forms.Button btn_Search_Specific_Book;
    }
}