using System.Collections.Generic;
namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// 发送消息结果
    /// </summary>
    public class GetFriendsResult : P2PResult<FriendsResultData>
    {

    }

    /// <summary>
    /// 用户数据
    /// </summary>
    public class FriendsResultData : P2PResultData,IP2PResultData
    {
        /// <summary>
        /// 用户信息列表
        /// </summary>
        public List<FriendsJsonData> FriendsJsonDataList { get; set; }
    }
}
