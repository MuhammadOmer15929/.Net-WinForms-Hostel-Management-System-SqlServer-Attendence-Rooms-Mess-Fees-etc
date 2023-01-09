using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPSemesterProjectHMS
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
           
        }


        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void gunaElipsePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

       
        
        private void Splash_Shown(object sender, EventArgs e)
        {
          }

         

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                panel2.Width = panel2.Width + 6;
                Thread.Sleep(30);
            }
            timer1.Stop();
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            panel2.Width = 0;
            timer1.Start();
        }
    }
    }

