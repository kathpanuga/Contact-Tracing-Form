namespace Contact_Tracing_Form
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.camcombobox = new System.Windows.Forms.ComboBox();
            this.STARTbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.QRcodetxtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(91, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Camera";
            // 
            // camcombobox
            // 
            this.camcombobox.FormattingEnabled = true;
            this.camcombobox.Location = new System.Drawing.Point(153, 45);
            this.camcombobox.Name = "camcombobox";
            this.camcombobox.Size = new System.Drawing.Size(253, 24);
            this.camcombobox.TabIndex = 5;
            // 
            // STARTbtn
            // 
            this.STARTbtn.Location = new System.Drawing.Point(91, 380);
            this.STARTbtn.Name = "STARTbtn";
            this.STARTbtn.Size = new System.Drawing.Size(75, 23);
            this.STARTbtn.TabIndex = 6;
            this.STARTbtn.Text = "Start";
            this.STARTbtn.UseVisualStyleBackColor = true;
            this.STARTbtn.Click += new System.EventHandler(this.STARTbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QRcodetxtb
            // 
            this.QRcodetxtb.Location = new System.Drawing.Point(91, 352);
            this.QRcodetxtb.Name = "QRcodetxtb";
            this.QRcodetxtb.Size = new System.Drawing.Size(315, 22);
            this.QRcodetxtb.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 481);
            this.Controls.Add(this.QRcodetxtb);
            this.Controls.Add(this.STARTbtn);
            this.Controls.Add(this.camcombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "QRcode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox camcombobox;
        private System.Windows.Forms.Button STARTbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox QRcodetxtb;
    }
}