using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common.Entities
{
    public class MemberInfoResult : P2PResult<MemberInfoResultData>
    {
    }

    public class MemberInfoResultData : IP2PResultData
    {
        /// <summary>
        /// 会员卡号
        /// </summary>
        public string CardNumber { get; set; }
        public string OpenId { get; set; }
        public long FakeId { get; set; }
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 当前积分
        /// </summary>
        public int Points { get; set; }

        public string RealName { get; set; }
        public string Phone { get; set; }
    }
}
