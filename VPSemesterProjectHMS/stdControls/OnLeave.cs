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

namespace VPSemesterProjectHMS.stdControls
{
    public partial class OnLeave : UserControl
    {
        public OnLeave()
        {
            InitializeComponent();
        }
        string con = @"Data Source=SHADOW\SQLEXPRESS;Initial Catalog=HostelManagementSystem;Integrated Security=True";
        private object printDocument1;

        private void OnLeave_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }


        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                string RegNo = gunaTextBox1.Text;
                SqlConnection sqlConnection = new SqlConnection(con);
                string query = "Select *from StudentsRecord  WHERE RegNo=" + RegNo;
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                sqlConnection.Open();
                int omer = cmd.ExecuteNonQuery();
                dataGridView1.Visible = true;

            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Update Status?", "Leave", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string OnLeave = "";
                if (checkBox5.Checked)
                {
                    OnLeave = "YES";
                }
                else
                {
                    OnLeave = "NOT";
                }
                SqlConnection sqlConnection = new SqlConnection(con);
                string query = "UPDATE StudentsRecord  SET OnLeave=@OnLeave Where RegNo=@RegNo";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@OnLeave", OnLeave);
                cmd.Parameters.AddWithValue("@RegNo", gunaTextBox2.Text);
                sqlConnection.Open();
                int omer = cmd.ExecuteNonQuery();
                sqlConnection.Close();




                dataGridView1.Update();


                dataGridView1.Visible = true;

            }
            else
            {
                MessageBox.Show("Status Not Updated Try Again");
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection(con);
            string query = "Select *from StudentsRecord WHERE OnLeave='YES'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Open();
            int omer = cmd.ExecuteNonQuery();
            dataGridView1.Visible = true;

        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Print?", "Leave", MessageBoxButtons.YesNo);
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
                printer.PrintDataGridView(dataGridView1);
            }
            else
            {
                MessageBox.Show("Not Printed Try Again");
            }

        }
    }
}
