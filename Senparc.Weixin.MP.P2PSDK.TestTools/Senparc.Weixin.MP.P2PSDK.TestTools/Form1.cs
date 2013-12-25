using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Senparc.Weixin.MP.Entities;
using Senparc.Weixin.MP.Helpers;
using Senparc.Weixin.MP.HttpUtility;
using Senparc.Weixin.MP.P2PSDK.Common;
using Image = Senparc.Weixin.MP.Entities.Image;

namespace Senparc.Weixin.MP.P2PSDK.TestTools
{
    using Senparc.Weixin.MP.P2PSDK;

    public partial class Form1 : Form
    {
        private bool initSuccessed = false;

        private bool isLocalTest = false;//切换本地测试或远程测试

        //private List<FriendsJsonData> friendsJsonDatas = null;

        public ApiContainer GetApiContainer
        {
            get
            {
                /*
                 * 这里因为appKey不确定，所以封装一下。
                 * 
                 * 由于应用中AppKey是固定的，可以使用固定属性命名的方式，
                 * 具体请看类P2PSDKer.cs中P2PSDKer.FormP2P方法，
                 * 这样可以直接在类中调用类似P2PSDKer.FormP2P.MessageApi.xxx
                 */
                var apiConainer = SdkManager.GetApiContainer(txtAppKey.Text, txtSecret.Text);//获取ApiContainer

                lblToken.Text = apiConainer.Passport.Token;//窗体上显示当前Passport的Token
                return apiConainer;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            isLocalTest = !isLocalTest;
            if (isLocalTest)
            {
                //根据自己的需要设置默认值
                txtUrl.Text = "http://localhost:12222";
                txtAppKey.Text = "93aeb8fe5e43401e8581eb3ee249df5e";
                txtSecret.Text = "58ed67dc82214a36ae10a712156f1408";
            }
            else
            {
                txtUrl.Text = "http://api.souidea.com:8282";
                txtAppKey.Text = "49979621130a4eb38e7378d5fd98ebdc";
                txtSecret.Text = "1e1ca3d3b5d14a2dbc6cea02ac2135a2";
            }
        }

        private void CheckGroupBoxVisible()
        {
            var visible = initSuccessed;
            tab.Visible = visible;
            gbFriends.Visible = visible;
            btnTestWrongApi.Visible = visible;
            lblAppKeyNotice.Visible = visible;
        }

        private void BindCbFriendsList(List<FriendsJsonData> data)
        {
            cbFriendsList.DataSource = null;
            cbFriendsList.DisplayMember = "nick_name";
            cbFriendsList.ValueMember = "id";
            cbFriendsList.DataSource = data;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //原先这里的SdkManager.Register方法已经废弃

                lblToken.Text = "载入中...";

                /*
                 * 注意：每次执行SdkManager.ApplyPassport都会重新获取Passport。
                 * 
                 * 实际过程中直接调用SDK中的静态API方法即可（如MessageApi.SendMessage()），
                 * Passport会在SDK请求过程中自动获取，如遇超时，会自动重试，不需要人工介入。
                 * 
                 * 当然，为了提高通讯的流畅性，也可以在程序开始运行的时候先执行一次此方法，如放在可以放在Application_Start中。
                 * 
                 * 这里调用SdkManager.ApplyPassport()方法只是作为演示，反应通行证获取情况。
                 */
                SdkManager.ApplyPassport(txtAppKey.Text, txtSecret.Text, txtUrl.Text);
            }
            catch (Exception ex)
            {
                lblToken.Text = "获取通行证失败：" + ex.Message;
            }

            initSuccessed = GetApiContainer.Passport.Token != null;
            CheckGroupBoxVisible();

            if (initSuccessed && !txtAppKey.Items.Contains(txtAppKey.Text))
            {
                txtAppKey.Items.Add(txtAppKey.Text);
            }
        }

