using QR.Business.WppMessage;
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
    public partial class Form_wpp : Form
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
        public Form_wpp(QR _form_qr)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.form_qr = _form_qr;
            tb_message.Text = "Message";
            form_qr.tb_description.Text = "Schedule a message to open your contact on WhatApp.";
        }

        private void btn_wpp_Click(object sender, EventArgs e)
        {
            if (tb_number.TextLength > 0)
            {
                image = WppMessage.QRWpp(tb_number, tb_message);
                form_qr.pb_preview.Image = image;
                form_qr.lb_direct.Visible = true;
            }
        }

        private void tb_number_Click(object sender, EventArgs e)
        {
            pn_number.BackColor = Color.CornflowerBlue;
        }

        private void tb_message_Click(object sender, EventArgs e)
        {
            tb_message.Text = "";
            pn_number.BackColor = Color.White;
        }
    }
}
