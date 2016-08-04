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
    public partial class Reference : Form
    {
        Library_Management info = new Library_Management();
        public Reference()
        {
            InitializeComponent();
            this.txt_NIC.LostFocus += new System.EventHandler
         (this.txt_NIC_LostFocus);
            this.txt_Contact_No.LostFocus += new System.EventHandler
         (this.txt_Contact_No_LostFocus);
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader y = info.Find_Outsider(txt_NIC.Text);
                if (y.Read())
                {
                    MessageBox.Show("Outsider Alredy Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    info.Insert_Outsiders(txt_NIC.Text, txt_Name.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text,int.Parse(txt_Contact_No.Text));
                    MessageBox.Show("Insert Succes","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Give_Book.Enabled = true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_NIC.Clear();
            txt_Name.Clear();
            txt_Address_Line1.Clear();
            txt_Address_Line2.Clear();
            txt_Address_Line3.Clear();
            btn_Give_Book.Enabled = false;
            txt_NIC.Enabled = true;
            btn_Insert.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            info.Update_Outsiders(txt_NIC.Text, txt_Name.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text,int.Parse(txt_Contact_No.Text));
            MessageBox.Show("Update Sucssus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Reference_Load(object sender, EventArgs e)
        {
            btn_Give_Book.Enabled = false;
            btn_Get_Book.Enabled = false;
            gbo_Outsider.Enabled = false;
            DataSet ds = info.List_Of_Books_Given_To_Reference();
            dgv_Information.DataSource = ds.Tables["List_Of_Books_Given_To_Reference"];
            btn_Insert.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void btn_Search_Book_Click(object sender, EventArgs e)
        {
            SqlDataReader y = info.Find_Book(int.Parse(txt_Book_Id.Text));
            if (y.Read())
            {
                lbl_Book_Catagory_Display_In.Text = y[1].ToString();
                lbl_Book_Title_Display_In.Text = y[3].ToString();

                SqlDataReader z = info.Find_Book_Status(int.Parse(txt_Book_Id.Text));
                if (z.Read())
                {
                    if (z[1].ToString() == "Yes")
                    {

                        SqlDataReader x = info.Find_Reference_No();
                        if (x.Read())
                        {
                            string Count = x[0].ToString();
                            int Count_2;
                            if (int.TryParse(Count, out Count_2))
                            {

                            }
                            Count_2++;
                            lbl_Reference_No_Display.Text = Count_2.ToString();
                        }
                        gbo_Outsider.Enabled = true;
                        txt_NIC.Focus();
                        txt_Book_Id.Enabled = false;
                        txt_NIC.Enabled = true;
                    }
                    else if (z[1].ToString() == "No")
                    {
                        MessageBox.Show("The Book Has Been Lended, Please Check The Book Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Book_Id.Clear();
                        txt_Book_Id.Focus();
                    }
                    else
                    {
                        MessageBox.Show("The Book Has Been Lost Alredy, Please Check The Book Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Book_Id.Clear();
                        txt_Book_Id.Focus();
                    }

                }
            }
            else
            {
                MessageBox.Show("The Book Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Book_Id.Clear();
                txt_Book_Id.Focus();
            }
        }

        private void btn_Search_Referance_No_Click(object sender, EventArgs e)
        {
            int i;
            if(int.TryParse(txt_Referance_No.Text,out i))
            {
                 SqlDataReader y = info.Find_Reference_Details(int.Parse(txt_Referance_No.Text));
                 if (y.Read())
                 {
                     dtp_Referance_Date.Text = y[1].ToString();
                     txt_NIC.Text = y[2].ToString();
                     lbl_Book_Id_Display.Text = y[3].ToString();
                     dtp_In_Time.Text = y[4].ToString();
                     string s = y[5].ToString();
                     if (s == "")
                     {
                         SqlDataReader x = info.Find_Book(int.Parse(lbl_Book_Id_Display.Text));
                         if (x.Read())
                         {
                             lbl_Catogory_No_Display.Text = x[1].ToString();
                             lbl_Book_Title_Display.Text = x[3].ToString();
                         }
                         SqlDataReader z = info.Find_Outsider(txt_NIC.Text);
                         if (z.Read())
                         {
                             txt_Name.Text = z[1].ToString();
                             txt_Address_Line1.Text = z[2].ToString();
                             txt_Address_Line2.Text = z[3].ToString();
                             txt_Address_Line3.Text = z[4].ToString();
                         }
                         gbo_Outsider.Enabled = false;
                         btn_Get_Book.Enabled = true;
                     }
                     else
                     {
                         MessageBox.Show("The Book Is Alredy Returned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         txt_Referance_No.Clear();
                         txt_Referance_No.Focus();
                     }
                 }
                 else
                 {
                     MessageBox.Show("The Reference No Do Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     txt_Referance_No.Clear();
                     txt_Referance_No.Focus();
                 }
            }
            else
            {
                MessageBox.Show("Enter a Valid Reference No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Referance_No.Clear();
                txt_Referance_No.Focus();
            }

        }

        private void btn_Clear_All_Click(object sender, EventArgs e)
        {
            txt_NIC.Clear();
            txt_Name.Clear();
            txt_Address_Line1.Clear();
            txt_Address_Line2.Clear();
            txt_Address_Line3.Clear();
            lbl_Reference_No_Display.Text = "";
            lbl_Catogory_No_Display.Text = "";
            lbl_Book_Title_Display.Text = "";
            lbl_Book_Id_Display.Text = "";
            txt_Referance_No.Clear();
            lbl_Reference_No_Display.Text = "";
            txt_Book_Id.Clear();
            lbl_Book_Catagory_Display_In.Text = "";
            lbl_Book_Title_Display_In.Text = "";
            btn_Get_Book.Enabled = false;
            btn_Give_Book.Enabled = false;
            gbo_Outsider.Enabled = false;
            txt_Book_Id.Enabled = true;
            btn_Insert.Enabled = false;
            btn_Update.Enabled = false;

        }

        private void btn_Give_Book_Click(object sender, EventArgs e)
        {
            info.Give_Books_For_Reference(int.Parse(lbl_Reference_No_Display.Text), dtp_Reference_Date_In.Value, txt_NIC.Text, int.Parse(txt_Book_Id.Text), dtp_In_Time_In.Value);
            MessageBox.Show("Book Is Succesfully Givend To Reading", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet ds = info.List_Of_Books_Given_To_Reference();
            dgv_Information.DataSource = ds.Tables["List_Of_Books_Given_To_Reference"];
            btn_Give_Book.Enabled = false;
        }

        private void btn_Get_Book_Click(object sender, EventArgs e)
        {
            info.Get_Books_From_Reference(int.Parse(txt_Referance_No.Text), dtp_Out_Time.Value,int.Parse(lbl_Book_Id_Display.Text));
            MessageBox.Show("Book Is Return From Reading", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet ds = info.List_Of_Books_Given_To_Reference();
            dgv_Information.DataSource = ds.Tables["List_Of_Books_Given_To_Reference"];
            btn_Get_Book.Enabled = false;
        }
        private void txt_NIC_LostFocus(object sender, System.EventArgs e)
        {
            if (txt_NIC.TextLength == 10)
            {
                int i;
                string s = txt_NIC.Text.Substring(0, 9);
                string s2 = txt_NIC.Text.Substring(9, 1);
                if (s2 == "V" || s2 == "X")
                {
                    if (int.TryParse(s, out i))
                    {
                        SqlDataReader y = info.Find_Outsider(txt_NIC.Text);
                        if (y.Read())
                        {
                            txt_Name.Text = y[1].ToString();
                            txt_Address_Line1.Text = y[2].ToString();
                            txt_Address_Line2.Text = y[3].ToString();
                            txt_Address_Line3.Text = y[4].ToString();
                            txt_Contact_No.Text = y[5].ToString();
                            btn_Give_Book.Enabled = true;
                            txt_NIC.Enabled = false;
                            btn_Insert.Enabled = false;
                            btn_Update.Enabled = true;
                            MessageBox.Show("Record Exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            btn_Insert.Enabled = true;
                            btn_Update.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Input A Correct NIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_NIC.Clear();
                        txt_NIC.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please Input A Correct NIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_NIC.Clear();
                    txt_NIC.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Input A Correct NIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NIC.Clear();
                txt_NIC.Focus();
            }

        }
        private void txt_Contact_No_LostFocus(object sender, System.EventArgs e)
        {
            if (txt_Contact_No.Text.Length == 10)
            {
                int i;
                if (int.TryParse(txt_Contact_No.Text, out i))
                {
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Contact_No.Clear();
                }
            }
            else if (txt_Contact_No.Text.Length == 0)
            {
                txt_Contact_No.Text = "0";
            }
            else if (txt_Contact_No.Text.Length == 1)
            {
                txt_Contact_No.Text = "0";
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contact_No.Clear();
                txt_Contact_No.Focus();
            }
        }
    }
}
