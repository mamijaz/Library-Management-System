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
    public partial class Book_Detaile_Search : Form
    {
        Library_Management info = new Library_Management();
        public Book_Detaile_Search()
        {
            InitializeComponent();
            gbo_Curently_With.Visible = false;
            lbl_Status.Visible = false;
        }

        private void btn_Find_Book_Click(object sender, EventArgs e)
        {
            SqlDataReader y = info.Find_Book(int.Parse(txt_Book_Id.Text));
            if (y.Read())
            {
                MessageBox.Show("Book Exist In Database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Book_Catagory_No_Display.Text = y[1].ToString();
                lbl_Book_Section_Display.Text = y[2].ToString();
                lbl_Book_Title_Display.Text = y[3].ToString();
                lbl_Book_Author_Display.Text = y[4].ToString();
                lbl_Book_Publisher_Dispaly.Text = y[5].ToString();
                lbl_Book_Publish_place_Display.Text = y[6].ToString();
                lbl_Book_Price_Display.Text = y[7].ToString();
                dtp_Date_Book_Recived.Text = y[8].ToString();
                lbl_No_of_Pages_Dispaly.Text = y[9].ToString();
                lbl_Book_Source_Display.Text = y[10].ToString();

                SqlDataReader x = info.Find_Book_Status(int.Parse(txt_Book_Id.Text));
                if (x.Read())
                {
                    if (x[0].ToString() == "No")
                    {
                        gbo_Curently_With.Visible = true;
                        SqlDataReader z = info.Find_Who_Has_The_Book(int.Parse(txt_Book_Id.Text));
                        if (z.Read())
                        {
                            lbl_Member_Id_Display.Text = z[1].ToString();
                            SqlDataReader p = info.Find_Members_Basic(int.Parse(lbl_Member_Id_Display.Text));
                            if (p.Read())
                            {
                                lbl_Name.Text = p[1].ToString();
                                lbl_Address_Line_1.Text = p[2].ToString();
                                lbl_Address_Line_2.Text = p[3].ToString();
                                lbl_Address_Line_3.Text = p[4].ToString();
                            }
                            dtp_Retun_due_Date.Text = z[3].ToString();
                            DateTime Date = dtp_Retun_due_Date.Value;
                            Date = Date.AddDays(14);
                            dtp_Retun_due_Date.Text = Date.ToString();
                        }

                    }
                    else if (x[0].ToString() == "Yes")
                    {
                        lbl_Status.Text = "This Book Is Curently In Library";
                        lbl_Status.Visible = true;
                    }
                    else
                    {
                        lbl_Status.Text = "This Book Is Lost";
                        lbl_Status.Visible = true;
                    }

                }
                DataSet ds = info.Find_Who_Have_Used_The_Book(int.Parse(txt_Book_Id.Text));
                dgv_Users.DataSource = ds.Tables["Books_Users"];
                btn_Find_Book.Enabled = false;
            }
            else
            {
                MessageBox.Show("Book Do Not Exist In Database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Book_Id.Clear();
            Book_Catagory_No_Display.Text = "";
            lbl_Book_Section_Display.Text = "";
            lbl_Book_Title_Display.Text = "";
            lbl_Book_Author_Display.Text = "";
            lbl_Book_Publisher_Dispaly.Text = "";
            lbl_Book_Publish_place_Display.Text = "";
            lbl_Book_Price_Display.Text = "";
            lbl_No_of_Pages_Dispaly.Text = "";
            lbl_Book_Source_Display.Text = "";
            lbl_Status.Visible = false;
            gbo_Curently_With.Visible = false;
            btn_Find_Book.Enabled = true;
        }

        private void Book_Detaile_Search_Load(object sender, EventArgs e)
        {
           
        }

    
    }
}
