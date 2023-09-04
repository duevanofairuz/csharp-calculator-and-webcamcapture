using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;


namespace webcam_capture_ez
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice videoSrc;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo deviceList in captureDevice)
            {
                webcamList.Items.Add(deviceList.Name);
            }
            webcamList.SelectedIndex = 0;
            videoSrc = new VideoCaptureDevice();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (videoSrc.IsRunning)
            {
                videoSrc.SignalToStop();
                videoSrc.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
            videoSrc = new VideoCaptureDevice(captureDevice[webcamList.SelectedIndex].MonikerString);
            videoSrc.NewFrame += new NewFrameEventHandler(VideoSrc_NewFrame);
            videoSrc.Start();
        }

        private void VideoSrc_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void webcamList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Image as";
            saveFileDialog.Filter = "Image files (*.jpg, *.png) | *.jpg, *.png";
            ImageFormat imageFormat = ImageFormat.Png;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg; break;
                    case ".png":
                        imageFormat = ImageFormat.Png; break;
                }
                pictureBox2.Image.Save(saveFileDialog.FileName, imageFormat);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (videoSrc.IsRunning)
            {
                videoSrc.SignalToStop();
                videoSrc.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
                pictureBox2.Image = null;
                pictureBox2.Invalidate();
            }
            Application.Exit(null);
        }
    }
}