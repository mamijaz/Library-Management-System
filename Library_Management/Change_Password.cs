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
    public partial class Change_Password : Form
    {
        Library_Management info = new Library_Management();
        public Change_Password()
        {
            InitializeComponent();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            SqlDataReader y = info.Log_In(txt_User_Name.Text, txt_Old_Password.Text);
            if (y.Read())
            {
                if (txt_New_Password.Text == txt_Confirm_New_Password.Text)
                {
                    try
                    {
                        info.Change_Pasword(txt_User_Name.Text, txt_New_Password.Text);
                        MessageBox.Show("Your Password Is Changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_User_Name.Clear();
                        txt_Old_Password.Clear();
                        txt_New_Password.Clear();
                        txt_Confirm_New_Password.Clear();
                        this.Close();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("New Password And Confirm Password Did Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_New_Password.Clear();
                    txt_Confirm_New_Password.Clear();
                }
            }
            else
            {
                MessageBox.Show("User Name Or Password Not Valid","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_User_Name.Clear();
                txt_Old_Password.Clear();
                txt_New_Password.Clear();
                txt_Confirm_New_Password.Clear();
            }
        }
    }
}
