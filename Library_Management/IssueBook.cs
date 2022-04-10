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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void IssueBook_Load(object sender, EventArgs e)
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

            SqlCommand comando = new SqlCommand("Select Name as [Student Name],major as [Student Major],[BOOK TITLE],br.Date as [Borrow Date] from Book b inner join Borrower br on b.ISBN = br.ISBN", cnn);
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
            this.Hide();
            Borrower br = new Borrower();
            br.Show();
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 br = new Form1();
            br.Show();
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
            this.Hide();
            Frm_Login fr = new Frm_Login();
            fr.Show();

        }
    }
}
