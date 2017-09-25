using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace JinRi.Flight.Utility.Secutiry
{
    public static class Base64Helper
    {

        /// <summary>
        /// Base64解密，采用utf8编码方式解密
        /// </summary>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string DecodeBase64(string result)
        {
            return DecodeBase64(result, Encoding.UTF8);
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="codeName">解密采用的编码方式，注意和加密时采用的方式一致</param>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string DecodeBase64(string result, Encoding encode)
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(result);
            try
            {
                decode = encode.GetString(bytes);
            }
            catch
            {
                decode = result;
            }
            return decode;
        }


        /// <summary>
        /// 转换成Base64
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        public static string ToBase64String(string inputStr)
        {
            byte[] bytes = Encoding.Default.GetBytes(inputStr);
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// 转换成Base64
        /// </summary>
        /// <param name="inputStr"></param>
        /// <param name="encode"></param>
        /// <returns></returns>
        public static string ToBase64String(string inputStr, Encoding encode)
        {
            byte[] bytes = encode.GetBytes(inputStr);
            return Convert.ToBase64String(bytes);
        }


        /// <summary>
        /// 把图片转换成Base64
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ImageToBase64(string path)
        {
            MemoryStream m = new MemoryStream();
            Bitmap bp = new Bitmap(path);
            bp.Save(m, System.Drawing.Imaging.ImageFormat.Gif);
            byte[] b = m.GetBuffer();
            string base64string = Convert.ToBase64String(b);
            return base64string;
        }

        /// <summary>
        /// 从Base64转换成Bitmap
        /// </summary>
        /// <param name="imageBase64Str"></param>
        /// <returns></returns>
        public static Bitmap Base64ToImage(string imageBase64Str)
        {
            byte[] bt = Convert.FromBase64String(imageBase64Str);
            MemoryStream stream = new MemoryStream(bt);
            Bitmap bitmap = new Bitmap(stream);
            return bitmap;
        }

    }
}
