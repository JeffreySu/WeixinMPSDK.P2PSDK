using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// 分组信息
    /// </summary>
    public class GroupData : IP2PResultData
    {
        /// <summary>
        /// 分组编号
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 分组名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 组内总人数
        /// </summary>
        public int cnt { get; set; }
    }
}
