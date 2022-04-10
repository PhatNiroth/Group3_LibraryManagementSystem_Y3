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

namespace Library_Management
{
    public partial class Testingform : Form
    {
        public Testingform()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
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
                   MessageBox.Show("Connection Successfull!");
                cnn.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }

            //

            cnn.Close();
        }
    }
}
