using QR.ui;
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

namespace QR
{
    public partial class QR : Form
    {
        marketing mkg = new marketing() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
        public QR()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.pn_main.Controls.Add(mkg);
            mkg.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_onlyText_Click(object sender, EventArgs e)
        {
            ChangeButton(1, btn_onlyText);
            lb_direct.Visible = false;
            lb_description.Visible = true;
            tb_description.Visible = true;
            Form_onlyText txt = new Form_onlyText(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pn_main.Controls.Clear();
            this.pn_main.Controls.Add(txt);
            pb_preview.Image = Properties.Resources.fora_ar;
            txt.Show();
        }

        private void btn_link_Click(object sender, EventArgs e)
        {
            ChangeButton(2, btn_link);
            lb_direct.Visible = false;
            lb_description.Visible = true;
            tb_description.Visible = true;
            Form_link fLink = new Form_link(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pn_main.Controls.Clear();
            this.pn_main.Controls.Add(fLink);
            pb_preview.Image = Properties.Resources.fora_ar;
            fLink.Show();
        }

        private void btn_wifi_Click(object sender, EventArgs e)
        {
            ChangeButton(3, btn_wifi);
            lb_direct.Visible = false;
            lb_description.Visible = true;
            tb_description.Visible = true;
            Form_wifi fwifi = new Form_wifi(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pn_main.Controls.Clear();
            this.pn_main.Controls.Add(fwifi);
            pb_preview.Image = Properties.Resources.fora_ar;
            fwifi.Show();
        }

        private void btn_wpp_Click(object sender, EventArgs e)
        {
            ChangeButton(4, btn_wpp);
            lb_direct.Visible = false;
            lb_description.Visible = true;
            tb_description.Visible = true;
            Form_wpp fwpp = new Form_wpp(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pn_main.Controls.Clear();
            this.pn_main.Controls.Add(fwpp);
            pb_preview.Image = Properties.Resources.fora_ar;
            fwpp.Show();
        }

        private void btn_skype_Click(object sender, EventArgs e)
        {
            ChangeButton(5, btn_skype);
            lb_direct.Visible = false;
            lb_description.Visible = true;
            tb_description.Visible = true;
            Form_skype fskype = new Form_skype(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pn_main.Controls.Clear();
            this.pn_main.Controls.Add(fskype);
            pb_preview.Image = Properties.Resources.fora_ar;
            fskype.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
                Form_save fsave = new Form_save(this);
                fsave.ShowDialog();
        }

        private void ChangeButton(int id, Button button)
        {
            switch(id)
            {
                case 1:
                    button.BackColor = Color.Transparent;
                    btn_link.BackColor = Color.SlateGray;
                    btn_wifi.BackColor = Color.SlateGray;
                    btn_wpp.BackColor = Color.SlateGray;
                    btn_skype.BackColor = Color.SlateGray;
                break;
                case 2:
                    button.BackColor = Color.Transparent;
                    btn_onlyText.BackColor = Color.SlateGray;
                    btn_wifi.BackColor = Color.SlateGray;
                    btn_wpp.BackColor = Color.SlateGray;
                    btn_skype.BackColor = Color.SlateGray;
                break;
                case 3:
                    button.BackColor = Color.Transparent;
                    btn_onlyText.BackColor = Color.SlateGray;
                    btn_link.BackColor = Color.SlateGray;
                    btn_wpp.BackColor = Color.SlateGray;
                    btn_skype.BackColor = Color.SlateGray;
                break;
                case 4:
                    button.BackColor = Color.Transparent;
                    btn_onlyText.BackColor = Color.SlateGray;
                    btn_link.BackColor = Color.SlateGray;
                    btn_wifi.BackColor = Color.SlateGray;
                    btn_skype.BackColor = Color.SlateGray;
                break;
                case 5:
                    button.BackColor = Color.Transparent;
                    btn_onlyText.BackColor = Color.SlateGray;
                    btn_wifi.BackColor = Color.SlateGray;
                    btn_wpp.BackColor = Color.SlateGray;
                    btn_link.BackColor = Color.SlateGray;
                break;
                default:
                    btn_link.BackColor = Color.SlateGray;
                    btn_onlyText.BackColor = Color.SlateGray;
                    btn_wifi.BackColor = Color.SlateGray;
                    btn_wpp.BackColor = Color.SlateGray;
                    btn_skype.BackColor = Color.SlateGray;
                    break;
            }
        }

        private void btn_scannQR_Click(object sender, EventArgs e)
        {
            pn_create.Visible = false;
            pn_scann.Visible = true;
            btn_createQR.BackColor = Color.FromArgb(200, 214, 209);
            btn_scannQR.BackColor = Color.Silver;
            pn_optionsCreate.Visible = false;
            ScannQR scann = new ScannQR(this);
            scann.ShowDialog();

            pn_main.Controls.Clear();
            tb_description.Clear();
            lb_description.Visible = false;
            tb_description.Visible = false;
            this.pn_main.Controls.Add(mkg);
            pb_preview.Image = Properties.Resources.fora_ar;
            lb_direct.Visible = false;
            ChangeButton(6, button: null);
        }
    }
}
