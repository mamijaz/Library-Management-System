namespace Library_Management
{
    partial class Lending
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
            this.dgv_Member = new System.Windows.Forms.DataGridView();
            this.lbl_Satatus_Display = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.gbo_Member_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Membership_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Membership_Date = new System.Windows.Forms.Label();
            this.lbl_Book_Author_Display = new System.Windows.Forms.Label();
            this.lbl_Book_Author = new System.Windows.Forms.Label();
            this.lbl_Bool_Title_Display = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.gbo_Book = new System.Windows.Forms.GroupBox();
            this.lbl_Book_Section_Display = new System.Windows.Forms.Label();
            this.lbl_Book_Section = new System.Windows.Forms.Label();
            this.lbl_Catagory_Number_Display = new System.Windows.Forms.Label();
            this.txt_Member_Id = new System.Windows.Forms.TextBox();
            this.txt_Book_Id = new System.Windows.Forms.TextBox();
            this.lbl_Book_Catagory_No = new System.Windows.Forms.Label();
            this.lbl_Member_Id = new System.Windows.Forms.Label();
            this.lbl_Lending_Date = new System.Windows.Forms.Label();
            this.lbl_Book_Id = new System.Windows.Forms.Label();
            this.lbl_Circulation_No = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Circulation_No_Display = new System.Windows.Forms.Label();
            this.gbo_Book_Lending = new System.Windows.Forms.GroupBox();
            this.dtp_Lending_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Member)).BeginInit();
            this.gbo_Member_Details.SuspendLayout();
            this.gbo_Book.SuspendLayout();
            this.gbo_Book_Lending.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Member
            // 
            this.dgv_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Member.Location = new System.Drawing.Point(65, 275);
            this.dgv_Member.Name = "dgv_Member";
            this.dgv_Member.ReadOnly = true;
            this.dgv_Member.Size = new System.Drawing.Size(745, 257);
            this.dgv_Member.TabIndex = 25;
            // 
            // lbl_Satatus_Display
            // 
            this.lbl_Satatus_Display.AutoSize = true;
            this.lbl_Satatus_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Satatus_Display.Location = new System.Drawing.Point(174, 59);
            this.lbl_Satatus_Display.Name = "lbl_Satatus_Display";
            this.lbl_Satatus_Display.Size = new System.Drawing.Size(36, 17);
            this.lbl_Satatus_Display.TabIndex = 3;
            this.lbl_Satatus_Display.Text = "0000";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(22, 59);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(121, 17);
            this.lbl_Status.TabIndex = 2;
            this.lbl_Status.Text = "Membership Status";
            // 
            // gbo_Member_Details
            // 
            this.gbo_Member_Details.Controls.Add(this.dtp_Membership_Date);
            this.gbo_Member_Details.Controls.Add(this.lbl_Membership_Date);
            this.gbo_Member_Details.Controls.Add(this.lbl_Satatus_Display);
            this.gbo_Member_Details.Controls.Add(this.lbl_Status);
            this.gbo_Member_Details.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Member_Details.Location = new System.Drawing.Point(482, 168);
            this.gbo_Member_Details.Name = "gbo_Member_Details";
            this.gbo_Member_Details.Size = new System.Drawing.Size(434, 88);
            this.gbo_Member_Details.TabIndex = 21;
            this.gbo_Member_Details.TabStop = false;
            this.gbo_Member_Details.Text = "Member Details";
            // 
            // dtp_Membership_Date
            // 
            this.dtp_Membership_Date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Membership_Date.Location = new System.Drawing.Point(173, 24);
            this.dtp_Membership_Date.Name = "dtp_Membership_Date";
            this.dtp_Membership_Date.Size = new System.Drawing.Size(212, 25);
            this.dtp_Membership_Date.TabIndex = 18;
            // 
            // lbl_Membership_Date
            // 
            this.lbl_Membership_Date.AutoSize = true;
            this.lbl_Membership_Date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Membership_Date.Location = new System.Drawing.Point(23, 28);
            this.lbl_Membership_Date.Name = "lbl_Membership_Date";
            this.lbl_Membership_Date.Size = new System.Drawing.Size(114, 17);
            this.lbl_Membership_Date.TabIndex = 4;
            this.lbl_Membership_Date.Text = "Membership Date";
            // 
            // lbl_Book_Author_Display
            // 
            this.lbl_Book_Author_Display.AutoSize = true;
            this.lbl_Book_Author_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Author_Display.Location = new System.Drawing.Point(175, 56);
            this.lbl_Book_Author_Display.Name = "lbl_Book_Author_Display";
            this.lbl_Book_Author_Display.Size = new System.Drawing.Size(36, 17);
            this.lbl_Book_Author_Display.TabIndex = 3;
            this.lbl_Book_Author_Display.Text = "0000";
            // 
            // lbl_Book_Author
            // 
            this.lbl_Book_Author.AutoSize = true;
            this.lbl_Book_Author.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Author.Location = new System.Drawing.Point(22, 53);
            this.lbl_Book_Author.Name = "lbl_Book_Author";
            this.lbl_Book_Author.Size = new System.Drawing.Size(83, 17);
            this.lbl_Book_Author.TabIndex = 2;
            this.lbl_Book_Author.Text = "Book Author";
            // 
            // lbl_Bool_Title_Display
            // 
            this.lbl_Bool_Title_Display.AutoSize = true;
            this.lbl_Bool_Title_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bool_Title_Display.Location = new System.Drawing.Point(174, 27);
            this.lbl_Bool_Title_Display.Name = "lbl_Bool_Title_Display";
            this.lbl_Bool_Title_Display.Size = new System.Drawing.Size(36, 17);
            this.lbl_Bool_Title_Display.TabIndex = 1;
            this.lbl_Bool_Title_Display.Text = "0000";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(23, 27);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(68, 17);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Book Title";
            // 
            // gbo_Book
            // 
            this.gbo_Book.Controls.Add(this.lbl_Book_Section_Display);
            this.gbo_Book.Controls.Add(this.lbl_Book_Section);
            this.gbo_Book.Controls.Add(this.lbl_Book_Author_Display);
            this.gbo_Book.Controls.Add(this.lbl_Book_Author);
            this.gbo_Book.Controls.Add(this.lbl_Bool_Title_Display);
            this.gbo_Book.Controls.Add(this.lbl_Title);
            this.gbo_Book.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Book.Location = new System.Drawing.Point(482, 50);
            this.gbo_Book.Name = "gbo_Book";
            this.gbo_Book.Size = new System.Drawing.Size(434, 119);
            this.gbo_Book.TabIndex = 20;
            this.gbo_Book.TabStop = false;
            this.gbo_Book.Text = "Book Detatils";
            // 
            // lbl_Book_Section_Display
            // 
            this.lbl_Book_Section_Display.AutoSize = true;
            this.lbl_Book_Section_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Section_Display.Location = new System.Drawing.Point(175, 81);
            this.lbl_Book_Section_Display.Name = "lbl_Book_Section_Display";
            this.lbl_Book_Section_Display.Size = new System.Drawing.Size(36, 17);
            this.lbl_Book_Section_Display.TabIndex = 5;
            this.lbl_Book_Section_Display.Text = "0000";
            // 
            // lbl_Book_Section
            // 
            this.lbl_Book_Section.AutoSize = true;
            this.lbl_Book_Section.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Section.Location = new System.Drawing.Point(23, 81);
            this.lbl_Book_Section.Name = "lbl_Book_Section";
            this.lbl_Book_Section.Size = new System.Drawing.Size(86, 17);
            this.lbl_Book_Section.TabIndex = 4;
            this.lbl_Book_Section.Text = "Book Section";
            // 
            // lbl_Catagory_Number_Display
            // 
            this.lbl_Catagory_Number_Display.AutoSize = true;
            this.lbl_Catagory_Number_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Catagory_Number_Display.Location = new System.Drawing.Point(132, 96);
            this.lbl_Catagory_Number_Display.Name = "lbl_Catagory_Number_Display";
            this.lbl_Catagory_Number_Display.Size = new System.Drawing.Size(36, 17);
            this.lbl_Catagory_Number_Display.TabIndex = 16;
            this.lbl_Catagory_Number_Display.Text = "0000";
            // 
            // txt_Member_Id
            // 
            this.txt_Member_Id.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Member_Id.Location = new System.Drawing.Point(135, 122);
            this.txt_Member_Id.Name = "txt_Member_Id";
            this.txt_Member_Id.Size = new System.Drawing.Size(200, 25);
            this.txt_Member_Id.TabIndex = 8;
            this.txt_Member_Id.TextChanged += new System.EventHandler(this.txt_Member_Id_TextChanged);
            // 
            // txt_Book_Id
            // 
            this.txt_Book_Id.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Book_Id.Location = new System.Drawing.Point(135, 56);
            this.txt_Book_Id.Name = "txt_Book_Id";
            this.txt_Book_Id.Size = new System.Drawing.Size(200, 25);
            this.txt_Book_Id.TabIndex = 6;
            this.txt_Book_Id.TextChanged += new System.EventHandler(this.txt_Book_Id_TextChanged);
            // 
            // lbl_Book_Catagory_No
            // 
            this.lbl_Book_Catagory_No.AutoSize = true;
            this.lbl_Book_Catagory_No.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Catagory_No.Location = new System.Drawing.Point(7, 96);
            this.lbl_Book_Catagory_No.Name = "lbl_Book_Catagory_No";
            this.lbl_Book_Catagory_No.Size = new System.Drawing.Size(122, 17);
            this.lbl_Book_Catagory_No.TabIndex = 4;
            this.lbl_Book_Catagory_No.Text = "Book Catagory No:";
            // 
            // lbl_Member_Id
            // 
            this.lbl_Member_Id.AutoSize = true;
            this.lbl_Member_Id.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Member_Id.Location = new System.Drawing.Point(11, 130);
            this.lbl_Member_Id.Name = "lbl_Member_Id";
            this.lbl_Member_Id.Size = new System.Drawing.Size(77, 17);
            this.lbl_Member_Id.TabIndex = 3;
            this.lbl_Member_Id.Text = "Member Id:";
            // 
            // lbl_Lending_Date
            // 
            this.lbl_Lending_Date.AutoSize = true;
            this.lbl_Lending_Date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lending_Date.Location = new System.Drawing.Point(12, 161);
            this.lbl_Lending_Date.Name = "lbl_Lending_Date";
            this.lbl_Lending_Date.Size = new System.Drawing.Size(91, 17);
            this.lbl_Lending_Date.TabIndex = 2;
            this.lbl_Lending_Date.Text = "Lending Date:";
            // 
            // lbl_Book_Id
            // 
            this.lbl_Book_Id.AutoSize = true;
            this.lbl_Book_Id.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Id.Location = new System.Drawing.Point(7, 64);
            this.lbl_Book_Id.Name = "lbl_Book_Id";
            this.lbl_Book_Id.Size = new System.Drawing.Size(58, 17);
            this.lbl_Book_Id.TabIndex = 1;
            this.lbl_Book_Id.Text = "Book Id:";
            // 
            // lbl_Circulation_No
            // 
            this.lbl_Circulation_No.AutoSize = true;
            this.lbl_Circulation_No.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Circulation_No.Location = new System.Drawing.Point(7, 31);
            this.lbl_Circulation_No.Name = "lbl_Circulation_No";
            this.lbl_Circulation_No.Size = new System.Drawing.Size(96, 17);
            this.lbl_Circulation_No.TabIndex = 0;
            this.lbl_Circulation_No.Text = "Circulation No:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(835, 340);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(81, 38);
            this.btn_Clear.TabIndex = 23;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(835, 393);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(81, 38);
            this.btn_Submit.TabIndex = 22;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Circulation_No_Display
            // 
            this.lbl_Circulation_No_Display.AutoSize = true;
            this.lbl_Circulation_No_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Circulation_No_Display.Location = new System.Drawing.Point(132, 31);
            this.lbl_Circulation_No_Display.Name = "lbl_Circulation_No_Display";
            this.lbl_Circulation_No_Display.Size = new System.Drawing.Size(43, 17);
            this.lbl_Circulation_No_Display.TabIndex = 15;
            this.lbl_Circulation_No_Display.Text = "00000";
            // 
            // gbo_Book_Lending
            // 
            this.gbo_Book_Lending.Controls.Add(this.dtp_Lending_Date);
            this.gbo_Book_Lending.Controls.Add(this.lbl_Catagory_Number_Display);
            this.gbo_Book_Lending.Controls.Add(this.lbl_Circulation_No_Display);
            this.gbo_Book_Lending.Controls.Add(this.txt_Member_Id);
            this.gbo_Book_Lending.Controls.Add(this.txt_Book_Id);
            this.gbo_Book_Lending.Controls.Add(this.lbl_Book_Catagory_No);
            this.gbo_Book_Lending.Controls.Add(this.lbl_Member_Id);
            this.gbo_Book_Lending.Controls.Add(this.lbl_Lending_Date);
            this.gbo_Book_Lending.Controls.Add(this.lbl_Book_Id);
            this.gbo_Book_Lending.Controls.Add(this.lbl_Circulation_No);
            this.gbo_Book_Lending.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Book_Lending.Location = new System.Drawing.Point(65, 51);
            this.gbo_Book_Lending.Name = "gbo_Book_Lending";
            this.gbo_Book_Lending.Size = new System.Drawing.Size(395, 205);
            this.gbo_Book_Lending.TabIndex = 19;
            this.gbo_Book_Lending.TabStop = false;
            this.gbo_Book_Lending.Text = "Book Lending";
            // 
            // dtp_Lending_Date
            // 
            this.dtp_Lending_Date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Lending_Date.Location = new System.Drawing.Point(135, 155);
            this.dtp_Lending_Date.Name = "dtp_Lending_Date";
            this.dtp_Lending_Date.Size = new System.Drawing.Size(236, 25);
            this.dtp_Lending_Date.TabIndex = 17;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(339, 1);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(234, 46);
            this.lbl_Header.TabIndex = 93;
            this.lbl_Header.Text = "Book Lending";
            // 
            // Lending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.dgv_Member);
            this.Controls.Add(this.gbo_Member_Details);
            this.Controls.Add(this.gbo_Book);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.gbo_Book_Lending);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lending";
            this.Text = "Lending";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Member)).EndInit();
            this.gbo_Member_Details.ResumeLayout(false);
            this.gbo_Member_Details.PerformLayout();
            this.gbo_Book.ResumeLayout(false);
            this.gbo_Book.PerformLayout();
            this.gbo_Book_Lending.ResumeLayout(false);
            this.gbo_Book_Lending.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Member;
        private System.Windows.Forms.Label lbl_Satatus_Display;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.GroupBox gbo_Member_Details;
        private System.Windows.Forms.Label lbl_Book_Author_Display;
        private System.Windows.Forms.Label lbl_Book_Author;
        private System.Windows.Forms.Label lbl_Bool_Title_Display;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox gbo_Book;
        private System.Windows.Forms.Label lbl_Catagory_Number_Display;
        private System.Windows.Forms.TextBox txt_Member_Id;
        private System.Windows.Forms.TextBox txt_Book_Id;
        private System.Windows.Forms.Label lbl_Book_Catagory_No;
        private System.Windows.Forms.Label lbl_Member_Id;
        private System.Windows.Forms.Label lbl_Lending_Date;
        private System.Windows.Forms.Label lbl_Book_Id;
        private System.Windows.Forms.Label lbl_Circulation_No;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Circulation_No_Display;
        private System.Windows.Forms.GroupBox gbo_Book_Lending;
        private System.Windows.Forms.DateTimePicker dtp_Lending_Date;
        private System.Windows.Forms.Label lbl_Book_Section_Display;
        private System.Windows.Forms.Label lbl_Book_Section;
        private System.Windows.Forms.DateTimePicker dtp_Membership_Date;
        private System.Windows.Forms.Label lbl_Membership_Date;
        private System.Windows.Forms.Label lbl_Header;
    }
}