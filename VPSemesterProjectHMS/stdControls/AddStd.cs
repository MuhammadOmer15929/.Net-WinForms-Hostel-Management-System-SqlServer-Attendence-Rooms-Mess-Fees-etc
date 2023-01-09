using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace VPSemesterProjectHMS.std_Controls
{
    public partial class AddStd : UserControl
    {
        public AddStd()
        {
            InitializeComponent();
        }

        string con = @"Data Source=SHADOW\SQLEXPRESS;Initial Catalog=HostelManagementSystem;Integrated Security=True";
        private object printDocument1;

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {




        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
         

            try
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Save?", "Add New Student", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {

                    }
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {

                    }
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {

                    }
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {

                    }
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {

                    }
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                    }
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                    }
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                    }
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                    }
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                    }
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                    }
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                    }
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                                            }
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                    }



                    string RegNo = gunaTextBox7.Text;
                    string Name = gunaTextBox1.Text;
                    string FatherName = gunaTextBox2.Text;
                    string ContactNo = gunaTextBox3.Text;
                    string GuardianNo = gunaTextBox4.Text;
                    string CNIC = gunaTextBox5.Text;
                    string City = gunaTextBox5.Text;
                    string Province = gunaComboBox1.SelectedItem.ToString();




                    string Class = gunaTextBox8.Text;
                    string Department = gunaComboBox2.SelectedItem.ToString();
                    string RoomNo = gunaTextBox9.Text;
                    string Floor = gunaComboBox3.SelectedItem.ToString();
                    string MessBill = "";
                    string Date = gunaDateTimePicker1.Value.ToShortDateString();
                    if (radioButton3.Checked == true)
                    {
                        MessBill = "Paid";
                    }
                    else
                    {
                        MessBill = "Un-Paid";
                    }
                    string FeeStatus = "";
                    if (radioButton1.Checked==true)
                    {
                        FeeStatus = "Paid";
                    }
                    else
                    {
                        FeeStatus = "Un-Paid";
                    }
                    string OnLeave = "No";


                    SqlConnection sqlConnection = new SqlConnection(con);
                    string query = "INSERT INTO StudentsRecord(RegNo,Name,FatherName,ContactNo,GuardianNo,City,Province,Class,Department,RoomNo,Floor,MessBill,FeeStatus,OnLeave,Date,CNIC) VALUES('" + RegNo + "','" + Name + "','" + FatherName + "','" + ContactNo + "','" + GuardianNo + "','" + City + "','" + Province + "','" + Class + "','" + Department + "','" + RoomNo + "','" + Floor + "','" + MessBill + "','" + FeeStatus + "','" + OnLeave + "','" + Date + "','" + CNIC + "')";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    int omer = cmd.ExecuteNonQuery();
                }
            }catch
            {
               
            }
        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(gunaTextBox1.Text))
            {

          
                errorProvider1.SetError(gunaTextBox1, "Please Enter Your Name");
            }
            else
            {
                errorProvider1.SetError(gunaTextBox1, null);
            }
        }

        private void gunaTextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(gunaTextBox2.Text))
            {

                errorProvider2.SetError(gunaTextBox2, "Please Enter Your FatherName");
            }
            else
            {
                errorProvider2.SetError(gunaTextBox2, null);
            }
        }

        private void gunaTextBox3_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(gunaTextBox3.Text))
            {
     
                errorProvider3.SetError(gunaTextBox3, "Please Enter Your ContactNo");
            }
            else
            {
                errorProvider3.SetError(gunaTextBox3, null);
            }
        }

        private void gunaTextBox4_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(gunaTextBox4.Text))
            {

   
                errorProvider4.SetError(gunaTextBox4, "Please Enter Your GuardiantNo");
            }
            else
            {

                errorProvider4.SetError(gunaTextBox4, null);

            }
        }

        private void gunaTextBox5_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(gunaTextBox5.Text))
            {

                errorProvider5.SetError(gunaTextBox5, "Please Enter Your CNIC");
            }
            else
            {
                errorProvider5.SetError(gunaTextBox5, null);

            }
        }

        private void gunaTextBox6_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(gunaTextBox6.Text))
            {

             
                errorProvider6.SetError(gunaTextBox6, "Please Enter Your City");
            }
            else
            {

                errorProvider6.SetError(gunaTextBox6, null);

            }
        }

        private void gunaComboBox1_Validating(object sender, CancelEventArgs e)
        {
            if(gunaComboBox1.SelectedIndex == -1)
            {
                errorProvider1.SetError(gunaComboBox1, "Please Enter");
            }
            else
            {

                errorProvider1.SetError(gunaComboBox1, null);


            }
        }

        private void gunaTextBox7_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(gunaTextBox7.Text))
            {

                errorProvider7.SetError(gunaTextBox7, "Please Enter Your RegNo");
            }
            else
            {

                errorProvider7.SetError(gunaTextBox7, null);

            }
        }

        private void gunaTextBox8_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(gunaTextBox8.Text))
            {

              
                errorProvider9.SetError(gunaTextBox8, "Please Enter Your Class");
            }
            else
            {

                errorProvider9.SetError(gunaTextBox8, null);

            }
        }

     
        private void gunaComboBox2_Validating(object sender, CancelEventArgs e)
        {

            if (gunaComboBox2.SelectedIndex == -1)
            {
                errorProvider1.SetError(gunaComboBox2, "Please Enter");
            }
            else
            {

                errorProvider1.SetError(gunaComboBox2, null);


            }
        }

        private void gunaComboBox3_Validating(object sender, CancelEventArgs e)
        {
            if (gunaComboBox3.SelectedIndex == -1)
            {
                errorProvider1.SetError(gunaComboBox3, "Please Enter");
            }
            else
            {

                errorProvider1.SetError(gunaComboBox3, null);


            }

        }

        private void gunaTextBox9_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(gunaTextBox9.Text))
            {

         
                errorProvider13.SetError(gunaTextBox9, "Please Enter Your Room");
            }
            else
            {

                errorProvider13.SetError(gunaTextBox9, null);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
    
    
