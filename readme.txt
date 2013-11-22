1、到网站注册，并申请微信APP：
网站内测入口：http://www.souidea.com
后台微信APP管理页面（注册、登陆后打开）：http://www.souidea.com/User/WeixinApp

2、申请成功后，进入微信App编辑页面，可以看到AppKey及Secret

3、打开Senparc.Weixin.MP.P2PSDK.BuildOutPut\Senparc.Weixin.MP.P2PSDK.TestTools.exe，填入AppKey及Secret，点击唯一的按钮，成功之后，点击【链接】，若连接成功，可以发送消息测试。

4、App申请成功后（拿到源代码后），请按照要求绑定一下P2PBridge.ashx（建议复制到网站根目录，并上传3个关键dll到bin文件夹下），P2PBridge.ashx用于接收fakeid-openid关系等绑定推送信息。



说明：源代码中的Senparc.Weixin.MP.dll，就是开源SDK的dll：https://github.com/JeffreySu/WeiXinMPSDK，尽量保证最新的，可以通过文件属性的版本号对比。
如果源代码有更新，大家可以用最新的Senparc.Weixin.MP.dll替换，我会尽量保证向下兼容。不放心的话可以放到一起编译一下：）

API地址：http://api.souidea.com:8282


注意：
从2013年11月20日起，微信后台不再显示用户名，因此无法得到用户名去用“预览”的形式发送图文信息。您可以先使用固定的用户名（如自己的），发送成功后，用得到的AppMsgId，推送到对方的fakeid(s)，而不是username(s)。

自2013年11月22日起，24小时内没有回复消息的用户无法主动推送信息。

如果大家发现任何问题，欢迎及时向我反馈。

感谢！


苏震巍