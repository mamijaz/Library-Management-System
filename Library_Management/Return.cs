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
    public partial class Return : Form
    {
        Library_Management info = new Library_Management();
        public Return()
        {
            InitializeComponent();
            lbl_Staff_Name_Display.Text = Library_Management.Staff_Name;
            this.txt_Circulation_No.LostFocus += new System.EventHandler
         (this.txt_Circulation_No_LostFocus);
            this.txt_Fine_Amount.LostFocus += new System.EventHandler
         (this.txt_Fine_Amount_LostFocus);
            this.txt_Reciept_No.LostFocus += new System.EventHandler
         (this.txt_Reciept_No_LostFocus);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Circulation_No.Clear();
            lbl_Member_Id_Display.Text = "";
            lbl_Book_Id_Display.Text = "";
            lbl_Book_Catagory_No_Display.Text = "";
            lbl_Book_Title_Display.Text = "";
            txt_Fine_Amount.Text = "0";
            txt_Reciept_No.Text = "0";
            txt_Circulation_No.Enabled = true;
            DataSet ds = info.List_Of_Books_To_Be_Returned();
            dgv_Books_To_Be_Returned.DataSource = ds.Tables["Lended Book Details"];
            btn_Return.Enabled = false;
            txt_Fine_Amount.Enabled = false;
            txt_Reciept_No.Enabled = false;
        }

        private void Return_Load(object sender, EventArgs e)
        {
            DataSet ds = info.List_Of_Books_To_Be_Returned();
            dgv_Books_To_Be_Returned.DataSource = ds.Tables["Lended Book Details"];
            btn_Return.Enabled = false;
            txt_Fine_Amount.Enabled = false;
            txt_Reciept_No.Enabled = false;
            dtp_Return_Date.Enabled = false;
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
             SqlDataReader y = info.Find_Book_Status(int.Parse(lbl_Book_Id_Display.Text));
             if (y.Read())
             {
                 if (y[0].ToString() == "No")
                 {
                     info.Return_Books(int.Parse(txt_Circulation_No.Text), int.Parse(lbl_Book_Id_Display.Text), int.Parse(lbl_Member_Id_Display.Text), dtp_Lending_Date.Value, dtp_Return_Date.Value, double.Parse(txt_Fine_Amount.Text), int.Parse(txt_Reciept_No.Text));
                     MessageBox.Show("Transaction Succesfull");
                     btn_Return.Enabled = false;
                     DataSet ds = info.List_Of_Books_To_Be_Returned();
                     dgv_Books_To_Be_Returned.DataSource = ds.Tables["Lended Book Details"];
                 }
                 else if (y[0].ToString() == "Lost")
                 {
                     MessageBox.Show("This Book Is Alredy Lost");
                 }
                 else
                 {
                     MessageBox.Show("This Book Is Alredy Returnd");
                 }
             }
        }

        private void txt_Circulation_No_LostFocus(object sender, System.EventArgs e)
        {
            int i;
            if(int.TryParse(txt_Circulation_No.Text,out i))
            {
                SqlDataReader y = info.Find_Lended_Details(int.Parse(txt_Circulation_No.Text));
                if (y.Read())
                {
                    lbl_Member_Id_Display.Text = y[1].ToString();
                    lbl_Book_Id_Display.Text = y[2].ToString();
                    dtp_Lending_Date.Text = y[3].ToString();

                    SqlDataReader z = info.Find_Book(int.Parse(lbl_Book_Id_Display.Text));
                    if (z.Read())
                    {
                        lbl_Book_Catagory_No_Display.Text = z[1].ToString();
                        lbl_Book_Title_Display.Text = z[3].ToString();
                    }
                    txt_Fine_Amount.Text = (info.Find_Late_Fine(dtp_Lending_Date.Value, dtp_Return_Date.Value)).ToString();
                    txt_Circulation_No.Enabled = false;

                    if (double.Parse(txt_Fine_Amount.Text) == 0)
                    {
                        btn_Return.Enabled = true;
                        txt_Fine_Amount.Enabled = false;
                    }
                    else
                    {
                        txt_Fine_Amount.Focus();
                        txt_Fine_Amount.Enabled = true;
                        txt_Fine_Amount.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Circulation No Do not exist");
                    txt_Circulation_No.Clear();
                    txt_Circulation_No.Focus();
                    txt_Fine_Amount.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Enter a valid circulation no");
                txt_Circulation_No.Clear();
                txt_Circulation_No.Focus();
                txt_Fine_Amount.Enabled = false;
            }

        }

        private void txt_Fine_Amount_LostFocus(object sender, System.EventArgs e)
        {
            double i;
            if (double.TryParse(txt_Fine_Amount.Text, out i))
            {
                if (i == 0)
                {
                    btn_Return.Focus();
                    btn_Return.Enabled = true;
                }
                else if (i > 0)
                {
                    txt_Fine_Amount.Enabled = false;
                    txt_Reciept_No.Focus();
                    txt_Reciept_No.Enabled = true;
                }
                else
                {
                    txt_Fine_Amount.Enabled = false;
                    txt_Fine_Amount.Clear();
                    txt_Circulation_No.Focus();

                }
            }
            else
            {
                MessageBox.Show("Please Enter a valid fine");
            }
        }

        private void txt_Reciept_No_LostFocus(object sender, System.EventArgs e)
        {
            int i;
            if (int.TryParse(txt_Reciept_No.Text, out i))
            {
                if (i >= 0)
                {
                    btn_Return.Enabled = true;
                    txt_Reciept_No.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter a valid Recipt No");
                txt_Reciept_No.Clear();
                txt_Reciept_No.Focus();
            }
        }

        private void txt_Fine_Amount_TextChanged(object sender, EventArgs e)
        {
            double i;
            if(double.TryParse(txt_Fine_Amount.Text,out i))
            {
                if(i==0)
                {
                    btn_Return.Enabled=true;
                    txt_Fine_Amount.Enabled=false;
                    txt_Reciept_No.Enabled = false;
                }
            }
        }

        private void txt_Circulation_No_TextChanged(object sender, EventArgs e)
        {
            txt_Fine_Amount.Enabled = true;
        }
    }
}
