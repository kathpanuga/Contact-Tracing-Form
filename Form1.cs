using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_P1_Click(object sender, EventArgs e)
        {
            P_profile.Visible = false;
            Health_Info.Visible = true;
        }

        private void Btn2_P2_Click(object sender, EventArgs e)
        {
            P_profile.Visible = true;
            Health_Info.Visible = false;
        }

        private void P_profile_Paint(object sender, PaintEventArgs e)
        {
            Health_Info.Visible = false;
        }

        private void Health_Info_Paint(object sender, PaintEventArgs e)
        {
            P_profile.Visible = false;
        }
        // for submit
        private void Btn3_P3_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Public\Document\test.text", true);

            file.WriteLine("Name:  " + textBox1.Text);
            file.WriteLine("Address:  " + textBox2.Text);
            file.WriteLine("Contact Number:  " + textBox3.Text);
            file.WriteLine("Email Address:  " + textBox4.Text);
            file.WriteLine("Date:  " + textBox5.Text);
            file.WriteLine("First Name:  " + textBox6.Text);
            file.WriteLine("Last Time:  " + textBox7.Text);
            file.WriteLine("Age:  " + textBox8.Text);
            file.WriteLine("Barangay:  " + textBox9.Text);
            file.WriteLine("Municipality:  " + textBox10.Text);
            file.WriteLine("Zip Code:  " + textBox11.Text);

            if (radioButton1.Checked)
            {
                file.WriteLine("Fully Vaccinated");
            }
            else if (radioButton2.Checked)
            {
                file.WriteLine("Not Vaccinated");
            }
            

            if (checkBox1.Checked)
            {
                file.WriteLine("Q1 : Yes");
            }
            else if (checkBox7.Checked)
            {
                file.WriteLine("Q1 : No");
            }
            if (checkBox2.Checked)
            {
                file.WriteLine("Q2 : Yes");
            }
            else if (checkBox8.Checked)
            {
                file.WriteLine("Q2 : No");
            }
            if (checkBox3.Checked)
            {
                file.WriteLine("Q3 : Yes");
            }
            else if (checkBox9.Checked)
            {
                file.WriteLine("Q3 : No");
            }
            if (checkBox4.Checked)
            {
                file.WriteLine("Q4 : Yes");
            }
            else if (checkBox10.Checked)
            {
                file.WriteLine("Q4 : No");
            }
            if (checkBox5.Checked)
            {
                file.WriteLine("Q5 : Yes");
            }
            else if (checkBox12.Checked)
            {
                file.WriteLine("Q5 : No");
            }

            file.Close();
            MessageBox.Show("Thank you for submitting!");
        }

    }
}
