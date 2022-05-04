using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phone_book_pro
{
    public partial class Entry_form : Form
    {
        public Entry_form()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // When we click New Data, we can't keep clicking it (we turn it to false). At this same moment, we also enable our Save button.
            this.toolStripButton1.Enabled = false;
            this.toolStripButton2.Enabled = true;
            // ---------------------------------
            this.groupBox1.Enabled = true;
            // ---------------------------------
            this.id_Textbox.ResetText();
            this.username_Textbox.ResetText();
            this.password_Textbox.ResetText();
            this.comments_Textbox.ResetText();
            this.application_Textbox.ResetText();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.id_Textbox.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }
            // When we click Save button, we can't keep clicking it (we turn it to false). At this same moment, we also enable our New Data button.
            this.toolStripButton2.Enabled = false;
            this.toolStripButton1.Enabled = true;
            // ---------------------------------
            this.groupBox1.Enabled = false;
            // ---------------------------------
            string fn;
            ///////// EXTREMELY IMPORTANT!!! ////////
            /// THE USER MUST CHANGE fn /////////////
            /// TO FILE PATH TO A DIRECTORY ON THEIR SYSTEM /////
            /// 
            ///
            /// my file path won't work for you.
            fn = "C:\\Users\\A8P9VZZ\\Desktop\\accountFolder\\";
            string p;
            // ------------- username ---------------------
            p = fn + this.id_Textbox.Text + "_username.txt";
            System.IO.File.WriteAllText(p, this.username_Textbox.Text, Encoding.UTF8);
            // ------------- password ----------------------
            string pw;
            pw = fn + this.id_Textbox.Text + "_password.txt";
            System.IO.File.WriteAllText(pw, this.password_Textbox.Text, Encoding.UTF8);
            // ----------- application ---------------------
            string app;
            app = fn + this.id_Textbox.Text + "_application.txt";
            System.IO.File.WriteAllText(app, this.application_Textbox.Text, Encoding.UTF8);
            // ---------- comments ---------------------
            string c;
            c = fn + this.id_Textbox.Text + "_comments.txt";
            System.IO.File.WriteAllText(c, this.comments_Textbox.Text, Encoding.UTF8);
            // ------------------------------------------------
            MessageBox.Show("Saved successfully.");
        }

        private void Entry_form_Load(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
        }
    }
}
