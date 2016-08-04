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
    public partial class Interface_Book_Maintanance : Form
    {
        public Interface_Book_Maintanance()
        {
            InitializeComponent();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            Books Book_Page = new Books();
            Book_Page.MdiParent = this.ParentForm;
            Book_Page.StartPosition = FormStartPosition.Manual;
            Book_Page.Location = new Point(this.Location.X, this.Location.Y);
            Book_Page.Show();
        }

        private void btn_Catagory_Click(object sender, EventArgs e)
        {
            Catagory Catagory_Page = new Catagory();
            Catagory_Page.MdiParent = this.ParentForm;
            Catagory_Page.StartPosition = FormStartPosition.Manual;
            Catagory_Page.Location = new Point(this.Location.X, this.Location.Y);
            Catagory_Page.Show();
        }
    }
}
