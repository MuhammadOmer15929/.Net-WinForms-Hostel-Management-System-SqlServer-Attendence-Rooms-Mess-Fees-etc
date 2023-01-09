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
    public partial class MessRecord : Form
    {
        public MessRecord()
        {
            InitializeComponent();
        }

        private void MessRecord_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DashBoard dv = new DashBoard();
            dv.Show();
            this.Hide();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            loadform(new MessStatus());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Reset?", "Reset MessFee Status", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string MessBill = "Un-Paid";

                string con = @"Data Source=SHADOW\SQLEXPRESS;Initial Catalog=HostelManagementSystem;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                string query = "UPDATE StudentsRecord  SET MessBill=@MessBill";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MessBill", MessBill);

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loadform(new MessDefaulter());
        }
    }
}
