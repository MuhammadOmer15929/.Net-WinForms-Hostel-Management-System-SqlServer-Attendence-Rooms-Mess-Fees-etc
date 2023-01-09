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

namespace VPSemesterProjectHMS
{
    public partial class AttendenceInformation : Form
    {
        public AttendenceInformation()
        {
            InitializeComponent();
        }
        string con = @"Data Source=SHADOW\SQLEXPRESS;Initial Catalog=HostelManagementSystem;Integrated Security=True";
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection(con);
            string query = "Select RegNo,Name,Class,Department,RoomNO,ContactNo,Attendence FROM StudentsRecord WHERE Attendence='Present'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Open();
            int omer = cmd.ExecuteNonQuery();
            dataGridView1.Visible = true;
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(con);
            string query = "Select RegNo,Name,Class,Department,RoomNO,ContactNo,Attendence FROM StudentsRecord WHERE Attendence='Late'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Open();
            int omer = cmd.ExecuteNonQuery();
            dataGridView1.Visible = true;
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(con);
            string query = "Select RegNo,Name,Class,Department,RoomNO,ContactNo,Attendence FROM StudentsRecord WHERE Attendence='Absent'";
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
            SqlConnection sqlConnection = new SqlConnection(con);
            string query = "Select RegNo,Name,Class,Department,RoomNO,ContactNo,Attendence FROM StudentsRecord WHERE Attendence='Leave'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Open();
            int omer = cmd.ExecuteNonQuery();
            dataGridView1.Visible = true;
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Print?", "Attendence Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Attendence Record";
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

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
          

        }
        void Fillchart()
        {
            
            
        }
        private void chart1_Click(object sender, EventArgs e)
        {
        }
    }
}
