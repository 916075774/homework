using SRV;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory.Suggest
{
    internal class NewFactory
    {
        private static SuggestService _suggestService;
        static NewFactory()
        {
            _suggestService = new SuggestService();
        }

        internal static void Create()
        {
            _suggestService.publish("测试1", "", RegissterFctory.XiaoYu.Id);
        }
    }
}
