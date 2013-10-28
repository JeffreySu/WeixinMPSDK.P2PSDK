using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common
{
    public interface IP2PResult<T> where T : IP2PResultData
    {
        P2PResultKind Result { get; set; }
        string ErrorMessage { get; set; }
        T Data { get; set; }
        long RunTime { get; set; }
    }

    public interface IP2PResultData
    {
    }

    public class P2PResultData : IP2PResultData
    {

    }

    /// <summary>
    /// JSON返回结果（用于菜单接口等）
    /// </summary>
    public class P2PResult<T> : IP2PResult<T> where T : IP2PResultData
    {
        public P2PResultKind Result { get; set; }
        /// <summary>
        /// 如果结果未成功，则Data为期望的类型
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 错误信息，如果结果为成功，错误信息为Null
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Api执行时间
        /// </summary>
        public long RunTime { get; set; }
        //public T SData
        //{
        //    get { return Data as T; }
        //}
    }
}
