using System.Collections.Generic;
using System.ComponentModel;
using Senparc.Weixin.MP.P2PSDK.Common.WeixinServerResult;

namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// 通过Ajax获取的用户信息（JSON格式）
    /// </summary>
    public class WeixinUserInfoJson : IP2PResultData
    {
        public BaseResp base_resp { get; set; }
        public ContactInfo contact_info { get; set; }
        //public List<GroupData> groups { get; set; }
    }
}