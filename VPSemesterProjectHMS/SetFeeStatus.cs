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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace VPSemesterProjectHMS
{
    public partial class SetFeeStatus : Form
    {
        public SetFeeStatus()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(con);
            string query = "Select  RegNo,Name,Class,Department,RoomNo,ContactNo,FeeStatus FROM StudentsRecord";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Open();
            int omer = cmd.ExecuteNonQuery();
            dataGridView1.Visible = true;
        }
        string con = @"Data Source=SHADOW\SQLEXPRESS;Initial Catalog=HostelManagementSystem;Integrated Security=True";
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {if (gunaTextBox1.Text=="")
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

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Print?", "Fees Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Fee Records";
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

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text=="")
            {
                MessageBox.Show("Please Enter RegNo");
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Update Status?", "FeeStatus", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string FeeStatus = "";
                    if (checkBox1.Checked)
                    {
                        FeeStatus = "Paid";
                    }
                    else
                    {
                        FeeStatus = "Un-Paid";
                    }
                    SqlConnection sqlConnection = new SqlConnection(con);
                    string query = "UPDATE StudentsRecord  SET FeeStatus=@FeeStatus Where RegNo=@RegNo";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.Parameters.AddWithValue("@FeeStatus", FeeStatus);
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
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
