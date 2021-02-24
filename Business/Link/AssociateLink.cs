using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR.Business.Link
{
    public class AssociateLink
    {
        public static Bitmap QrLink(TextBox tb_link)
        {
            Bitmap qrCodeImage;

            if (tb_link.TextLength > 0)
            {
                Url generator = new Url(tb_link.Text);
                String payload = generator.ToString();

                QRCodeGenerator QR = new QRCodeGenerator();
                QRCodeData data = QR.CreateQrCode(payload, QRCodeGenerator.ECCLevel.H);
                QRCode qrCode = new QRCode(data);
                qrCodeImage = qrCode.GetGraphic(50);
                return qrCodeImage;
            }
            else
            {
                MessageBox.Show("Write or Paste an Link.");
                qrCodeImage = null;
                return qrCodeImage;
            }
        }
    }
}
