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
    public partial class Create_New_User : Form
    {
        Library_Management info = new Library_Management();
        public Create_New_User()
        {
            InitializeComponent();
            Get_Staff_NIC();
        }
        private void Get_Staff_NIC()
        {
            SqlDataReader y = info.Get_Staff_NIC();
            while (y.Read())
            {
                string NIC = y[0].ToString();
                cbo_NIC.Items.Add(NIC);
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
             SqlDataReader p= info.Check_Is_User_Name_A_Staff(cbo_NIC.Text);
             if (p.Read())
             {
                 SqlDataReader z = info.Check_Is_User_NIC_In_Use(cbo_NIC.Text);
                 if (z.Read())
                 {
                     MessageBox.Show("You Have Already Registered","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                 }
                 else
                 {
                     SqlDataReader x = info.Check_Is_User_Name_In_Use(cbo_NIC.Text);
                     if (x.Read())
                     {
                         DialogResult Reasult = MessageBox.Show("Please Try Another User Name","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         if (Reasult == DialogResult.OK)
                         {
                             txt_User_Name.Clear();
                         }
                     }
                     else
                     {
                         if (txt_Password.Text == txt_Confirm_Password.Text)
                         {
                             try
                             {
                                 info.Insert_User(cbo_NIC.Text, txt_User_Name.Text, txt_Password.Text, cbo_User_Level.Text, cbo_Security_Question.Text, txt_Answer.Text);
                                 MessageBox.Show("New User Is Added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             }
                             catch (Exception error)
                             {
                                 MessageBox.Show(error.Message.ToString());
                             }
                         }
                         else
                         {
                             DialogResult Reasult = MessageBox.Show("Your Confirm Password Does Not Match The Password.So Please Re-Enter The Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             if (Reasult == DialogResult.OK)
                             {
                                 txt_Password.Clear();
                                 txt_Confirm_Password.Clear();
                             }
                         }
                     }
                 }

             }
             else
             {
                 MessageBox.Show("You Are Not a Staff","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
             }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_User_Name.Clear();
            txt_Password.Clear();
            txt_Confirm_Password.Clear();
            txt_Answer.Clear();
        }

        
    }
}
