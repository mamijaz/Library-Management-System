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
    public partial class Lending : Form
    {
        Library_Management info = new Library_Management();
        public Lending()
        {
            InitializeComponent();
            dtp_Membership_Date.Enabled = false;
            btn_Submit.Enabled = false;
            this.txt_Member_Id.LostFocus += new System.EventHandler
         (this.txt_Member_Id_LostFocus);
            this.txt_Book_Id.LostFocus += new System.EventHandler
         (this.txt_Book_Id_LostFocus);
            txt_Member_Id.Enabled = false;
            btn_Submit.Enabled = false;
            dtp_Lending_Date.Enabled = false;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_Circulation_No_Display.Text="";
            txt_Book_Id.Clear();
            lbl_Catagory_Number_Display.Text = "";
            txt_Member_Id.Clear();
            lbl_Bool_Title_Display.Text = "";
            lbl_Book_Author_Display.Text = "";
            lbl_Satatus_Display.Text = "";
            lbl_Book_Section_Display.Text = "";
            btn_Submit.Enabled = false;
            txt_Book_Id.Enabled = true;
            txt_Member_Id.Enabled = false;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                info.Lend_Books(int.Parse(lbl_Circulation_No_Display.Text),int.Parse(txt_Member_Id.Text),int.Parse(txt_Book_Id.Text),dtp_Lending_Date.Value);
                MessageBox.Show("Book Is Succesfully Lended","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btn_Submit.Enabled = false;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btn_Submit.Enabled = false;
            DataSet ds = info.List_Of_Lended_Books(int.Parse(txt_Member_Id.Text));
            dgv_Member.DataSource = ds.Tables["Lended Book Details"];
        }
        private void txt_Member_Id_LostFocus(object sender, System.EventArgs e)
        {
            SqlDataReader q = info.Find_Members_Basic(int.Parse(txt_Member_Id.Text));
            if (q.Read())
            {
                dtp_Membership_Date.Text = q[7].ToString();

                info.Set_Membership_Status(int.Parse(txt_Member_Id.Text), dtp_Membership_Date.Value);

                SqlDataReader z = info.Find_Membership_Status(int.Parse(txt_Member_Id.Text));
                if (z.Read())
                {
                    lbl_Satatus_Display.Text = z[0].ToString();
                }

                DataSet ds = info.List_Of_Lended_Books(int.Parse(txt_Member_Id.Text));
                dgv_Member.DataSource = ds.Tables["Lended Book Details"];

                if (lbl_Satatus_Display.Text == "Active")
                {

                    int p = info.Find_No_Book_To_Returned(int.Parse(txt_Member_Id.Text));

                    if (p >= 2)
                    {
                        MessageBox.Show("Lended Books Are Not Returend Yet","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txt_Member_Id.Clear();
                        txt_Member_Id.Focus();
                        btn_Submit.Enabled = false;
                    }
                    else
                    {
                        SqlDataReader x = info.Find_Circulation_No();
                        if (x.Read())
                        {
                            string Count = x[0].ToString();
                            int Count_2;
                            if (int.TryParse(Count, out Count_2))
                            {

                            }
                            Count_2++;
                            lbl_Circulation_No_Display.Text = Count_2.ToString();
                        }
                        txt_Member_Id.Enabled = false;
                        btn_Submit.Enabled = true;

                    }
                }
                else
                {
                    MessageBox.Show("Membership Suspended","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_Member_Id.Clear();
                    txt_Member_Id.Focus();
                    btn_Submit.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("The Member Does Not Exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_Member_Id.Clear();
                txt_Member_Id.Focus();
                btn_Submit.Enabled = false;
            }
        }
        private void txt_Book_Id_LostFocus(object sender, System.EventArgs e)
        {
            SqlDataReader y = info.Find_Book(int.Parse(txt_Book_Id.Text));
            if (y.Read())
            {
                lbl_Catagory_Number_Display.Text = y[1].ToString();
                lbl_Book_Section_Display.Text = y[2].ToString();
                lbl_Bool_Title_Display.Text = y[3].ToString();
                lbl_Book_Author_Display.Text = y[4].ToString();

                if (lbl_Book_Section_Display.Text == "Lending" || lbl_Book_Section_Display.Text == "Children Lending")
                {
                    SqlDataReader r = info.Find_Book_Status(int.Parse(txt_Book_Id.Text));
                    if (r.Read())
                    {
                        if (r[0].ToString() == "Yes")
                        {
                            txt_Book_Id.Enabled = false;
                            txt_Member_Id.Focus();
                        }
                        else if (r[0].ToString() == "No")
                        {
                            MessageBox.Show("This Book Is Alredy Lended,Check The Book Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_Book_Id.Clear();
                            txt_Book_Id.Focus();
                            txt_Member_Id.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("This Book Is Alredy Lost,Check The Book Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_Book_Id.Clear();
                            txt_Book_Id.Focus();
                            txt_Member_Id.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This Book Cannot Be Lended", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Book_Id.Clear();
                    txt_Book_Id.Focus();
                    txt_Member_Id.Enabled = false;
                }
            }
            else
            {
                txt_Book_Id.Clear();
                txt_Book_Id.Focus();
                MessageBox.Show("The Book Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Member_Id.Enabled = false;
            }
        }

        private void txt_Book_Id_TextChanged(object sender, EventArgs e)
        {
            txt_Member_Id.Enabled = true;
        }

        private void txt_Member_Id_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    }
}
