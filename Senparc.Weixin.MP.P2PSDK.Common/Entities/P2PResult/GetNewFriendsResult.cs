using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common
{
    public class GetNewFriendsResult : P2PResult<NewFriendsResultData>
    {
    }

    /// <summary>
    /// 用户数据
    /// </summary>
    public class NewFriendsResultData : IP2PResultData
    {
        /// <summary>
        /// 还有更多未载入信息
        /// </summary>
        public bool HasMoreInfo { get; set; }
        /// <summary>
        /// 用户信息列表
        /// </summary>
        public List<FriendsJsonData> FriendsJsonDataList { get; set; }
    }
}
