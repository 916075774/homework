using System;
using HomeWork;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace HomeWork._17bang
{
    public static class Xxx
    {

        public static void XElement()
        {
            XElement xElement = new XElement("articles",
                new XComment("以下存放所有“源栈”所有文章"),
                new XElement("article", new XAttribute("isDraft", "false"),
                        new XElement("id", "1"),
                        new XElement("title", "源栈培训：C#进阶—7：Linq to XML"),
                        new XElement("body", "什么是XML（EXtensible Markup Language）是一种文本文件格式被设计用来传输和存储数据由：标签和属性组成元素（节点），由元素组成“树状结构”必须有而且只能有一个根节点其他"),
                        new XElement("authorId", "1"),
                        new XElement("publishDate", DateTime.Now.ToString()),
                        new XElement("comments",
                            new XElement("comment", new XAttribute("recommend", "true"),
                            new XElement("id", "12"),
                            new XElement("body", "不错，赞！"),
                            new XElement("authorId", "2")),
                            new XElement("comment",
                                new XElement("id", "14"),
                                new XElement("body", "作业太难了"),
                                new XElement("authorId", "3")))),
               Yyy.XElement1()
            );

            //XDocument document = new XDocument(
            //    new XDeclaration("1.0", "utf-8", "yes"),
            //    xElement);                              //实例化
            //document.Save("D:\\17bang\\XML.xml");       //文件保存
        }
    }
    public static class Yyy
    {
        public static XElement XElement1()
        {
            XElement xElement1 =
            new XElement("article", new XAttribute("isDraft", "true"),
                new XElement("id", "2"),
                new XElement("title", "源栈培训：C#进阶-6：异步和并行"),
                new XElement("authorId", "1"));

            XDocument document = new XDocument(xElement1);
            document.Save("D:\\17bang\\XML.xml");
            Console.WriteLine(xElement1);

            return xElement1;
        }
    }

}