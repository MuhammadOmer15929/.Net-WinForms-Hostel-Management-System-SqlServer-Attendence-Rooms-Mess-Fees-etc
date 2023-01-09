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
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        private void Attendence_Load(object sender, EventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.guna2Panel1.Controls.Count > 0)
                this.guna2Panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.guna2Panel1.Controls.Add(f);
            this.guna2Panel1.Tag = f;
            f.Show();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            loadform(new MarkAtt());
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Exit", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            d.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Reset?", "Reset Attendence", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string Attendence = " ";

                string con = @"Data Source=SHADOW\SQLEXPRESS;Initial Catalog=HostelManagementSystem;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                string query = "UPDATE StudentsRecord  SET Attendence=@Attendence";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Attendence",Attendence);

                connection.Open();

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Reseted Successfully");
            }
            else
            {
                MessageBox.Show("Not Reseted");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loadform(new AttendenceInformation());
        }
    }
}
