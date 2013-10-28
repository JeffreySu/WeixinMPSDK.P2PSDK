using System.Collections.Generic;
namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// 发送消息结果
    /// </summary>
    public class GetFriendHeadImageResult : P2PResult<FriendHeadImageData>
    {

    }

    /// <summary>
    /// 用户数据
    /// </summary>
    public class FriendHeadImageData : P2PResultData, IP2PResultData
    {
        /// <summary>
        /// 储存头像信息Base64编码
        /// </summary>
        public string HeadImageBase64 { get; set; }
    }
}
