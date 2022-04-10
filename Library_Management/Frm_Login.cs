using Library_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manangment_System.Forms
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, System.EventArgs e)
        {
            var user = textuser.Text;
            var pass = textpass.Text;
            if(user == pass)
            {
                this.Hide();
                Form1 db = new Form1();
                db.Show();
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
