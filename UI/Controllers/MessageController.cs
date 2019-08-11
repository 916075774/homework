using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models.Message;

namespace UI.Controllers
{
    public class MessageController : Controller
    {
        [HttpGet]
        public ActionResult Mine()
        {
            MineModel model = new MineModel
            {

                Messages = new List<MessageItemModel>
                {
                    new MessageItemModel{Content="《折腾》风雨 之（1）视野",Id=1},
                    new MessageItemModel{Content="《折腾》风雨 之（2）远见",Id=2},
                    new MessageItemModel{Content="《折腾》风雨 之（3）胸怀",Id=3},
                    new MessageItemModel{Content="《折腾》风雨 之（4）抱负",Id=4},
                }
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Mine(MineModel model)
        {
            foreach (var item in model.Messages)
            {
                if (item.Selected)
                {
                    //使用item.Id处理
                }
            }
            return View();
        }

    }
}