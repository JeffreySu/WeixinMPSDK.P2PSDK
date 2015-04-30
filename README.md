WeixinMPSDK.P2PSDK
==================

WeixinMPSDK.P2PSDK 及测试工具源代码

对接“微微嗨”平台地址：http://www.weiweihi.com

开发手册：http://www.weiweihi.com/ApiDocuments

--------------

Senparc.Weixin.MP.dll 开源项目地址：https://github.com/JeffreySu/WeiXinMPSDK


文件夹说明
===================
> Senparc.Weixin.MP.P2PSDK： Senparc.Weixin.MP.P2PSDK.dll 核心库项目

> Senparc.Weixin.MP.P2PSDK.BuildOutPut： 所有dll及测试工具的编译输出文件夹

> Senparc.Weixin.MP.P2PSDK.Common： Senparc.Weixin.MP.P2PSDK.Common.dll 公用类库

> Senparc.Weixin.MP.P2PSDK.TestTools： 测试工具项目（Senparc.Weixin.MP.P2PSDK.TestTools.exe）

--------------------

Windows客户端测试工具位置：/Senparc.Weixin.MP.P2PSDK.BuildOutPut/Senparc.Weixin.MP.P2PSDK.TestTools.exe

使用Nuget安装到项目中
--------------
地址：https://www.nuget.org/packages/Senparc.Weixin.MP.P2P

命令：
```
PM> Install-Package Senparc.Weixin.MP.P2P
```


功能介绍
=====================

用于微信公众账号获取用户详细信息及头像、获取媒体文、绑定OpenId-Fakeid、自动推动消息等。

P2P严正声明：我们致力于提供更加优秀的用户实时互动体验，反对使用P2P进行群发骚扰用户。


关注P2P测试微信公众账号（Souidea是一个全面测试Senparc.Weixin.MP和Senparc.Weixin.MP.P2P的机器人）：
[![image]](http://weixin.senparc.com/)  
[image]: http://weixin.senparc.com/Images/qrcode_for_souidea.jpg



#功能：

自动模拟登陆微信公众账号后台 OK

自动收集用户信息及fakeid OK

自动收集用户对话消息 OK

用户数据自动录入数据库 OK

保持登录状态 OK

给指定用户发送消息（或群发） OK

自动更新用户数据 OK

登陆超时后自动重新登陆 OK

建立P2PManager，快速注册到程序进程 OK

建立P2PThread，P2P专有线程 OK


建立用于P2PThread的异步侦探OpenId和Fakeid映射关系的方法 OK

自动侦探OpenId和Fakeid映射关系，并允许添加事件，让用户处理侦探之后的结果（如录入自己的数据库） OK

上传图片 OK

发送图文信息 OK

下载语音文件 OK

获取用户图片 OK

返回消息发送时的验证码图片 OK


获取视频等更多媒体文件


你还能想到什么？
