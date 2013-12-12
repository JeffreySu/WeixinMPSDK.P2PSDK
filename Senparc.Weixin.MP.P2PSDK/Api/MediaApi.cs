using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK
{
    using Senparc.Weixin.MP;
    using Senparc.Weixin.MP.Entities;
    using Senparc.Weixin.MP.P2PSDK.Common;

    public class MediaApi : BaseApi
    {
        public MediaApi(Passport passport)
            : base(passport)
        {
        }

        private GetVoiceResult GetVoiceFunc(long? fakeid, string argument)
        {
            var url = _passport.P2PUrl + "GetVoice";
            var formData = new Dictionary<string, string>();
            formData["token"] = _passport.Token;
            formData["fakeid"] = fakeid == null ? "" : fakeid.Value.ToString();
            formData["argument"] = argument;
            var result = HttpUtility.Post.PostGetJson<GetVoiceResult>(url, formData: formData);
            return result;
        }

        /// <summary>
        /// 获取语音文件（测试阶段限5秒以下）
        /// </summary>
        /// <param name="fakeid">指定用户fakeid。如果不为空，则获取该用户最新一个语音；
        /// 如果为空，获取全局任意人的第一个语音（限前50条消息中）</param>
        /// <param name="argument">用于推送到P2PBridge的识别参数，可以为ID等参数，不可为空</param>
        /// <returns></returns>
        public GetVoiceResult GetVoice(long? fakeid, string argument)
        {
            return ApiConnection.Connection(() => GetVoiceFunc(fakeid, argument)) as GetVoiceResult;
        }
    }
}
