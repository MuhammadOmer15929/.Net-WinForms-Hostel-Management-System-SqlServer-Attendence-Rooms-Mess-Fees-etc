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
    public partial class MarkAtt : Form
    {
        public MarkAtt()
        {
            InitializeComponent();
        }
        string con = @"Data Source=SHADOW\SQLEXPRESS;Initial Catalog=HostelManagementSystem;Integrated Security=True";
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {if (gunaTextBox1.Text == "")
            {
                MessageBox.Show("Please Enter RegNo");
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Update Status?", "Attendence", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string Attendence = gunaComboBox1.SelectedItem.ToString();

                    SqlConnection sqlConnection = new SqlConnection(con);
                    string query = "UPDATE StudentsRecord  SET Attendence=@Attendence Where RegNo=@RegNo";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.Parameters.AddWithValue("@Attendence", Attendence);
                    cmd.Parameters.AddWithValue("@RegNo", gunaTextBox1.Text);
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

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(con);
            string query = "Select RegNo,Name,Class,Department,RoomNO,ContactNo,Attendence FROM StudentsRecord";
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
}
