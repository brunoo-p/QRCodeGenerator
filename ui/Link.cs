using QR.Business.Link;
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
    public partial class Form_link : Form
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
        public Form_link(QR _form_qr)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.form_qr = _form_qr;
            form_qr.tb_description.Text = "In this function you associate a link to open with your QRCode.";
        }

        private void btn_createLink_Click(object sender, EventArgs e)
        {
            if (tb_link.TextLength > 0)
            {
                image = AssociateLink.QrLink(tb_link);
                form_qr.pb_preview.Image = image;
                form_qr.lb_direct.Visible = true;
                if (form_qr.pb_preview.Image == null)
                {
                    form_qr.pb_preview.Image = Properties.Resources.fora_ar;
                    form_qr.lb_direct.Visible = false;
                    tb_link.Focus();
                }
                
            }
            else
            {
                tb_link.Focus();
            }

        }

        private void tb_link_TextChanged(object sender, EventArgs e)
        {
            if (tb_link.TextLength < 1)
            {
                form_qr.pb_preview.Image = Properties.Resources.fora_ar;
                form_qr.lb_direct.Visible = false;
            }
        }
    }
}
