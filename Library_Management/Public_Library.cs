﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class Public_Library : Form
    {
        private int childFormNumber = 0;

        public Public_Library()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void Public_Library_Load(object sender, EventArgs e)
        {
            Interface_Main First_Page = new Interface_Main();
            First_Page.MdiParent = this;
            First_Page.StartPosition = FormStartPosition.Manual;
            First_Page.Location = new Point(0,98);
            First_Page.Show();
        }

        private void lbl_Back_To_Home_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }

        private void lbl_Log_Out_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            Interface_Main First_Page = new Interface_Main();
            First_Page.MdiParent = this;
            First_Page.StartPosition = FormStartPosition.Manual;
            First_Page.Location = new Point(0, 98);
            First_Page.Show();
        }

       
    }
}
