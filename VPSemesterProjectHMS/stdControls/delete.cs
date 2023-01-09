using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPSemesterProjectHMS.stdControls
{
    public partial class delete : UserControl
    {
        public delete()
        {
            InitializeComponent();
       
        }
        string con = @"Data Source=SHADOW\SQLEXPRESS;Initial Catalog=HostelManagementSystem;Integrated Security=True";
        private object printDocument1;


        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
        
        }

        private void delete_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                MessageBox.Show("Please Enter RegNo");

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Delete?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string RegNo = gunaTextBox1.Text;
                    SqlConnection sqlConnection = new SqlConnection(con);
                    string query = "Delete  from StudentsRecord  WHERE RegNo=" + RegNo;
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    sqlConnection.Open();
                    int omer = cmd.ExecuteNonQuery();
                    dataGridView1.Visible = true;
                    this.dataGridView1.Visible = true;
                }

                else
                {
                    MessageBox.Show("Not Deleted Try Again");
                }
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
            dataGridView1.DataSource = dataTable;
            sqlConnection.Open();
            int omer = cmd.ExecuteNonQuery();

           dataGridView1.Visible = true;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaTextBox1_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
