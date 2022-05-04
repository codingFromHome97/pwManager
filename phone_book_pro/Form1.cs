using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phone_book_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Data entry button:
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Entry_form rg = new Entry_form();
            rg.MdiParent = this;
            rg.Show();
        }

        // Search button:
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Search_Form rg = new Search_Form();
            rg.MdiParent = this;
            rg.Show();
        }
        
        // About button:
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            About_Form rg = new About_Form();
            rg.MdiParent = this;
            rg.Show();
        }

        // Exit Button:
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Calculator Button
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                toolStripButton1_Click(sender, e);
            }
            // --------------------------------
            if (e.KeyCode == Keys.F3)
            {
                toolStripButton2_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                toolStripButton3_Click(sender, e);
            }
            // --------------------------------
            if (e.KeyCode == Keys.F5)
            {
                toolStripButton4_Click(sender, e);
            }
            // --------------------------------
            if (e.KeyCode == Keys.Escape)
            {
                toolStripButton5_Click(sender, e);
            }
            // --------------------------------
        }
    }
}
