using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK
{
    using Senparc.Weixin.MP;
    using Senparc.Weixin.MP.Entities;
    using Senparc.Weixin.MP.P2PSDK.Common;

    public class MessageApi : BaseApi
    {

        public MessageApi(Passport passport)
            : base(passport)
        {
        }

        private SendMessageResult SendMessageFunc(long fakeid, string text = null, long? appMsgId = null, string imgcode = null)
        {
            var url = _passport.P2PUrl + "SendMessage";
            var formData = new Dictionary<string, string>();
            formData["token"] = _passport.Token;
            formData["fakeid"] = fakeid.ToString();
            if (appMsgId.HasValue)
            {
                formData["appMsgId"] = appMsgId.ToString();
            }
            else
            {
                formData["text"] = text;// System.Web.HttpUtility.UrlEncode(text);
            }
            if (!string.IsNullOrEmpty(imgcode))
            {
                formData["imgcode"] = imgcode;// 输入验证码
            }

            var result = HttpUtility.Post.PostGetJson<SendMessageResult>(url, formData: formData);
            return result;
        }

        private SendMessageNewsResult SendMessageFunc(List<string> usernames, List<Article> articles)
        {
            var url = _passport.P2PUrl + "SendMessageNews";
            var formData = new Dictionary<string, string>();
            formData["token"] = _passport.Token;
            for (int i = 0; i < usernames.Count; i++)
            {
                var key = string.Format("userNames[{0}]", i);
                formData[key] = usernames[i];
            }

            for (int i = 0; i < articles.Count; i++)
            {
                var article = articles[i];
                var key = string.Format("articles[{0}]", i);
                formData[key + ".Title"] = article.Title;
                formData[key + ".Description"] = article.Description;
                formData[key + ".PicUrl"] = article.PicUrl;
                formData[key + ".Url"] = article.Url;
            }

            var result = HttpUtility.Post.PostGetJson<SendMessageNewsResult>(url, formData: formData);
            return result;
        }

        /// <summary>
        /// 发送简单消息
        /// </summary>
        /// <param name="fakeid"></param>
        /// <param name="text"></param>
        /// <param name="imgcode"></param>
        /// <returns></returns>
        public SendMessageResult SendMessage(long fakeid, string text, string imgcode = null)
        {
            return ApiConnection.Connection(() => SendMessageFunc(fakeid, text, imgcode: imgcode)) as SendMessageResult;
        }

        /// <summary>
        /// 发送已经存在appMsgId的图文信息
        /// </summary>
        /// <param name="fakeid"></param>
        /// <param name="appMsgId"></param>
        /// <param name="imgcode"></param>
        /// <returns></returns>
        public SendMessageResult SendMessage(long fakeid, long appMsgId, string imgcode = null)
        {
            return ApiConnection.Connection(() => SendMessageFunc(fakeid, appMsgId: appMsgId, imgcode: imgcode)) as SendMessageResult;
        }

        /// <summary>
        /// 发送图文消息
        /// </summary>
        /// <param name="usernames"></param>
        /// <param name="articles"></param>
        /// <returns></returns>
        public SendMessageNewsResult SendMessage(List<string> usernames, List<Article> articles)
        {
            return ApiConnection.Connection(() => SendMessageFunc(usernames, articles)) as SendMessageNewsResult;
        }
    }
}
