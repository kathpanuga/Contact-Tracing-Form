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
        

            file.WriteLine("First Name: " + textBox6.Text);
            file.WriteLine("Last Time:  " + textBox7.Text);
            file.WriteLine("Age:  " + textBox8.Text);
            file.WriteLine("Barangay:  " + textBox9.Text);
            file.WriteLine("Municipality:  " + textBox10.Text);
            file.WriteLine("Zip Code:  " + textBox11.Text);

            if (radioButton1.Checked)
            {

            }
            file.Close();
        }
       
    }
}
