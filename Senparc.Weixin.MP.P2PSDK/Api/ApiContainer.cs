using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senparc.Weixin.MP.P2PSDK.Common;

namespace Senparc.Weixin.MP.P2PSDK
{
    /// <summary>
    /// API操作容器（每次构造都会获取当前缓存中最新的Passport）
    /// </summary>
    public class ApiContainer
    {
        public Passport Passport { get; set; }

        public FriendApi FriendApi { get; set; }
        public MessageApi MessageApi { get; set; }
        public MediaApi MediaApi { get; set; }
        /// <summary>
        /// 属于“营销工具”接口
        /// </summary>
        public MarketingToolApi.MemberApi MemberApi { get; set; }

        public ApiContainer(string appKey, string appSecret, string url = SdkManager.DEFAULT_URL)
        {
            var passportBag = SdkManager.GetPassportBag(appKey);
            if (passportBag == null || passportBag.Passport == null)
            {
                SdkManager.ApplyPassport(appKey, appSecret, url);
            }

            Passport = SdkManager.GetPassportBag(appKey).Passport;//执行SdkManager.ApplyPassport后，PassportCollection[appKey]必定存在

            FriendApi = new FriendApi(Passport);
            MessageApi = new MessageApi(Passport);
            MediaApi = new MediaApi(Passport);
            MemberApi = new MarketingToolApi.MemberApi(Passport);
        }
    }
}
