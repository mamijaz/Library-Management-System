using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class Interface_Lending : Form
    {
        public Interface_Lending()
        {
            InitializeComponent();
        }

        private void btn_Lending_Click(object sender, EventArgs e)
        {
            Lending Lending_Page = new Lending();
            Lending_Page.MdiParent = this.ParentForm;
            Lending_Page.StartPosition = FormStartPosition.Manual;
            Lending_Page.Location = new Point(this.Location.X, this.Location.Y);
            Lending_Page.Show();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            Return Return_Page = new Return();
            Return_Page.MdiParent = this.ParentForm;
            Return_Page.StartPosition = FormStartPosition.Manual;
            Return_Page.Location = new Point(this.Location.X, this.Location.Y);
            Return_Page.Show();
        }

        private void btn_Lost_Click(object sender, EventArgs e)
        {
            Lost Lost_Page = new Lost();
            Lost_Page.MdiParent = this.ParentForm;
            Lost_Page.StartPosition = FormStartPosition.Manual;
            Lost_Page.Location = new Point(this.Location.X, this.Location.Y);
            Lost_Page.Show();
        }
    }
}
