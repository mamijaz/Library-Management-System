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
    public partial class Staff : Form
    {
        Library_Management info = new Library_Management();
        public Staff()
        {
            InitializeComponent();
            btn_Update.Enabled = false;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                info.Insert_Staff(txt_NIC.Text, txt_Name.Text, cbo_Post.Text, txt_Address_Line_1.Text, txt_Address_Line_2.Text, txt_Address_Line_3.Text, int.Parse(txt_Contact_No.Text), cbo_Section.Text);
                MessageBox.Show("Staff Is added Succesfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Insert.Enabled = false;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                info.Update_Staff(txt_NIC.Text, txt_Name.Text, cbo_Post.Text, txt_Address_Line_1.Text, txt_Address_Line_2.Text, txt_Address_Line_3.Text, int.Parse(txt_Contact_No.Text), cbo_Section.Text);
                MessageBox.Show("Staff Is updated Succesfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_NIC.Clear();
            txt_Name.Clear();
            txt_Contact_No.Text = "0";
            txt_Address_Line_1.Clear();
            txt_Address_Line_2.Clear();
            txt_Address_Line_3.Clear();
            cbo_Post.Text = "";
            cbo_Section.Text = "";
            btn_Update.Enabled = false;
            btn_Insert.Enabled = true;
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            SqlDataReader z = info.Get_Staff(txt_NIC.Text);
            if (z.Read())
            {
                txt_Name.Text = z[1].ToString();
                cbo_Post.Text = z[2].ToString();
                txt_Address_Line_1.Text = z[3].ToString();
                txt_Address_Line_2.Text = z[4].ToString();
                txt_Address_Line_3.Text = z[5].ToString();
                txt_Contact_No.Text = z[6].ToString();
                cbo_Section.Text = z[7].ToString();
                btn_Update.Enabled = true;
            }
        }
    }
}
