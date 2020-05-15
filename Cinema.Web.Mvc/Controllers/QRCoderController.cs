using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System;
using System.Drawing;
using System.IO;

namespace Cinema.Web.Mvc.Controllers
{
    public class QRCoderController : Controller
    {

        private readonly IWebHostEnvironment _webHostEnvironment;

        public QRCoderController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index(string qrText)
        {
            Bitmap qrCodeImage = null;
            if (qrText != null)
            {
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


        public IActionResult GenerateFile(string qrText)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);

            string fileGuid = Guid.NewGuid().ToString().Substring(0, 4);

            qrCodeData.SaveRawData("wwwroot/qrr/file-" + fileGuid + ".qrr", QRCodeData.Compression.Uncompressed);

            QRCodeData qrCodeData1 = new QRCodeData("wwwroot/qrr/file-" + fileGuid + ".qrr", QRCodeData.Compression.Uncompressed);

            QRCode qrCode = new QRCode(qrCodeData1);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return View(BitmapToBytes(qrCodeImage));
        }

        public string CreateImage(string Byt)
        {
            byte[] data = Convert.FromBase64String(Byt);
            var filename = Convert.ToString(System.Guid.NewGuid()).Substring(0, 5) + Convert.ToString(System.Guid.NewGuid()).Substring(0, 5) + System.DateTime.Now.ToString("FFFFFF") + System.DateTime.Now.Minute;
            String path = Path.Combine(_webHostEnvironment.WebRootPath, "qrr"); //Path

            //Check if directory exist
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path); //Create directory if it doesn't exist
            }

            string imageName = filename + ".jpg";
            //set the image path
            string imgPath = Path.Combine(path, imageName);

            System.IO.File.WriteAllBytes(imgPath, data);
            return filename;
        }
    }
}