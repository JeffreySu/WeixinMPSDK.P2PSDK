using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senparc.Weixin.MP.P2PSDK.Common;

namespace Senparc.Weixin.MP.P2PSDK
{
    /// <summary>
    /// 同时管理多个应用的Passport的容器
    /// </summary>
    public class PassportCollection : Dictionary<string, PassportBag>
    {
        /// <summary>
        /// 统一URL前缀，如http://api.souidea.com:8282/P2P/
        /// </summary>
        public string BasicUrl { get; set; }
        public string MarketingToolUrl { get; set; }
        public PassportCollection()
        {
        }
    }
}
