using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UI.Utils
{
    public static class Convertor
    {
        public static Bitmap ToImage(byte[] bytes)
        {
            if(bytes == null)
            {
                return Properties.Resources.icons8_customer_50;
            }
            var ms = new MemoryStream(bytes);
            return new Bitmap(ms);
        }

        public static byte[] ToBinaryArray(Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Bmp);
            return ms.ToArray();
        }

        public static DateTime? StringToDate(string text, string stringFormat = "dd/MM/yyyy")
        {
            var provider = CultureInfo.InvariantCulture;
            return DateTime.ParseExact(text, stringFormat, provider);            
        }

        public static DateTime? StringToTime(string text, string stringFormat = "HH:mm dd/MM/yyyy")
        {
            var provider = CultureInfo.InvariantCulture;
            return DateTime.ParseExact(text, stringFormat, provider);
        }

        public static string DateToString(DateTime date, string stringFormat = "dd/MM/yyyy")
        {
            return date.ToString(stringFormat);
        }

        public static string TimeToString(DateTime time, string stringFormat = "HH:mm dd/MM/yyyy")
        {
            return time.ToString(stringFormat);
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
