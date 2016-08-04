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
    public partial class Interface_Search : Form
    {
        public Interface_Search()
        {
            InitializeComponent();
        }

        private void btn_Search_Books_Click(object sender, EventArgs e)
        {
            Search_Book Search_Book_Page = new Search_Book();
            Search_Book_Page.MdiParent = this.ParentForm;
            Search_Book_Page.StartPosition = FormStartPosition.Manual;
            Search_Book_Page.Location = new Point(this.Location.X, this.Location.Y);
            Search_Book_Page.Show();
        }

        private void btn_Search_Specific_Book_Click(object sender, EventArgs e)
        {
            Book_Detaile_Search Search_Detaile_Book_Page = new Book_Detaile_Search();
            Search_Detaile_Book_Page.MdiParent = this.ParentForm;
            Search_Detaile_Book_Page.StartPosition = FormStartPosition.Manual;
            Search_Detaile_Book_Page.Location = new Point(this.Location.X, this.Location.Y);
            Search_Detaile_Book_Page.Show();
        }
    }
}
