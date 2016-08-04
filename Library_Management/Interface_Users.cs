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
    public partial class Interface_Users : Form
    {
        public Interface_Users()
        {
            InitializeComponent();
        }

        private void btn_Add_New_User_Click(object sender, EventArgs e)
        {
            Create_New_User Create_New_User_Page = new Create_New_User();
            Create_New_User_Page.MdiParent = this.ParentForm;
            Create_New_User_Page.StartPosition = FormStartPosition.Manual;
            Create_New_User_Page.Location = new Point(this.Location.X, this.Location.Y);
            Create_New_User_Page.Show();
        }

        private void btn_Change_Password_Click(object sender, EventArgs e)
        {
            Change_Password Change_Password_Page = new Change_Password();
            Change_Password_Page.MdiParent = this.ParentForm;
            Change_Password_Page.StartPosition = FormStartPosition.Manual;
            Change_Password_Page.Location = new Point(this.Location.X, this.Location.Y);
            Change_Password_Page.Show();
        }

        private void btn_Forget_Password_Click(object sender, EventArgs e)
        {
            Reset_Password Reset_Password_Page = new Reset_Password();
            Reset_Password_Page.MdiParent = this.ParentForm;
            Reset_Password_Page.StartPosition = FormStartPosition.Manual;
            Reset_Password_Page.Location = new Point(this.Location.X, this.Location.Y);
            Reset_Password_Page.Show();
        }
    }
}
