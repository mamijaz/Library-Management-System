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
    public partial class Lost : Form
    {
        Library_Management info = new Library_Management();
        public Lost()
        {
            InitializeComponent();
            lbl_Staff_Name_Display.Text = Library_Management.Staff_Name;
            this.txt_Circulation_No.LostFocus += new System.EventHandler
          (this.txt_Circulation_No_LostFocus);
            this.cbo_Binding_Charge.LostFocus += new System.EventHandler
          (this.cbo_Binding_Charge_LostFocus);
            this.txt_Late_Fine.LostFocus += new System.EventHandler
          (this.txt_Late_Fine_LostFocus);
            this.txt_Receipt_No.LostFocus += new System.EventHandler
         (this.txt_Receipt_No_LostFocus);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Circulation_No.Clear();
            txt_Late_Fine.Text = "0";
            lbl_Total_Lost_Fine.Text = "0";
            txt_Receipt_No.Text = "0";
            lbl_Fine_For_Lost_Display.Text = "";
            lbl_Member_Id_Display.Text = "";
            lbl_Book_Id_Display.Text = "";
            lbl_Book_Catagory_No_Display.Text = "";
            lbl_Book_Title_Display.Text = "";
            DataSet ds = info.List_Of_Books_To_Be_Returned();
            dgv_Books_To_Be_Returned.DataSource = ds.Tables["Lended Book Details"];
            btn_Submit.Enabled = false;
            txt_Late_Fine.Enabled = false;
            txt_Receipt_No.Enabled = false;
            cbo_Binding_Charge.Enabled = false;
            txt_Circulation_No.Enabled = true;
        }

        private void Lost_Load(object sender, EventArgs e)
        {
            DataSet ds = info.List_Of_Books_To_Be_Returned();
            dgv_Books_To_Be_Returned.DataSource = ds.Tables["Lended Book Details"];
            btn_Submit.Enabled = false;
            txt_Late_Fine.Enabled = false;
            txt_Receipt_No.Enabled = false;
            cbo_Binding_Charge.Enabled = false;
            dtp_Lost_Date.Enabled = false;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlDataReader y = info.Find_Book_Status(int.Parse(lbl_Book_Id_Display.Text));
            if (y.Read())
            {
                if (y[0].ToString() == "No")
                {
                    info.Lost_Books(int.Parse(txt_Circulation_No.Text), int.Parse(lbl_Book_Id_Display.Text), int.Parse(lbl_Member_Id_Display.Text), dtp_Lending_Date.Value, dtp_Lost_Date.Value, double.Parse(lbl_Fine_For_Lost_Display.Text), double.Parse(txt_Late_Fine.Text), double.Parse(cbo_Binding_Charge.Text), double.Parse(lbl_Total_Lost_Fine.Text), int.Parse(txt_Receipt_No.Text));
                    MessageBox.Show("Transaction Succesfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Submit.Enabled = false;
                    DataSet ds = info.List_Of_Books_To_Be_Returned();
                    dgv_Books_To_Be_Returned.DataSource = ds.Tables["Lended Book Details"];
                }
                else if (y[0].ToString() == "Lost")
                {
                    MessageBox.Show("This Book Is Alredy Lost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Book Is Alredy Returnd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            lbl_Fine_For_Lost_Display.Text = (double.Parse((z[7].ToString())) * 1.25).ToString();
                        }
                        txt_Late_Fine.Text = (info.Find_Late_Fine(dtp_Lending_Date.Value, dtp_Lost_Date.Value)).ToString();
                        txt_Circulation_No.Enabled = false;
                        if (int.Parse(txt_Late_Fine.Text) == 0)
                        {
                            cbo_Binding_Charge.Enabled = true;
                            cbo_Binding_Charge.Focus();
                            txt_Late_Fine.Enabled = false;
                        }
                        else
                        {
                            txt_Late_Fine.Enabled = true;
                            txt_Late_Fine.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter A valid Circulation No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Circulation_No.Clear();
                        txt_Circulation_No.Focus();
                        txt_Late_Fine.Enabled = false;
                    }
                 
            }
          else
           {
               MessageBox.Show("Please Enter A valid Circulation No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Circulation_No.Clear();
                txt_Circulation_No.Focus();
                txt_Late_Fine.Enabled = false;
          }
        }

        private void cbo_Binding_Charge_LostFocus(object sender, System.EventArgs e)
        {
            lbl_Total_Lost_Fine.Text = (double.Parse(txt_Late_Fine.Text) + double.Parse(cbo_Binding_Charge.Text) + double.Parse(lbl_Fine_For_Lost_Display.Text)).ToString();
            txt_Receipt_No.Focus();
        }

        private void txt_Late_Fine_LostFocus(object sender, System.EventArgs e)
        {
            double i;
            if (double.TryParse(txt_Late_Fine.Text,out i))
            {
                if (i >= 0)
                {
                    cbo_Binding_Charge.Focus();
                    cbo_Binding_Charge.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please Correct The Fine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Circulation_No.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Correct The Fine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Circulation_No.Focus();
                cbo_Binding_Charge.Enabled = false;
            }
        }
        private void txt_Receipt_No_LostFocus(object sender, System.EventArgs e)
        {
            int i;
            if (int.TryParse(txt_Receipt_No.Text,out i))
            {
                if (i >= 0)
                {
                    btn_Submit.Enabled = true;
                    btn_Submit.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Recipt No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Receipt_No.Clear();
                    txt_Receipt_No.Focus();
                    btn_Submit.Enabled = false;
                }
            }
        }

        private void txt_Late_Fine_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txt_Late_Fine.Text) == 0)
            {
                cbo_Binding_Charge.Enabled = true;
            }
        }

        private void txt_Circulation_No_TextChanged(object sender, EventArgs e)
        {
            txt_Late_Fine.Enabled = true;
        }

        private void cbo_Binding_Charge_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Receipt_No.Enabled = true;
        }

        private void txt_Receipt_No_TextChanged(object sender, EventArgs e)
        {
            int i;
            if(int.TryParse(txt_Receipt_No.Text,out i))
            {
                if (i> 0)
                {
                    btn_Submit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Recipt No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Receipt_No.Clear();
                    txt_Receipt_No.Focus();
                    btn_Submit.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Recipt No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Receipt_No.Clear();
                txt_Receipt_No.Focus();
                btn_Submit.Enabled = false;
            }
        }

        
    }
}
