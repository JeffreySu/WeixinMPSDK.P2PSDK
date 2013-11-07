using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// 发送单条消息结果
    /// </summary>
    public class SendMessageResult : P2PResult<PostMessageResult>
    {
        /// <summary>
        /// 验证码（如果不需要提供验证码则为null）
        /// </summary>
        public string VerifyCode { get; set; }
    }

    /// <summary>
    /// 发送图文消息结果
    /// </summary>
    public class SendMessageNewsResult : P2PResult<SendMessageNewsData>
    {
    }
    /// <summary>
    /// 发送图文消息数据类型
    /// </summary>
    public class SendMessageNewsData : /*List<PostMessageResult>,*/ IP2PResultData
    {
        public List<PostMessageResult> PostMessageResults { get; set; }

        public SendMessageNewsData()
        {
            PostMessageResults = new List<PostMessageResult>();
        }
    }
}
