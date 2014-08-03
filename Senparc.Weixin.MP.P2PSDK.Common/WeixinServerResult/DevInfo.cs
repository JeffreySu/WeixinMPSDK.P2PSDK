using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common.WeixinServerResult
{
    /// <summary>
    /// 开发者信息
    /// </summary>
    public class DevInfo
    {
        public string URL { get; set; }
        public string Token { get; set; }
        public string AppId { get; set; }
        public string AppSecret { get; set; }
        /// <summary>
        /// 是否已经开通高级功能
        /// </summary>
        public bool HasAdvancedApi { get; set; }
    }
}
