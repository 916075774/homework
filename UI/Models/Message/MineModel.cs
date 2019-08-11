using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models.Message
{
    public class MineModel
    {
        public IList<MessageItemModel> Messages { get; set; }
    }

    public class MessageItemModel
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
        public bool Selected { get; set; }
    }
}