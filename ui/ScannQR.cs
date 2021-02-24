using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Codec;
using System.Runtime.InteropServices;

namespace QR.ui
{
    public partial class ScannQR : Form
    {
        private QR form_qr = null;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        OpenFileDialog openFile = new OpenFileDialog();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,
          int nRightRect,
          int nTopRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse
      );
        public ScannQR(QR _form_qr)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.form_qr = _form_qr;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pb_cam.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ScannQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            pb_cam.Image = null;
            if (captureDevice != null)
            {
                if (captureDevice.IsRunning)
                {
                    captureDevice.SignalToStop();
                    captureDevice = null;
                }
            }
        }

        private Result DecodeQR(PictureBox pb)
        {
            BarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode((Bitmap)pb.Image);
            return result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb_cam.Image != null)
            {
                Result result = DecodeQR(pb_cam);

                if (result != null)
                {
                    string data = result.ToString();
                    if (data.Contains("https"))
                    {
                        System.Diagnostics.Process.Start(data);
                        captureDevice.Stop();
                        timer1.Stop();
                    }
                    MessageBox.Show(data);

                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
                pb_cam.Image = Properties.Resources.samara_film;
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                btn_start.Enabled = false;
                bt_stop.Enabled = false;
                pb_cam.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void btn_scann_Click(object sender, EventArgs e)
        {
            try
            {
                if (pb_cam.Image != null)
                {
                    Result result = DecodeQR(pb_cam);

                    if (result != null)
                    {
                        string data = result.ToString();
                        if (data.Contains("https"))
                        {
                            System.Diagnostics.Process.Start(data);
                        }
                        MessageBox.Show(data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            captureDevice = null;
            this.Close();
            form_qr.pn_scann.Visible = false;
            form_qr.pn_create.Visible = true;
            form_qr.btn_createQR.BackColor = Color.Silver;
            form_qr.pn_optionsCreate.Visible = true;
        }
    }
}
