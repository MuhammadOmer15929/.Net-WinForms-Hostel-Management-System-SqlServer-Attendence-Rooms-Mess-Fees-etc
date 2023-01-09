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
    public partial class Update : UserControl
    {
        string con = @"Data Source=SHADOW\SQLEXPRESS;Initial Catalog=HostelManagementSystem;Integrated Security=True";
        public Update()
        {
            InitializeComponent();
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
                dataGridView3.DataSource = dataTable;
                sqlConnection.Open();
                int omer = cmd.ExecuteNonQuery();
                dataGridView3.Visible = true;
                dataGridView3.AllowUserToAddRows = false;
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int item = 0; item <= dataGridView3.Rows.Count - 1; item++)
                {
                    string RegNo = gunaTextBox1.Text;
                    SqlConnection sqlConnection = new SqlConnection(con);
                    string query = "Update StudentsRecord set RegNo=@RegNo,Name=@Name,FatherName=@FatherName,ContactNo=@ContactNo,GuardianNo=@GuardianNo,City=@City,Province=@Province,Class=@Class,Department=@Department,RoomNo=@RoomNo,Floor=@Floor,MessBill=@MessBill,FeeStatus=@FeeStatus,OnLeave=@OnLeave,Date=@Date,CNIC=@CNIC,Attendence=@Attendence where RegNo="+RegNo ;
                    SqlCommand sql = new SqlCommand(query, sqlConnection);

                    sql.Parameters.AddWithValue("@RegNo", dataGridView3.Rows[item].Cells[0].Value);
                    sql.Parameters.AddWithValue("@Name", dataGridView3.Rows[item].Cells[1].Value);
                    sql.Parameters.AddWithValue("@FatherName", dataGridView3.Rows[item].Cells[2].Value);
                    sql.Parameters.AddWithValue("@ContactNo", dataGridView3.Rows[item].Cells[3].Value);
                    sql.Parameters.AddWithValue("@GuardianNo", dataGridView3.Rows[item].Cells[4].Value);
                    sql.Parameters.AddWithValue("@City", dataGridView3.Rows[item].Cells[5].Value);
                    sql.Parameters.AddWithValue("@Province", dataGridView3.Rows[item].Cells[6].Value);
                    sql.Parameters.AddWithValue("@Class", dataGridView3.Rows[item].Cells[7].Value);
                    sql.Parameters.AddWithValue("@Department", dataGridView3.Rows[item].Cells[8].Value);
                    sql.Parameters.AddWithValue("@RoomNo", dataGridView3.Rows[item].Cells[9].Value);
                    sql.Parameters.AddWithValue("@Floor", dataGridView3.Rows[item].Cells[10].Value);
                    sql.Parameters.AddWithValue("@MessBill", dataGridView3.Rows[item].Cells[11].Value);
                    sql.Parameters.AddWithValue("@FeeStatus", dataGridView3.Rows[item].Cells[12].Value);
                    sql.Parameters.AddWithValue("@OnLeave", dataGridView3.Rows[item].Cells[13].Value);
                    sql.Parameters.AddWithValue("@Date", dataGridView3.Rows[item].Cells[14].Value);
                    sql.Parameters.AddWithValue("@CNIC", dataGridView3.Rows[item].Cells[15].Value);
                    sql.Parameters.AddWithValue("@Attendence", dataGridView3.Rows[item].Cells[16].Value);

                    sqlConnection.Open();
                    sql.ExecuteNonQuery();
                    sqlConnection.Close();
                    dataGridView3.Update();
                 


                }
            }
            catch
            {

            }
         
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(con);
            string query = "Select *from StudentsRecord ";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
            sqlConnection.Open();
            int omer = cmd.ExecuteNonQuery();
            dataGridView3.Visible = true;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
