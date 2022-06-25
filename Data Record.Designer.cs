namespace Contact_Tracing_Form
{
    partial class Data_Record
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.P_profile = new System.Windows.Forms.Panel();
            this.Btn1_P1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.P_profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_profile
            // 
            this.P_profile.BackColor = System.Drawing.Color.Snow;
            this.P_profile.Controls.Add(this.dateTimePicker2);
            this.P_profile.Controls.Add(this.dateTimePicker1);
            this.P_profile.Controls.Add(this.Btn1_P1);
            this.P_profile.Controls.Add(this.label1);
            this.P_profile.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_profile.Location = new System.Drawing.Point(176, 110);
            this.P_profile.Name = "P_profile";
            this.P_profile.Size = new System.Drawing.Size(555, 523);
            this.P_profile.TabIndex = 1;
            // 
            // Btn1_P1
            // 
            this.Btn1_P1.ForeColor = System.Drawing.Color.Black;
            this.Btn1_P1.Location = new System.Drawing.Point(451, 486);
            this.Btn1_P1.Name = "Btn1_P1";
            this.Btn1_P1.Size = new System.Drawing.Size(83, 23);
            this.Btn1_P1.TabIndex = 5;
            this.Btn1_P1.Text = "Next";
            this.Btn1_P1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(113, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTACT TRACING FORM";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(272, 135);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // Data_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.P_profile);
            this.Name = "Data_Record";
            this.Size = new System.Drawing.Size(907, 743);
            this.P_profile.ResumeLayout(false);
            this.P_profile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_profile;
        private System.Windows.Forms.Button Btn1_P1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
