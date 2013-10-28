using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common.Bridge
{
    /// <summary>
    /// P2P Bridge推送类型
    /// </summary>
    public enum BridgeType
    {
        Check,//检查P2PBridge
        FakeidBind,//绑定fakeid,openid
        FakeidBindUnFound,//未找到Fakeid绑定
        MediaDownload,//媒体文件下载
        MediaDownloadFailed,//媒体文件下载失败
        ParseFail//转换失败
    }
}
