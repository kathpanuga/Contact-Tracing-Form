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
        List<string> ViewRecordsList = new List<string>();


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

            file.WriteLine("Date:  " + dateTimePicker2.Value);
            file.WriteLine("First Name:  " + Panel1Txtb1.Text);
            file.WriteLine("Middle Name:  " + Panel1Txtb2.Text);
            file.WriteLine("Last Name:  " + Panel1Txtb3.Text);
            file.WriteLine("Address:  " + Panel1Txtb4.Text);
            file.WriteLine("Email:  " + Panel1Txtb5.Text);
            file.WriteLine("Mobile Number:  " + Panel1Txtb6.Text);
            file.WriteLine("Temperature:  " + Panel2Txtb1.Text);
            file.WriteLine("First Name:  " + Panel2Txtb2.Text);
            file.WriteLine("Last Name:  " + Panel2Txtb3.Text);
            file.WriteLine("Age:  " + Panel2Txtb4.Text);
            file.WriteLine("Barangay:  " + Panel2Txtb5.Text);
            file.WriteLine("Municipality:  " + Panel2Txtb6.Text);
            file.WriteLine("Zip Code:  " + Panel2Txtb7.Text);


            // for date



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

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            // for checkboxes
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;

            // for textbox
            Panel1Txtb1.Text = "";
            Panel1Txtb2.Text = "";
            Panel1Txtb3.Text = "";
            Panel1Txtb4.Text = "";
            Panel1Txtb5.Text = "";
            Panel1Txtb6.Text = "";
            Panel2Txtb1.Text = "";
            Panel2Txtb2.Text = "";
            Panel2Txtb3.Text = "";
            Panel2Txtb4.Text = "";
            Panel2Txtb5.Text = "";
            Panel2Txtb6.Text = "";
            Panel2Txtb7.Text = "";

            // for radiobutton

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            button4.BackColor = Color.SteelBlue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Health_Info.Visible = true;
            P_profile.Visible = true;
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            P_profile.Visible = false;
            Health_Info.Visible = false;
        }

        private void Record_Click(object sender, EventArgs e)
        {
            string ViewRecords = @"C:\Users\Public\Document\test.text";
            List<string> ViewRecordsList = new List<string>();
            ViewRecordsList = File.ReadLines(ViewRecords).ToList();

            foreach (string ViewRecord in ViewRecordsList)
            {
                Records.Items.Add(ViewRecord);
            }
            File.WriteAllLines(ViewRecords, ViewRecordsList.ToArray());
        }

        private void DateRcrd(object sender, EventArgs e)
        {
            string ViewDateRecords = DateRecord.ToString();
            List<string> ViewDateRecordsList = new List<string>();
            ViewDateRecordsList = File.ReadLines(ViewDateRecords).ToList();

            foreach(string ViewDateRecord in ViewDateRecordsList)
            {
                Records.Items.Add(ViewDateRecord);
            }
            File.WriteAllLines(ViewDateRecords, ViewDateRecordsList.ToArray());
        }
    }
}