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
    public partial class Interface_Reports : Form
    {
        public Interface_Reports()
        {
            InitializeComponent();
        }

        private void btn_Report_On_Books_Click(object sender, EventArgs e)
        {
            Book_Delay Book_Delay_Report_Page = new Book_Delay();
            Book_Delay_Report_Page.MdiParent = this.ParentForm;
            Book_Delay_Report_Page.StartPosition = FormStartPosition.Manual;
            Book_Delay_Report_Page.Location = new Point(this.Location.X, this.Location.Y);
            Book_Delay_Report_Page.Show();
        }

        private void btn_Reports_On_Transaction_Click(object sender, EventArgs e)
        {
            Transaction_Report Transaction_Report_Page = new Transaction_Report();
            Transaction_Report_Page.MdiParent = this.ParentForm;
            Transaction_Report_Page.StartPosition = FormStartPosition.Manual;
            Transaction_Report_Page.Location = new Point(this.Location.X, this.Location.Y);
            Transaction_Report_Page.Show();
        }
    }
}
