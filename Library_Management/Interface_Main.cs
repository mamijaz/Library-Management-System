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
    public partial class Interface_Main : Form
    {
        Library_Management info = new Library_Management();
        public Interface_Main()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_User_Name.Clear();
            txt_Password.Clear();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader y = info.Log_In(txt_User_Name.Text, txt_Password.Text);
                if (y.Read())
                {
                    if (y[2].ToString() == "Admin")
                    {
                        lbl_Name.Text = y[1].ToString();
                        lbl_NIC.Text = y[0].ToString();
                        lbl_Level.Text = y[2].ToString();
                        Library_Management.Staff_NIC = y[0].ToString();
                        Library_Management.Staff_Name = y[1].ToString();
                        btn_Book_Maintanance.Enabled = true;
                        btn_Income_Reports.Enabled = true;
                        btn_Lending.Enabled = true;
                        btn_Member_Registration.Enabled = true;
                        btn_Multimedia.Enabled = true;
                        btn_Reference.Enabled = true;
                        btn_Report_On_Books.Enabled = true;
                        btn_Search.Enabled = true;
                        btn_Staff.Enabled = true;
                        btn_User_Accounts.Enabled = true;
                        MessageBox.Show("Login Succesfull","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txt_User_Name.Clear();
                        txt_Password.Clear();
                        gbo_Log_In.Visible = false;
                        gbo_Curent_User.Visible = true;
                    }
                    else if (y[2].ToString() == "Lending Section")
                    {
                        lbl_Name.Text = y[1].ToString();
                        lbl_NIC.Text = y[0].ToString();
                        lbl_Level.Text = y[2].ToString();
                        Library_Management.Staff_NIC = y[0].ToString();
                        Library_Management.Staff_Name = y[1].ToString();
                        btn_Income_Reports.Enabled = true;
                        btn_Lending.Enabled = true;
                        btn_Report_On_Books.Enabled = true;
                        btn_Search.Enabled = true;
                        MessageBox.Show("Login Succesfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_User_Name.Clear();
                        txt_Password.Clear();
                        gbo_Log_In.Visible = false;
                        gbo_Curent_User.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Please try Again Later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DialogResult Reasult = MessageBox.Show("Please Check Your Username And Password And Try Again", "Login failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (Reasult == DialogResult.OK)
                    {
                        txt_User_Name.Clear();
                        txt_Password.Clear();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }

        }

        private void Interface_Main_Load(object sender, EventArgs e)
        {
            btn_Book_Maintanance.Enabled = false;
            btn_Income_Reports.Enabled = false;
            btn_Lending.Enabled = false;
            btn_Member_Registration.Enabled = false;
            btn_Multimedia.Enabled = false;
            btn_Reference.Enabled = false;
            btn_Report_On_Books.Enabled = false;
            btn_Search.Enabled = false;
            btn_Staff.Enabled = false;
            btn_User_Accounts.Enabled = false;
            gbo_Curent_User.Visible = false;
        }

        private void btn_Reference_Click(object sender, EventArgs e)
        {
          
            Reference Reference_Page = new Reference();
            Reference_Page.MdiParent = this.ParentForm;
            Reference_Page.StartPosition = FormStartPosition.Manual;
            Reference_Page.Location = new Point(this.Location.X,this.Location.Y);
            Reference_Page.Show();
        }

        private void btn_Report_On_Books_Click(object sender, EventArgs e)
        {
            Interface_Reports Report_Page = new Interface_Reports();
            Report_Page.MdiParent = this.ParentForm;
            Report_Page.StartPosition = FormStartPosition.Manual;
            Report_Page.Location = new Point(this.Location.X, this.Location.Y);
            Report_Page.Show();
        }

        private void btn_Multimedia_Click(object sender, EventArgs e)
        {
            
            Multimedia Multimedia_Page = new Multimedia();
            Multimedia_Page.MdiParent = this.ParentForm;
            Multimedia_Page.StartPosition = FormStartPosition.Manual;
            Multimedia_Page.Location = new Point(this.Location.X, this.Location.Y);
            Multimedia_Page.Show();
        }

        private void btn_Income_Reports_Click(object sender, EventArgs e)
        {
            
            Income_Reports Income_Report_Page = new Income_Reports();
            Income_Report_Page.MdiParent = this.ParentForm;
            Income_Report_Page.StartPosition = FormStartPosition.Manual;
            Income_Report_Page.Location = new Point(this.Location.X, this.Location.Y);
            Income_Report_Page.Show();
        }

        private void btn_Member_Registration_Click(object sender, EventArgs e)
        {
            Interface_Member Member_Main_Page = new Interface_Member();
            Member_Main_Page.MdiParent = this.ParentForm;
            Member_Main_Page.StartPosition = FormStartPosition.Manual;
            Member_Main_Page.Location = new Point(this.Location.X, this.Location.Y);
            Member_Main_Page.Show();
        }

        private void btn_Lending_Click(object sender, EventArgs e)
        {
            Interface_Lending Lending_Main_Page = new Interface_Lending();
            Lending_Main_Page.MdiParent = this.ParentForm;
            Lending_Main_Page.StartPosition = FormStartPosition.Manual;
            Lending_Main_Page.Location = new Point(this.Location.X, this.Location.Y);
            Lending_Main_Page.Show();
        }

        private void btn_Book_Maintanance_Click(object sender, EventArgs e)
        {
            Interface_Book_Maintanance Book_Maintanance_Page = new Interface_Book_Maintanance();
            Book_Maintanance_Page.MdiParent = this.ParentForm;
            Book_Maintanance_Page.StartPosition = FormStartPosition.Manual;
            Book_Maintanance_Page.Location = new Point(this.Location.X, this.Location.Y);
            Book_Maintanance_Page.Show();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            Staff Staff_Page = new Staff();
            Staff_Page.MdiParent = this.ParentForm;
            Staff_Page.StartPosition = FormStartPosition.Manual;
            Staff_Page.Location = new Point(this.Location.X, this.Location.Y);
            Staff_Page.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Interface_Search Search_Page = new Interface_Search();
            Search_Page.MdiParent = this.ParentForm;
            Search_Page.StartPosition = FormStartPosition.Manual;
            Search_Page.Location = new Point(this.Location.X, this.Location.Y);
            Search_Page.Show();
        }

        private void btn_User_Accounts_Click(object sender, EventArgs e)
        {
            Interface_Users User_Page = new Interface_Users();
            User_Page.MdiParent = this.ParentForm;
            User_Page.StartPosition = FormStartPosition.Manual;
            User_Page.Location = new Point(this.Location.X, this.Location.Y);
            User_Page.Show();
        }

        private void lbl_Forgot_Password_Click(object sender, EventArgs e)
        {
            Reset_Password Reset_Password_Page = new Reset_Password();
            Reset_Password_Page.MdiParent = this.ParentForm;
            Reset_Password_Page.StartPosition = FormStartPosition.Manual;
            Reset_Password_Page.Location = new Point(this.Location.X, this.Location.Y);
            Reset_Password_Page.Show();
        }

        private void lbl_Change_Password_Click(object sender, EventArgs e)
        {
            Change_Password Change_Password_Page = new Change_Password();
            Change_Password_Page.MdiParent = this.ParentForm;
            Change_Password_Page.StartPosition = FormStartPosition.Manual;
            Change_Password_Page.Location = new Point(this.Location.X, this.Location.Y);
            Change_Password_Page.Show();
        }
    }
}
