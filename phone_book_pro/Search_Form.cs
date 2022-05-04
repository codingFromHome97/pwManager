using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phone_book_pro
{
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            InitializeComponent();
        }

        // Search button (button1_Click)
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }
            // ------------------------------------------
            string fn;
            fn = "C:\\Users\\A8P9VZZ\\Desktop\\accountFolder\\";
            string p;
            string r;
            // ---------------------- username ----------------------------
            p = fn + this.textBox1.Text + "_username.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.username_Textbox.Text = r;
            }
            // -------------------- password --------------------------------
            string pwFP;
            string pwRead;
            pwFP = fn + this.textBox1.Text + "_password.txt";
            if(System.IO.File.Exists(pwFP) == true)
            {
                pwRead = System.IO.File.ReadAllText(pwFP, Encoding.UTF8);
                this.password_Textbox.Text = pwRead;
            }
            // ------------------ application ---------------------------
            string appFP;
            string appRead;
            appFP = fn + this.textBox1.Text + "_application.txt";
            if(System.IO.File.Exists(appFP) == true)
            {
                appRead = System.IO.File.ReadAllText(appFP, Encoding.UTF8);
                this.application_Textbox.Text = appRead;
            }
            // ---------------------- comments -----------------------------
            string comFP;
            string comRead;
            comFP = fn + this.textBox1.Text + "_comments.txt";
            if(System.IO.File.Exists(comFP) == true)
            {
                comRead = System.IO.File.ReadAllText(comFP, Encoding.UTF8);
                this.comments_Textbox.Text = comRead;
            }
            // id
            this.id_Textbox.Text = this.textBox1.Text;
        }
    }
}
