using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management
{
    public partial class Reset_Password : Form
    {
        Library_Management info = new Library_Management();
        public Reset_Password()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlDataReader y = info.Check_For_Account_Password_Reset(txt_User_Name.Text, cbo_Security_Question.Text, txt_Answer.Text);
            if (y.Read())
            {
                string Password = "1234";
                info.Change_Pasword(txt_User_Name.Text, Password);
                MessageBox.Show("Your Password is changed to 1234, Please use the Password Change to change your paswsord", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_User_Name.Clear();
                cbo_Security_Question.Text = "";
                txt_Answer.Clear();
                Change_Password Change_Password_Page = new Change_Password();
                Change_Password_Page.MdiParent = this.ParentForm;
                Change_Password_Page.StartPosition = FormStartPosition.Manual;
                Change_Password_Page.Location = new Point(this.Location.X, this.Location.Y);
                Change_Password_Page.Show();
            }
            else
            {
                MessageBox.Show("Please Input Correct Data And Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
