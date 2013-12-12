using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK
{
    using Senparc.Weixin.MP.P2PSDK.Common;

    public class ApiConnection
    {
        private Passport _passport;
        public ApiConnection(Passport passport)
        {
            if (passport == null)
            {
                throw new WeixinException("Passport不可以为NULL！");
            }
            _passport = passport;
        }

        /// <summary>
        /// 自动更新Passport的链接方法
        /// </summary>
        /// <param name="apiFunc"></param>
        /// <returns></returns>
        public IP2PResult<T> Connection<T>(Func<IP2PResult<T>> apiFunc) where T : IP2PResultData
        {
            var result = apiFunc();
            if (result.Result == P2PResultKind.账户验证失败)
            {
                //更新Passport
                SdkManager.ApplyPassport(_passport.AppKey, _passport.Secret, _passport.P2PUrl);
                result = apiFunc();
            }
            return result;
        }
    }
}
