using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// 获取语音结果
    /// </summary>
    public class GetVoiceResult : P2PResult<NormalP2PData>
    {
        public string VoiceStream { get; set; }
    }

    //public class GetVoiceData
    //{

    //}
}
