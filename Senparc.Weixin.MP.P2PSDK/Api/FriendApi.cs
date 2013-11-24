using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senparc.Weixin.MP.P2PSDK.Common;

namespace Senparc.Weixin.MP.P2PSDK
{
    public class FriendApi : BaseApi
    {

        public FriendApi(Passport passport)
            : base(passport)
        {
        }

        private GetGroupsResult GetGroupIdsFunc()
        {
            var url = _passport.Url + "GetGroupIds";
            var formData = new Dictionary<string, string>();
            formData["token"] = _passport.Token;
            var result = HttpUtility.Post.PostGetJson<GetGroupsResult>(url, formData: formData);
            return result;
        }


        private GetFriendsResult GetGroupFriendsFunc(string groupId, int pageSize, int pageIndex)
        {
            if (string.IsNullOrEmpty(groupId))
            {
                throw new WeixinException("必须指定一个存在的GroupId！", null);
            }

            var url = _passport.Url + "GetGroupFriends";
            var formData = new Dictionary<string, string>();
            formData["token"] = _passport.Token;
            formData["groupId"] = groupId;
            formData["pageSize"] = pageSize.ToString();
            formData["pageIndex"] = pageIndex.ToString();
            var result = HttpUtility.Post.PostGetJson<GetFriendsResult>(url, formData: formData);
            return result;
        }

        private GetFriendsResult GetFriendsFunc(string groupId, int maxCount)
        {
            var url = _passport.Url + "GetFriends";
            var formData = new Dictionary<string, string>();
            formData["token"] = _passport.Token;
            formData["groupId"] = groupId;
            formData["maxCount"] = maxCount.ToString();
            var result = HttpUtility.Post.PostGetJson<GetFriendsResult>(url, formData: formData);
            return result;
        }

        private GetFriendsDetailsResult GetFriendsDetailsFunc(long[] fakeids)
        {
            var url = _passport.Url + "GetFriendsDetails";
            var formData = new Dictionary<string, string>();
            formData["token"] = _passport.Token;
            for (int i = 0; i < fakeids.Length; i++)
            {
                var key = string.Format("fakeids[{0}]", i);
                formData[key] = fakeids[i].ToString();
            }
            var result = HttpUtility.Post.PostGetJson<GetFriendsDetailsResult>(url, formData: formData);
            return result;
        }

        private GetFriendHeadImageResult GetFriendHeadImageFunc(string fakeid)
        {
            var url = _passport.Url + "GetFriendHeadImage";
            var formData = new Dictionary<string, string>();
            formData["token"] = _passport.Token;
            formData["fakeid"] = fakeid;
            var result = HttpUtility.Post.PostGetJson<GetFriendHeadImageResult>(url, formData: formData);
            return result;
        }

        private NormalP2PResult BindFakeidOpenidFunc(string openid, string keyword, string p2pBridgeUrl = null)
        {
            var url = _passport.Url + "BindFakeidOpenid";
            var formData = new Dictionary<string, string>();
            formData["token"] = _passport.Token;
            formData["openid"] = HttpUtility.RequestUtility.UrlEncode(openid);
            formData["keyword"] = HttpUtility.RequestUtility.UrlEncode(keyword);
            if (!string.IsNullOrEmpty(p2pBridgeUrl))
            {
                formData["p2pBridgeUrl"] = HttpUtility.RequestUtility.UrlEncode(p2pBridgeUrl);
            }
            var result = HttpUtility.Post.PostGetJson<NormalP2PResult>(url, formData: formData);
            return result;
        }

        /// <summary>
        /// 获取所有分组ID
        /// </summary>
        /// <returns></returns>
        public GetGroupsResult GetGroupIds()
        {
            return ApiConnection.Connection(GetGroupIdsFunc) as GetGroupsResult;
        }

        /// <summary>
        /// 获取某一分组下的用户信息，支持分页
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="pageSize">最大500，建议值：50～100</param>
        /// <param name="pageIndex">0为第1页</param>
        /// <returns></returns>
        public GetFriendsResult GetGroupFriends(string groupId, int pageSize, int pageIndex)
        {
            return ApiConnection.Connection(() => GetGroupFriendsFunc(groupId, pageSize, pageIndex)) as GetFriendsResult;
        }

        /// <summary>
        /// 获取分组中的用户信息
        /// </summary>
        /// <param name="groupId">对应组的Id，当Id为null时，从“未分组”依次向下搜索，直到获取到maxCount数量的信息</param>
        /// <param name="maxCount"></param>
        /// <returns></returns>
        public GetFriendsResult GetFriends(string groupId, int maxCount)
        {
            return ApiConnection.Connection(() => GetFriendsFunc(groupId, maxCount)) as GetFriendsResult;
        }

        /// <summary>
        /// 获取一批fakeid对应的详细信息
        /// </summary>
        /// <param name="fakeids"></param>
        /// <returns></returns>
        public GetFriendsDetailsResult GetFriendsDetails(long[] fakeids)
        {
            return ApiConnection.Connection(() => GetFriendsDetailsFunc(fakeids)) as GetFriendsDetailsResult;
        }

        /// <summary>
        /// 获取一批fakeid对应的详细信息
        /// </summary>
        /// <param name="fakeid"></param>
        /// <returns></returns>
        public GetFriendHeadImageResult GetFriendHeadImage(long fakeid)
        {
            return ApiConnection.Connection(() => GetFriendHeadImageFunc(fakeid.ToString())) as GetFriendHeadImageResult;
        }

        /// <summary>
        /// 请求Fakeid-Openid匹配
        /// </summary>
        /// <param name="openid"></param>
        /// <param name="keyword"></param>
        /// <param name="p2pBridgeUrl">如果为空，则使用www.souidea.com后台设置的P2PUrl，无论使用哪一个，都共用后台的P2PBridge Token，所以后台必须有一个可用的Url验证通过</param>
        /// <returns></returns>
        public NormalP2PResult BindFakeidOpenid(string openid, string keyword, string p2pBridgeUrl = null)
        {
            return ApiConnection.Connection(() => BindFakeidOpenidFunc(openid, keyword, p2pBridgeUrl)) as NormalP2PResult;
        }
    }
}
