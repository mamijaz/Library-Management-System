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
    public partial class Multimedia : Form
    {
        Library_Management info = new Library_Management();
        public Multimedia()
        {
            InitializeComponent();
            this.dtp_In_Time.LostFocus += new System.EventHandler
         (this.dtp_In_Time_LostFocus);
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
                     MessageBox.Show("Insert Succes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     btn_Charge.Enabled = true;
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
            btn_Charge.Enabled = false;
            txt_NIC.Enabled = true;
            btn_Insert.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            info.Update_Outsiders(txt_NIC.Text, txt_Name.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text,int.Parse(txt_Contact_No.Text));
            MessageBox.Show("Update Sucssus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Multimedia_Load(object sender, EventArgs e)
        {
            lbl_Staff_Name_Display.Text = Library_Management.Staff_Name;
            DataSet ds = info.Find_Multimedia_Usage_Details(dtp_date.Value);
            dgv_Usage_Details.DataSource = ds.Tables["Uasge For The Day"];
            btn_Charge.Enabled = false;
            gbo_Outsider.Enabled = false;
            txt_Recipt_No.Enabled = false;
            btn_Insert.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void btn_Charge_Click(object sender, EventArgs e)
        {
            info.Insert_Charges_For_Multimedia(int.Parse(lbl_Circulation_No_Display.Text), txt_NIC.Text, dtp_date.Value, dtp_In_Time.Value, dtp_Out_Time.Value, dtp_Duration.Value, double.Parse(lbl_Cost_Display.Text), int.Parse(txt_Recipt_No.Text));
            MessageBox.Show("Transaction Succes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet ds = info.Find_Multimedia_Usage_Details(dtp_date.Value);
            dgv_Usage_Details.DataSource = ds.Tables["Uasge For The Day"];
            btn_Charge.Enabled = false;
            gbo_Outsider.Enabled = false;
            btn_Insert.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void btn_Clear_All_Click(object sender, EventArgs e)
        {
            txt_NIC.Clear();
            txt_Name.Clear();
            txt_Address_Line1.Clear();
            txt_Address_Line2.Clear();
            txt_Address_Line3.Clear();
            lbl_Circulation_No_Display.Text = "";
            lbl_Cost_Display.Text = "";
            txt_Recipt_No.Clear();
            btn_Charge.Enabled = false;
            gbo_Outsider.Enabled = false;
            dtp_In_Time.Enabled = true;
            txt_Recipt_No.Enabled = false;
            btn_Insert.Enabled = false;
            btn_Update.Enabled = false;
        }
        private void dtp_In_Time_LostFocus(object sender, System.EventArgs e)
        {
            SqlDataReader x = info.Find_Mutimedia_Usage_No();
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
            dtp_Duration.Text = ((((dtp_Out_Time.Value).AddMinutes(1)).Subtract(dtp_In_Time.Value))).ToString();
            double Cost1 = ((dtp_Duration.Value).Minute) * 0.6666;
            double Cost2 = ((dtp_Duration.Value).Hour) * 40;
            double Cost3 = Cost1 + Cost2;
            lbl_Cost_Display.Text = (Math.Round(Cost3, 0)).ToString();
            txt_Recipt_No.Focus();
            dtp_In_Time.Enabled = false;
            txt_Recipt_No.Enabled = true;
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
                                btn_Charge.Enabled = true;
                                txt_NIC.Enabled = false;
                                btn_Insert.Enabled = false;
                                btn_Update.Enabled = true;
                                MessageBox.Show("Record Exisit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txt_Recipt_No_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(txt_Recipt_No.Text, out i))
            {
                if (i > 0)
                {
                    gbo_Outsider.Enabled = true;
                    txt_Recipt_No.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Recipt No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Recipt_No.Clear();
                    txt_Recipt_No.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Recipt No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Recipt_No.Clear();
                txt_Recipt_No.Focus();
            }
        }

        private void dtp_In_Time_ValueChanged(object sender, EventArgs e)
        {
            txt_Recipt_No.Enabled = true;
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
