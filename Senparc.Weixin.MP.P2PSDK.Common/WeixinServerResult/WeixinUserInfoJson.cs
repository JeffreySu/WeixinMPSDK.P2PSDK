using System.ComponentModel;

namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// 通过Ajax获取的用户信息（JSON格式）
    /// </summary>
    public class WeixinUserInfoJson : IP2PResultData
    {
        /// <summary>
        /// 次Id为数据库主键，非微信信息
        /// </summary>
        public int Id { get; set; }
        public long? FakeId { get; set; }
        public string NickName { get; set; }
        public string ReMarkName { get; set; }
        public string Username { get; set; }
        public string Signature { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        /// <summary>
        /// 男：1，女：2
        /// </summary>
        public string Sex { get; set; }
        public string GroupID { get; set; }
    }
}