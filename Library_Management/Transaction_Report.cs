using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class Transaction_Report : Form
    {
        public Transaction_Report()
        {
            InitializeComponent();
        }

        private void Transaction_Report_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Genarate_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Transaction_Reports.Member' table. You can move, or remove it, as needed.
            this.MemberTableAdapter.Fill(this.Transaction_Reports.Member,dtp_From.Text,dtp_To.Text);
            // TODO: This line of code loads data into the 'Transaction_Reports.Lending' table. You can move, or remove it, as needed.
            this.LendingTableAdapter.Fill(this.Transaction_Reports.Lending, dtp_From.Text, dtp_To.Text);
            // TODO: This line of code loads data into the 'Transaction_Reports.Return' table. You can move, or remove it, as needed.
            this.ReturnTableAdapter.Fill(this.Transaction_Reports.Return, dtp_From.Text, dtp_To.Text);
            // TODO: This line of code loads data into the 'Transaction_Reports.Lost' table. You can move, or remove it, as needed.
            this.LostTableAdapter.Fill(this.Transaction_Reports.Lost, dtp_From.Text, dtp_To.Text);
            // TODO: This line of code loads data into the 'Transaction_Reports.Multimedia' table. You can move, or remove it, as needed.
            this.MultimediaTableAdapter.Fill(this.Transaction_Reports.Multimedia, dtp_From.Text, dtp_To.Text);
            // TODO: This line of code loads data into the 'Transaction_Reports.Reference' table. You can move, or remove it, as needed.
            this.ReferenceTableAdapter.Fill(this.Transaction_Reports.Reference, dtp_From.Text, dtp_To.Text);

            this.rpt_Member.RefreshReport();
            this.rpt_Lending.RefreshReport();
            this.rpt_Return.RefreshReport();
            this.rpt_Lost.RefreshReport();
            this.rpt_Mutimedia.RefreshReport();
            this.rpt_Reference.RefreshReport();
        }
    }
}
