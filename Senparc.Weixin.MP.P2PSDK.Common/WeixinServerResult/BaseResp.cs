using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common.WeixinServerResult
{
    /// <summary>
    /// 对应base_resp，比如出现在用户用户详细信息中
    /// </summary>
   public class BaseResp
    {
        public int ret { get; set; }
        public string err_msg { get; set; }
    }
}
