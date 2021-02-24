using QR.Business.OnlyText;
using QRCoder;
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
    public partial class Form_onlyText : Form
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
        public Form_onlyText(QR _form_qr)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.form_qr = _form_qr;
            form_qr.tb_description.Text = "In this option you can create a QRCode with an Text for show when it's read.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_text.TextLength > 0)
            {
                image = OnlyText.QRText(tb_text);
                form_qr.pb_preview.Image = image;
                form_qr.lb_direct.Visible = true;
            }
            else
            {
                tb_text.Focus();
            }
        }

        private void tb_text_TextChanged(object sender, EventArgs e)
        {
            if(tb_text.TextLength < 1)
            {
                form_qr.pb_preview.Image = Properties.Resources.fora_ar;
                form_qr.lb_direct.Visible = false;
            }
        }
    }
}
