<%@ WebHandler Language="C#" Class="Senparc.Web.P2PBridge" %>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace Senparc.Web
{
    using Senparc.Weixin.MP;
    using Senparc.Weixin.MP.P2PSDK;
    using Senparc.Weixin.MP.P2PSDK.Common;
    using Senparc.Weixin.MP.P2PSDK.Common.Bridge;
    using Senparc.Weixin.MP.P2PSDK.Common.Utility;

    /// <summary>
    /// .NET 4.0以上已包含TryParse方法，可以将此类注释掉
    /// </summary>
    public static class Enum
    {
        public static bool TryParse(string value, bool ignoreCase, out BridgeType result)
        {
            try
            {
                result = (BridgeType)System.Enum.Parse(typeof(BridgeType), value, ignoreCase);
                return true;
            }
            catch
            {
                result = BridgeType.ParseFail;
                return false;
            }
        }
    }

    /// <summary>
    /// P2PBridge 的摘要说明
    /// </summary>
    public class P2PBridge : IHttpHandler
    {
        private const string Token = "Weixin";//这是Souidea后台微信App的Token，和微信公众账号后台无关。

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            var method = context.Request.HttpMethod.ToUpper();
            var type = BridgeType.Check;
            string signature = context.Request.QueryString["signature"];
            string timestamp = context.Request.QueryString["timestamp"];
            string nonce = context.Request.QueryString["nonce"];
            string echostr = context.Request.QueryString["echostr"];

            var pass = CheckSignature.Check(signature, timestamp, nonce, Token);

            if (!pass || !Enum.TryParse(context.Request.QueryString["type"] ?? "", true, out type))
            {
                context.Response.Write("无效参数。");
                if (method == "GET")
                {
                    context.Response.Write("看到这条信息，表明此Url可以在后台设置使用。");
                }

                context.Response.End();
            }
            else if (method == "GET")
            {
                context.Response.Write(echostr);//返回确认参数
                context.Response.End();
            }

            var callbackResultKind = P2PResultKind.成功;//返回给P2P服务器的结果

            switch (type)
            {
                //case BridgeType.Check:
                //    break;
                case BridgeType.FakeidBind://成功找到Fakeid-Openid绑定关系
                    {
                        //接收到绑定信息
                        var fakeid = context.Request.Form["fakeid"];
                        var openid = context.Request.Form["openid"];
                        var keyword = context.Request.Form["keyword"];

                        //TODO：这里根据自己的业务逻辑储存对应关系。
                    }
                    break;
                case BridgeType.FakeidBindUnFound://未找到Fakeid-Openid绑定关系
                    {
                        //接收到绑定信息
                        var openid = context.Request.Form["openid"];
                        var keyword = context.Request.Form["keyword"];

                        //TODO：这里根据自己的业务逻辑储存对应关系。
                    }
                    break;
                case BridgeType.MediaDownload://媒体文件下载
                    {
                        var argument = context.Request.Form["argument"];
                        var fakeid = context.Request.Form["fakeid"];
                        var voiceStream = context.Request["VoiceStream"];
                        var videoStream = context.Request["VideoStream"];
                        if (voiceStream != null)
                        {
                            //获取到音频文件
                            //反序列化并保存文件

                            //文件路径根据实际情况调整，必须是完整物理路径。如果文件路径为null，则不保存文件。
                            var filePath = HttpContext.Current.Server.MapPath("~/" + DateTime.Now.Ticks + ".mp3");
                            using (var ms = StreamUtility.GetStreamFromBase64String(voiceStream, filePath))
                            {
                                //TODO:这里可以对ms对象做一些操作，也可以直接释放，如果不使用using,建议及时进行ms.Close();
                            }
                        }
                        else if (videoStream != null)
                        {
                            //获取到视频文件（即将上线）
                        }
                    }
                    break;
                case BridgeType.MediaDownloadFailed://媒体文件下载失败
                    {
                        var argument = context.Request.Form["argument"];
                        var fakeid = context.Request.Form["fakeid"];

                        //TODO:这里可以将失败结果写入日志
                    }
                    break;
                case BridgeType.ParseFail://转换失败
                default:
                    callbackResultKind = P2PResultKind.执行过程发生异常;
                    break;
            }

            //完成自定义操作后必须返回如下Json结果：
            var jsonResult = GetCallbackResult(echostr, callbackResultKind);
            context.Response.Write(jsonResult);
        }

        /// <summary>
        /// 返回结果
        /// </summary>
        /// <returns></returns>
        private string GetCallbackResult(string echostr, P2PResultKind resultKind)
        {
            var result = new P2PBridgeCallbackResult(echostr);
            result.Result = resultKind;
            var js = new JavaScriptSerializer();
            return js.Serialize(result);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}