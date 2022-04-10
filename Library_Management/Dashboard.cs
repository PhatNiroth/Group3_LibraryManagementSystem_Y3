using Library_Manangment_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
 

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
           //Itself
           
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Borrower br = new Borrower();
            br.Show();
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            IssueBook ib = new IssueBook();
            ib.Show();
        }

        private void iconButton5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ReturnBook rb=new ReturnBook();
            rb.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login fr = new Frm_Login();
        }
    }
}
