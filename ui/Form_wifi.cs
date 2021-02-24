using QR.Business.Wifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR.ui
{
    public partial class Form_wifi : Form
    {
        Bitmap image;
        private QR form_qr = null;
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
        public Form_wifi(QR _form_qr)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.form_qr = _form_qr;
            form_qr.tb_description.Text = "Here you can create an Access Code for Wi-Fi point!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_ssid.TextLength > 0)
            {
                image = ConnectWifi.QRwifi(tb_ssid, tb_pass);
                form_qr.pb_preview.Image = image;
                form_qr.lb_direct.Visible = true;
            }
        }

        private void tb_ssid_Click(object sender, EventArgs e)
        {
            tb_ssid.Clear();
            tb_pass.Clear();
            pn_pass.BackColor = Color.White;
            pn_ssid.BackColor = Color.CornflowerBlue;
        }

        private void tb_pass_Click(object sender, EventArgs e)
        {
            tb_pass.Clear();
            tb_ssid.Clear();
            pn_ssid.BackColor = Color.White;
            pn_pass.BackColor = Color.CornflowerBlue;
            tb_pass.PasswordChar = '•';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(tb_pass.PasswordChar == '•')
            {
                tb_pass.PasswordChar = '\0';
            }else if(tb_pass.PasswordChar == '\0')
            {
                tb_pass.PasswordChar = '•';
            }
            
        }
    }
}
