using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library_Manangment_System.Forms;

namespace Library_Management
{
    public partial class Borrower : Form
    {
        public Borrower()
        {
            InitializeComponent();
        }


        private void Borrower_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 br = new Form1();
            br.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection cnn;
            string datasource = "SOVANTHA\\SQLEXPRESS";
            string database = "SPIlibrary";
            connectionString = "Data Source= " + datasource + ";Initial Catalog= " + database + ";Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                //   MessageBox.Show("Connection Successfull!");
                cnn.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            SqlCommand cmd;
            //string id = txttitle.Text;
            string name = txtname.Text;
            string isbn = txtisbn.Text;
            string year = txtyear.Text;
            string major = txtmajor.Text;
            string date = txtdate.Text;
            cnn.Open();
            cmd = new SqlCommand("INSERT INTO Borrower values('" + name + "','" + major + "','" + year + "', '" + isbn + "', '" + date + "')", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved To Borrower Table.");
            //

            cnn.Close();
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection cnn;
            string datasource = "SOVANTHA\\SQLEXPRESS";
            string database = "SPIlibrary";
            connectionString = "Data Source= " + datasource + ";Initial Catalog= " + database + ";Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                //   MessageBox.Show("Connection Successfull!");
                cnn.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }

            SqlCommand comando = new SqlCommand("SELECT *FROM Borrower order by BorrowerID asc", cnn);
            SqlDataAdapter adatator = new SqlDataAdapter();
            adatator.SelectCommand = comando;
            DataTable table = new DataTable();
            adatator.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dh = new Dashboard();
            dh.Show();
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            //itself
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
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Frm_Login fr = new Frm_Login();
            fr.Show();
                
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtisbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
