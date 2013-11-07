using Senparc.Weixin.MP.P2PSDK.Common.WeixinServerResult;

namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// 发送消息结果
    /// </summary>
    public class PostMessageResult : IP2PResultData
    {
        public BaseResp base_resp { get; set; }

        //如果是单条推送，以下两个属性自2013-11-07起不在json中出现，放入base_resp中。
        public int ret
        {
            get
            {
                return base_resp.ret;
            }
            set
            {
                base_resp.ret = value;
            }
        }
        public string msg
        {
            get
            {
                return base_resp.err_msg;
            }
            set
            {
                base_resp.err_msg = value;
            }
        }

        //以下两个属性只在发送预览信息时出现
        public string appMsgId { get; set; }
        public string fakeid { get; set; }

        public PostMessageResult()
        {
            base_resp = new BaseResp();
        }
    }
}
