namespace Library_Management
{
    partial class Transaction_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Tab_Control = new System.Windows.Forms.TabControl();
            this.tab_Member_Registartion = new System.Windows.Forms.TabPage();
            this.tab_Book_Lending = new System.Windows.Forms.TabPage();
            this.tab_Book_Return = new System.Windows.Forms.TabPage();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gbo_Member = new System.Windows.Forms.GroupBox();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.lbl_To_Member = new System.Windows.Forms.Label();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.lbl_From_Member = new System.Windows.Forms.Label();
            this.btn_Genarate = new System.Windows.Forms.Button();
            this.tab_Book_Lost = new System.Windows.Forms.TabPage();
            this.tab_Multimedia = new System.Windows.Forms.TabPage();
            this.tab_Reference = new System.Windows.Forms.TabPage();
            this.rpt_Member = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpt_Lending = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpt_Return = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpt_Lost = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpt_Reference = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Transaction_Reports = new Transaction_Reports();
            this.ReferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReferenceTableAdapter = new Transaction_ReportsTableAdapters.ReferenceTableAdapter();
            this.rpt_Mutimedia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MultimediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MultimediaTableAdapter = new Transaction_ReportsTableAdapters.MultimediaTableAdapter();
            this.LostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LostTableAdapter = new Transaction_ReportsTableAdapters.LostTableAdapter();
            this.ReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReturnTableAdapter = new Transaction_ReportsTableAdapters.ReturnTableAdapter();
            this.LendingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LendingTableAdapter = new Transaction_ReportsTableAdapters.LendingTableAdapter();
            this.MemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MemberTableAdapter = new Transaction_ReportsTableAdapters.MemberTableAdapter();
            this.Tab_Control.SuspendLayout();
            this.tab_Member_Registartion.SuspendLayout();
            this.tab_Book_Lending.SuspendLayout();
            this.tab_Book_Return.SuspendLayout();
            this.gbo_Member.SuspendLayout();
            this.tab_Book_Lost.SuspendLayout();
            this.tab_Multimedia.SuspendLayout();
            this.tab_Reference.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transaction_Reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultimediaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LendingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab_Control
            // 
            this.Tab_Control.Controls.Add(this.tab_Member_Registartion);
            this.Tab_Control.Controls.Add(this.tab_Book_Lending);
            this.Tab_Control.Controls.Add(this.tab_Book_Return);
            this.Tab_Control.Controls.Add(this.tab_Book_Lost);
            this.Tab_Control.Controls.Add(this.tab_Multimedia);
            this.Tab_Control.Controls.Add(this.tab_Reference);
            this.Tab_Control.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Control.Location = new System.Drawing.Point(41, 147);
            this.Tab_Control.Name = "Tab_Control";
            this.Tab_Control.SelectedIndex = 0;
            this.Tab_Control.Size = new System.Drawing.Size(896, 406);
            this.Tab_Control.TabIndex = 94;
            // 
            // tab_Member_Registartion
            // 
            this.tab_Member_Registartion.Controls.Add(this.rpt_Member);
            this.tab_Member_Registartion.Location = new System.Drawing.Point(4, 26);
            this.tab_Member_Registartion.Name = "tab_Member_Registartion";
            this.tab_Member_Registartion.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Member_Registartion.Size = new System.Drawing.Size(888, 376);
            this.tab_Member_Registartion.TabIndex = 0;
            this.tab_Member_Registartion.Text = "Member Registrations";
            this.tab_Member_Registartion.UseVisualStyleBackColor = true;
            // 
            // tab_Book_Lending
            // 
            this.tab_Book_Lending.Controls.Add(this.rpt_Lending);
            this.tab_Book_Lending.Location = new System.Drawing.Point(4, 26);
            this.tab_Book_Lending.Name = "tab_Book_Lending";
            this.tab_Book_Lending.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Book_Lending.Size = new System.Drawing.Size(888, 376);
            this.tab_Book_Lending.TabIndex = 1;
            this.tab_Book_Lending.Text = "Book Lending";
            this.tab_Book_Lending.UseVisualStyleBackColor = true;
            // 
            // tab_Book_Return
            // 
            this.tab_Book_Return.Controls.Add(this.rpt_Return);
            this.tab_Book_Return.Location = new System.Drawing.Point(4, 26);
            this.tab_Book_Return.Name = "tab_Book_Return";
            this.tab_Book_Return.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Book_Return.Size = new System.Drawing.Size(888, 376);
            this.tab_Book_Return.TabIndex = 2;
            this.tab_Book_Return.Text = "Book Return";
            this.tab_Book_Return.UseVisualStyleBackColor = true;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(349, 5);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(328, 46);
            this.lbl_Header.TabIndex = 95;
            this.lbl_Header.Text = "Transaction Reports";
            // 
            // gbo_Member
            // 
            this.gbo_Member.Controls.Add(this.dtp_From);
            this.gbo_Member.Controls.Add(this.lbl_To_Member);
            this.gbo_Member.Controls.Add(this.dtp_To);
            this.gbo_Member.Controls.Add(this.lbl_From_Member);
            this.gbo_Member.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Member.Location = new System.Drawing.Point(85, 45);
            this.gbo_Member.Name = "gbo_Member";
            this.gbo_Member.Size = new System.Drawing.Size(805, 67);
            this.gbo_Member.TabIndex = 97;
            this.gbo_Member.TabStop = false;
            this.gbo_Member.Text = "Duration";
            // 
            // dtp_From
            // 
            this.dtp_From.Location = new System.Drawing.Point(79, 23);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(215, 25);
            this.dtp_From.TabIndex = 0;
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
            // dtp_To
            // 
            this.dtp_To.Location = new System.Drawing.Point(522, 24);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(214, 25);
            this.dtp_To.TabIndex = 1;
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
            // btn_Genarate
            // 
            this.btn_Genarate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Genarate.Location = new System.Drawing.Point(788, 118);
            this.btn_Genarate.Name = "btn_Genarate";
            this.btn_Genarate.Size = new System.Drawing.Size(102, 23);
            this.btn_Genarate.TabIndex = 96;
            this.btn_Genarate.Text = "Genarate";
            this.btn_Genarate.UseVisualStyleBackColor = true;
            this.btn_Genarate.Click += new System.EventHandler(this.btn_Genarate_Click);
            // 
            // tab_Book_Lost
            // 
            this.tab_Book_Lost.Controls.Add(this.rpt_Lost);
            this.tab_Book_Lost.Location = new System.Drawing.Point(4, 26);
            this.tab_Book_Lost.Name = "tab_Book_Lost";
            this.tab_Book_Lost.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Book_Lost.Size = new System.Drawing.Size(888, 376);
            this.tab_Book_Lost.TabIndex = 3;
            this.tab_Book_Lost.Text = "Book Lost";
            this.tab_Book_Lost.UseVisualStyleBackColor = true;
            // 
            // tab_Multimedia
            // 
            this.tab_Multimedia.Controls.Add(this.rpt_Mutimedia);
            this.tab_Multimedia.Location = new System.Drawing.Point(4, 26);
            this.tab_Multimedia.Name = "tab_Multimedia";
            this.tab_Multimedia.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Multimedia.Size = new System.Drawing.Size(888, 376);
            this.tab_Multimedia.TabIndex = 4;
            this.tab_Multimedia.Text = "Multimedia";
            this.tab_Multimedia.UseVisualStyleBackColor = true;
            // 
            // tab_Reference
            // 
            this.tab_Reference.Controls.Add(this.rpt_Reference);
            this.tab_Reference.Location = new System.Drawing.Point(4, 26);
            this.tab_Reference.Name = "tab_Reference";
            this.tab_Reference.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Reference.Size = new System.Drawing.Size(888, 376);
            this.tab_Reference.TabIndex = 5;
            this.tab_Reference.Text = "Reference";
            this.tab_Reference.UseVisualStyleBackColor = true;
            // 
            // rpt_Member
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MemberBindingSource;
            this.rpt_Member.LocalReport.DataSources.Add(reportDataSource1);
            this.rpt_Member.LocalReport.ReportEmbeddedResource = "Library_Management.Member_Registration.rdlc";
            this.rpt_Member.Location = new System.Drawing.Point(19, 21);
            this.rpt_Member.Name = "rpt_Member";
            this.rpt_Member.Size = new System.Drawing.Size(847, 335);
            this.rpt_Member.TabIndex = 0;
            // 
            // rpt_Lending
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.LendingBindingSource;
            this.rpt_Lending.LocalReport.DataSources.Add(reportDataSource2);
            this.rpt_Lending.LocalReport.ReportEmbeddedResource = "Library_Management.Book_Lending.rdlc";
            this.rpt_Lending.Location = new System.Drawing.Point(20, 21);
            this.rpt_Lending.Name = "rpt_Lending";
            this.rpt_Lending.Size = new System.Drawing.Size(847, 335);
            this.rpt_Lending.TabIndex = 1;
            // 
            // rpt_Return
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.ReturnBindingSource;
            this.rpt_Return.LocalReport.DataSources.Add(reportDataSource3);
            this.rpt_Return.LocalReport.ReportEmbeddedResource = "Library_Management.Book_Return.rdlc";
            this.rpt_Return.Location = new System.Drawing.Point(21, 21);
            this.rpt_Return.Name = "rpt_Return";
            this.rpt_Return.Size = new System.Drawing.Size(847, 335);
            this.rpt_Return.TabIndex = 1;
            // 
            // rpt_Lost
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.LostBindingSource;
            this.rpt_Lost.LocalReport.DataSources.Add(reportDataSource4);
            this.rpt_Lost.LocalReport.ReportEmbeddedResource = "Library_Management.Book_Lost.rdlc";
            this.rpt_Lost.Location = new System.Drawing.Point(21, 21);
            this.rpt_Lost.Name = "rpt_Lost";
            this.rpt_Lost.Size = new System.Drawing.Size(847, 335);
            this.rpt_Lost.TabIndex = 1;
            // 
            // rpt_Reference
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.ReferenceBindingSource;
            this.rpt_Reference.LocalReport.DataSources.Add(reportDataSource6);
            this.rpt_Reference.LocalReport.ReportEmbeddedResource = "Library_Management.Reference.rdlc";
            this.rpt_Reference.Location = new System.Drawing.Point(21, 21);
            this.rpt_Reference.Name = "rpt_Reference";
            this.rpt_Reference.Size = new System.Drawing.Size(847, 335);
            this.rpt_Reference.TabIndex = 1;
            // 
            // Transaction_Reports
            // 
            this.Transaction_Reports.DataSetName = "Transaction_Reports";
            this.Transaction_Reports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReferenceBindingSource
            // 
            this.ReferenceBindingSource.DataMember = "Reference";
            this.ReferenceBindingSource.DataSource = this.Transaction_Reports;
            // 
            // ReferenceTableAdapter
            // 
            this.ReferenceTableAdapter.ClearBeforeFill = true;
            // 
            // rpt_Mutimedia
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.MultimediaBindingSource;
            this.rpt_Mutimedia.LocalReport.DataSources.Add(reportDataSource5);
            this.rpt_Mutimedia.LocalReport.ReportEmbeddedResource = "Library_Management.Multimedia.rdlc";
            this.rpt_Mutimedia.Location = new System.Drawing.Point(21, 21);
            this.rpt_Mutimedia.Name = "rpt_Mutimedia";
            this.rpt_Mutimedia.Size = new System.Drawing.Size(847, 335);
            this.rpt_Mutimedia.TabIndex = 2;
            // 
            // MultimediaBindingSource
            // 
            this.MultimediaBindingSource.DataMember = "Multimedia";
            this.MultimediaBindingSource.DataSource = this.Transaction_Reports;
            // 
            // MultimediaTableAdapter
            // 
            this.MultimediaTableAdapter.ClearBeforeFill = true;
            // 
            // LostBindingSource
            // 
            this.LostBindingSource.DataMember = "Lost";
            this.LostBindingSource.DataSource = this.Transaction_Reports;
            // 
            // LostTableAdapter
            // 
            this.LostTableAdapter.ClearBeforeFill = true;
            // 
            // ReturnBindingSource
            // 
            this.ReturnBindingSource.DataMember = "Return";
            this.ReturnBindingSource.DataSource = this.Transaction_Reports;
            // 
            // ReturnTableAdapter
            // 
            this.ReturnTableAdapter.ClearBeforeFill = true;
            // 
            // LendingBindingSource
            // 
            this.LendingBindingSource.DataMember = "Lending";
            this.LendingBindingSource.DataSource = this.Transaction_Reports;
            // 
            // LendingTableAdapter
            // 
            this.LendingTableAdapter.ClearBeforeFill = true;
            // 
            // MemberBindingSource
            // 
            this.MemberBindingSource.DataMember = "Member";
            this.MemberBindingSource.DataSource = this.Transaction_Reports;
            // 
            // MemberTableAdapter
            // 
            this.MemberTableAdapter.ClearBeforeFill = true;
            // 
            // Transaction_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.gbo_Member);
            this.Controls.Add(this.btn_Genarate);
            this.Controls.Add(this.Tab_Control);
            this.Controls.Add(this.lbl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction_Report";
            this.Text = "Transaction_Report";
            this.Load += new System.EventHandler(this.Transaction_Report_Load);
            this.Tab_Control.ResumeLayout(false);
            this.tab_Member_Registartion.ResumeLayout(false);
            this.tab_Book_Lending.ResumeLayout(false);
            this.tab_Book_Return.ResumeLayout(false);
            this.gbo_Member.ResumeLayout(false);
            this.gbo_Member.PerformLayout();
            this.tab_Book_Lost.ResumeLayout(false);
            this.tab_Multimedia.ResumeLayout(false);
            this.tab_Reference.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Transaction_Reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultimediaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LendingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_Control;
        private System.Windows.Forms.TabPage tab_Member_Registartion;
        private System.Windows.Forms.TabPage tab_Book_Lending;
        private System.Windows.Forms.TabPage tab_Book_Return;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gbo_Member;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.Label lbl_To_Member;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.Label lbl_From_Member;
        private System.Windows.Forms.Button btn_Genarate;
        private System.Windows.Forms.TabPage tab_Book_Lost;
        private System.Windows.Forms.TabPage tab_Multimedia;
        private System.Windows.Forms.TabPage tab_Reference;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_Member;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_Lending;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_Return;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_Lost;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_Reference;
        private System.Windows.Forms.BindingSource ReferenceBindingSource;
        private Transaction_Reports Transaction_Reports;
        private Transaction_ReportsTableAdapters.ReferenceTableAdapter ReferenceTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_Mutimedia;
        private System.Windows.Forms.BindingSource MultimediaBindingSource;
        private Transaction_ReportsTableAdapters.MultimediaTableAdapter MultimediaTableAdapter;
        private System.Windows.Forms.BindingSource LostBindingSource;
        private Transaction_ReportsTableAdapters.LostTableAdapter LostTableAdapter;
        private System.Windows.Forms.BindingSource ReturnBindingSource;
        private Transaction_ReportsTableAdapters.ReturnTableAdapter ReturnTableAdapter;
        private System.Windows.Forms.BindingSource LendingBindingSource;
        private Transaction_ReportsTableAdapters.LendingTableAdapter LendingTableAdapter;
        private System.Windows.Forms.BindingSource MemberBindingSource;
        private Transaction_ReportsTableAdapters.MemberTableAdapter MemberTableAdapter;
    }
}