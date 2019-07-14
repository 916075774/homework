using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb
{
    /// <summary>
    /// pager是指定tag的名字(如果没有它会使用默认的，默认的是类型，去掉后缀TagHelper的类名)，Attributes指定tag里可以包含的属性
    /// </summary>
    [HtmlTargetElement("pager",Attributes = "pagePrivacy,path")]
    /// 必须继承TagHelper
    public class PagerTagHelper : TagHelper
    {
                //context: 能够获取attributes的信息
        //output：输出的原生html标签
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a"; //原生标签名

            //设置a标签里href的值
            object pagePrivacy = context.AllAttributes["pagePrivacy"].Value;
            object path = context.AllAttributes["path"].Value;
            output.Attributes.Add("href", $"{path}/Page-{pagePrivacy}");

        }
    }
}
