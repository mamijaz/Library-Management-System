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
    public partial class Books : Form
    {
        Library_Management info = new Library_Management();
        public Books()
        {
            InitializeComponent();
            Get_Catagory();
            btn_Update_Book.Enabled = false;
            this.txt_Book_Id.LostFocus += new System.EventHandler
            (this.txt_Book_Id_LostFocus);
        }

        private void Get_Catagory()
        {
            SqlDataReader y =info.Get_Catagorys();
            while (y.Read())
            {
                string Catagory = y[0].ToString();
                Cbo_Catagory_No.Items.Add(Catagory);
            }
        }

        private void btn_Add_Book_Click(object sender, EventArgs e)
        {
            try
            {
                info.Insert_Book(int.Parse(txt_Book_Id.Text), float.Parse(Cbo_Catagory_No.Text), cbo_Book_Section.Text, txt_Book_Title.Text, txt_Book_Author.Text, txt_Book_Publisher.Text, txt_Book_Publisher_Place.Text, float.Parse(txt_Book_Price.Text), dtp_Date_Book_Recived.Value, int.Parse(txt_No_Of_Pages.Text), cbo_Book_Source.Text);
                MessageBox.Show("Book Is Added To Database","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
            btn_Add_Book.Enabled = false;
            DataSet ds = info.List_Books();
            dgv_Books.DataSource = ds.Tables["Books"];
        }

               private void btn_Update_Book_Click_1(object sender, EventArgs e)
        {
            try
            {
                info.Update_Book(int.Parse(txt_Book_Id.Text), float.Parse(Cbo_Catagory_No.Text), cbo_Book_Section.Text, txt_Book_Title.Text, txt_Book_Author.Text, txt_Book_Publisher.Text, txt_Book_Publisher_Place.Text, float.Parse(txt_Book_Price.Text), dtp_Date_Book_Recived.Value, int.Parse(txt_No_Of_Pages.Text), cbo_Book_Source.Text);
                MessageBox.Show("Update Succesfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
            DataSet ds = info.List_Books();
            dgv_Books.DataSource = ds.Tables["Books"];
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Book_Id.Text = "";
            Cbo_Catagory_No.Text = "";
            cbo_Book_Section.Text="";
            cbo_Book_Source.Text = "";
            txt_Book_Title.Text = "";
            txt_Book_Author.Text = "";
            txt_Book_Publisher.Text = "";
            txt_Book_Publisher_Place.Text = "";
            txt_No_Of_Pages.Text = "";
            txt_Book_Price.Text = "";
            btn_Add_Book.Enabled = true;
            btn_Update_Book.Enabled = false;
            txt_Book_Id.Enabled = true;
        }

        private void btn_Genarate_Click_1(object sender, EventArgs e)
        {
            txt_Book_Id.Text = (info.Find_Book_Id()).ToString();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            DataSet ds = info.List_Books();
            dgv_Books.DataSource = ds.Tables["Books"];
        }
        private void txt_Book_Id_LostFocus(object sender, System.EventArgs e)
        {
            int i;
            if (int.TryParse(txt_Book_Id.Text, out i)||txt_Book_Id.Text=="")
            {
                 SqlDataReader y =info.Find_Book(int.Parse(txt_Book_Id.Text));
                 if (y.Read())
                 {
                     MessageBox.Show("Book Exist In Database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     Cbo_Catagory_No.Text = y[1].ToString();
                     cbo_Book_Section.Text = y[2].ToString();
                     txt_Book_Title.Text = y[3].ToString();
                     txt_Book_Author.Text = y[4].ToString();
                     txt_Book_Publisher.Text = y[5].ToString();
                     txt_Book_Publisher_Place.Text = y[6].ToString();
                     txt_Book_Price.Text = y[7].ToString();
                     dtp_Date_Book_Recived.Text = y[8].ToString();
                     txt_No_Of_Pages.Text = y[9].ToString();
                     cbo_Book_Source.Text = y[10].ToString();
                     txt_Book_Id.Enabled = false;
                     btn_Update_Book.Enabled = true;
                     btn_Add_Book.Enabled = false;
                 }
                 else
                 {
                    
                 }
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Book Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Book_Id.Clear();
                txt_Book_Id.Focus();
            }
        }



        private void txt_No_Of_Pages_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(txt_No_Of_Pages.Text, out i))
            {
                if (i > 0)
                {
                }
                else
                {
                    MessageBox.Show("Please Enter A Valid Page No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_No_Of_Pages.Clear();
                    txt_No_Of_Pages.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Page No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_No_Of_Pages.Clear();
                txt_No_Of_Pages.Focus();
            }

        }

        private void txt_Book_Price_TextChanged(object sender, EventArgs e)
        {
            double i;
            if (double.TryParse(txt_Book_Price.Text, out i))
            {
                if (i > 0)
                {
                }
                else
                {
                    MessageBox.Show("Please Enter A Valid Page No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Book_Price.Clear();
                    txt_Book_Price.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Page No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Book_Price.Clear();
                txt_Book_Price.Focus();
            }
        }
    }
}
