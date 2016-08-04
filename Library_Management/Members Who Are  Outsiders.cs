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
    public partial class Members_Who_Are__Outsiders : Form
    {
        Library_Management info = new Library_Management();
        public Members_Who_Are__Outsiders()
        {
            InitializeComponent();
            btn_Update.Enabled = false;
            lbl_Staff_Name_Display.Text = Library_Management.Staff_Name;
            this.txt_NIC.LostFocus += new System.EventHandler
        (this.txt_NIC_LostFocus);
            this.txt_Guarantee_NIC.LostFocus += new System.EventHandler
        (this.txt_Guarantee_NIC_LostFocus);
            this.txt_Member_Id.LostFocus += new System.EventHandler
      (this.txt_Member_Id_LostFocus);
            this.txt_Contact_No.LostFocus += new System.EventHandler
     (this.txt_Contact_No_LostFocus);
            this.txt_Receipt_No.LostFocus += new System.EventHandler
    (this.txt_Receipt_No_LostFocus);
        }
          private string M_Type = "Members_Who_Are_Outsiders";
          private string Relation = "None";
          private DateTime d;

        private void btn_Register_Click(object sender, EventArgs e)
        {
            
            try
            {
                info.Insert_Members_Basic(int.Parse(txt_Member_Id.Text), txt_Full_Name.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text, txt_NIC.Text, dtp_DOB.Value, dtp_Date_Of_Membership.Value, M_Type);
                info.Insert_Member_Contact(int.Parse(txt_Member_Id.Text), int.Parse(txt_Contact_No.Text));
                info.Insert_Job_Details(int.Parse(txt_Member_Id.Text), txt_Job.Text, txt_Office_Name.Text, txt_Office_Address_Line1.Text, txt_Office_Address_Line2.Text, txt_Office_Address_Line3.Text);
                info.Insert_Tax_Payer(int.Parse(txt_Member_Id.Text), txt_Guarantee_Name.Text, txt_Guarantee_NIC.Text, txt_Guarantee_Address_Line1.Text, txt_Guarantee_Address_Line2.Text, txt_Guarantee_Address_Line3.Text, Relation);
                info.Insert_Membership_Status(int.Parse(txt_Member_Id.Text));
                info.Charge_Membership_Fee(int.Parse(txt_Member_Id.Text), dtp_Date_Of_Membership.Value, double.Parse(cbo_Membership_Fee.Text),int.Parse(txt_Receipt_No.Text));
                MessageBox.Show("Member Is Sccesfully Added To Database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Register.Enabled = false;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Member_Id.Clear();
            txt_Full_Name.Clear();
            txt_Address_Line1.Clear();
            txt_Address_Line2.Clear();
            txt_Address_Line3.Clear();
            txt_NIC.Clear();
            txt_Contact_No.Text = "0";
            txt_Job.Clear();
            txt_Office_Address_Line1.Clear();
            txt_Office_Address_Line2.Clear();
            txt_Office_Address_Line3.Clear();
            txt_Guarantee_Name.Clear();
            txt_Guarantee_Address_Line1.Clear();
            txt_Guarantee_Address_Line2.Clear();
            txt_Guarantee_Address_Line3.Clear();
            txt_Guarantee_NIC.Clear();
            txt_Receipt_No.Clear();
            btn_Register.Enabled = true;
            txt_Member_Id.Enabled = true;
            btn_Update.Enabled = false;
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (d != dtp_Date_Of_Membership.Value)
                {
                    info.Charge_Membership_Fee(int.Parse(txt_Member_Id.Text), dtp_Date_Of_Membership.Value, double.Parse(cbo_Membership_Fee.Text), int.Parse(txt_Receipt_No.Text));
                    info.Update_Members_Basic(int.Parse(txt_Member_Id.Text), txt_Full_Name.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text, txt_NIC.Text,dtp_DOB.Value, dtp_Date_Of_Membership.Value, M_Type);
                    info.Update_Member_Contact(int.Parse(txt_Member_Id.Text), int.Parse(txt_Contact_No.Text));
                    info.Update_Job_Details(int.Parse(txt_Member_Id.Text), txt_Job.Text, txt_Office_Name.Text, txt_Office_Address_Line1.Text, txt_Office_Address_Line2.Text, txt_Office_Address_Line3.Text);
                    info.Update_Tax_Payer(int.Parse(txt_Member_Id.Text), txt_Guarantee_Name.Text, txt_Guarantee_NIC.Text, txt_Guarantee_Address_Line1.Text, txt_Guarantee_Address_Line2.Text, txt_Guarantee_Address_Line3.Text, Relation);
                    MessageBox.Show("Update Succes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    info.Update_Members_Basic(int.Parse(txt_Member_Id.Text), txt_Full_Name.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text, txt_NIC.Text, dtp_DOB.Value, dtp_Date_Of_Membership.Value, M_Type);
                    info.Update_Member_Contact(int.Parse(txt_Member_Id.Text), int.Parse(txt_Contact_No.Text));
                    info.Update_Job_Details(int.Parse(txt_Member_Id.Text), txt_Job.Text, txt_Office_Name.Text, txt_Office_Address_Line1.Text, txt_Office_Address_Line2.Text, txt_Office_Address_Line3.Text);
                    info.Update_Tax_Payer(int.Parse(txt_Member_Id.Text), txt_Guarantee_Name.Text, txt_Guarantee_NIC.Text, txt_Guarantee_Address_Line1.Text, txt_Guarantee_Address_Line2.Text, txt_Guarantee_Address_Line3.Text, Relation);
                    MessageBox.Show("Update Succes","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            else if (txt_NIC.TextLength == 0)
            {
                txt_NIC.Text = "0";
            }
            else if (txt_NIC.TextLength == 1)
            {
                txt_NIC.Text = "0";
            }
            else
            {
                MessageBox.Show("Please Input A Correct NIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NIC.Clear();
                txt_NIC.Focus();
            }

        }

        private void txt_Guarantee_NIC_LostFocus(object sender, System.EventArgs e)
        {

            if (txt_Guarantee_NIC.TextLength == 10)
            {
                int i;
                string s = txt_Guarantee_NIC.Text.Substring(0, 9);
                string s2 = txt_Guarantee_NIC.Text.Substring(9, 1);
                if (s2 == "V" || s2 == "X")
                {
                    if (int.TryParse(s, out i))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Please Input A Correct NIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Guarantee_NIC.Clear();
                        txt_Guarantee_NIC.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please Input A Correct NIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Guarantee_NIC.Clear();
                    txt_Guarantee_NIC.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Input A Correct NIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Guarantee_NIC.Clear();
                txt_Guarantee_NIC.Focus();
            }

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
                dtp_Date_Of_Membership.Text = y[7].ToString();
                d = dtp_Date_Of_Membership.Value;
                SqlDataReader x = info.Find_Member_Contact(int.Parse(txt_Member_Id.Text));
                if (x.Read())
                {
                    txt_Contact_No.Text = x[1].ToString();
                }
                SqlDataReader z = info.Find_Job_Details(int.Parse(txt_Member_Id.Text));
                if (z.Read())
                {
                    txt_Job.Text = z[1].ToString();
                    txt_Office_Name.Text = z[2].ToString();
                    txt_Office_Address_Line1.Text = z[3].ToString();
                    txt_Office_Address_Line2.Text = z[4].ToString();
                    txt_Office_Address_Line3.Text = z[5].ToString();
                }
                SqlDataReader p = info.Find_Tax_Payer(int.Parse(txt_Member_Id.Text));
                if (p.Read())
                {
                    txt_Guarantee_Name.Text = p[1].ToString();
                    txt_Guarantee_NIC.Text = p[2].ToString();
                    txt_Guarantee_Address_Line1.Text = p[3].ToString();
                    txt_Guarantee_Address_Line2.Text = p[4].ToString();
                    txt_Guarantee_Address_Line3.Text = p[5].ToString();
                }

                btn_Register.Enabled = false;
                txt_Member_Id.Enabled = false;
                btn_Update.Enabled = true;
                gbo_Registration_Fee.Enabled = false;
            }

        }

        private void dtp_Date_Of_Membership_ValueChanged(object sender, EventArgs e)
        {
            gbo_Registration_Fee.Enabled = true;
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
        private void txt_Receipt_No_LostFocus(object sender, System.EventArgs e)
        {
            int i;
            if(int.TryParse(txt_Receipt_No.Text,out i))
            {
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Recipt No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Receipt_No.Text="0";
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
                MessageBox.Show("Please Input a valid member Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Member_Id.Clear();
                txt_Member_Id.Focus();
            }

        }

    }
}
