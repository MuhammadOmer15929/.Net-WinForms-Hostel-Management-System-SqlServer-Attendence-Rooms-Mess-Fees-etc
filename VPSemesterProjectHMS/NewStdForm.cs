using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VPSemesterProjectHMS.std_Controls;
using VPSemesterProjectHMS.stdControls;

namespace VPSemesterProjectHMS
{
    public partial class NewStdForm : Form
    {
        public NewStdForm()
        {
            InitializeComponent();
        }

        private void NewStdForm_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {

        }

        private void panelContStd_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock=DockStyle.Fill;
            panelContStd.Controls.Clear();
            panelContStd.Controls.Add(userControl);
             userControl.BringToFront();
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            AddStd add = new AddStd();
            addUserControl(add);
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            StdRecord stdRecord = new StdRecord();
            addUserControl(stdRecord);
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            OnLeave stdRecord = new OnLeave();
            addUserControl(stdRecord);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            db.Show();
            this.Hide();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
         

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
           delete stdRecord = new delete();
            addUserControl(stdRecord);

        }

        private void gunaAdvenceButton2_Click_1(object sender, EventArgs e)
        {
            Update stdRecord = new Update();
            addUserControl(stdRecord);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
        }
    }
}
