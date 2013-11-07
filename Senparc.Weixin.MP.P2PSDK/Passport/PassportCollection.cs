using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senparc.Weixin.MP.P2PSDK.Common;

namespace Senparc.Weixin.MP.P2PSDK
{
    public class PassportCollection : Dictionary<string, PassportBag>
    {
        /// <summary>
        /// 统一URL前缀，如http://api.souidea.com:8282/P2P/
        /// </summary>
        public string Url { get; set; }
        public PassportCollection()
        {
        }
    }
}
