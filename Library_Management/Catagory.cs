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
    public partial class Catagory : Form
    {
        Library_Management info = new Library_Management();
        public Catagory()
        {
            InitializeComponent();
            this.txt_Catagory_No.LostFocus += new System.EventHandler
            (this.txt_Catagory_No_LostFocus);
        }

        private void Catagory_Load(object sender, EventArgs e)
        {
            DataSet ds = info.List_Book_Catagory();
            dgv_Catagory.DataSource = ds.Tables["Book_Catagory"];
            btn_Update.Enabled = false;
        }

        private void btn_Add_New_Click(object sender, EventArgs e)
        {
            info.Insert_Book_Catagory(double.Parse(txt_Catagory_No.Text), txt_Catagory_Name.Text);
            btn_Add_New.Enabled = false;
            DataSet ds = info.List_Book_Catagory();
            dgv_Catagory.DataSource = ds.Tables["Book_Catagory"];
            MessageBox.Show("Catagory Is Suucesfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            info.Update_Book_Catagory(double.Parse(txt_Catagory_No.Text), txt_Catagory_Name.Text);
            DataSet ds = info.List_Book_Catagory();
            dgv_Catagory.DataSource = ds.Tables["Book_Catagory"];
            MessageBox.Show("Catagory Is Suucesfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Catagory_No.Clear();
            txt_Catagory_Name.Clear();
            btn_Add_New.Enabled = true;
            btn_Update.Enabled = false;
            txt_Catagory_No.Enabled = true;
        }
        private void txt_Catagory_No_LostFocus(object sender, System.EventArgs e)
        {
            double i;
            if (double.TryParse(txt_Catagory_No.Text, out i))
            {
                if (i > 0)
                {
                    SqlDataReader y = info.Find_Book_Catagory(double.Parse(txt_Catagory_No.Text));
                    if (y.Read())
                    {
                        txt_Catagory_Name.Text = y[1].ToString();
                        btn_Add_New.Enabled = false;
                        DataSet ds = info.List_Book_For_Catagory(double.Parse(txt_Catagory_No.Text));
                        dgv_Books.DataSource = ds.Tables["Book_For_Catagory"];
                        txt_Catagory_No.Enabled = false;
                        btn_Update.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter A Valid Catagory No");
                    txt_Catagory_No.Clear();
                    txt_Catagory_No.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Catagory No");
                txt_Catagory_No.Clear();
                txt_Catagory_No.Focus();
            }
        }
    }
}
