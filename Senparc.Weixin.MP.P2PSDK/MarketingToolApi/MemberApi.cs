using System.Collections.Generic;
using Senparc.Weixin.MP.P2PSDK.Common;
using Senparc.Weixin.MP.P2PSDK.Common.Entities;

namespace Senparc.Weixin.MP.P2PSDK.MarketingToolApi
{
    public class MemberApi : BaseApi
    {
        public MemberApi(Passport passport)
            : base(passport)
        {
        }

        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <param name="openId"></param>
        /// <returns></returns>
        public MemberInfoResult GetMemberInfo(string openId)
        {
            var url = _passport.MarketToolUrl + "GetMemberInfo";
            var formData = new Dictionary<string, string>();
            formData["token"] = _passport.Token;
            formData["openId"] = openId;
            var result = HttpUtility.Post.PostGetJson<MemberInfoResult>(url, formData: formData);
            return result;
        }

        /// <summary>
        /// 修改会员积分
        /// </summary>
        /// <param name="openId"></param>
        /// <param name="points"></param>
        /// <returns>最新会员信息，包括积分</returns>
        public MemberInfoResult ChangeMemberPoint(string openId,int points)
        {
            var url = _passport.MarketToolUrl + "ChangeMemberPoint";
            var formData = new Dictionary<string, string>();
            formData["token"] = _passport.Token;
            formData["openId"] = openId;
            formData["points"] = points.ToString();
            var result = HttpUtility.Post.PostGetJson<MemberInfoResult>(url, formData: formData);
            return result;
        }
    }
}
