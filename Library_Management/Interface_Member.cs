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
    public partial class Interface_Member : Form
    {
        public Interface_Member()
        {
            InitializeComponent();
        }

        private void btn_Outsid_Members_Click(object sender, EventArgs e)
        {
            
            Members_Who_Are__Outsiders Outsider_Member_Page = new Members_Who_Are__Outsiders();
            Outsider_Member_Page.MdiParent = this.ParentForm;
            Outsider_Member_Page.StartPosition = FormStartPosition.Manual;
            Outsider_Member_Page.Location = new Point(this.Location.X, this.Location.Y);
            Outsider_Member_Page.Show();
        }

        private void btn_Tax_Paying_Members_Click(object sender, EventArgs e)
        {
            
            Members_Who_Pay_Tax Tax_Paying_Member_Page = new Members_Who_Pay_Tax();
            Tax_Paying_Member_Page.MdiParent = this.ParentForm;
            Tax_Paying_Member_Page.StartPosition = FormStartPosition.Manual;
            Tax_Paying_Member_Page.Location = new Point(this.Location.X, this.Location.Y);
            Tax_Paying_Member_Page.Show();
        }

        private void btn_Student_Members_Click(object sender, EventArgs e)
        {
            Members_Who_Are_Students_And_Who_Reside_Outside Student_Member_Page = new Members_Who_Are_Students_And_Who_Reside_Outside();
            Student_Member_Page.MdiParent = this.ParentForm;
            Student_Member_Page.StartPosition = FormStartPosition.Manual;
            Student_Member_Page.Location = new Point(this.Location.X, this.Location.Y);
            Student_Member_Page.Show();
        }

        private void btn_Government_Members_Click(object sender, EventArgs e)
        {
            Members_Who_Are_Government_Staffs Government_Member_Page = new Members_Who_Are_Government_Staffs();
            Government_Member_Page.MdiParent = this.ParentForm;
            Government_Member_Page.StartPosition = FormStartPosition.Manual;
            Government_Member_Page.Location = new Point(this.Location.X, this.Location.Y);
            Government_Member_Page.Show();
        }
    }
}
