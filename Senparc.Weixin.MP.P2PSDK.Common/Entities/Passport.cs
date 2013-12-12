using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// P2P通行证
    /// </summary>
    public class Passport : IP2PResultData
    {
        public string Token { get; set; }
        public string AppKey { get; set; }
        public string Secret { get; set; }
        /// <summary>
        /// P2P常规URL
        /// </summary>
        public string P2PUrl { get; set; }
        /// <summary>
        /// 微信营销工具URL
        /// </summary>
        public string MarketToolUrl { get; set; }
        public string UserName { get; set; }
        public string PasswordMd5 { get; set; }
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 供P2P服务器记录唯一标准
        /// </summary>
        public int WeixinAppId { get; set; }
    }
}
