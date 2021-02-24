using QR.Business.Skype;
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
    public partial class Form_skype : Form
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
        public Form_skype(QR _form_qr)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.form_qr = _form_qr;
            form_qr.tb_description.Text = "Redirect to a call on Skype.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_skype.TextLength > 0)
            {
                image = CallSkype.Call(tb_skype);
                form_qr.pb_preview.Image = image;
                form_qr.lb_direct.Visible = true;
            }
        }

        private void tb_skype_Click(object sender, EventArgs e)
        {
            pn_skype.BackColor = Color.CornflowerBlue;
            lb_user.ForeColor = Color.CornflowerBlue;
        }

        private void tb_skype_TextChanged(object sender, EventArgs e)
        {
            if (tb_skype.TextLength > 0)
            {
                pn_skype.BackColor = Color.CornflowerBlue;
                lb_user.ForeColor = Color.CornflowerBlue;
            }
                
        }
    }
}
