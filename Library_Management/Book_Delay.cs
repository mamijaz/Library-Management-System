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
    public partial class Book_Delay : Form
    {
        public Book_Delay()
        {
            InitializeComponent();
        }

        private void Book_Delay_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Genarate_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Delay_Book.DataTable3' table. You can move, or remove it, as needed.
            DateTime D1 = dtp_Date.Value.AddDays(-30);
            this.DataTable1TableAdapter.Fill(this.Delay_Book.DataTable1, D1.ToString());
            
            // TODO: This line of code loads data into the 'Delay_Book.DataTable2' table. You can move, or remove it, as needed.
            DateTime D2 = dtp_Date.Value.AddDays(-60);
            this.DataTable2TableAdapter.Fill(this.Delay_Book.DataTable2, D2.ToString());

            // TODO: This line of code loads data into the 'Delay_Book.DataTable1' table. You can move, or remove it, as needed.
            DateTime D3 = dtp_Date.Value.AddDays(-90);
            this.DataTable3TableAdapter.Fill(this.Delay_Book.DataTable3, D3.ToString());

            this.rpt_30.RefreshReport();
            this.rpt_60.RefreshReport();
            this.rpt_90.RefreshReport();
        }
    }
}
