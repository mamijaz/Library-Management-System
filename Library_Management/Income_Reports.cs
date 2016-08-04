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
    public partial class Income_Reports : Form
    {
        Library_Management info = new Library_Management();
        public Income_Reports()
        {
            InitializeComponent();
        }

        private void btn_Search_Member_Click(object sender, EventArgs e)
        {
            SqlDataReader q = info.Find_Income_From_Member_Registration(dtp_From_Member.Value, dtp_To_Member.Value);
            if (q.Read())
            {
                lbl_Total_Income_Display_Member.Text = q[0].ToString();
                if (lbl_Total_Income_Display_Member.Text == "")
                {
                    lbl_Total_Income_Display_Member.Text = "0";
                }
            }
            DataSet ds = info.View_Income_From_Member_Registration(dtp_From_Member.Value, dtp_To_Member.Value);
            dgv_Member.DataSource = ds.Tables["Report"];
            btn_Search_Member.Enabled = false;
        }

        private void btn_Search_Lending_Click(object sender, EventArgs e)
        {
            SqlDataReader q = info.Find_Income_From_Return(dtp_From_Lending.Value, dtp_To_Lending.Value);
            SqlDataReader r = info.Find_Income_From_Lost(dtp_From_Lending.Value, dtp_To_Lending.Value);
            if (q.Read()&&r.Read())
            {
                string x = q[0].ToString();
                string y = r[0].ToString();
                double s;
                double.TryParse(x, out s);
                double t;
                double.TryParse(y, out t);
                lbl_Total_Income_Display_Lending.Text = (s+t).ToString();
                if (lbl_Total_Income_Display_Lending.Text == "")
                {
                    lbl_Total_Income_Display_Lending.Text = "0";
                }
            }
            DataSet ds = info.View_Income_From_Book_Return(dtp_From_Lending.Value, dtp_To_Lending.Value);
            dgv_Return.DataSource = ds.Tables["Report"];

            DataSet ds2 = info.View_Income_From_Book_Lost(dtp_From_Lending.Value, dtp_To_Lending.Value);
            dgv_Lost.DataSource = ds2.Tables["Report"];
            btn_Search_Lending.Enabled = false;
        }

        private void btn_Search_Multimedia_Click(object sender, EventArgs e)
        {
            SqlDataReader q = info.Find_Income_From_Multimedia(dtp_From_Multimedia.Value,dtp_To_Multimedia.Value);
            if (q.Read())
            {
                lbl_Total_Income_Display_Multimedia.Text = q[0].ToString();
                if (lbl_Total_Income_Display_Multimedia.Text == "")
                {
                    lbl_Total_Income_Display_Multimedia.Text = "0";
                }
            }
            DataSet ds = info.View_Income_From_Multomedia(dtp_From_Multimedia.Value, dtp_To_Multimedia.Value);
            dgv_Mutimedia.DataSource = ds.Tables["Report"];
            btn_Search_Multimedia.Enabled = false;
        }

        private void btn_Clear_Member_Click(object sender, EventArgs e)
        {
            lbl_Total_Income_Display_Member.Text = "0";
            btn_Search_Member.Enabled = true;
        }

        private void btn_Clear_Lending_Click(object sender, EventArgs e)
        {
            lbl_Total_Income_Display_Lending.Text = "0";
            btn_Search_Lending.Enabled = true;
        }

        private void btn_Clear_Mutimedia_Click(object sender, EventArgs e)
        {
            lbl_Total_Income_Display_Multimedia.Text = "0";
            btn_Search_Multimedia.Enabled = true;
        }
    }
}
