namespace Library_Management
{
    partial class Income_Reports
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Member_Registration = new System.Windows.Forms.TabPage();
            this.btn_Clear_Member = new System.Windows.Forms.Button();
            this.dgv_Member = new System.Windows.Forms.DataGridView();
            this.lbl_Total_Income_Display_Member = new System.Windows.Forms.Label();
            this.lbl_Total_Income_Member = new System.Windows.Forms.Label();
            this.gbo_Member = new System.Windows.Forms.GroupBox();
            this.dtp_From_Member = new System.Windows.Forms.DateTimePicker();
            this.lbl_To_Member = new System.Windows.Forms.Label();
            this.dtp_To_Member = new System.Windows.Forms.DateTimePicker();
            this.lbl_From_Member = new System.Windows.Forms.Label();
            this.btn_Search_Member = new System.Windows.Forms.Button();
            this.tab_Lending_Section = new System.Windows.Forms.TabPage();
            this.btn_Clear_Lending = new System.Windows.Forms.Button();
            this.lbl_By_Book_Losts = new System.Windows.Forms.Label();
            this.lbl_Book_Returns = new System.Windows.Forms.Label();
            this.dgv_Lost = new System.Windows.Forms.DataGridView();
            this.gbo_Lendind = new System.Windows.Forms.GroupBox();
            this.dtp_From_Lending = new System.Windows.Forms.DateTimePicker();
            this.lbl_To_Lending = new System.Windows.Forms.Label();
            this.dtp_To_Lending = new System.Windows.Forms.DateTimePicker();
            this.lbl_From_Lending = new System.Windows.Forms.Label();
            this.btn_Search_Lending = new System.Windows.Forms.Button();
            this.lbl_Total_Income_Display_Lending = new System.Windows.Forms.Label();
            this.lbl_Total_Income_Lending = new System.Windows.Forms.Label();
            this.dgv_Return = new System.Windows.Forms.DataGridView();
            this.tab_Multimedia_Section = new System.Windows.Forms.TabPage();
            this.btn_Clear_Mutimedia = new System.Windows.Forms.Button();
            this.gbo_Mutimedia = new System.Windows.Forms.GroupBox();
            this.dtp_From_Multimedia = new System.Windows.Forms.DateTimePicker();
            this.lbl_To_Multimedia = new System.Windows.Forms.Label();
            this.dtp_To_Multimedia = new System.Windows.Forms.DateTimePicker();
            this.lbl_From_Multimedia = new System.Windows.Forms.Label();
            this.btn_Search_Multimedia = new System.Windows.Forms.Button();
            this.lbl_Total_Income_Display_Multimedia = new System.Windows.Forms.Label();
            this.lbl_Total_Income_Multimedia = new System.Windows.Forms.Label();
            this.dgv_Mutimedia = new System.Windows.Forms.DataGridView();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_Member_Registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Member)).BeginInit();
            this.gbo_Member.SuspendLayout();
            this.tab_Lending_Section.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lost)).BeginInit();
            this.gbo_Lendind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Return)).BeginInit();
            this.tab_Multimedia_Section.SuspendLayout();
            this.gbo_Mutimedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mutimedia)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Member_Registration);
            this.tabControl1.Controls.Add(this.tab_Lending_Section);
            this.tabControl1.Controls.Add(this.tab_Multimedia_Section);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(43, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 509);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_Member_Registration
            // 
            this.tab_Member_Registration.Controls.Add(this.btn_Clear_Member);
            this.tab_Member_Registration.Controls.Add(this.dgv_Member);
            this.tab_Member_Registration.Controls.Add(this.lbl_Total_Income_Display_Member);
            this.tab_Member_Registration.Controls.Add(this.lbl_Total_Income_Member);
            this.tab_Member_Registration.Controls.Add(this.gbo_Member);
            this.tab_Member_Registration.Controls.Add(this.btn_Search_Member);
            this.tab_Member_Registration.Location = new System.Drawing.Point(4, 26);
            this.tab_Member_Registration.Name = "tab_Member_Registration";
            this.tab_Member_Registration.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Member_Registration.Size = new System.Drawing.Size(888, 479);
            this.tab_Member_Registration.TabIndex = 0;
            this.tab_Member_Registration.Text = "Member Registrations Section";
            this.tab_Member_Registration.UseVisualStyleBackColor = true;
            // 
            // btn_Clear_Member
            // 
            this.btn_Clear_Member.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear_Member.Location = new System.Drawing.Point(715, 107);
            this.btn_Clear_Member.Name = "btn_Clear_Member";
            this.btn_Clear_Member.Size = new System.Drawing.Size(102, 23);
            this.btn_Clear_Member.TabIndex = 15;
            this.btn_Clear_Member.Text = "Clear";
            this.btn_Clear_Member.UseVisualStyleBackColor = true;
            this.btn_Clear_Member.Click += new System.EventHandler(this.btn_Clear_Member_Click);
            // 
            // dgv_Member
            // 
            this.dgv_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Member.Location = new System.Drawing.Point(37, 150);
            this.dgv_Member.Name = "dgv_Member";
            this.dgv_Member.ReadOnly = true;
            this.dgv_Member.Size = new System.Drawing.Size(808, 312);
            this.dgv_Member.TabIndex = 8;
            // 
            // lbl_Total_Income_Display_Member
            // 
            this.lbl_Total_Income_Display_Member.AutoSize = true;
            this.lbl_Total_Income_Display_Member.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Income_Display_Member.Location = new System.Drawing.Point(157, 111);
            this.lbl_Total_Income_Display_Member.Name = "lbl_Total_Income_Display_Member";
            this.lbl_Total_Income_Display_Member.Size = new System.Drawing.Size(40, 17);
            this.lbl_Total_Income_Display_Member.TabIndex = 7;
            this.lbl_Total_Income_Display_Member.Text = "0000";
            // 
            // lbl_Total_Income_Member
            // 
            this.lbl_Total_Income_Member.AutoSize = true;
            this.lbl_Total_Income_Member.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Income_Member.Location = new System.Drawing.Point(57, 111);
            this.lbl_Total_Income_Member.Name = "lbl_Total_Income_Member";
            this.lbl_Total_Income_Member.Size = new System.Drawing.Size(94, 17);
            this.lbl_Total_Income_Member.TabIndex = 6;
            this.lbl_Total_Income_Member.Text = "Total Income";
            // 
            // gbo_Member
            // 
            this.gbo_Member.Controls.Add(this.dtp_From_Member);
            this.gbo_Member.Controls.Add(this.lbl_To_Member);
            this.gbo_Member.Controls.Add(this.dtp_To_Member);
            this.gbo_Member.Controls.Add(this.lbl_From_Member);
            this.gbo_Member.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Member.Location = new System.Drawing.Point(37, 24);
            this.gbo_Member.Name = "gbo_Member";
            this.gbo_Member.Size = new System.Drawing.Size(805, 67);
            this.gbo_Member.TabIndex = 5;
            this.gbo_Member.TabStop = false;
            this.gbo_Member.Text = "Duration";
            // 
            // dtp_From_Member
            // 
            this.dtp_From_Member.Location = new System.Drawing.Point(79, 23);
            this.dtp_From_Member.Name = "dtp_From_Member";
            this.dtp_From_Member.Size = new System.Drawing.Size(215, 25);
            this.dtp_From_Member.TabIndex = 0;
            // 
            // lbl_To_Member
            // 
            this.lbl_To_Member.AutoSize = true;
            this.lbl_To_Member.Location = new System.Drawing.Point(479, 29);
            this.lbl_To_Member.Name = "lbl_To_Member";
            this.lbl_To_Member.Size = new System.Drawing.Size(23, 17);
            this.lbl_To_Member.TabIndex = 4;
            this.lbl_To_Member.Text = "To";
            // 
            // dtp_To_Member
            // 
            this.dtp_To_Member.Location = new System.Drawing.Point(522, 24);
            this.dtp_To_Member.Name = "dtp_To_Member";
            this.dtp_To_Member.Size = new System.Drawing.Size(214, 25);
            this.dtp_To_Member.TabIndex = 1;
            // 
            // lbl_From_Member
            // 
            this.lbl_From_Member.AutoSize = true;
            this.lbl_From_Member.Location = new System.Drawing.Point(25, 30);
            this.lbl_From_Member.Name = "lbl_From_Member";
            this.lbl_From_Member.Size = new System.Drawing.Size(39, 17);
            this.lbl_From_Member.TabIndex = 3;
            this.lbl_From_Member.Text = "From";
            // 
            // btn_Search_Member
            // 
            this.btn_Search_Member.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Member.Location = new System.Drawing.Point(598, 107);
            this.btn_Search_Member.Name = "btn_Search_Member";
            this.btn_Search_Member.Size = new System.Drawing.Size(102, 23);
            this.btn_Search_Member.TabIndex = 2;
            this.btn_Search_Member.Text = "Search";
            this.btn_Search_Member.UseVisualStyleBackColor = true;
            this.btn_Search_Member.Click += new System.EventHandler(this.btn_Search_Member_Click);
            // 
            // tab_Lending_Section
            // 
            this.tab_Lending_Section.Controls.Add(this.btn_Clear_Lending);
            this.tab_Lending_Section.Controls.Add(this.lbl_By_Book_Losts);
            this.tab_Lending_Section.Controls.Add(this.lbl_Book_Returns);
            this.tab_Lending_Section.Controls.Add(this.dgv_Lost);
            this.tab_Lending_Section.Controls.Add(this.gbo_Lendind);
            this.tab_Lending_Section.Controls.Add(this.btn_Search_Lending);
            this.tab_Lending_Section.Controls.Add(this.lbl_Total_Income_Display_Lending);
            this.tab_Lending_Section.Controls.Add(this.lbl_Total_Income_Lending);
            this.tab_Lending_Section.Controls.Add(this.dgv_Return);
            this.tab_Lending_Section.Location = new System.Drawing.Point(4, 26);
            this.tab_Lending_Section.Name = "tab_Lending_Section";
            this.tab_Lending_Section.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Lending_Section.Size = new System.Drawing.Size(888, 479);
            this.tab_Lending_Section.TabIndex = 1;
            this.tab_Lending_Section.Text = "Lending Section";
            this.tab_Lending_Section.UseVisualStyleBackColor = true;
            // 
            // btn_Clear_Lending
            // 
            this.btn_Clear_Lending.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear_Lending.Location = new System.Drawing.Point(716, 109);
            this.btn_Clear_Lending.Name = "btn_Clear_Lending";
            this.btn_Clear_Lending.Size = new System.Drawing.Size(102, 23);
            this.btn_Clear_Lending.TabIndex = 17;
            this.btn_Clear_Lending.Text = "Clear";
            this.btn_Clear_Lending.UseVisualStyleBackColor = true;
            this.btn_Clear_Lending.Click += new System.EventHandler(this.btn_Clear_Lending_Click);
            // 
            // lbl_By_Book_Losts
            // 
            this.lbl_By_Book_Losts.AutoSize = true;
            this.lbl_By_Book_Losts.Location = new System.Drawing.Point(473, 170);
            this.lbl_By_Book_Losts.Name = "lbl_By_Book_Losts";
            this.lbl_By_Book_Losts.Size = new System.Drawing.Size(96, 17);
            this.lbl_By_Book_Losts.TabIndex = 16;
            this.lbl_By_Book_Losts.Text = "By Book Losts";
            // 
            // lbl_Book_Returns
            // 
            this.lbl_Book_Returns.AutoSize = true;
            this.lbl_Book_Returns.Location = new System.Drawing.Point(45, 168);
            this.lbl_Book_Returns.Name = "lbl_Book_Returns";
            this.lbl_Book_Returns.Size = new System.Drawing.Size(110, 17);
            this.lbl_Book_Returns.TabIndex = 15;
            this.lbl_Book_Returns.Text = "By Book Returns";
            // 
            // dgv_Lost
            // 
            this.dgv_Lost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lost.Location = new System.Drawing.Point(453, 194);
            this.dgv_Lost.Name = "dgv_Lost";
            this.dgv_Lost.Size = new System.Drawing.Size(394, 269);
            this.dgv_Lost.TabIndex = 14;
            // 
            // gbo_Lendind
            // 
            this.gbo_Lendind.Controls.Add(this.dtp_From_Lending);
            this.gbo_Lendind.Controls.Add(this.lbl_To_Lending);
            this.gbo_Lendind.Controls.Add(this.dtp_To_Lending);
            this.gbo_Lendind.Controls.Add(this.lbl_From_Lending);
            this.gbo_Lendind.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Lendind.Location = new System.Drawing.Point(37, 24);
            this.gbo_Lendind.Name = "gbo_Lendind";
            this.gbo_Lendind.Size = new System.Drawing.Size(804, 67);
            this.gbo_Lendind.TabIndex = 10;
            this.gbo_Lendind.TabStop = false;
            this.gbo_Lendind.Text = "Duration";
            // 
            // dtp_From_Lending
            // 
            this.dtp_From_Lending.Location = new System.Drawing.Point(79, 23);
            this.dtp_From_Lending.Name = "dtp_From_Lending";
            this.dtp_From_Lending.Size = new System.Drawing.Size(217, 25);
            this.dtp_From_Lending.TabIndex = 0;
            // 
            // lbl_To_Lending
            // 
            this.lbl_To_Lending.AutoSize = true;
            this.lbl_To_Lending.Location = new System.Drawing.Point(483, 29);
            this.lbl_To_Lending.Name = "lbl_To_Lending";
            this.lbl_To_Lending.Size = new System.Drawing.Size(23, 17);
            this.lbl_To_Lending.TabIndex = 4;
            this.lbl_To_Lending.Text = "To";
            // 
            // dtp_To_Lending
            // 
            this.dtp_To_Lending.Location = new System.Drawing.Point(526, 24);
            this.dtp_To_Lending.Name = "dtp_To_Lending";
            this.dtp_To_Lending.Size = new System.Drawing.Size(215, 25);
            this.dtp_To_Lending.TabIndex = 1;
            // 
            // lbl_From_Lending
            // 
            this.lbl_From_Lending.AutoSize = true;
            this.lbl_From_Lending.Location = new System.Drawing.Point(25, 30);
            this.lbl_From_Lending.Name = "lbl_From_Lending";
            this.lbl_From_Lending.Size = new System.Drawing.Size(39, 17);
            this.lbl_From_Lending.TabIndex = 3;
            this.lbl_From_Lending.Text = "From";
            // 
            // btn_Search_Lending
            // 
            this.btn_Search_Lending.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Lending.Location = new System.Drawing.Point(600, 109);
            this.btn_Search_Lending.Name = "btn_Search_Lending";
            this.btn_Search_Lending.Size = new System.Drawing.Size(102, 23);
            this.btn_Search_Lending.TabIndex = 9;
            this.btn_Search_Lending.Text = "Search";
            this.btn_Search_Lending.UseVisualStyleBackColor = true;
            this.btn_Search_Lending.Click += new System.EventHandler(this.btn_Search_Lending_Click);
            // 
            // lbl_Total_Income_Display_Lending
            // 
            this.lbl_Total_Income_Display_Lending.AutoSize = true;
            this.lbl_Total_Income_Display_Lending.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Income_Display_Lending.Location = new System.Drawing.Point(136, 111);
            this.lbl_Total_Income_Display_Lending.Name = "lbl_Total_Income_Display_Lending";
            this.lbl_Total_Income_Display_Lending.Size = new System.Drawing.Size(40, 17);
            this.lbl_Total_Income_Display_Lending.TabIndex = 12;
            this.lbl_Total_Income_Display_Lending.Text = "0000";
            // 
            // lbl_Total_Income_Lending
            // 
            this.lbl_Total_Income_Lending.AutoSize = true;
            this.lbl_Total_Income_Lending.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Income_Lending.Location = new System.Drawing.Point(36, 111);
            this.lbl_Total_Income_Lending.Name = "lbl_Total_Income_Lending";
            this.lbl_Total_Income_Lending.Size = new System.Drawing.Size(94, 17);
            this.lbl_Total_Income_Lending.TabIndex = 11;
            this.lbl_Total_Income_Lending.Text = "Total Income";
            // 
            // dgv_Return
            // 
            this.dgv_Return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Return.Location = new System.Drawing.Point(35, 194);
            this.dgv_Return.Name = "dgv_Return";
            this.dgv_Return.Size = new System.Drawing.Size(392, 269);
            this.dgv_Return.TabIndex = 13;
            // 
            // tab_Multimedia_Section
            // 
            this.tab_Multimedia_Section.Controls.Add(this.btn_Clear_Mutimedia);
            this.tab_Multimedia_Section.Controls.Add(this.gbo_Mutimedia);
            this.tab_Multimedia_Section.Controls.Add(this.btn_Search_Multimedia);
            this.tab_Multimedia_Section.Controls.Add(this.lbl_Total_Income_Display_Multimedia);
            this.tab_Multimedia_Section.Controls.Add(this.lbl_Total_Income_Multimedia);
            this.tab_Multimedia_Section.Controls.Add(this.dgv_Mutimedia);
            this.tab_Multimedia_Section.Location = new System.Drawing.Point(4, 26);
            this.tab_Multimedia_Section.Name = "tab_Multimedia_Section";
            this.tab_Multimedia_Section.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Multimedia_Section.Size = new System.Drawing.Size(888, 479);
            this.tab_Multimedia_Section.TabIndex = 2;
            this.tab_Multimedia_Section.Text = "Multimedia Section";
            this.tab_Multimedia_Section.UseVisualStyleBackColor = true;
            // 
            // btn_Clear_Mutimedia
            // 
            this.btn_Clear_Mutimedia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear_Mutimedia.Location = new System.Drawing.Point(715, 106);
            this.btn_Clear_Mutimedia.Name = "btn_Clear_Mutimedia";
            this.btn_Clear_Mutimedia.Size = new System.Drawing.Size(102, 23);
            this.btn_Clear_Mutimedia.TabIndex = 14;
            this.btn_Clear_Mutimedia.Text = "Clear";
            this.btn_Clear_Mutimedia.UseVisualStyleBackColor = true;
            this.btn_Clear_Mutimedia.Click += new System.EventHandler(this.btn_Clear_Mutimedia_Click);
            // 
            // gbo_Mutimedia
            // 
            this.gbo_Mutimedia.Controls.Add(this.dtp_From_Multimedia);
            this.gbo_Mutimedia.Controls.Add(this.lbl_To_Multimedia);
            this.gbo_Mutimedia.Controls.Add(this.dtp_To_Multimedia);
            this.gbo_Mutimedia.Controls.Add(this.lbl_From_Multimedia);
            this.gbo_Mutimedia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Mutimedia.Location = new System.Drawing.Point(39, 24);
            this.gbo_Mutimedia.Name = "gbo_Mutimedia";
            this.gbo_Mutimedia.Size = new System.Drawing.Size(801, 67);
            this.gbo_Mutimedia.TabIndex = 10;
            this.gbo_Mutimedia.TabStop = false;
            this.gbo_Mutimedia.Text = "Duration";
            // 
            // dtp_From_Multimedia
            // 
            this.dtp_From_Multimedia.Location = new System.Drawing.Point(79, 23);
            this.dtp_From_Multimedia.Name = "dtp_From_Multimedia";
            this.dtp_From_Multimedia.Size = new System.Drawing.Size(215, 25);
            this.dtp_From_Multimedia.TabIndex = 0;
            // 
            // lbl_To_Multimedia
            // 
            this.lbl_To_Multimedia.AutoSize = true;
            this.lbl_To_Multimedia.Location = new System.Drawing.Point(486, 29);
            this.lbl_To_Multimedia.Name = "lbl_To_Multimedia";
            this.lbl_To_Multimedia.Size = new System.Drawing.Size(23, 17);
            this.lbl_To_Multimedia.TabIndex = 4;
            this.lbl_To_Multimedia.Text = "To";
            // 
            // dtp_To_Multimedia
            // 
            this.dtp_To_Multimedia.Location = new System.Drawing.Point(529, 24);
            this.dtp_To_Multimedia.Name = "dtp_To_Multimedia";
            this.dtp_To_Multimedia.Size = new System.Drawing.Size(214, 25);
            this.dtp_To_Multimedia.TabIndex = 1;
            // 
            // lbl_From_Multimedia
            // 
            this.lbl_From_Multimedia.AutoSize = true;
            this.lbl_From_Multimedia.Location = new System.Drawing.Point(25, 30);
            this.lbl_From_Multimedia.Name = "lbl_From_Multimedia";
            this.lbl_From_Multimedia.Size = new System.Drawing.Size(39, 17);
            this.lbl_From_Multimedia.TabIndex = 3;
            this.lbl_From_Multimedia.Text = "From";
            // 
            // btn_Search_Multimedia
            // 
            this.btn_Search_Multimedia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Multimedia.Location = new System.Drawing.Point(595, 106);
            this.btn_Search_Multimedia.Name = "btn_Search_Multimedia";
            this.btn_Search_Multimedia.Size = new System.Drawing.Size(102, 23);
            this.btn_Search_Multimedia.TabIndex = 9;
            this.btn_Search_Multimedia.Text = "Search";
            this.btn_Search_Multimedia.UseVisualStyleBackColor = true;
            this.btn_Search_Multimedia.Click += new System.EventHandler(this.btn_Search_Multimedia_Click);
            // 
            // lbl_Total_Income_Display_Multimedia
            // 
            this.lbl_Total_Income_Display_Multimedia.AutoSize = true;
            this.lbl_Total_Income_Display_Multimedia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Income_Display_Multimedia.Location = new System.Drawing.Point(136, 111);
            this.lbl_Total_Income_Display_Multimedia.Name = "lbl_Total_Income_Display_Multimedia";
            this.lbl_Total_Income_Display_Multimedia.Size = new System.Drawing.Size(40, 17);
            this.lbl_Total_Income_Display_Multimedia.TabIndex = 12;
            this.lbl_Total_Income_Display_Multimedia.Text = "0000";
            // 
            // lbl_Total_Income_Multimedia
            // 
            this.lbl_Total_Income_Multimedia.AutoSize = true;
            this.lbl_Total_Income_Multimedia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Income_Multimedia.Location = new System.Drawing.Point(36, 112);
            this.lbl_Total_Income_Multimedia.Name = "lbl_Total_Income_Multimedia";
            this.lbl_Total_Income_Multimedia.Size = new System.Drawing.Size(94, 17);
            this.lbl_Total_Income_Multimedia.TabIndex = 11;
            this.lbl_Total_Income_Multimedia.Text = "Total Income";
            // 
            // dgv_Mutimedia
            // 
            this.dgv_Mutimedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mutimedia.Location = new System.Drawing.Point(39, 152);
            this.dgv_Mutimedia.Name = "dgv_Mutimedia";
            this.dgv_Mutimedia.Size = new System.Drawing.Size(801, 310);
            this.dgv_Mutimedia.TabIndex = 13;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(351, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(251, 46);
            this.lbl_Header.TabIndex = 93;
            this.lbl_Header.Text = "Income Reports";
            // 
            // Income_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Income_Reports";
            this.Text = "Income_Reports";
            this.tabControl1.ResumeLayout(false);
            this.tab_Member_Registration.ResumeLayout(false);
            this.tab_Member_Registration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Member)).EndInit();
            this.gbo_Member.ResumeLayout(false);
            this.gbo_Member.PerformLayout();
            this.tab_Lending_Section.ResumeLayout(false);
            this.tab_Lending_Section.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lost)).EndInit();
            this.gbo_Lendind.ResumeLayout(false);
            this.gbo_Lendind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Return)).EndInit();
            this.tab_Multimedia_Section.ResumeLayout(false);
            this.tab_Multimedia_Section.PerformLayout();
            this.gbo_Mutimedia.ResumeLayout(false);
            this.gbo_Mutimedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mutimedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Member_Registration;
        private System.Windows.Forms.DataGridView dgv_Member;
        private System.Windows.Forms.Label lbl_Total_Income_Display_Member;
        private System.Windows.Forms.Label lbl_Total_Income_Member;
        private System.Windows.Forms.GroupBox gbo_Member;
        private System.Windows.Forms.DateTimePicker dtp_From_Member;
        private System.Windows.Forms.Label lbl_To_Member;
        private System.Windows.Forms.DateTimePicker dtp_To_Member;
        private System.Windows.Forms.Label lbl_From_Member;
        private System.Windows.Forms.Button btn_Search_Member;
        private System.Windows.Forms.TabPage tab_Lending_Section;
        private System.Windows.Forms.DataGridView dgv_Lost;
        private System.Windows.Forms.GroupBox gbo_Lendind;
        private System.Windows.Forms.DateTimePicker dtp_From_Lending;
        private System.Windows.Forms.Label lbl_To_Lending;
        private System.Windows.Forms.DateTimePicker dtp_To_Lending;
        private System.Windows.Forms.Label lbl_From_Lending;
        private System.Windows.Forms.Button btn_Search_Lending;
        private System.Windows.Forms.Label lbl_Total_Income_Display_Lending;
        private System.Windows.Forms.Label lbl_Total_Income_Lending;
        private System.Windows.Forms.DataGridView dgv_Return;
        private System.Windows.Forms.TabPage tab_Multimedia_Section;
        private System.Windows.Forms.GroupBox gbo_Mutimedia;
        private System.Windows.Forms.DateTimePicker dtp_From_Multimedia;
        private System.Windows.Forms.Label lbl_To_Multimedia;
        private System.Windows.Forms.DateTimePicker dtp_To_Multimedia;
        private System.Windows.Forms.Label lbl_From_Multimedia;
        private System.Windows.Forms.Button btn_Search_Multimedia;
        private System.Windows.Forms.Label lbl_Total_Income_Display_Multimedia;
        private System.Windows.Forms.Label lbl_Total_Income_Multimedia;
        private System.Windows.Forms.DataGridView dgv_Mutimedia;
        private System.Windows.Forms.Label lbl_Book_Returns;
        private System.Windows.Forms.Label lbl_By_Book_Losts;
        private System.Windows.Forms.Button btn_Clear_Mutimedia;
        private System.Windows.Forms.Button btn_Clear_Lending;
        private System.Windows.Forms.Button btn_Clear_Member;
        private System.Windows.Forms.Label lbl_Header;
    }
}