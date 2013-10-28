namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// 发送消息结果
    /// </summary>
    public class PostMessageResult : IP2PResultData
    {
        public int ret { get; set; }
        public string msg { get; set; }
        //以下两个属性在发送预览信息时会出现
        public string appMsgId { get; set; }
        public string fakeid { get; set; }
    }
}