        private void btnSendMessageSend_Click(object sender, EventArgs e)
        {
            /*
             * 说明：MessageApi.SendMessage()方法用于向客户推送信息
             * 注意：频繁推送信息或群发将导致验证码、取消认证、封号等一系列严重的后果，请妥善使用，严禁利用此功能做群发！
             */
            long fakeid = 0;
            if (!long.TryParse(txtSendMessageFakeid.Text, out fakeid))
            {
                MessageBox.Show("Fakeid格式不正确！");
                return;
            }
            if (string.IsNullOrEmpty(txtSendMessageText.Text))
            {
                MessageBox.Show("请输入内容！");
                return;
            }

            var p2pResult = GetApiContainer.MessageApi.SendMessage(fakeid, txtSendMessageText.Text, txtVerifyCode.Text.Length > 0 ? txtVerifyCode.Text : null);
            if (p2pResult.Result == P2PResultKind.成功)
            {
                var postMessageResult = p2pResult.Data;
                MessageBox.Show("发送成功！");
            }
            else
            {
                MessageBox.Show("发送失败！返回结果：" + p2pResult.Result);
            }

            ShowVerifyCode(p2pResult.Result, p2pResult.VerifyCode);
        }

        /// <summary>
        /// 演示验证码
        /// </summary>
        /// <param name="p2pResult"></param>
        private void ShowVerifyCode(P2PResultKind p2PResultKind, string verifyCode)
        {
            if (p2PResultKind == P2PResultKind.发送消息失败_需要验证码)
            {
                //读取验证码
                byte[] imageBytes = Convert.FromBase64String(verifyCode);
                //读入MemoryStream对象
                MemoryStream memoryStream = new MemoryStream(imageBytes, 0, imageBytes.Length);
                memoryStream.Write(imageBytes, 0, imageBytes.Length);
                //转成图片
                var image = System.Drawing.Image.FromStream(memoryStream);
                picVerifyCode.Image = image;
                txtVerifyCode.Visible = true;
                txtVerifyCode.Text = "";
            }
            else
            {
                picVerifyCode.Image = null;
                txtVerifyCode.Visible = false;
                txtVerifyCode.Text = "";
            }
        }

        private void btnGetGroupIds_Click(object sender, EventArgs e)
        {
            /*
             * 说明：FriendApi.GetGroupIds()这个例子用于返回所有的用户组Id
             * “未分组”的groupId为0，通常可以在这个组中取前x位，获取新用户的信息
             */
            var result = GetApiContainer.FriendApi.GetGroupIds();//TODO:下一版本中可能更名为GetGroups

            //TODO:此处可以额外判断结果类型，参考btnSendMessageSend_Click
            var groupDataList = result.Data.GroupDataList;
            cbGroupIds.DataSource = groupDataList;
            cbGroupIds.ValueMember = "id";
            cbGroupIds.DisplayMember = "name";

            var nextVisible = groupDataList.Count > 0;
            btnGetGroupFriends.Visible = nextVisible;
            btnGetGroupFriends.Visible = nextVisible;
            cbFriendsList.Visible = nextVisible;
            btnGetFriendDetails.Visible = nextVisible;
            btnGetAllFriends.Visible = nextVisible;
        }

        private void btnGetGroupFriends_Click(object sender, EventArgs e)
        {
            /*
             * 说明：FriendApi.GetGroupFriends()用于获取指定分组内的用户信息，支持分页搜索。
             * 注意：GroupId必须指定，否则会抛出异常。
             * 
             * 当groupId="0"时，为搜索“未指定”用户组。
             * 
             * 此方法可以用来与数据库已经储存的用户作比对，判断新加入的用户。
             * 由于微信用户按照最近一次加入时间排序，所以一旦发现有重复的人员，可以认为下面所有的人都已经储存过，不必再载入更多。
             */

            var selectedItem = (GroupData)cbGroupIds.SelectedItem;
            var result = GetApiContainer.FriendApi.GetGroupFriends(selectedItem.id.ToString(), 50, 0);//获取第1页，前50个
            //TODO:此处可以额外判断结果类型，参考btnSendMessageSend_Click

            this.BindCbFriendsList(result.Data.FriendsJsonDataList);
        }


