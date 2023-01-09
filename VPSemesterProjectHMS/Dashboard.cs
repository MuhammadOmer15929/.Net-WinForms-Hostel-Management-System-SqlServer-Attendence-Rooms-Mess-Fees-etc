using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPSemesterProjectHMS
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

       

private void gunaButton1_Click(object sender, EventArgs e)
        {
            StudentRecordAll student = new StudentRecordAll();
            student.Show();
            Hide();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            NewStdForm student = new NewStdForm();
            student.Show();
            Hide();
        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            ManageRooms manageRooms = new ManageRooms();
            manageRooms.Show();
            this.Hide();
        }
            
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Form1 splash = new Form1();
            splash.Show();
            this.Hide();
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            MessRecord messRecord = new MessRecord();
            messRecord.Show();
            this.Hide();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Attendence attendence = new Attendence();
            attendence.Show();
            this.Hide();
        }
    }
}
