using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VPSemesterProjectHMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Username or Password is Missing");
            }
            else {
                if (textBox1.Text == "omer" && textBox2.Text == "123")
                {
                    this.Hide();
                    DashBoard dashBoard = new DashBoard();
                    dashBoard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
      

        private void gunaPictureBox1_Click(object sender, EventArgs e)
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBox2.UseSystemPasswordChar = true;  
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
