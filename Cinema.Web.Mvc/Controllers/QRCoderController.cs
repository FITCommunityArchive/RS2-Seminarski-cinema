using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.IO;
using QRCoder;

namespace Cinema.Web.Mvc.Controllers
{
    public class QRCoderController : Controller
    {
        
        public IActionResult Index(string qrText)
        {
            Bitmap qrCodeImage = null;
            if (qrText != null) { 
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText,
                QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                qrCodeImage = qrCode.GetGraphic(20);
                return View(BitmapToBytes(qrCodeImage));
            }

            return View();
        }

        private static Byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public byte[] GenerateCode(string qrText)
        {
            Bitmap qrCodeImage = null;
            if (qrText != null)
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText,
                QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                qrCodeImage = qrCode.GetGraphic(20);
            }

            return BitmapToBytes(qrCodeImage);
        }
    }
}