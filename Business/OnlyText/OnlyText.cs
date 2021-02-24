using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR.Business.OnlyText
{
    public class OnlyText
    {
        public static Bitmap QRText(TextBox tb_onlyText)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var data = QG.CreateQrCode(tb_onlyText.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(data);
            Bitmap qrCodeImage = code.GetGraphic(50);
            
            return qrCodeImage;
        }

    }
}
