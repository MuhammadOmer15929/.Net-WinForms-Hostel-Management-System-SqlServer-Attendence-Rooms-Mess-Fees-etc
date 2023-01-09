using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPSemesterProjectHMS
{
    public partial class StudentRecordAll : Form
    {
        public StudentRecordAll()
        {
            InitializeComponent();

        }

    
        public void loadform(object Form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f =Form as Form;
            f.TopLevel = false;
            f.Dock=DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            loadform(new SetFeeStatus());
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loadform(new FeeDefaulter());
        }

        private void pictureBox1_Click(object sender, EventArgs e)       {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Reset?", "Reset Fee Status", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string FeeStatus = "Un-Paid";

                string con = @"Data Source=SHADOW\SQLEXPRESS;Initial Catalog=HostelManagementSystem;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                string query = "UPDATE StudentsRecord  SET FeeStatus=@FeeStatus";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FeeStatus", FeeStatus);

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
            Form1 form1=new Form1();
            form1.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void viewAvailPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buyCarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void viewSoldPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sellCarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}