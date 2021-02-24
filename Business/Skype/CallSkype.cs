using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace QR.Business.Skype
{
    public class CallSkype
    {
        public static Bitmap Call(TextBox tb_skype)
        {
            SkypeCall generator = new SkypeCall(tb_skype.Text);
            String payload = generator.ToString();

            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData data = QR.CreateQrCode(payload, QRCodeGenerator.ECCLevel.H);
            QRCode code = new QRCode(data);
            Bitmap image = code.GetGraphic(50, Color.FromArgb(34, 112, 147), Color.FromArgb(245, 245, 245), (Bitmap)Image.FromFile("C:\\Users\\bruno\\Downloads\\skype.png"), 25);
            return image;
        }
    }
}
