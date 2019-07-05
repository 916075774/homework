using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace FrameWork
{
    class Program
    {
        static void Main(string[] args)
        {

            Type myType = typeof(Form);
            Console.WriteLine(myType.BaseType.FullName + Environment.NewLine + myType.FullName);




            //Form f = new Form();
            //f.WindowState = FormWindowState.Normal;
            //f.ShowDialog();

            Console.ReadLine();
            #region dynamic
            //dynamic myVar = 100;
            //Console.WriteLine(myVar);
            //myVar = "Mr.OKay";
            //Console.WriteLine(myVar); 
            #endregion//
        }
        class Captcha
        {
            public Bitmap bitmap;
            public Graphics graphics;
            private Random random;
            public Color[] colors = { Color.Black, Color.Blue, Color.Yellow, Color.Red, Color.Navy, Color.Coral };
            public string[] fonts = { "微软雅黑", "长城中行书体", "黑体", "隶书", "吕建德行楷" };
            public FontStyle[] fontStyles = { FontStyle.Italic, FontStyle.Bold, FontStyle.Regular };
            public Captcha(int width, int height)
            {
                bitmap = new Bitmap(width, height);
                random = new Random();
                graphics = Graphics.FromImage(bitmap);
            }
            /// <summary>
            /// 画字符串
            /// </summary>
            /// <param name="codeNumber"></param>
            /// <returns></returns>
            public Bitmap CreateBitmap(int codeNumber)
            {
                if (codeNumber < 0)
                {
                    throw new MyException();
                }
                float fontSize = 60;
                string strCode = null;

                for (int i = 0; i < codeNumber; i++)
                {
                    int rNumber = random.Next(10);
                    strCode += rNumber.ToString();
                }
                for (int i = 0; i < codeNumber; i++)
                {
                    graphics.DrawString(strCode[i].ToString(), new Font(fonts[random.Next(fonts.Length)], fontSize, fontStyles[random.Next(fontStyles.Length)]), new SolidBrush(colors[random.Next(colors.Length)]), new Point(i * 50, 0));
                }
                return bitmap;
            }
            /// <summary>
            /// 添加曲线
            /// </summary>
            public void AddCurve(int curveNumber)
            {
                for (int i = 0; i < curveNumber; i++)
                {
                    graphics.DrawCurve(new Pen(colors[random.Next(colors.Length)]), new Point[]
                   {
                        new Point(random.Next(bitmap.Width),random.Next(bitmap.Height)),
                        new Point(random.Next(bitmap.Width),random.Next(bitmap.Height)),
                        new Point(random.Next(bitmap.Width),random.Next(bitmap.Height)),
                        new Point(random.Next(bitmap.Width),random.Next(bitmap.Height))
                   });
                }
            }
            /// <summary>
            /// 添加像素点
            /// </summary>
            public void AddPixel(int pixelNumber)
            {
                for (int i = 0; i < pixelNumber; i++)
                {
                    bitmap.SetPixel(random.Next(bitmap.Width), random.Next(bitmap.Height), colors[random.Next(colors.Length)]);
                }
            }
        }
        class MyException : Exception
        {
            public void MyMessage()
            {
                Console.WriteLine("不行,你输入的验证码太长了!!!");
            }
        }
    }



}