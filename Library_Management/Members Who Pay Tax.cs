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
    public partial class Members_Who_Pay_Tax : Form
    {
        Library_Management info = new Library_Management();
        public Members_Who_Pay_Tax()
        {
            InitializeComponent();
            btn_Update.Enabled = false;
            lbl_Staff_Name_Display.Text = Library_Management.Staff_Name;
            this.txt_Member_Id.LostFocus += new System.EventHandler
            (this.txt_Member_Id_LostFocus);
            this.txt_NIC.LostFocus += new System.EventHandler
            (this.txt_NIC_LostFocus);
            this.txt_Tax_Payer_NIC.LostFocus += new System.EventHandler
           (this.txt_Tax_Payer_NIC_LostFocus);
            this.txt_Contact_Mobile.LostFocus += new System.EventHandler
          (this.txt_Contact_Mobile_LostFocus);
            this.txt_Contact_Office.LostFocus += new System.EventHandler
          (this.txt_Contact_Office_LostFocus);
            this.txt_Contact_Home.LostFocus += new System.EventHandler
          (this.txt_Contact_Home_LostFocus);
            this.txt_Receipt_No.LostFocus += new System.EventHandler
           (this.txt_Receipt_No_LostFocus);

        }
        private string M_Type = "Members_Who_Pay_Tax";
        private string Class = "Unknown";
        private DateTime d;

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                info.Insert_Members_Basic(int.Parse(txt_Member_Id.Text), txt_Full_Name.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text,txt_NIC.Text,dtp_DOB.Value, dtp_Membership_Date.Value,M_Type);
                info.Insert_Member_Contact(int.Parse(txt_Member_Id.Text), int.Parse(txt_Contact_Mobile.Text), int.Parse(txt_Contact_Home.Text), int.Parse(txt_Contact_Office.Text));
                if (tabControl1.SelectedTab == tbo_If_Student)
                {
                    info.Insert_Member_School(int.Parse(txt_Member_Id.Text), txt_School_Name.Text, Class);
                }
                else
                {
                    info.Insert_Job_Details(int.Parse(txt_Member_Id.Text), txt_Job.Text, txt_Work_Place_Name.Text, txt_Work_Place_Address_Line_1.Text, txt_Work_Place_Address_Line_2.Text, txt_Work_Place_Address_Line_3.Text);
                }
                info.Insert_Member_Urban(int.Parse(txt_Member_Id.Text), cbo_Urban_Division.Text, txt_Road_Name.Text);
                info.Insert_Tax_Payer(int.Parse(txt_Member_Id.Text),txt_Tax_Payer_Name.Text, txt_Tax_Payer_NIC.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text, txt_Relationship_To_The_Tax_Payer.Text);
                info.Insert_Membership_Status(int.Parse(txt_Member_Id.Text));
                info.Charge_Membership_Fee(int.Parse(txt_Member_Id.Text), dtp_Membership_Date.Value, double.Parse(cbo_Registration_Fee.Text),int.Parse(txt_Receipt_No.Text));
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
            txt_Road_Name.Clear();
            txt_School_Name.Clear();
            txt_NIC.Clear();
            txt_Job.Clear();
            txt_Tax_Payer_NIC.Clear();
            txt_Relationship_To_The_Tax_Payer.Clear();
            txt_Contact_Home.Text = "0";
            txt_Contact_Mobile.Text="0";
            txt_Contact_Office.Text = "0";
            txt_Tax_Payer_Name.Clear();
            txt_Work_Place_Name.Clear();
            txt_Work_Place_Address_Line_1.Clear();
            txt_Work_Place_Address_Line_2.Clear();
            txt_Work_Place_Address_Line_3.Clear();
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
                    info.Update_Member_Contact(int.Parse(txt_Member_Id.Text), int.Parse(txt_Contact_Mobile.Text), int.Parse(txt_Contact_Home.Text), int.Parse(txt_Contact_Office.Text));
                    info.Update_Member_School(int.Parse(txt_Member_Id.Text), txt_School_Name.Text, Class);
                    info.Update_Member_Urban(int.Parse(txt_Member_Id.Text), cbo_Urban_Division.Text, txt_Road_Name.Text);
                    info.Update_Tax_Payer(int.Parse(txt_Member_Id.Text), txt_Full_Name.Text, txt_Tax_Payer_NIC.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text, txt_Relationship_To_The_Tax_Payer.Text);
                    info.Update_Job_Details(int.Parse(txt_Member_Id.Text), txt_Job.Text, txt_Work_Place_Name.Text, txt_Work_Place_Address_Line_1.Text, txt_Work_Place_Address_Line_2.Text, txt_Work_Place_Address_Line_3.Text);
                    info.Charge_Membership_Fee(int.Parse(txt_Member_Id.Text), dtp_Membership_Date.Value, double.Parse(cbo_Registration_Fee.Text), int.Parse(txt_Receipt_No.Text));
                    MessageBox.Show("Update Succesful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    info.Update_Members_Basic(int.Parse(txt_Member_Id.Text), txt_Full_Name.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text, txt_NIC.Text,dtp_DOB.Value, dtp_Membership_Date.Value, M_Type);
                    info.Update_Member_Contact(int.Parse(txt_Member_Id.Text), int.Parse(txt_Contact_Mobile.Text), int.Parse(txt_Contact_Home.Text), int.Parse(txt_Contact_Office.Text));
                    info.Update_Member_School(int.Parse(txt_Member_Id.Text), txt_School_Name.Text, Class);
                    info.Update_Member_Urban(int.Parse(txt_Member_Id.Text), cbo_Urban_Division.Text, txt_Road_Name.Text);
                    info.Update_Tax_Payer(int.Parse(txt_Member_Id.Text), txt_Full_Name.Text, txt_Tax_Payer_NIC.Text, txt_Address_Line1.Text, txt_Address_Line2.Text, txt_Address_Line3.Text, txt_Relationship_To_The_Tax_Payer.Text);
                    info.Update_Job_Details(int.Parse(txt_Member_Id.Text), txt_Job.Text, txt_Work_Place_Name.Text, txt_Work_Place_Address_Line_1.Text, txt_Work_Place_Address_Line_2.Text, txt_Work_Place_Address_Line_3.Text);
                    MessageBox.Show("Update Succesful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txt_Contact_Mobile.Text = z[1].ToString();
                    txt_Contact_Home.Text = z[2].ToString();
                    txt_Contact_Office.Text = z[3].ToString();
                }
                SqlDataReader x = info.Find_Member_School(int.Parse(txt_Member_Id.Text));
                if (x.Read())
                {
                    tabControl1.SelectedTab = tbo_If_Student;
                    txt_School_Name.Text = x[1].ToString();
                }
                SqlDataReader p = info.Find_Member_Urban(int.Parse(txt_Member_Id.Text));
                if (p.Read())
                {
                    cbo_Urban_Division.Text = p[1].ToString();
                    txt_Road_Name.Text = p[2].ToString();
                }
                SqlDataReader q = info.Find_Tax_Payer(int.Parse(txt_Member_Id.Text));
                if (q.Read())
                {
                    txt_Tax_Payer_Name.Text = q[1].ToString();
                    txt_Tax_Payer_NIC.Text = q[2].ToString();
                    txt_Relationship_To_The_Tax_Payer.Text = q[6].ToString();
                }
                SqlDataReader r = info.Find_Job_Details(int.Parse(txt_Member_Id.Text));
                if (r.Read())
                {
                    tabControl1.SelectedTab = tbo_If_Employed;
                    txt_Job.Text = r[1].ToString();
                    txt_Work_Place_Name.Text = r[2].ToString();
                    txt_Work_Place_Address_Line_1.Text = r[3].ToString();
                    txt_Work_Place_Address_Line_2.Text = r[4].ToString();
                    txt_Work_Place_Address_Line_3.Text = r[5].ToString();
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
        private void txt_NIC_LostFocus(object sender, EventArgs e)
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
        private void txt_Tax_Payer_NIC_LostFocus(object sender, EventArgs e)
        {
            if (txt_Tax_Payer_NIC.TextLength == 10)
            {
                int i;
                string s = txt_Tax_Payer_NIC.Text.Substring(0, 9);
                string s2 = txt_Tax_Payer_NIC.Text.Substring(9, 1);
                if (s2 == "V" || s2 == "X")
                {
                    if (int.TryParse(s, out i))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Please Input A Correct NIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Tax_Payer_NIC.Clear();
                        txt_Tax_Payer_NIC.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please Input A Correct NIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Tax_Payer_NIC.Clear();
                    txt_Tax_Payer_NIC.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Input A Correct NIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Tax_Payer_NIC.Clear();
                txt_Tax_Payer_NIC.Focus();
            }
        }

        private void txt_Contact_Mobile_LostFocus(object sender, System.EventArgs e)
        {
            if (txt_Contact_Mobile.Text.Length == 10)
            {
                int i;
                if (int.TryParse(txt_Contact_Mobile.Text, out i))
                {
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Contact_Mobile.Clear();
                }
            }
            else if (txt_Contact_Mobile.Text.Length == 0)
            {
                txt_Contact_Mobile.Text = "0";
            }
            else if (txt_Contact_Mobile.Text.Length == 1)
            {
                txt_Contact_Mobile.Text = "0";
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contact_Mobile.Clear();
                txt_Contact_Mobile.Focus();
            }
        }
        private void txt_Contact_Office_LostFocus(object sender, System.EventArgs e)
        {
            if (txt_Contact_Office.Text.Length == 10)
            {
                int i;
                if (int.TryParse(txt_Contact_Office.Text, out i))
                {
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Contact_Office.Clear();
                }
            }
            else if (txt_Contact_Office.Text.Length == 0)
            {
                txt_Contact_Office.Text = "0";
            }
            else if (txt_Contact_Office.Text.Length == 1)
            {
                txt_Contact_Office.Text = "0";
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contact_Office.Clear();
                txt_Contact_Office.Focus();
            }
        }

        private void txt_Contact_Home_LostFocus(object sender, System.EventArgs e)
        {
            if (txt_Contact_Home.Text.Length == 10)
            {
                int i;
                if (int.TryParse(txt_Contact_Home.Text, out i))
                {
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Contact_Home.Clear();
                }
            }
            else if (txt_Contact_Home.Text.Length == 0)
            {
                txt_Contact_Home.Text = "0";
            }
            else if (txt_Contact_Home.Text.Length == 1)
            {
                txt_Contact_Home.Text = "0";
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contact_Home.Clear();
                txt_Contact_Home.Focus();
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
