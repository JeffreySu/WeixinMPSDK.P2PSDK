using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.TestTools
{
    public static class P2PSDKer
    {
        /// <summary>
        /// 如果有多个P2P微信应用，可以使用类似方法新建固定访问。
        /// 比如这里，只需要调用P2PSDKer.FormP2P
        /// </summary>
        public static ApiContainer FormP2P
        {
            get { return SdkManager.GetApiContainer("Your AppKey","Your AppSecret"); }
        }
    }
}
