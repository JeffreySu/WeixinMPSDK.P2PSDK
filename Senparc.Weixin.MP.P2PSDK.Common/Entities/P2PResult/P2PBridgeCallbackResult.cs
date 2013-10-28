using System.Collections.Generic;
namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// 发送消息结果
    /// </summary>
    public class P2PBridgeCallbackResult : P2PResult<P2PBridgeCallbackData>
    {
        public P2PBridgeCallbackResult()
        {
            //IP2PResult必须带有无参数构造函数
        }

        public P2PBridgeCallbackResult(string message)
        {
            base.Data = new P2PBridgeCallbackData(message);
        }
    }

    /// <summary>
    /// 用户数据
    /// </summary>
    public class P2PBridgeCallbackData : P2PResultData, IP2PResultData
    {
        /// <summary>
        /// 储存头像信息Base64编码
        /// </summary>
        public string Message { get; set; }

        public P2PBridgeCallbackData()
        {
            //IP2PResultData必须带有无参数构造函数
        }

        public P2PBridgeCallbackData(string message)
        {
            Message = message;
        }
    }
}
