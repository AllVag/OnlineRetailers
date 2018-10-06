using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace _0922WebApp
{
    public partial class VerifyCode : System.Web.UI.Page
    {
        public static string strVerifyCode = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            strVerifyCode = GenerateCheckCode();
            CreateCheckCodeImage(strVerifyCode);
        }

        /// <summary>
        /// 生成验证码(静态函数)
        /// </summary>
        /// <param name="nLen"></param>
        /// <returns></returns>
        private string GenerateCheckCode(int nLen = 4)
        {

            string checkCode = String.Empty;

            //随机数
            Random random = new Random();

            char code;

            for (int i = 0; i < nLen; i++)
            {
                int number = random.Next();

                //生成数字
                if (i % 2 == 0)
                {
                    code = (char)('0' + (char)(number % 10));
                }
                else
                { //生成字母
                    code = (char)('A' + (char)(number % 26));
                }

                checkCode += code.ToString();

            }

            return checkCode;
        }

        /// <summary>
        /// 绘制验证码
        /// </summary>
        /// <param name="checkCode"></param>
        private void CreateCheckCodeImage(string checkCode)
        {
            if (checkCode == null || checkCode.Trim() == String.Empty)
                return;

            System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling((checkCode.Length * 25.0)), 33);
            Graphics g = Graphics.FromImage(image);

            try
            {
                //生成随机生成器
                Random random = new Random();

                //清空图片背景色
                g.Clear(Color.White);

                //画图片的背景噪音线
                for (int i = 0; i < 2; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);

                    g.DrawLine(new Pen(Color.Black), x1, y1, x2, y2);
                }

                Font font = new System.Drawing.Font("Arial", 20, (System.Drawing.FontStyle.Bold));
                System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.DarkRed, 1.2f, true);

                //绘制生成的验证码字符
                g.DrawString(checkCode, font, brush, 2, 2);

                //画图片的前景噪音点
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);

                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }

                //画图片的边框线
                g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

                Response.ClearContent();
                //设置页面输出的内容类型
                Response.ContentType = "image/Gif";
                Response.BinaryWrite(ms.ToArray());
            }
            catch(Exception e) 
            {
                Response.Write(e);
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }

    }
}