using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR.ui
{
    public partial class Form_save : Form
    {
        private QR form_qr = null;
        SaveFileDialog saveFile = new SaveFileDialog();
        public Form_save(QR _form_qr)
        {
            InitializeComponent();
            this.form_qr = _form_qr;
            pb_save.Image = form_qr.pb_preview.Image;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                saveFile.Filter = "PNG|*.png";
                saveFile.FileName = "QRCode";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    if (pb_save.Image != null)
                    {
                        pb_save.Image.Save(String.Concat(saveFile.FileName, ".png"), ImageFormat.Png);
                    }
                    MessageBox.Show("Arquivo Salvo.", "Sucesso!", MessageBoxButtons.OK);
                    this.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Salvar Arquivo.", "Tente Novamente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
