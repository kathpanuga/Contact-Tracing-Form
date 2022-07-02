using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using ZXing.QrCode;

namespace Contact_Tracing_Form
{
    public partial class Form2 : Form
    {
        private BarcodeReaderGeneric barcodeReader = new BarcodeReaderGeneric(new QRCodeReader(), null, null);

        public Form2()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;
            
        private void Form2_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                camcombobox.Items.Add(filterInfo.Name);
            camcombobox.SelectedIndex = 0;
        }

        private void STARTbtn_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[camcombobox.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
            timer1.Start();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(VideoCaptureDevice.IsRunning)
             VideoCaptureDevice.Stop();
        }

        private void VideoCaptureDevice_NewFrame (object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap) eventArgs.Frame.Clone();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                    if (result != null)
                {
                    QRcodetxtb.Text = result.ToString();
                    timer1.Stop();
                    if (VideoCaptureDevice.IsRunning)
                        VideoCaptureDevice.Stop();
                }

            }
        }
    }
}
