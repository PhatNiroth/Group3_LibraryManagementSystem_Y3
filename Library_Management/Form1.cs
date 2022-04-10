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
    public partial class Form1 : Form
    {
        public void connection()
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

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
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
            string title = txttitle.Text;
            string author = txtauthor.Text;
            string ISBN = txtisbn.Text;
            string quantity = txtquantity.Text;
            string publisher = txtpublisher.Text;
            cnn.Open();
            //MessageBox.Show(title + author + ISBN + quantity + publisher);
            cmd = new SqlCommand("INSERT INTO Book values('"+title +"','"+author+ "','" + ISBN + "','" + quantity + "', '" + publisher + "')", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved");
            cnn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
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

            SqlCommand comando = new SqlCommand("SELECT *FROM Book order by BOOKID asc", cnn);
            SqlDataAdapter adatator = new SqlDataAdapter();
            adatator.SelectCommand = comando;
            DataTable table = new DataTable();
            adatator.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            Dashboard dh = new Dashboard();
            dh.Show();
            this.Hide();

        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Borrower br = new Borrower();
            br.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1  br = new Form1();
            br.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBook ib = new IssueBook();
            ib.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Frm_Login fr = new Frm_Login();
            fr.Show();
        }
    }
}
