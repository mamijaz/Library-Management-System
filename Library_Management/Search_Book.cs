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
    public partial class Search_Book : Form
    {
        Library_Management info = new Library_Management();
        public Search_Book()
        {
            InitializeComponent();
            Get_Catagory();
        }

        private void Search_Book_Load(object sender, EventArgs e)
        {
            DataSet ds = info.List_Books();
            dgv_Search.DataSource = ds.Tables["Books"];
        }
        private void Get_Catagory()
        {
            SqlDataReader y = info.Get_Catagorys();
            while (y.Read())
            {
                string Catagory = y[0].ToString();
                cbo_Catagory.Items.Add(Catagory);
            }
        }

        private void btn_Title_Click(object sender, EventArgs e)
        {
            DataSet ds = info.Search_Books_By_Title(txt_Key_Word.Text);
            dgv_Search.DataSource = ds.Tables["Books_By_Title"];
        }

        private void btn_Author_Click(object sender, EventArgs e)
        {
            DataSet ds = info.Search_Books_By_Author(txt_Author.Text);
            dgv_Search.DataSource = ds.Tables["Books_By_Author"];
        }

        private void btn_Catagory_Click(object sender, EventArgs e)
        {
            DataSet ds = info.List_Book_For_Catagory(double.Parse(cbo_Catagory.Text));
            dgv_Search.DataSource = ds.Tables["Book_For_Catagory"];
        }
    }
}
