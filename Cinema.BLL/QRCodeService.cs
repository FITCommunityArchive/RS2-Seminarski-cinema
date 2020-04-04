﻿using Microsoft.AspNetCore.Hosting;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Cinema.BLL
{
    public class QRCodeService
    {

        private readonly IWebHostEnvironment _webHostEnvironment;

        public QRCodeService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
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

        public string CreateImage(string Byt)
        {
            byte[] data = Convert.FromBase64String(Byt);
            var filename = Convert.ToString(System.Guid.NewGuid()).Substring(0, 5) + Convert.ToString(System.Guid.NewGuid()).Substring(0, 5) + System.DateTime.Now.ToString("FFFFFF") + System.DateTime.Now.Minute;
            String path = Path.Combine(_webHostEnvironment.WebRootPath, "qrr"); //Path

            //Check if directory exist
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path); //Create directory if it doesn't exist
            }

            string imageName = filename + ".jpg";
            //set the image path
            string imgPath = Path.Combine(path, imageName);

            File.WriteAllBytes(imgPath, data);
            return filename;
        }
    }
}
