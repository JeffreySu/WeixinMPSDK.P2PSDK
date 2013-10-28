using System.Collections.Generic;
namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// 发送消息结果
    /// </summary>
    public class GetFriendsDetailsResult : P2PResult<FriendsDetailsData>
    {

    }

    /// <summary>
    /// 用户数据
    /// </summary>
    public class FriendsDetailsData : P2PResultData,IP2PResultData
    {
        /// <summary>
        /// 用户信息列表
        /// </summary>
        public List<WeixinUserInfoJson> WeixinUserInfoList { get; set; }
    }
}
