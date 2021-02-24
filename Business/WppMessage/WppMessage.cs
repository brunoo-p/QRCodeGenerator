using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR.Business.WppMessage
{
    public class WppMessage
    {
        public static Bitmap QRWpp(TextBox tb_number, TextBox tb_message)
        {
            PayloadGenerator.WhatsAppMessage generator = new PayloadGenerator.WhatsAppMessage(tb_number.Text, tb_message.Text);
            String payload = generator.ToString();

            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData data = QR.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            Bitmap image = code.GetGraphic(50, Color.FromArgb(33, 140, 116), Color.FromArgb(245,245,245), (Bitmap)Image.FromFile("C:\\Users\\bruno\\Downloads\\wpp1.png"),25);
            return image;
        }
    }
}
