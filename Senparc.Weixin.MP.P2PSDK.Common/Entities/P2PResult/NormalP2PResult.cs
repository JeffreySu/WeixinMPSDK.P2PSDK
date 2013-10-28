using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// 普通P2P返回类型
    /// </summary>
    public class NormalP2PResult : P2PResult<NormalP2PData>
    {
    }

    public class NormalP2PData : IP2PResultData
    {
        public object Object { get; set; }
    }
}
