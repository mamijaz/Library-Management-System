namespace Library_Management
{
    partial class Books
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
            this.btn_Update_Book = new System.Windows.Forms.Button();
            this.btn_Add_Book = new System.Windows.Forms.Button();
            this.cbo_Book_Source = new System.Windows.Forms.ComboBox();
            this.lbl_Book_Source = new System.Windows.Forms.Label();
            this.txt_No_Of_Pages = new System.Windows.Forms.TextBox();
            this.txt_Book_Price = new System.Windows.Forms.TextBox();
            this.txt_Book_Publisher_Place = new System.Windows.Forms.TextBox();
            this.txt_Book_Publisher = new System.Windows.Forms.TextBox();
            this.dtp_Date_Book_Recived = new System.Windows.Forms.DateTimePicker();
            this.txt_Book_Author = new System.Windows.Forms.TextBox();
            this.txt_Book_Title = new System.Windows.Forms.TextBox();
            this.cbo_Book_Section = new System.Windows.Forms.ComboBox();
            this.Cbo_Catagory_No = new System.Windows.Forms.ComboBox();
            this.txt_Book_Id = new System.Windows.Forms.TextBox();
            this.No_of_Pages = new System.Windows.Forms.Label();
            this.Book_Recived_Date = new System.Windows.Forms.Label();
            this.Book_Publisher = new System.Windows.Forms.Label();
            this.Book_Author = new System.Windows.Forms.Label();
            this.Book_Publish_place = new System.Windows.Forms.Label();
            this.Book_Price = new System.Windows.Forms.Label();
            this.Book_Section = new System.Windows.Forms.Label();
            this.Book_Title = new System.Windows.Forms.Label();
            this.Book_Catagory_No = new System.Windows.Forms.Label();
            this.lbl_Book_Id = new System.Windows.Forms.Label();
            this.gbo_Book_Basic = new System.Windows.Forms.GroupBox();
            this.gbo_Book_Maintanance = new System.Windows.Forms.GroupBox();
            this.btn_Genarate = new System.Windows.Forms.Button();
            this.dgv_Books = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gbo_Book_Basic.SuspendLayout();
            this.gbo_Book_Maintanance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Update_Book
            // 
            this.btn_Update_Book.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Book.Location = new System.Drawing.Point(178, 264);
            this.btn_Update_Book.Name = "btn_Update_Book";
            this.btn_Update_Book.Size = new System.Drawing.Size(75, 23);
            this.btn_Update_Book.TabIndex = 71;
            this.btn_Update_Book.Text = "Update Book";
            this.btn_Update_Book.UseVisualStyleBackColor = true;
            this.btn_Update_Book.Click += new System.EventHandler(this.btn_Update_Book_Click_1);
            // 
            // btn_Add_Book
            // 
            this.btn_Add_Book.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Book.Location = new System.Drawing.Point(85, 264);
            this.btn_Add_Book.Name = "btn_Add_Book";
            this.btn_Add_Book.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_Book.TabIndex = 70;
            this.btn_Add_Book.Text = "Insert";
            this.btn_Add_Book.UseVisualStyleBackColor = true;
            this.btn_Add_Book.Click += new System.EventHandler(this.btn_Add_Book_Click);
            // 
            // cbo_Book_Source
            // 
            this.cbo_Book_Source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Book_Source.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Book_Source.FormattingEnabled = true;
            this.cbo_Book_Source.Items.AddRange(new object[] {
            "Municiple Council",
            "Public Donation",
            "Private Donation"});
            this.cbo_Book_Source.Location = new System.Drawing.Point(141, 127);
            this.cbo_Book_Source.Name = "cbo_Book_Source";
            this.cbo_Book_Source.Size = new System.Drawing.Size(144, 27);
            this.cbo_Book_Source.TabIndex = 69;
            // 
            // lbl_Book_Source
            // 
            this.lbl_Book_Source.AutoSize = true;
            this.lbl_Book_Source.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Source.Location = new System.Drawing.Point(8, 130);
            this.lbl_Book_Source.Name = "lbl_Book_Source";
            this.lbl_Book_Source.Size = new System.Drawing.Size(90, 19);
            this.lbl_Book_Source.TabIndex = 68;
            this.lbl_Book_Source.Text = "Book Source";
            // 
            // txt_No_Of_Pages
            // 
            this.txt_No_Of_Pages.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_No_Of_Pages.Location = new System.Drawing.Point(156, 155);
            this.txt_No_Of_Pages.Name = "txt_No_Of_Pages";
            this.txt_No_Of_Pages.Size = new System.Drawing.Size(205, 26);
            this.txt_No_Of_Pages.TabIndex = 67;
            this.txt_No_Of_Pages.TextChanged += new System.EventHandler(this.txt_No_Of_Pages_TextChanged);
            // 
            // txt_Book_Price
            // 
            this.txt_Book_Price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Book_Price.Location = new System.Drawing.Point(156, 193);
            this.txt_Book_Price.Name = "txt_Book_Price";
            this.txt_Book_Price.Size = new System.Drawing.Size(205, 26);
            this.txt_Book_Price.TabIndex = 66;
            this.txt_Book_Price.TextChanged += new System.EventHandler(this.txt_Book_Price_TextChanged);
            // 
            // txt_Book_Publisher_Place
            // 
            this.txt_Book_Publisher_Place.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Book_Publisher_Place.Location = new System.Drawing.Point(156, 123);
            this.txt_Book_Publisher_Place.Name = "txt_Book_Publisher_Place";
            this.txt_Book_Publisher_Place.Size = new System.Drawing.Size(205, 26);
            this.txt_Book_Publisher_Place.TabIndex = 65;
            // 
            // txt_Book_Publisher
            // 
            this.txt_Book_Publisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Book_Publisher.Location = new System.Drawing.Point(156, 93);
            this.txt_Book_Publisher.Name = "txt_Book_Publisher";
            this.txt_Book_Publisher.Size = new System.Drawing.Size(205, 26);
            this.txt_Book_Publisher.TabIndex = 64;
            // 
            // dtp_Date_Book_Recived
            // 
            this.dtp_Date_Book_Recived.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date_Book_Recived.Location = new System.Drawing.Point(141, 162);
            this.dtp_Date_Book_Recived.Name = "dtp_Date_Book_Recived";
            this.dtp_Date_Book_Recived.Size = new System.Drawing.Size(242, 26);
            this.dtp_Date_Book_Recived.TabIndex = 63;
            // 
            // txt_Book_Author
            // 
            this.txt_Book_Author.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Book_Author.Location = new System.Drawing.Point(156, 61);
            this.txt_Book_Author.Name = "txt_Book_Author";
            this.txt_Book_Author.Size = new System.Drawing.Size(205, 26);
            this.txt_Book_Author.TabIndex = 62;
            // 
            // txt_Book_Title
            // 
            this.txt_Book_Title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Book_Title.Location = new System.Drawing.Point(156, 29);
            this.txt_Book_Title.Name = "txt_Book_Title";
            this.txt_Book_Title.Size = new System.Drawing.Size(205, 26);
            this.txt_Book_Title.TabIndex = 61;
            // 
            // cbo_Book_Section
            // 
            this.cbo_Book_Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Book_Section.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Book_Section.FormattingEnabled = true;
            this.cbo_Book_Section.Items.AddRange(new object[] {
            "Lending",
            "Reference",
            "Children Reference",
            "Children Lending",
            "Mobile"});
            this.cbo_Book_Section.Location = new System.Drawing.Point(141, 93);
            this.cbo_Book_Section.Name = "cbo_Book_Section";
            this.cbo_Book_Section.Size = new System.Drawing.Size(144, 27);
            this.cbo_Book_Section.TabIndex = 60;
            // 
            // Cbo_Catagory_No
            // 
            this.Cbo_Catagory_No.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Catagory_No.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Catagory_No.FormattingEnabled = true;
            this.Cbo_Catagory_No.Location = new System.Drawing.Point(141, 60);
            this.Cbo_Catagory_No.Name = "Cbo_Catagory_No";
            this.Cbo_Catagory_No.Size = new System.Drawing.Size(144, 27);
            this.Cbo_Catagory_No.TabIndex = 59;
            // 
            // txt_Book_Id
            // 
            this.txt_Book_Id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Book_Id.Location = new System.Drawing.Point(141, 29);
            this.txt_Book_Id.Name = "txt_Book_Id";
            this.txt_Book_Id.Size = new System.Drawing.Size(144, 26);
            this.txt_Book_Id.TabIndex = 58;
            // 
            // No_of_Pages
            // 
            this.No_of_Pages.AutoSize = true;
            this.No_of_Pages.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_of_Pages.Location = new System.Drawing.Point(12, 164);
            this.No_of_Pages.Name = "No_of_Pages";
            this.No_of_Pages.Size = new System.Drawing.Size(89, 19);
            this.No_of_Pages.TabIndex = 57;
            this.No_of_Pages.Text = "No Of Pages";
            // 
            // Book_Recived_Date
            // 
            this.Book_Recived_Date.AutoSize = true;
            this.Book_Recived_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Recived_Date.Location = new System.Drawing.Point(8, 168);
            this.Book_Recived_Date.Name = "Book_Recived_Date";
            this.Book_Recived_Date.Size = new System.Drawing.Size(133, 19);
            this.Book_Recived_Date.TabIndex = 56;
            this.Book_Recived_Date.Text = "Book Recived  Date";
            // 
            // Book_Publisher
            // 
            this.Book_Publisher.AutoSize = true;
            this.Book_Publisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Publisher.Location = new System.Drawing.Point(12, 96);
            this.Book_Publisher.Name = "Book_Publisher";
            this.Book_Publisher.Size = new System.Drawing.Size(102, 19);
            this.Book_Publisher.TabIndex = 55;
            this.Book_Publisher.Text = "Book Publisher";
            // 
            // Book_Author
            // 
            this.Book_Author.AutoSize = true;
            this.Book_Author.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Author.Location = new System.Drawing.Point(12, 63);
            this.Book_Author.Name = "Book_Author";
            this.Book_Author.Size = new System.Drawing.Size(88, 19);
            this.Book_Author.TabIndex = 54;
            this.Book_Author.Text = "Book Author";
            // 
            // Book_Publish_place
            // 
            this.Book_Publish_place.AutoSize = true;
            this.Book_Publish_place.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Publish_place.Location = new System.Drawing.Point(12, 130);
            this.Book_Publish_place.Name = "Book_Publish_place";
            this.Book_Publish_place.Size = new System.Drawing.Size(127, 19);
            this.Book_Publish_place.TabIndex = 53;
            this.Book_Publish_place.Text = "Book Publish Place";
            // 
            // Book_Price
            // 
            this.Book_Price.AutoSize = true;
            this.Book_Price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Price.Location = new System.Drawing.Point(12, 196);
            this.Book_Price.Name = "Book_Price";
            this.Book_Price.Size = new System.Drawing.Size(78, 19);
            this.Book_Price.TabIndex = 52;
            this.Book_Price.Text = "Book Price";
            // 
            // Book_Section
            // 
            this.Book_Section.AutoSize = true;
            this.Book_Section.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Section.Location = new System.Drawing.Point(8, 96);
            this.Book_Section.Name = "Book_Section";
            this.Book_Section.Size = new System.Drawing.Size(92, 19);
            this.Book_Section.TabIndex = 51;
            this.Book_Section.Text = "Book Section";
            // 
            // Book_Title
            // 
            this.Book_Title.AutoSize = true;
            this.Book_Title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Title.Location = new System.Drawing.Point(12, 32);
            this.Book_Title.Name = "Book_Title";
            this.Book_Title.Size = new System.Drawing.Size(72, 19);
            this.Book_Title.TabIndex = 50;
            this.Book_Title.Text = "Book Title";
            // 
            // Book_Catagory_No
            // 
            this.Book_Catagory_No.AutoSize = true;
            this.Book_Catagory_No.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Catagory_No.Location = new System.Drawing.Point(8, 63);
            this.Book_Catagory_No.Name = "Book_Catagory_No";
            this.Book_Catagory_No.Size = new System.Drawing.Size(89, 19);
            this.Book_Catagory_No.TabIndex = 49;
            this.Book_Catagory_No.Text = "Catagory No";
            // 
            // lbl_Book_Id
            // 
            this.lbl_Book_Id.AutoSize = true;
            this.lbl_Book_Id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Id.Location = new System.Drawing.Point(8, 32);
            this.lbl_Book_Id.Name = "lbl_Book_Id";
            this.lbl_Book_Id.Size = new System.Drawing.Size(60, 19);
            this.lbl_Book_Id.TabIndex = 48;
            this.lbl_Book_Id.Text = "Book Id";
            // 
            // gbo_Book_Basic
            // 
            this.gbo_Book_Basic.Controls.Add(this.Book_Title);
            this.gbo_Book_Basic.Controls.Add(this.Book_Price);
            this.gbo_Book_Basic.Controls.Add(this.Book_Publish_place);
            this.gbo_Book_Basic.Controls.Add(this.Book_Author);
            this.gbo_Book_Basic.Controls.Add(this.Book_Publisher);
            this.gbo_Book_Basic.Controls.Add(this.No_of_Pages);
            this.gbo_Book_Basic.Controls.Add(this.txt_No_Of_Pages);
            this.gbo_Book_Basic.Controls.Add(this.txt_Book_Title);
            this.gbo_Book_Basic.Controls.Add(this.txt_Book_Price);
            this.gbo_Book_Basic.Controls.Add(this.txt_Book_Author);
            this.gbo_Book_Basic.Controls.Add(this.txt_Book_Publisher_Place);
            this.gbo_Book_Basic.Controls.Add(this.txt_Book_Publisher);
            this.gbo_Book_Basic.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Book_Basic.Location = new System.Drawing.Point(505, 40);
            this.gbo_Book_Basic.Name = "gbo_Book_Basic";
            this.gbo_Book_Basic.Size = new System.Drawing.Size(423, 262);
            this.gbo_Book_Basic.TabIndex = 73;
            this.gbo_Book_Basic.TabStop = false;
            this.gbo_Book_Basic.Text = "Book  Basic Details";
            // 
            // gbo_Book_Maintanance
            // 
            this.gbo_Book_Maintanance.Controls.Add(this.btn_Genarate);
            this.gbo_Book_Maintanance.Controls.Add(this.txt_Book_Id);
            this.gbo_Book_Maintanance.Controls.Add(this.lbl_Book_Id);
            this.gbo_Book_Maintanance.Controls.Add(this.Book_Catagory_No);
            this.gbo_Book_Maintanance.Controls.Add(this.Book_Section);
            this.gbo_Book_Maintanance.Controls.Add(this.Book_Recived_Date);
            this.gbo_Book_Maintanance.Controls.Add(this.cbo_Book_Source);
            this.gbo_Book_Maintanance.Controls.Add(this.Cbo_Catagory_No);
            this.gbo_Book_Maintanance.Controls.Add(this.lbl_Book_Source);
            this.gbo_Book_Maintanance.Controls.Add(this.cbo_Book_Section);
            this.gbo_Book_Maintanance.Controls.Add(this.dtp_Date_Book_Recived);
            this.gbo_Book_Maintanance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Book_Maintanance.Location = new System.Drawing.Point(53, 40);
            this.gbo_Book_Maintanance.Name = "gbo_Book_Maintanance";
            this.gbo_Book_Maintanance.Size = new System.Drawing.Size(424, 211);
            this.gbo_Book_Maintanance.TabIndex = 68;
            this.gbo_Book_Maintanance.TabStop = false;
            this.gbo_Book_Maintanance.Text = "Book Maintanance";
            // 
            // btn_Genarate
            // 
            this.btn_Genarate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Genarate.Location = new System.Drawing.Point(291, 32);
            this.btn_Genarate.Name = "btn_Genarate";
            this.btn_Genarate.Size = new System.Drawing.Size(75, 23);
            this.btn_Genarate.TabIndex = 74;
            this.btn_Genarate.Text = "Genarate";
            this.btn_Genarate.UseVisualStyleBackColor = true;
            this.btn_Genarate.Click += new System.EventHandler(this.btn_Genarate_Click_1);
            // 
            // dgv_Books
            // 
            this.dgv_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Books.Location = new System.Drawing.Point(53, 315);
            this.dgv_Books.Name = "dgv_Books";
            this.dgv_Books.ReadOnly = true;
            this.dgv_Books.Size = new System.Drawing.Size(875, 222);
            this.dgv_Books.TabIndex = 74;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(280, 264);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 75;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(311, -5);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(303, 46);
            this.lbl_Header.TabIndex = 92;
            this.lbl_Header.Text = "Book Management";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dgv_Books);
            this.Controls.Add(this.gbo_Book_Maintanance);
            this.Controls.Add(this.gbo_Book_Basic);
            this.Controls.Add(this.btn_Update_Book);
            this.Controls.Add(this.btn_Add_Book);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.gbo_Book_Basic.ResumeLayout(false);
            this.gbo_Book_Basic.PerformLayout();
            this.gbo_Book_Maintanance.ResumeLayout(false);
            this.gbo_Book_Maintanance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update_Book;
        private System.Windows.Forms.Button btn_Add_Book;
        private System.Windows.Forms.ComboBox cbo_Book_Source;
        private System.Windows.Forms.Label lbl_Book_Source;
        private System.Windows.Forms.TextBox txt_No_Of_Pages;
        private System.Windows.Forms.TextBox txt_Book_Price;
        private System.Windows.Forms.TextBox txt_Book_Publisher_Place;
        private System.Windows.Forms.TextBox txt_Book_Publisher;
        private System.Windows.Forms.DateTimePicker dtp_Date_Book_Recived;
        private System.Windows.Forms.TextBox txt_Book_Author;
        private System.Windows.Forms.TextBox txt_Book_Title;
        private System.Windows.Forms.ComboBox cbo_Book_Section;
        private System.Windows.Forms.ComboBox Cbo_Catagory_No;
        private System.Windows.Forms.TextBox txt_Book_Id;
        private System.Windows.Forms.Label No_of_Pages;
        private System.Windows.Forms.Label Book_Recived_Date;
        private System.Windows.Forms.Label Book_Publisher;
        private System.Windows.Forms.Label Book_Author;
        private System.Windows.Forms.Label Book_Publish_place;
        private System.Windows.Forms.Label Book_Price;
        private System.Windows.Forms.Label Book_Section;
        private System.Windows.Forms.Label Book_Title;
        private System.Windows.Forms.Label Book_Catagory_No;
        private System.Windows.Forms.Label lbl_Book_Id;
        private System.Windows.Forms.GroupBox gbo_Book_Basic;
        private System.Windows.Forms.GroupBox gbo_Book_Maintanance;
        private System.Windows.Forms.Button btn_Genarate;
        private System.Windows.Forms.DataGridView dgv_Books;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Header;
    }
}

