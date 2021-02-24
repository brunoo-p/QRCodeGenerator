using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR.Business.Wifi
{
    public class ConnectWifi
    {
        public static Bitmap QRwifi(TextBox tb_ssid, TextBox tb_pass)
        {
            PayloadGenerator.WiFi generator = new PayloadGenerator.WiFi(tb_ssid.Text, tb_pass.Text, PayloadGenerator.WiFi.Authentication.WPA);
            String payload = generator.ToString();

            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData data = QR.CreateQrCode(payload, QRCodeGenerator.ECCLevel.H);
            QRCode code = new QRCode(data);
            Bitmap image = code.GetGraphic(50, "#c23616", "#FFF");
            return image;
        }
    }
}