        private void btnGetAllFriends_Click(object sender, EventArgs e)
        {
            /*
            * 说明：FriendApi.GetFriendsResult()用于获取指定分组或忽略分组（从“未分组”开始依次获取），直到达到maxCount或全部获取
            * 如果groupId=null，则依次返回从“未指定”开始所有分组内的朋友信息，直到达到maxCount或全部抓取
            * 
            * 注意：为了提高效率，这里返回的是概要信息，可以用fakeid与数据库进行比对，如果数据库中不存在，可以使用
            * FriendApi.GetFriendsDetailsResult(long[] fakeids)方法获取详细数据，并录入数据库。
            * 
            * 当groupId="0"时，为搜索“未指定”用户组。
            * 
            * 此方法和FriendApi.GetGroupFriends()一样，同样可以用于从“未分组”获取新用户信息（groupId设为null或"0"）。
            */

            var result = GetApiContainer.FriendApi.GetFriends(null, 2000);
            //TODO:此处可以额外判断结果类型，参考btnSendMessageSend_Click

            this.BindCbFriendsList(result.Data.FriendsJsonDataList);
        }

        private void cbFriendsList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbFriendsList.SelectedValue == null)
            {
                return;
            }

            txtSendMessageFakeid.Text = cbFriendsList.SelectedValue.ToString();

