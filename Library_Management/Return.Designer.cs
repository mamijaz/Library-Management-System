namespace Library_Management
{
    partial class Return
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
            this.txt_Reciept_No = new System.Windows.Forms.TextBox();
            this.lbl_Circulation_No = new System.Windows.Forms.Label();
            this.txt_Fine_Amount = new System.Windows.Forms.TextBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.lbl_Staff_Name = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.gbo_Circulation_Details = new System.Windows.Forms.GroupBox();
            this.lbl_Staff_Name_Display = new System.Windows.Forms.Label();
            this.txt_Circulation_No = new System.Windows.Forms.TextBox();
            this.lbl_Fine_Amount = new System.Windows.Forms.Label();
            this.lbl_Return_Date = new System.Windows.Forms.Label();
            this.lbl_Receipt_No = new System.Windows.Forms.Label();
            this.dtp_Return_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Book_Id = new System.Windows.Forms.Label();
            this.lbl_Member_Id = new System.Windows.Forms.Label();
            this.lbl_Book_Catagory_No_Display = new System.Windows.Forms.Label();
            this.lbl_Lending_Date = new System.Windows.Forms.Label();
            this.lbl_Book_Id_Display = new System.Windows.Forms.Label();
            this.lbl_Book_Catagory = new System.Windows.Forms.Label();
            this.lbl_Member_Id_Display = new System.Windows.Forms.Label();
            this.lbl_Book_Title_Display = new System.Windows.Forms.Label();
            this.gbo_Return_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Lending_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Book_Title = new System.Windows.Forms.Label();
            this.dgv_Books_To_Be_Returned = new System.Windows.Forms.DataGridView();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gbo_Circulation_Details.SuspendLayout();
            this.gbo_Return_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books_To_Be_Returned)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Reciept_No
            // 
            this.txt_Reciept_No.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reciept_No.Location = new System.Drawing.Point(155, 132);
            this.txt_Reciept_No.Name = "txt_Reciept_No";
            this.txt_Reciept_No.Size = new System.Drawing.Size(100, 25);
            this.txt_Reciept_No.TabIndex = 16;
            this.txt_Reciept_No.Text = "0";
            // 
            // lbl_Circulation_No
            // 
            this.lbl_Circulation_No.AutoSize = true;
            this.lbl_Circulation_No.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Circulation_No.Location = new System.Drawing.Point(22, 40);
            this.lbl_Circulation_No.Name = "lbl_Circulation_No";
            this.lbl_Circulation_No.Size = new System.Drawing.Size(93, 17);
            this.lbl_Circulation_No.TabIndex = 0;
            this.lbl_Circulation_No.Text = "Circulation No";
            // 
            // txt_Fine_Amount
            // 
            this.txt_Fine_Amount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fine_Amount.Location = new System.Drawing.Point(155, 101);
            this.txt_Fine_Amount.Name = "txt_Fine_Amount";
            this.txt_Fine_Amount.Size = new System.Drawing.Size(100, 25);
            this.txt_Fine_Amount.TabIndex = 17;
            this.txt_Fine_Amount.Text = "0";
            this.txt_Fine_Amount.TextChanged += new System.EventHandler(this.txt_Fine_Amount_TextChanged);
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(776, 388);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 34);
            this.btn_Return.TabIndex = 30;
            this.btn_Return.Text = "Submit";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // lbl_Staff_Name
            // 
            this.lbl_Staff_Name.AutoSize = true;
            this.lbl_Staff_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Name.Location = new System.Drawing.Point(22, 170);
            this.lbl_Staff_Name.Name = "lbl_Staff_Name";
            this.lbl_Staff_Name.Size = new System.Drawing.Size(77, 17);
            this.lbl_Staff_Name.TabIndex = 11;
            this.lbl_Staff_Name.Text = "Staff Name";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(776, 337);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 36);
            this.btn_Clear.TabIndex = 28;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // gbo_Circulation_Details
            // 
            this.gbo_Circulation_Details.Controls.Add(this.lbl_Circulation_No);
            this.gbo_Circulation_Details.Controls.Add(this.lbl_Staff_Name_Display);
            this.gbo_Circulation_Details.Controls.Add(this.txt_Circulation_No);
            this.gbo_Circulation_Details.Controls.Add(this.lbl_Fine_Amount);
            this.gbo_Circulation_Details.Controls.Add(this.lbl_Return_Date);
            this.gbo_Circulation_Details.Controls.Add(this.lbl_Receipt_No);
            this.gbo_Circulation_Details.Controls.Add(this.txt_Reciept_No);
            this.gbo_Circulation_Details.Controls.Add(this.dtp_Return_Date);
            this.gbo_Circulation_Details.Controls.Add(this.txt_Fine_Amount);
            this.gbo_Circulation_Details.Controls.Add(this.lbl_Staff_Name);
            this.gbo_Circulation_Details.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Circulation_Details.Location = new System.Drawing.Point(88, 51);
            this.gbo_Circulation_Details.Name = "gbo_Circulation_Details";
            this.gbo_Circulation_Details.Size = new System.Drawing.Size(391, 199);
            this.gbo_Circulation_Details.TabIndex = 26;
            this.gbo_Circulation_Details.TabStop = false;
            this.gbo_Circulation_Details.Text = "Circulation Details";
            // 
            // lbl_Staff_Name_Display
            // 
            this.lbl_Staff_Name_Display.AutoSize = true;
            this.lbl_Staff_Name_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Name_Display.Location = new System.Drawing.Point(152, 170);
            this.lbl_Staff_Name_Display.Name = "lbl_Staff_Name_Display";
            this.lbl_Staff_Name_Display.Size = new System.Drawing.Size(36, 17);
            this.lbl_Staff_Name_Display.TabIndex = 18;
            this.lbl_Staff_Name_Display.Text = "0000";
            // 
            // txt_Circulation_No
            // 
            this.txt_Circulation_No.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Circulation_No.Location = new System.Drawing.Point(152, 35);
            this.txt_Circulation_No.Name = "txt_Circulation_No";
            this.txt_Circulation_No.Size = new System.Drawing.Size(139, 25);
            this.txt_Circulation_No.TabIndex = 19;
            this.txt_Circulation_No.TextChanged += new System.EventHandler(this.txt_Circulation_No_TextChanged);
            // 
            // lbl_Fine_Amount
            // 
            this.lbl_Fine_Amount.AutoSize = true;
            this.lbl_Fine_Amount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fine_Amount.Location = new System.Drawing.Point(23, 106);
            this.lbl_Fine_Amount.Name = "lbl_Fine_Amount";
            this.lbl_Fine_Amount.Size = new System.Drawing.Size(83, 17);
            this.lbl_Fine_Amount.TabIndex = 5;
            this.lbl_Fine_Amount.Text = "Fine Amount";
            // 
            // lbl_Return_Date
            // 
            this.lbl_Return_Date.AutoSize = true;
            this.lbl_Return_Date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Return_Date.Location = new System.Drawing.Point(22, 72);
            this.lbl_Return_Date.Name = "lbl_Return_Date";
            this.lbl_Return_Date.Size = new System.Drawing.Size(81, 17);
            this.lbl_Return_Date.TabIndex = 7;
            this.lbl_Return_Date.Text = "Return Date";
            // 
            // lbl_Receipt_No
            // 
            this.lbl_Receipt_No.AutoSize = true;
            this.lbl_Receipt_No.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Receipt_No.Location = new System.Drawing.Point(23, 141);
            this.lbl_Receipt_No.Name = "lbl_Receipt_No";
            this.lbl_Receipt_No.Size = new System.Drawing.Size(75, 17);
            this.lbl_Receipt_No.TabIndex = 8;
            this.lbl_Receipt_No.Text = "Receipt No";
            // 
            // dtp_Return_Date
            // 
            this.dtp_Return_Date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Return_Date.Location = new System.Drawing.Point(152, 66);
            this.dtp_Return_Date.Name = "dtp_Return_Date";
            this.dtp_Return_Date.Size = new System.Drawing.Size(219, 25);
            this.dtp_Return_Date.TabIndex = 10;
            // 
            // lbl_Book_Id
            // 
            this.lbl_Book_Id.AutoSize = true;
            this.lbl_Book_Id.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Id.Location = new System.Drawing.Point(22, 106);
            this.lbl_Book_Id.Name = "lbl_Book_Id";
            this.lbl_Book_Id.Size = new System.Drawing.Size(55, 17);
            this.lbl_Book_Id.TabIndex = 1;
            this.lbl_Book_Id.Text = "Book Id";
            // 
            // lbl_Member_Id
            // 
            this.lbl_Member_Id.AutoSize = true;
            this.lbl_Member_Id.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Member_Id.Location = new System.Drawing.Point(22, 40);
            this.lbl_Member_Id.Name = "lbl_Member_Id";
            this.lbl_Member_Id.Size = new System.Drawing.Size(74, 17);
            this.lbl_Member_Id.TabIndex = 3;
            this.lbl_Member_Id.Text = "Member Id";
            // 
            // lbl_Book_Catagory_No_Display
            // 
            this.lbl_Book_Catagory_No_Display.AutoSize = true;
            this.lbl_Book_Catagory_No_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Catagory_No_Display.Location = new System.Drawing.Point(149, 135);
            this.lbl_Book_Catagory_No_Display.Name = "lbl_Book_Catagory_No_Display";
            this.lbl_Book_Catagory_No_Display.Size = new System.Drawing.Size(36, 17);
            this.lbl_Book_Catagory_No_Display.TabIndex = 14;
            this.lbl_Book_Catagory_No_Display.Text = "0000";
            // 
            // lbl_Lending_Date
            // 
            this.lbl_Lending_Date.AutoSize = true;
            this.lbl_Lending_Date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lending_Date.Location = new System.Drawing.Point(22, 70);
            this.lbl_Lending_Date.Name = "lbl_Lending_Date";
            this.lbl_Lending_Date.Size = new System.Drawing.Size(88, 17);
            this.lbl_Lending_Date.TabIndex = 4;
            this.lbl_Lending_Date.Text = "Lending Date";
            // 
            // lbl_Book_Id_Display
            // 
            this.lbl_Book_Id_Display.AutoSize = true;
            this.lbl_Book_Id_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Id_Display.Location = new System.Drawing.Point(149, 106);
            this.lbl_Book_Id_Display.Name = "lbl_Book_Id_Display";
            this.lbl_Book_Id_Display.Size = new System.Drawing.Size(36, 17);
            this.lbl_Book_Id_Display.TabIndex = 13;
            this.lbl_Book_Id_Display.Text = "0000";
            // 
            // lbl_Book_Catagory
            // 
            this.lbl_Book_Catagory.AutoSize = true;
            this.lbl_Book_Catagory.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Catagory.Location = new System.Drawing.Point(22, 135);
            this.lbl_Book_Catagory.Name = "lbl_Book_Catagory";
            this.lbl_Book_Catagory.Size = new System.Drawing.Size(119, 17);
            this.lbl_Book_Catagory.TabIndex = 6;
            this.lbl_Book_Catagory.Text = "Book Catagory No";
            // 
            // lbl_Member_Id_Display
            // 
            this.lbl_Member_Id_Display.AutoSize = true;
            this.lbl_Member_Id_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Member_Id_Display.Location = new System.Drawing.Point(149, 40);
            this.lbl_Member_Id_Display.Name = "lbl_Member_Id_Display";
            this.lbl_Member_Id_Display.Size = new System.Drawing.Size(36, 17);
            this.lbl_Member_Id_Display.TabIndex = 12;
            this.lbl_Member_Id_Display.Text = "0000";
            // 
            // lbl_Book_Title_Display
            // 
            this.lbl_Book_Title_Display.AutoSize = true;
            this.lbl_Book_Title_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Title_Display.Location = new System.Drawing.Point(149, 170);
            this.lbl_Book_Title_Display.Name = "lbl_Book_Title_Display";
            this.lbl_Book_Title_Display.Size = new System.Drawing.Size(36, 17);
            this.lbl_Book_Title_Display.TabIndex = 15;
            this.lbl_Book_Title_Display.Text = "0000";
            // 
            // gbo_Return_Details
            // 
            this.gbo_Return_Details.Controls.Add(this.dtp_Lending_Date);
            this.gbo_Return_Details.Controls.Add(this.lbl_Book_Title);
            this.gbo_Return_Details.Controls.Add(this.lbl_Book_Id);
            this.gbo_Return_Details.Controls.Add(this.lbl_Member_Id);
            this.gbo_Return_Details.Controls.Add(this.lbl_Lending_Date);
            this.gbo_Return_Details.Controls.Add(this.lbl_Book_Catagory_No_Display);
            this.gbo_Return_Details.Controls.Add(this.lbl_Book_Id_Display);
            this.gbo_Return_Details.Controls.Add(this.lbl_Member_Id_Display);
            this.gbo_Return_Details.Controls.Add(this.lbl_Book_Title_Display);
            this.gbo_Return_Details.Controls.Add(this.lbl_Book_Catagory);
            this.gbo_Return_Details.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Return_Details.Location = new System.Drawing.Point(485, 51);
            this.gbo_Return_Details.Name = "gbo_Return_Details";
            this.gbo_Return_Details.Size = new System.Drawing.Size(378, 199);
            this.gbo_Return_Details.TabIndex = 27;
            this.gbo_Return_Details.TabStop = false;
            this.gbo_Return_Details.Text = "Return Details";
            // 
            // dtp_Lending_Date
            // 
            this.dtp_Lending_Date.Enabled = false;
            this.dtp_Lending_Date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Lending_Date.Location = new System.Drawing.Point(152, 64);
            this.dtp_Lending_Date.Name = "dtp_Lending_Date";
            this.dtp_Lending_Date.Size = new System.Drawing.Size(215, 25);
            this.dtp_Lending_Date.TabIndex = 19;
            // 
            // lbl_Book_Title
            // 
            this.lbl_Book_Title.AutoSize = true;
            this.lbl_Book_Title.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Title.Location = new System.Drawing.Point(22, 170);
            this.lbl_Book_Title.Name = "lbl_Book_Title";
            this.lbl_Book_Title.Size = new System.Drawing.Size(68, 17);
            this.lbl_Book_Title.TabIndex = 2;
            this.lbl_Book_Title.Text = "Book Title";
            // 
            // dgv_Books_To_Be_Returned
            // 
            this.dgv_Books_To_Be_Returned.AllowDrop = true;
            this.dgv_Books_To_Be_Returned.AllowUserToAddRows = false;
            this.dgv_Books_To_Be_Returned.AllowUserToDeleteRows = false;
            this.dgv_Books_To_Be_Returned.AllowUserToResizeRows = false;
            this.dgv_Books_To_Be_Returned.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Books_To_Be_Returned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Books_To_Be_Returned.Location = new System.Drawing.Point(88, 269);
            this.dgv_Books_To_Be_Returned.Name = "dgv_Books_To_Be_Returned";
            this.dgv_Books_To_Be_Returned.ReadOnly = true;
            this.dgv_Books_To_Be_Returned.Size = new System.Drawing.Size(668, 270);
            this.dgv_Books_To_Be_Returned.TabIndex = 31;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(395, 2);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(214, 46);
            this.lbl_Header.TabIndex = 94;
            this.lbl_Header.Text = "Book Return";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.gbo_Circulation_Details);
            this.Controls.Add(this.gbo_Return_Details);
            this.Controls.Add(this.dgv_Books_To_Be_Returned);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.gbo_Circulation_Details.ResumeLayout(false);
            this.gbo_Circulation_Details.PerformLayout();
            this.gbo_Return_Details.ResumeLayout(false);
            this.gbo_Return_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books_To_Be_Returned)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Reciept_No;
        private System.Windows.Forms.Label lbl_Circulation_No;
        private System.Windows.Forms.TextBox txt_Fine_Amount;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label lbl_Staff_Name;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox gbo_Circulation_Details;
        private System.Windows.Forms.Label lbl_Book_Id;
        private System.Windows.Forms.TextBox txt_Circulation_No;
        private System.Windows.Forms.Label lbl_Member_Id;
        private System.Windows.Forms.Label lbl_Book_Catagory_No_Display;
        private System.Windows.Forms.Label lbl_Lending_Date;
        private System.Windows.Forms.Label lbl_Book_Id_Display;
        private System.Windows.Forms.Label lbl_Book_Catagory;
        private System.Windows.Forms.Label lbl_Member_Id_Display;
        private System.Windows.Forms.Label lbl_Book_Title_Display;
        private System.Windows.Forms.GroupBox gbo_Return_Details;
        private System.Windows.Forms.Label lbl_Book_Title;
        private System.Windows.Forms.Label lbl_Fine_Amount;
        private System.Windows.Forms.Label lbl_Return_Date;
        private System.Windows.Forms.Label lbl_Receipt_No;
        private System.Windows.Forms.DateTimePicker dtp_Return_Date;
        private System.Windows.Forms.DataGridView dgv_Books_To_Be_Returned;
        private System.Windows.Forms.Label lbl_Staff_Name_Display;
        private System.Windows.Forms.DateTimePicker dtp_Lending_Date;
        private System.Windows.Forms.Label lbl_Header;
    }
}