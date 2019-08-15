using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class CaptchaController : Controller
    {
        public const string CAPTCHA = "captcha";

        // GET: Captcha
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Get()
        {
            byte[] captcha = MakeCaptcha(out string random);
            //把验证码存入session
            Session[CAPTCHA]= random;

            return File(captcha, "jpg");
        }

        //生成随机的验证码图片
        public byte[] MakeCaptcha(out string random)
        {
            Bitmap bitmap = new Bitmap(55, 27);
            Graphics graphics = Graphics.FromImage(bitmap);
            Font font = new Font("Arial", 12, (FontStyle.Bold | FontStyle.Italic));
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                Color.DarkCyan, Color.AliceBlue, 1.2f, true);

            random = new Random().Next(1000, 9999).ToString();

            graphics.DrawString(random, font, brush, 3, 2);

            //保存图片数据
            MemoryStream stream = new MemoryStream();
            bitmap.Save(stream, ImageFormat.Jpeg);

            //输出图片流
            return stream.ToArray();
        }

    }
}