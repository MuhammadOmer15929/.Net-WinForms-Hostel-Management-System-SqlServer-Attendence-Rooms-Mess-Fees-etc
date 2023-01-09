using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPSemesterProjectHMS.std_Controls
{
    public partial class StdRecord : UserControl
    {
        public StdRecord()
        {
            InitializeComponent();
          
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string con = @"Data Source=SHADOW\SQLEXPRESS;Initial Catalog=HostelManagementSystem;Integrated Security=True";
        private object printDocument1;

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
      
        }

      
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {if (gunaTextBox1.Text == "")
            {
                MessageBox.Show("Please Enter RegNo");
            }
            else
            {
                string RegNo = gunaTextBox1.Text;
                SqlConnection sqlConnection = new SqlConnection(con);
                string query = "Select *from StudentsRecord  WHERE RegNo=" + RegNo;
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
                sqlConnection.Open();
                int omer = cmd.ExecuteNonQuery();
                dataGridView2.Visible = true;
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(con);
            string query = "Select *from StudentsRecord ";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            sqlConnection.Open();
            int omer = cmd.ExecuteNonQuery();
            dataGridView2.Visible = true;
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Print?", "Student Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Leave Student Records";
                printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.PrintDataGridView(dataGridView2);
            }
            else
            {
                MessageBox.Show("Not Printed Try Again");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
