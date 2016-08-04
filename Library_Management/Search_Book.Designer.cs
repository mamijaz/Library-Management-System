namespace Library_Management
{
    partial class Search_Book
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbo_Catagory = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Title = new System.Windows.Forms.TabPage();
            this.btn_Title = new System.Windows.Forms.Button();
            this.lbl_Key_Word = new System.Windows.Forms.Label();
            this.txt_Key_Word = new System.Windows.Forms.TextBox();
            this.tab_Author = new System.Windows.Forms.TabPage();
            this.btn_Author = new System.Windows.Forms.Button();
            this.lbl_Auther = new System.Windows.Forms.Label();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.tab_Catagory = new System.Windows.Forms.TabPage();
            this.btn_Catagory = new System.Windows.Forms.Button();
            this.lbl_Catagory = new System.Windows.Forms.Label();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_Title.SuspendLayout();
            this.tab_Author.SuspendLayout();
            this.tab_Catagory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_Catagory
            // 
            this.cbo_Catagory.FormattingEnabled = true;
            this.cbo_Catagory.Location = new System.Drawing.Point(306, 60);
            this.cbo_Catagory.Name = "cbo_Catagory";
            this.cbo_Catagory.Size = new System.Drawing.Size(150, 25);
            this.cbo_Catagory.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Title);
            this.tabControl1.Controls.Add(this.tab_Author);
            this.tabControl1.Controls.Add(this.tab_Catagory);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(115, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 165);
            this.tabControl1.TabIndex = 2;
            // 
            // tab_Title
            // 
            this.tab_Title.Controls.Add(this.btn_Title);
            this.tab_Title.Controls.Add(this.lbl_Key_Word);
            this.tab_Title.Controls.Add(this.txt_Key_Word);
            this.tab_Title.Location = new System.Drawing.Point(4, 26);
            this.tab_Title.Name = "tab_Title";
            this.tab_Title.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Title.Size = new System.Drawing.Size(736, 135);
            this.tab_Title.TabIndex = 0;
            this.tab_Title.Text = "By Title";
            this.tab_Title.UseVisualStyleBackColor = true;
            // 
            // btn_Title
            // 
            this.btn_Title.Location = new System.Drawing.Point(485, 53);
            this.btn_Title.Name = "btn_Title";
            this.btn_Title.Size = new System.Drawing.Size(90, 23);
            this.btn_Title.TabIndex = 4;
            this.btn_Title.Text = "Search";
            this.btn_Title.UseVisualStyleBackColor = true;
            this.btn_Title.Click += new System.EventHandler(this.btn_Title_Click);
            // 
            // lbl_Key_Word
            // 
            this.lbl_Key_Word.AutoSize = true;
            this.lbl_Key_Word.Location = new System.Drawing.Point(173, 56);
            this.lbl_Key_Word.Name = "lbl_Key_Word";
            this.lbl_Key_Word.Size = new System.Drawing.Size(69, 17);
            this.lbl_Key_Word.TabIndex = 3;
            this.lbl_Key_Word.Text = "Key Word";
            // 
            // txt_Key_Word
            // 
            this.txt_Key_Word.Location = new System.Drawing.Point(248, 53);
            this.txt_Key_Word.Name = "txt_Key_Word";
            this.txt_Key_Word.Size = new System.Drawing.Size(231, 25);
            this.txt_Key_Word.TabIndex = 2;
            // 
            // tab_Author
            // 
            this.tab_Author.Controls.Add(this.btn_Author);
            this.tab_Author.Controls.Add(this.lbl_Auther);
            this.tab_Author.Controls.Add(this.txt_Author);
            this.tab_Author.Location = new System.Drawing.Point(4, 26);
            this.tab_Author.Name = "tab_Author";
            this.tab_Author.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Author.Size = new System.Drawing.Size(736, 135);
            this.tab_Author.TabIndex = 1;
            this.tab_Author.Text = "By Author";
            this.tab_Author.UseVisualStyleBackColor = true;
            // 
            // btn_Author
            // 
            this.btn_Author.Location = new System.Drawing.Point(499, 53);
            this.btn_Author.Name = "btn_Author";
            this.btn_Author.Size = new System.Drawing.Size(75, 23);
            this.btn_Author.TabIndex = 7;
            this.btn_Author.Text = "Search";
            this.btn_Author.UseVisualStyleBackColor = true;
            this.btn_Author.Click += new System.EventHandler(this.btn_Author_Click);
            // 
            // lbl_Auther
            // 
            this.lbl_Auther.AutoSize = true;
            this.lbl_Auther.Location = new System.Drawing.Point(170, 56);
            this.lbl_Auther.Name = "lbl_Auther";
            this.lbl_Auther.Size = new System.Drawing.Size(69, 17);
            this.lbl_Auther.TabIndex = 6;
            this.lbl_Auther.Text = "Key Word";
            // 
            // txt_Author
            // 
            this.txt_Author.Location = new System.Drawing.Point(255, 53);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(238, 25);
            this.txt_Author.TabIndex = 5;
            // 
            // tab_Catagory
            // 
            this.tab_Catagory.Controls.Add(this.cbo_Catagory);
            this.tab_Catagory.Controls.Add(this.btn_Catagory);
            this.tab_Catagory.Controls.Add(this.lbl_Catagory);
            this.tab_Catagory.Location = new System.Drawing.Point(4, 26);
            this.tab_Catagory.Name = "tab_Catagory";
            this.tab_Catagory.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Catagory.Size = new System.Drawing.Size(736, 135);
            this.tab_Catagory.TabIndex = 2;
            this.tab_Catagory.Text = "By Catagory";
            this.tab_Catagory.UseVisualStyleBackColor = true;
            // 
            // btn_Catagory
            // 
            this.btn_Catagory.Location = new System.Drawing.Point(471, 60);
            this.btn_Catagory.Name = "btn_Catagory";
            this.btn_Catagory.Size = new System.Drawing.Size(75, 23);
            this.btn_Catagory.TabIndex = 7;
            this.btn_Catagory.Text = "Search";
            this.btn_Catagory.UseVisualStyleBackColor = true;
            this.btn_Catagory.Click += new System.EventHandler(this.btn_Catagory_Click);
            // 
            // lbl_Catagory
            // 
            this.lbl_Catagory.AutoSize = true;
            this.lbl_Catagory.Location = new System.Drawing.Point(224, 63);
            this.lbl_Catagory.Name = "lbl_Catagory";
            this.lbl_Catagory.Size = new System.Drawing.Size(84, 17);
            this.lbl_Catagory.TabIndex = 6;
            this.lbl_Catagory.Text = "Catagory No";
            // 
            // dgv_Search
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Search.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Search.Location = new System.Drawing.Point(115, 239);
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.ReadOnly = true;
            this.dgv_Search.Size = new System.Drawing.Size(736, 292);
            this.dgv_Search.TabIndex = 3;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(343, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(279, 46);
            this.lbl_Header.TabIndex = 94;
            this.lbl_Header.Text = "Search For Books";
            // 
            // Search_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgv_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search_Book";
            this.Text = "Search_Book";
            this.Load += new System.EventHandler(this.Search_Book_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Title.ResumeLayout(false);
            this.tab_Title.PerformLayout();
            this.tab_Author.ResumeLayout(false);
            this.tab_Author.PerformLayout();
            this.tab_Catagory.ResumeLayout(false);
            this.tab_Catagory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Catagory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Title;
        private System.Windows.Forms.Button btn_Title;
        private System.Windows.Forms.Label lbl_Key_Word;
        private System.Windows.Forms.TextBox txt_Key_Word;
        private System.Windows.Forms.TabPage tab_Author;
        private System.Windows.Forms.Button btn_Author;
        private System.Windows.Forms.Label lbl_Auther;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.TabPage tab_Catagory;
        private System.Windows.Forms.Button btn_Catagory;
        private System.Windows.Forms.Label lbl_Catagory;
        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Label lbl_Header;
    }
}