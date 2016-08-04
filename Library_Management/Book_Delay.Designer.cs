namespace Library_Management
{
    partial class Book_Delay
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Delay_Book = new Delay_Book();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Genarate = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.rpt_60_Days = new System.Windows.Forms.TabControl();
            this.tab_30_Days = new System.Windows.Forms.TabPage();
            this.rpt_30 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tab_60_Days = new System.Windows.Forms.TabPage();
            this.rpt_60 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tab_90_Days = new System.Windows.Forms.TabPage();
            this.rpt_90 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new Delay_BookTableAdapters.DataTable1TableAdapter();
            this.DataTable2TableAdapter = new Delay_BookTableAdapters.DataTable2TableAdapter();
            this.DataTable3TableAdapter = new Delay_BookTableAdapters.DataTable3TableAdapter();
            this.gbo_Report = new System.Windows.Forms.GroupBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delay_Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).BeginInit();
            this.rpt_60_Days.SuspendLayout();
            this.tab_30_Days.SuspendLayout();
            this.tab_60_Days.SuspendLayout();
            this.tab_90_Days.SuspendLayout();
            this.gbo_Report.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.Delay_Book;
            // 
            // Delay_Book
            // 
            this.Delay_Book.DataSetName = "Delay_Book";
            this.Delay_Book.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.Delay_Book;
            // 
            // DataTable3BindingSource
            // 
            this.DataTable3BindingSource.DataMember = "DataTable3";
            this.DataTable3BindingSource.DataSource = this.Delay_Book;
            // 
            // btn_Genarate
            // 
            this.btn_Genarate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Genarate.Location = new System.Drawing.Point(443, 39);
            this.btn_Genarate.Name = "btn_Genarate";
            this.btn_Genarate.Size = new System.Drawing.Size(75, 23);
            this.btn_Genarate.TabIndex = 7;
            this.btn_Genarate.Tag = "";
            this.btn_Genarate.Text = "Genarate";
            this.btn_Genarate.UseVisualStyleBackColor = true;
            this.btn_Genarate.Click += new System.EventHandler(this.btn_Genarate_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(186, 36);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(228, 25);
            this.dtp_Date.TabIndex = 6;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(126, 43);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(37, 17);
            this.lbl_Date.TabIndex = 5;
            this.lbl_Date.Text = "Date";
            // 
            // rpt_60_Days
            // 
            this.rpt_60_Days.Controls.Add(this.tab_30_Days);
            this.rpt_60_Days.Controls.Add(this.tab_60_Days);
            this.rpt_60_Days.Controls.Add(this.tab_90_Days);
            this.rpt_60_Days.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpt_60_Days.Location = new System.Drawing.Point(34, 164);
            this.rpt_60_Days.Name = "rpt_60_Days";
            this.rpt_60_Days.SelectedIndex = 0;
            this.rpt_60_Days.Size = new System.Drawing.Size(920, 383);
            this.rpt_60_Days.TabIndex = 4;
            // 
            // tab_30_Days
            // 
            this.tab_30_Days.Controls.Add(this.rpt_30);
            this.tab_30_Days.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_30_Days.Location = new System.Drawing.Point(4, 26);
            this.tab_30_Days.Name = "tab_30_Days";
            this.tab_30_Days.Padding = new System.Windows.Forms.Padding(3);
            this.tab_30_Days.Size = new System.Drawing.Size(912, 353);
            this.tab_30_Days.TabIndex = 0;
            this.tab_30_Days.Text = "30 Days";
            this.tab_30_Days.UseVisualStyleBackColor = true;
            // 
            // rpt_30
            // 
            this.rpt_30.Cursor = System.Windows.Forms.Cursors.IBeam;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rpt_30.LocalReport.DataSources.Add(reportDataSource1);
            this.rpt_30.LocalReport.ReportEmbeddedResource = "Library_Management.30_Days.rdlc";
            this.rpt_30.Location = new System.Drawing.Point(28, 30);
            this.rpt_30.Name = "rpt_30";
            this.rpt_30.Size = new System.Drawing.Size(856, 295);
            this.rpt_30.TabIndex = 0;
            // 
            // tab_60_Days
            // 
            this.tab_60_Days.Controls.Add(this.rpt_60);
            this.tab_60_Days.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_60_Days.Location = new System.Drawing.Point(4, 26);
            this.tab_60_Days.Name = "tab_60_Days";
            this.tab_60_Days.Padding = new System.Windows.Forms.Padding(3);
            this.tab_60_Days.Size = new System.Drawing.Size(912, 353);
            this.tab_60_Days.TabIndex = 1;
            this.tab_60_Days.Text = "60 Days";
            this.tab_60_Days.UseVisualStyleBackColor = true;
            // 
            // rpt_60
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable2BindingSource;
            this.rpt_60.LocalReport.DataSources.Add(reportDataSource2);
            this.rpt_60.LocalReport.ReportEmbeddedResource = "Library_Management.60_Days.rdlc";
            this.rpt_60.Location = new System.Drawing.Point(28, 30);
            this.rpt_60.Name = "rpt_60";
            this.rpt_60.Size = new System.Drawing.Size(855, 297);
            this.rpt_60.TabIndex = 1;
            // 
            // tab_90_Days
            // 
            this.tab_90_Days.Controls.Add(this.rpt_90);
            this.tab_90_Days.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_90_Days.Location = new System.Drawing.Point(4, 26);
            this.tab_90_Days.Name = "tab_90_Days";
            this.tab_90_Days.Padding = new System.Windows.Forms.Padding(3);
            this.tab_90_Days.Size = new System.Drawing.Size(912, 353);
            this.tab_90_Days.TabIndex = 2;
            this.tab_90_Days.Text = "90 Days";
            this.tab_90_Days.UseVisualStyleBackColor = true;
            // 
            // rpt_90
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.DataTable3BindingSource;
            this.rpt_90.LocalReport.DataSources.Add(reportDataSource3);
            this.rpt_90.LocalReport.ReportEmbeddedResource = "Library_Management.90_Days.rdlc";
            this.rpt_90.Location = new System.Drawing.Point(28, 31);
            this.rpt_90.Name = "rpt_90";
            this.rpt_90.Size = new System.Drawing.Size(855, 297);
            this.rpt_90.TabIndex = 2;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable3TableAdapter
            // 
            this.DataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // gbo_Report
            // 
            this.gbo_Report.Controls.Add(this.dtp_Date);
            this.gbo_Report.Controls.Add(this.btn_Genarate);
            this.gbo_Report.Controls.Add(this.lbl_Date);
            this.gbo_Report.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Report.Location = new System.Drawing.Point(142, 57);
            this.gbo_Report.Name = "gbo_Report";
            this.gbo_Report.Size = new System.Drawing.Size(674, 100);
            this.gbo_Report.TabIndex = 8;
            this.gbo_Report.TabStop = false;
            this.gbo_Report.Text = "Report";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(357, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(317, 46);
            this.lbl_Header.TabIndex = 9;
            this.lbl_Header.Text = "Book Delay Reports";
            // 
            // Book_Delay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.gbo_Report);
            this.Controls.Add(this.rpt_60_Days);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book_Delay";
            this.Text = "Book_Delay";
            this.Load += new System.EventHandler(this.Book_Delay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delay_Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).EndInit();
            this.rpt_60_Days.ResumeLayout(false);
            this.tab_30_Days.ResumeLayout(false);
            this.tab_60_Days.ResumeLayout(false);
            this.tab_90_Days.ResumeLayout(false);
            this.gbo_Report.ResumeLayout(false);
            this.gbo_Report.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Genarate;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TabControl rpt_60_Days;
        private System.Windows.Forms.TabPage tab_30_Days;
        private System.Windows.Forms.TabPage tab_60_Days;
        private System.Windows.Forms.TabPage tab_90_Days;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_30;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Delay_Book Delay_Book;
        private Delay_BookTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_60;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private Delay_BookTableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_90;
        private System.Windows.Forms.BindingSource DataTable3BindingSource;
        private Delay_BookTableAdapters.DataTable3TableAdapter DataTable3TableAdapter;
        private System.Windows.Forms.GroupBox gbo_Report;
        private System.Windows.Forms.Label lbl_Header;
    }
}