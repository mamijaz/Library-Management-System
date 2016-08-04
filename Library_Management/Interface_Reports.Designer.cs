namespace Library_Management
{
    partial class Interface_Reports
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
            this.btn_Report_On_Books = new System.Windows.Forms.Button();
            this.btn_Reports_On_Transaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Report_On_Books
            // 
            this.btn_Report_On_Books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Report_On_Books.BackgroundImage = global::Library_Management.Properties.Resources.book_reports;
            this.btn_Report_On_Books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Report_On_Books.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report_On_Books.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Report_On_Books.Location = new System.Drawing.Point(371, 146);
            this.btn_Report_On_Books.Name = "btn_Report_On_Books";
            this.btn_Report_On_Books.Size = new System.Drawing.Size(103, 196);
            this.btn_Report_On_Books.TabIndex = 54;
            this.btn_Report_On_Books.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Report_On_Books.UseVisualStyleBackColor = false;
            this.btn_Report_On_Books.Click += new System.EventHandler(this.btn_Report_On_Books_Click);
            // 
            // btn_Reports_On_Transaction
            // 
            this.btn_Reports_On_Transaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Reports_On_Transaction.BackgroundImage = global::Library_Management.Properties.Resources.tansaction_reports;
            this.btn_Reports_On_Transaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Reports_On_Transaction.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports_On_Transaction.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Reports_On_Transaction.Location = new System.Drawing.Point(518, 146);
            this.btn_Reports_On_Transaction.Name = "btn_Reports_On_Transaction";
            this.btn_Reports_On_Transaction.Size = new System.Drawing.Size(103, 196);
            this.btn_Reports_On_Transaction.TabIndex = 55;
            this.btn_Reports_On_Transaction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Reports_On_Transaction.UseVisualStyleBackColor = false;
            this.btn_Reports_On_Transaction.Click += new System.EventHandler(this.btn_Reports_On_Transaction_Click);
            // 
            // Interface_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.btn_Reports_On_Transaction);
            this.Controls.Add(this.btn_Report_On_Books);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interface_Reports";
            this.Text = "Interface_Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Report_On_Books;
        private System.Windows.Forms.Button btn_Reports_On_Transaction;
    }
}