namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// 输出在页面中的用户Json信息
    /// </summary>
    public class FriendsJsonData : IP2PResultData
    {
        public string id { get; set; }
        public string nick_name { get; set; }
        public string remark_name { get; set; }
        public string group_id { get; set; }
    }
}
