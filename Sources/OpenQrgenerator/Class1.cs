using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace OpenQrgenerator
{
    public class Class1
    {

        public String GenerateQr(String Qrdata)
        {
            String t_stamp = DateTime.Now.ToShortDateString()+"-" + DateTime.Now.ToShortTimeString();
             
         if (String.IsNullOrEmpty(Qrdata))
            {
                return "invalid data-" +t_stamp;
            }
            try
            {
    
                BitmapImage bitmapImage;
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRCodedata = qRCodeGenerator.CreateQrCode(Qrdata.ToString(), QRCodeGenerator.ECCLevel.Q);
                QRCode qrcode = new QRCode(qRCodedata);
                Bitmap bitmap = qrcode.GetGraphic(20);
                using (var memory = new System.IO.MemoryStream())
                {
                    bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
                    memory.Position = 0;
                    bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = memory;
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.EndInit();
                }
                if (bitmapImage != null)
                {
                    String img_path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Qrimg.jpg");
                    BitmapEncoder encoder = new JpegBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                    using (var Qr_img = new FileStream(img_path, FileMode.Create))
                    {
                        encoder.Save(Qr_img);
                    }
                }
                return "Qr generated -" + t_stamp;
            }catch(Exception ex)
            {
                return t_stamp + "-"+ ex.Message;
            }


        }









    }

}
