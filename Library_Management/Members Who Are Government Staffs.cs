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
    public partial class Members_Who_Are_Government_Staffs : Form
    {
        Library_Management info = new Library_Management();
        public Members_Who_Are_Government_Staffs()
        {
            InitializeComponent();
            btn_Update.Enabled = false;
            lbl_Staff_Name_Display.Text = Library_Management.Staff_Name;
            this.txt_Member_Id.LostFocus += new System.EventHandler
        (this.txt_Member_Id_LostFocus);
            this.txt_NIC.LostFocus += new System.EventHandler
        (this.txt_NIC_LostFocus);
            this.txt_Mobile.LostFocus += new System.EventHandler
         (this.txt_Mobile_LostFocus);
            this.txt_Office.LostFocus += new System.EventHandler
         (this.txt_Office_LostFocus);
            this.txt_Home.LostFocus += new System.EventHandler
         (this.txt_Home_LostFocus);
            this.txt_Receipt_No.LostFocus += new System.EventHandler
        (this.txt_Receipt_No_LostFocus);

        }
        private string M_Type = "Members_Who_Are_Government_Staff";
        private DateTime d;

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                info.Insert_Members_Basic(int.Parse(txt_Member_Id.Text), txt_Full_Name.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text, txt_NIC.Text,dtp_DOB.Value, dtp_Membership_Date.Value,M_Type);
                info.Insert_Member_Contact(int.Parse(txt_Member_Id.Text), int.Parse(txt_Mobile.Text), int.Parse(txt_Home.Text), int.Parse(txt_Office.Text));
                info.Insert_Job_Details(int.Parse(txt_Member_Id.Text), txt_Job.Text, txt_Office_Name.Text, txt_Office_Address_Line1.Text, txt_Office_Address_Line2.Text, txt_Office_Address_Line3.Text);
                info.Insert_Membership_Status(int.Parse(txt_Member_Id.Text));
                info.Charge_Membership_Fee(int.Parse(txt_Member_Id.Text),dtp_Membership_Date.Value, double.Parse(cbo_Registration_Fee.Text),int.Parse(txt_Receipt_No.Text));
                MessageBox.Show("Member Is Sccesfully Added To Database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btn_Register.Enabled = false;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Member_Id.Clear();
            txt_Full_Name.Clear();
            txt_Address_Line1.Clear();
            txt_Address_Line2.Clear();
            txt_Address_Line3.Clear();
            txt_NIC.Clear();
            txt_Office.Text = "0";
            txt_Mobile.Text = "0";
            txt_Home.Text = "0";
            txt_Job.Clear();
            txt_Office_Name.Clear();
            txt_Office_Address_Line1.Clear();
            txt_Office_Address_Line2.Clear();
            txt_Office_Address_Line3.Clear();
            txt_Receipt_No.Clear();
            btn_Register.Enabled = true;
            txt_Member_Id.Enabled = true;
            btn_Update.Enabled = false;

        }



        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (d != dtp_Membership_Date.Value)
                {
                    info.Update_Members_Basic(int.Parse(txt_Member_Id.Text), txt_Full_Name.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text, txt_NIC.Text,dtp_DOB.Value, dtp_Membership_Date.Value, M_Type);
                    info.Update_Member_Contact(int.Parse(txt_Member_Id.Text), int.Parse(txt_Mobile.Text), int.Parse(txt_Home.Text), int.Parse(txt_Office.Text));
                    info.Update_Job_Details(int.Parse(txt_Member_Id.Text), txt_Job.Text, txt_Office_Name.Text, txt_Office_Address_Line1.Text, txt_Office_Address_Line2.Text, txt_Office_Address_Line3.Text);
                    info.Charge_Membership_Fee(int.Parse(txt_Member_Id.Text), dtp_Membership_Date.Value, double.Parse(cbo_Registration_Fee.Text), int.Parse(txt_Receipt_No.Text));
                    MessageBox.Show("Update Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    info.Update_Members_Basic(int.Parse(txt_Member_Id.Text), txt_Full_Name.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text, txt_NIC.Text, dtp_DOB.Value, dtp_Membership_Date.Value, M_Type);
                    info.Update_Member_Contact(int.Parse(txt_Member_Id.Text), int.Parse(txt_Mobile.Text), int.Parse(txt_Home.Text), int.Parse(txt_Office.Text));
                    info.Update_Job_Details(int.Parse(txt_Member_Id.Text), txt_Job.Text, txt_Office_Name.Text, txt_Office_Address_Line1.Text, txt_Office_Address_Line2.Text, txt_Office_Address_Line3.Text);
                    MessageBox.Show("Update Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
             txt_Member_Id.Text = (info.Find_Member_Id()).ToString();
        }

        private void txt_Member_Id_LostFocus(object sender, System.EventArgs e)
        {
            SqlDataReader y = info.Find_Members_Basic(int.Parse(txt_Member_Id.Text));
            if (y.Read())
            {
                MessageBox.Show("Record Exist In Database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Full_Name.Text = y[1].ToString();
                txt_Address_Line1.Text = y[2].ToString();
                txt_Address_Line2.Text = y[3].ToString();
                txt_Address_Line3.Text = y[4].ToString();
                txt_NIC.Text = y[5].ToString();
                dtp_DOB.Text = y[6].ToString();
                dtp_Membership_Date.Text = y[7].ToString();
                d = dtp_Membership_Date.Value;
                SqlDataReader z = info.Find_Member_Contact(int.Parse(txt_Member_Id.Text));
                if (z.Read())
                {
                    txt_Mobile.Text = z[1].ToString();
                    txt_Home.Text = z[2].ToString();
                    txt_Office.Text = z[3].ToString();
                }

                SqlDataReader x = info.Find_Job_Details(int.Parse(txt_Member_Id.Text));
                if (x.Read())
                {
                    txt_Job.Text = x[1].ToString();
                    txt_Office_Name.Text = x[2].ToString();
                    txt_Office_Address_Line1.Text = x[3].ToString();
                    txt_Office_Address_Line2.Text = x[4].ToString();
                    txt_Office_Address_Line3.Text = x[5].ToString();
                }
                btn_Register.Enabled = false;
                txt_Member_Id.Enabled = false;
                btn_Update.Enabled = true;
                gbo_Registration_Fee.Enabled = false;
            }
        }

        private void dtp_Membership_Date_ValueChanged(object sender, EventArgs e)
        {
            gbo_Registration_Fee.Enabled = true;
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
        private void txt_Mobile_LostFocus(object sender, System.EventArgs e)
        {
            if (txt_Mobile.Text.Length == 10)
            {
                int i;
                if (int.TryParse(txt_Mobile.Text, out i))
                {
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Mobile.Text = "0";
                }
            }
            else if (txt_Mobile.Text.Length == 0)
            {
                txt_Mobile.Text = "0";
            }
            else if (txt_Mobile.Text.Length == 1)
            {
                txt_Mobile.Text = "0";
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Mobile.Clear();
                txt_Mobile.Focus();
            }
        }
        private void txt_Office_LostFocus(object sender, System.EventArgs e)
        {
            if (txt_Office.Text.Length == 10)
            {
                int i;
                if (int.TryParse(txt_Office.Text, out i))
                {
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Office.Text = "0";
                }
            }
            else if (txt_Office.Text.Length == 0)
            {
                txt_Office.Text = "0";
            }
            else if (txt_Office.Text.Length == 1)
            {
                txt_Office.Text = "0";
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Office.Clear();
                txt_Office.Focus();
            }
        }

        private void txt_Home_LostFocus(object sender, System.EventArgs e)
        {
            if (txt_Home.Text.Length == 10)
            {
                int i;
                if (int.TryParse(txt_Home.Text, out i))
                {
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Home.Text = "0";
                }
            }
            else if (txt_Home.Text.Length == 0)
            {
                txt_Home.Text = "0";
            }
            else if (txt_Home.Text.Length == 1)
            {
                txt_Home.Text = "0";
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Home.Clear();
                txt_Home.Focus();
            }
        }
        private void txt_Receipt_No_LostFocus(object sender, System.EventArgs e)
        {
            int i;
            if (int.TryParse(txt_Receipt_No.Text, out i))
            {
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Recipt No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Receipt_No.Text = "0";
            }
        }

        private void txt_Member_Id_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(txt_Member_Id.Text, out i))
            {
            }
            else
            {
                MessageBox.Show("Please Input a Valid Member Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Member_Id.Clear();
                txt_Member_Id.Focus();
            }
        }

    }
}