            //获取用户详细信息，用于获取用户名
            var fakeid = cbFriendsList.SelectedValue.ToString();
            var detailsResult = GetApiContainer.FriendApi.GetFriendsDetails(new[] { long.Parse(cbFriendsList.SelectedValue.ToString()) });
            txtSendMessageUserName.Text = detailsResult.Data.WeixinUserInfoList[0].contact_info.user_name;
            txtFakeidBindFakeid.Text = fakeid;
            txtMediaFakeid.Text = fakeid;
            txtSendNewsMessageFakeid.Text = fakeid;
        }

        private void btnGetFriendDetails_Click(object sender, EventArgs e)
        {
            /*
             * 说明：FriendApi.GetFriendsDetailsResult()用于获取多个（包括一个）fakeid对应的详细信息
             * 为了提高通讯质量，建议每次fakeid在20个以内。
             * 如果返回结果中，FakeId属性为null或""，则说明该用户不存在。
             */

            if (cbFriendsList.SelectedValue == null)
            {
                MessageBox.Show("请选择用户！");
                return;
            }

            var fakeid = long.Parse(cbFriendsList.SelectedValue.ToString());
            var result = GetApiContainer.FriendApi.GetFriendsDetails(new[] { fakeid, 1322144533 /* 测试不存在的fakeid */ });

            //TODO:此处可以额外判断结果类型，参考btnSendMessageSend_Click

            if (result.Data.WeixinUserInfoList.Count > 0)
            {
                var weixinUserInfo = result.Data.WeixinUserInfoList[0];

                var headImageFilename = Path.Combine("HeadImages", fakeid + ".jpg");
                DownloadHeadImage(fakeid, headImageFilename);//下载并保存头像
                var contactInfo = weixinUserInfo.contact_info;
                string msg = string.Format(
@"fake_id：{0}
group_id:{1}
nick_name:{2}
remark_name：{3}
gender：{4}
user_name：{5}
country：{6}
province：{7}
city：{8}
signature：{9}

用户头像已经保存到：{10}
"
, contactInfo.fake_id, contactInfo.group_id, contactInfo.nick_name, contactInfo.remark_name, contactInfo.gender,
contactInfo.user_name, contactInfo.country, contactInfo.province, contactInfo.city, contactInfo.signature,
headImageFilename);

                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("查询出错！");
            }
        }

        private void DownloadHeadImage(long fakeid, string filePath)
        {
            /*
             * 说明：FriendApi.GetFriendHeadImage()用于获取Base64编码的用户头像信息
             * 可以将Base64编码还原到Stream直接使用或保存为文件。
             */
            var result = GetApiContainer.FriendApi.GetFriendHeadImage(fakeid);
            if (result.Result == P2PResultKind.成功)
            {
                byte[] imageBytes = Convert.FromBase64String(result.Data.HeadImageBase64);
                //读入MemoryStream对象
                using (MemoryStream memoryStream = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    memoryStream.Write(imageBytes, 0, imageBytes.Length);
                    //转成图片
                    var image = System.Drawing.Image.FromStream(memoryStream);
                    //保存图片
                    image.Save(filePath, ImageFormat.Jpeg);

                    //显示图片
                    picHeaderImage.Image = image;
                }
            }
            else
            {
                MessageBox.Show("头像获取失败！");
            }
        }

        private void btnSendMessageNews_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSendMessageUserName.Text))
            {
                MessageBox.Show(
                    "请输入用户名！\r\n注意：从2013年11月20日起，微信后台不再显示用户名，因此无法得到用户名去用“预览”的形式发送图文信息。\r\n您可以在这里输入固定的用户名（如自己的），发送成功后，用得到的AppMsgId，推送到对方的fakeid(s)，而不是username(s)。");
                return;
            }

            /*
             * 说明：MessageApi.SendMessage()用于发送图文信息
             * 调用接口时，同一次传入的远程图片，将自动加为素材，并用同一个ID的图片素材发送。
             * Title及Description中的{username}可用于替换用户名。每一则消息都将被存为独立ID的多图文素材。
             */

            //可以同时发给多人，但是不建议同时发送给太多人，以免被判为群发。
            var usernames = new List<string>() { txtSendMessageUserName.Text.UrlEncode() };
            var articles = new List<Article>();
            for (int i = 0; i < 3; i++)
            {
                //模拟输出N条不同内容
                articles.Add(new Article()
                {
                    //如果不确定内容是否会影响Url参数格式，尽量进行UrlEncode
                    Title = ("TO：{username}" + txtSendMessageTitle.Text + string.Format("【{0}】", i)).UrlEncode(),
                    //此处可以加HTML代码，必须UrlEncode
                    Description = ("TO：{username}"
                                   + txtSendMessageDescription.Text
                                   + string.Format("<span style=\"color:red;\">【{0}】</span>", i)).UrlEncode(),
                    //确保文件可以在公网上访问，P2P服务器将会自动下载并上传到维新后台的素材中。如果有后台素材图片的ID，这里可以直接输入ID
                    PicUrl = "http://weixin.senparc.com/Images/qrcode_for_souidea.jpg".UrlEncode(),
                    Url = "http://weixin.senparc.com/".UrlEncode()
                });
            }

            MessageBox.Show("1、AppMsgId为空的情况下，本次测试会发送2条信息，第一条为新信息，发送到username，并生成appMsgId，第二条为通过这个appMsgId推送到fakeid。\r\n2、AppMsgId不为空的情况下，将会直接发送此图文素材（请确保参数正确）！");

            var appMegId = txtNewsAppMsgId.Text;
            var success = true;
            if (string.IsNullOrEmpty(appMegId))
            {
                var result = GetApiContainer.MessageApi.SendMessage(usernames, articles);
                //TODO:此处可以额外判断结果类型，参考btnSendMessageSend_Click

                var firstSendNewMessageResult = result.Data.PostMessageResults[0];//每一个username都会按照次序有一条发送结果。
                success = firstSendNewMessageResult.msg.Contains("success");
                MessageBox.Show("第一条发送结果：" + firstSendNewMessageResult.msg + "\r\n" +
                    (success ? "现在开始发送第二条" : "有错误发生，第二条将停止发送"));

                txtNewsAppMsgId.Text = firstSendNewMessageResult.appMsgId == "0" ? null : firstSendNewMessageResult.appMsgId;
            }

            if (success)
            {
                var sendMessageResult = GetApiContainer.MessageApi.SendMessage(
                    long.Parse(txtSendNewsMessageFakeid.Text), long.Parse(txtNewsAppMsgId.Text));
                MessageBox.Show("第二条发送结果：" + sendMessageResult.Result);
            }
        }

        private void btnFakeIdBind_Click(object sender, EventArgs e)
        {
            /*
             * 说明：FriendApi.BindFakeidOpenid()用于绑定Fakeid和OpenId信息。建议在用户关注，或发送第一条消息时就进行绑定操作。
             * 
             * 由于测试的客户端没有对接公众平台后台Url，所以这里的测试只是模拟一下
             * 实际的使用过程如下：
             * 1、当有用户关注或主动发送消息到公众平台，我们可以得到他的Opend。
             * 2、在回复这条消息（ResponseMessage）的过程中，内容明文包含下面的keyword参数（无论明文或者加在html代码中都可以），
             *     keyword确保短时间内不会有重复即可。
             * 3、在这条消息（ResponseMessage）完成之前，请求FriendApi.BindFakeidOpenid()，系统将自动侦查并计算。
             *     注意！！2和3必须在同一个Request-Response过程中发送（通常1秒以内），以得到更精确的结果！
             * 4、匹配结果
             * 
             * 建议把keyword放到欢迎信息中，在第一时间捕获信息。
             */

            if (string.IsNullOrEmpty(txtFakeidBindFakeid.Text))
            {
                MessageBox.Show("请输入fakeid！");
                return;
            }

            var openId = "JeffreySu";//这里的Openid只能随便假设一个，实际微信请求到达的时候，可以得到真实的OpenId，即RequestMessage.FromUserName
            var keyword = "【" + Guid.NewGuid().ToString("n").Substring(0, 4) + "】";//这里可以随机产生一个序列，保证不会出现重复即可

            /* 进行绑定请求，结果会发送到P2PBridge接口（如P2PBridge.ashx），所以调用之前请确认P2P后台的P2PBridge接口已经成功添加。
             * 
             * 下面的p2pBridgeUrl如果为空，则使用www.souidea.com后台设置的P2PUrl，无论使用哪一个，都共用后台的P2PBridge Token，所以后台必须有一个可用的Url验证通过。
             * 当p2pBridgeUrl为空的时候，也可以不传入，这里仅作为演示。
             */
            string p2pBridgeUrl = null;//如http://xxx.com/OtherBridgeUrl
            var result = GetApiContainer.FriendApi.BindFakeidOpenid(openId, keyword, p2pBridgeUrl);
            if (result.Result != P2PResultKind.成功)
            {
                MessageBox.Show("请求出错：" + result.Result);
                return;
            }


            /*
             * 注意：以下代码用主动推送模拟公众平台服务器自动回复用户消息，
             * 实际过程中fakeid事先是不知道的，只要将keyword放在ResponseMessage内容中正常返回即可。实际应用过程中请忽略以下代码！
             */
            var msg = string.Format("绑定测试。编号：{0}。", keyword);//keyword必须包含在回复内容中，作为P2P多重锁定目标的重要条件之一。
            var msgResult = GetApiContainer.MessageApi.SendMessage(long.Parse(txtFakeidBindFakeid.Text), msg, txtVerifyCode.Text.Length > 0 ? txtVerifyCode.Text : null);
            if (msgResult.Result == P2PResultKind.成功)
            {
                MessageBox.Show("请求发送成功，匹配结果计算出来之后将自动推送到P2PBridge。");
            }
            else
            {
                MessageBox.Show("单条测试信息发送错误：" + msgResult.Result);
            }

            ShowVerifyCode(msgResult.Result, msgResult.VerifyCode);
        }

        private void btnGetVoice_Click(object sender, EventArgs e)
        {
            /*
            * 说明：MediaApi.GetVoice()用于获取符合下列条件的最近一个音频文件：
            *       1、当提供fakeid时，获取该用户的最近一个音频文件
            *       2、当未提供fakeid时，获取全局所有用户消息的最近一个音频文件（从前50条中筛选）
            *       3、MediaApi.GetVoice()返回的结果是对资源存在性进行验证，实际的文件会通过P2PBridge推送。
            */

            //argument参数非常重要，可用于记录Openid或数据库记录ID等参数，当P2PBridge收到消息时以此为依据判断这是谁的文件信息。
            var argument = DateTime.Now.Ticks.ToString();
            var p2pResult = GetApiContainer.MediaApi.GetVoice(long.Parse(txtMediaFakeid.Text ?? "0"), argument);
            if (p2pResult.Result != P2PResultKind.成功)
            {
                MessageBox.Show(p2pResult.Result.ToString());
                return;
            }

            MessageBox.Show("音频文件已经找到，将推送到P2PBridge，请检查。");
        }

        private void btnTestWrongApi_Click(object sender, EventArgs e)
        {
            //此过程用于测试请求了不存在的API

            var passport = GetApiContainer.Passport;

            var url = passport.P2PUrl + "AnyNotExistApi";
            var formData = new Dictionary<string, string>();
            formData["token"] = passport.Token;//也可以是不存在的Token

            DateTime dt1 = DateTime.Now;
            var result = HttpUtility.Post.PostGetJson<GetGroupsResult>(url, null, formData, null);//这里的GetGroupIdsResult可以是任意IP2PResult类型
            DateTime dt2 = DateTime.Now;

            var msg = string.Format(@"{0}
传输+API执行时间（ms）：{1}
API执行时间：{2}", result.Result.ToString(), (dt2 - dt1).TotalMilliseconds, result.RunTime);

            MessageBox.Show(msg);
        }

        private void cbGroupIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            var selectedItem = (GroupData)cb.SelectedItem;
            lblGroupCnt.Text = selectedItem.cnt.ToString();
        }

        private void btnMember_GetMemberinfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOpenId.Text))
            {
                MessageBox.Show("请输入有效的OpenID！");
                return;
            }

            var memberInfoResult = GetApiContainer.MemberApi.GetMemberInfo(txtOpenId.Text.Trim());
            if (memberInfoResult.Result != P2PResultKind.成功)
            {
                MessageBox.Show(memberInfoResult.Result.ToString());
                return;
            }

            var memberInfo = memberInfoResult.Data;
            MessageBox.Show(string.Format(@"用户信息获取成功：
会员卡号：{0}
OpenId：{1}
FakeId：{2}
加入时间：{3}
当前积分：{4}
真实姓名：{5}
电话号码：{6}",
memberInfo.CardNumber,
memberInfo.OpenId,
memberInfo.FakeId,
memberInfo.AddTime,
memberInfo.Points,
memberInfo.RealName,
memberInfo.Phone));
        }

        private void btnChangePoints_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOpenId.Text))
            {
                MessageBox.Show("请输入有效的OpenID！");
                return;
            }

            int points = 0;
            if (txtChangePoints.Text == null || !int.TryParse(txtChangePoints.Text, out points))
            {
                MessageBox.Show("请输入有效的积分值！正数为加分，负数为减分");
                return;
            }

            var memberInfoResult = GetApiContainer.MemberApi.ChangeMemberPoint(txtOpenId.Text.Trim(), points);
            if (memberInfoResult.Result != P2PResultKind.成功)
            {
                MessageBox.Show(memberInfoResult.Result.ToString());
                return;
            }

            MessageBox.Show(string.Format("修改会员积分成功！当前积分：{0}", memberInfoResult.Data.Points));
        }
    }
}