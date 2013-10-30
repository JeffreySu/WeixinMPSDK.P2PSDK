using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common.WeixinServerResult
{
    /// <summary>
    /// 用户详细信息
    /// </summary>
    public class ContactInfo
    {
        /// <summary>
        /// 此Id为数据库主键，非微信信息
        /// </summary>
        public int Id { get; set; }
        public long? fake_id { get; set; }
        public string nick_name { get; set; }
        public string user_name { get; set; }
        public string signature { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        /// <summary>
        /// 性别。男：1，女：2
        /// </summary>
        public string gender { get; set; }
        public string remark_name { get; set; }
        public int group_id { get; set; }

        //"fake_id":13221445,"nick_name":"苏震巍",
        //"user_name":"JeffreySu","signature":"",
        //"city":"苏州","province":"江苏","country":"中国",
        //"gender":1,"remark_name":"","group_id":0
    }
}
