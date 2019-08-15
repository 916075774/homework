using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class DownloadController : Controller
    {
        // GET: Download
        public ActionResult Index()
        {
            return View();
        }

        //下载图片
        [HttpGet]
        public ActionResult Get()
        {
            string fileName = Server.MapPath("~/tupian.ico");
            return File(fileName, "ico", "myname.ico");
        }
    }
}