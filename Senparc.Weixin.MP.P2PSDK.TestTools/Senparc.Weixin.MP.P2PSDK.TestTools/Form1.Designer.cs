namespace Senparc.Weixin.MP.P2PSDK.TestTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.gbSendMessage = new System.Windows.Forms.GroupBox();
            this.btnSendMessageSend = new System.Windows.Forms.Button();
            this.txtSendMessageText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSendMessageFakeid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVerifyCode = new System.Windows.Forms.TextBox();
            this.picVerifyCode = new System.Windows.Forms.PictureBox();
            this.txtSendMessageDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSendMessageTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSendMessageNews = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSendMessageUserName = new System.Windows.Forms.TextBox();
            this.gbFriends = new System.Windows.Forms.GroupBox();
            this.lblGroupCnt = new System.Windows.Forms.Label();
            this.picHeaderImage = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGetAllFriends = new System.Windows.Forms.Button();
            this.btnGetFriendDetails = new System.Windows.Forms.Button();
            this.cbFriendsList = new System.Windows.Forms.ComboBox();
            this.btnGetGroupFriends = new System.Windows.Forms.Button();
            this.cbGroupIds = new System.Windows.Forms.ComboBox();
            this.btnGetGroupIds = new System.Windows.Forms.Button();
            this.gbSendMessageNews = new System.Windows.Forms.GroupBox();
            this.txtSendNewsMessageFakeid = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.gbFakeidBind = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFakeIdBind = new System.Windows.Forms.Button();
            this.txtFakeidBindFakeid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbVerifyCode = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbMedia = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGetVoice = new System.Windows.Forms.Button();
            this.txtMediaFakeid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnTestWrongApi = new System.Windows.Forms.Button();
            this.lblAppKeyNotice = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtAppKey = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNewsAppMsgId = new System.Windows.Forms.TextBox();
            this.gbSendMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerifyCode)).BeginInit();
            this.gbFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderImage)).BeginInit();
            this.gbSendMessageNews.SuspendLayout();
            this.gbFakeidBind.SuspendLayout();
            this.gbVerifyCode.SuspendLayout();
            this.gbMedia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL地址（不以/结尾）：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "AppKey：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secret:";
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(193, 74);
            this.txtSecret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(292, 25);
            this.txtSecret.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(493, 114);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(204, 22);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "初始化驻留信息并连接";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Token：";
            // 
            // lblToken
            // 
            this.lblToken.Location = new System.Drawing.Point(193, 108);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(292, 38);
            this.lblToken.TabIndex = 8;
            this.lblToken.Text = "无";
            // 
            // gbSendMessage
            // 
            this.gbSendMessage.Controls.Add(this.btnSendMessageSend);
            this.gbSendMessage.Controls.Add(this.txtSendMessageText);
            this.gbSendMessage.Controls.Add(this.label6);
            this.gbSendMessage.Controls.Add(this.txtSendMessageFakeid);
            this.gbSendMessage.Controls.Add(this.label5);
            this.gbSendMessage.Location = new System.Drawing.Point(19, 296);
            this.gbSendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSendMessage.Name = "gbSendMessage";
            this.gbSendMessage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSendMessage.Size = new System.Drawing.Size(437, 96);
            this.gbSendMessage.TabIndex = 9;
            this.gbSendMessage.TabStop = false;
            this.gbSendMessage.Text = "单发消息测试";
            this.gbSendMessage.Visible = false;
            // 
            // btnSendMessageSend
            // 
            this.btnSendMessageSend.Location = new System.Drawing.Point(357, 52);
            this.btnSendMessageSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendMessageSend.Name = "btnSendMessageSend";
            this.btnSendMessageSend.Size = new System.Drawing.Size(75, 22);
            this.btnSendMessageSend.TabIndex = 4;
            this.btnSendMessageSend.Text = "发送";
            this.btnSendMessageSend.UseVisualStyleBackColor = true;
            this.btnSendMessageSend.Click += new System.EventHandler(this.btnSendMessageSend_Click);
            // 
            // txtSendMessageText
            // 
            this.txtSendMessageText.Location = new System.Drawing.Point(83, 51);
            this.txtSendMessageText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSendMessageText.Name = "txtSendMessageText";
            this.txtSendMessageText.Size = new System.Drawing.Size(268, 25);
            this.txtSendMessageText.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "消息：";
            // 
            // txtSendMessageFakeid
            // 
            this.txtSendMessageFakeid.Location = new System.Drawing.Point(83, 22);
            this.txtSendMessageFakeid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSendMessageFakeid.Name = "txtSendMessageFakeid";
            this.txtSendMessageFakeid.Size = new System.Drawing.Size(120, 25);
            this.txtSendMessageFakeid.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "fakeid：";
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.Location = new System.Drawing.Point(141, 52);
            this.txtVerifyCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.Size = new System.Drawing.Size(100, 25);
            this.txtVerifyCode.TabIndex = 6;
            this.txtVerifyCode.Visible = false;
            // 
            // picVerifyCode
            // 
            this.picVerifyCode.Location = new System.Drawing.Point(5, 25);
            this.picVerifyCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picVerifyCode.Name = "picVerifyCode";
            this.picVerifyCode.Size = new System.Drawing.Size(131, 52);
            this.picVerifyCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVerifyCode.TabIndex = 5;
            this.picVerifyCode.TabStop = false;
            // 
            // txtSendMessageDescription
            // 
            this.txtSendMessageDescription.Location = new System.Drawing.Point(379, 51);
            this.txtSendMessageDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSendMessageDescription.Name = "txtSendMessageDescription";
            this.txtSendMessageDescription.Size = new System.Drawing.Size(262, 25);
            this.txtSendMessageDescription.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "内容（支持HTML）：";
            // 
            // txtSendMessageTitle
            // 
            this.txtSendMessageTitle.Location = new System.Drawing.Point(71, 51);
            this.txtSendMessageTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSendMessageTitle.Name = "txtSendMessageTitle";
            this.txtSendMessageTitle.Size = new System.Drawing.Size(159, 25);
            this.txtSendMessageTitle.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "标题：";
            // 
            // btnSendMessageNews
            // 
            this.btnSendMessageNews.Location = new System.Drawing.Point(651, 54);
            this.btnSendMessageNews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendMessageNews.Name = "btnSendMessageNews";
            this.btnSendMessageNews.Size = new System.Drawing.Size(75, 22);
            this.btnSendMessageNews.TabIndex = 6;
            this.btnSendMessageNews.Text = "发送";
            this.btnSendMessageNews.UseVisualStyleBackColor = true;
            this.btnSendMessageNews.Click += new System.EventHandler(this.btnSendMessageNews_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "username：";
            // 
            // txtSendMessageUserName
            // 
            this.txtSendMessageUserName.Location = new System.Drawing.Point(99, 22);
            this.txtSendMessageUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSendMessageUserName.Name = "txtSendMessageUserName";
            this.txtSendMessageUserName.Size = new System.Drawing.Size(120, 25);
            this.txtSendMessageUserName.TabIndex = 1;
            // 
            // gbFriends
            // 
            this.gbFriends.Controls.Add(this.lblGroupCnt);
            this.gbFriends.Controls.Add(this.picHeaderImage);
            this.gbFriends.Controls.Add(this.label12);
            this.gbFriends.Controls.Add(this.btnGetAllFriends);
            this.gbFriends.Controls.Add(this.btnGetFriendDetails);
            this.gbFriends.Controls.Add(this.cbFriendsList);
            this.gbFriends.Controls.Add(this.btnGetGroupFriends);
            this.gbFriends.Controls.Add(this.cbGroupIds);
            this.gbFriends.Controls.Add(this.btnGetGroupIds);
            this.gbFriends.Location = new System.Drawing.Point(16, 160);
            this.gbFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFriends.Name = "gbFriends";
            this.gbFriends.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFriends.Size = new System.Drawing.Size(745, 124);
            this.gbFriends.TabIndex = 5;
            this.gbFriends.TabStop = false;
            this.gbFriends.Text = "用户组及用户信息";
            this.gbFriends.Visible = false;
            // 
            // lblGroupCnt
            // 
            this.lblGroupCnt.AutoSize = true;
            this.lblGroupCnt.Location = new System.Drawing.Point(255, 28);
            this.lblGroupCnt.Name = "lblGroupCnt";
            this.lblGroupCnt.Size = new System.Drawing.Size(0, 15);
            this.lblGroupCnt.TabIndex = 8;
            // 
            // picHeaderImage
            // 
            this.picHeaderImage.Location = new System.Drawing.Point(576, 49);
            this.picHeaderImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHeaderImage.Name = "picHeaderImage";
            this.picHeaderImage.Size = new System.Drawing.Size(68, 68);
            this.picHeaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeaderImage.TabIndex = 7;
            this.picHeaderImage.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "用户列表：";
            // 
            // btnGetAllFriends
            // 
            this.btnGetAllFriends.Location = new System.Drawing.Point(12, 95);
            this.btnGetAllFriends.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetAllFriends.Name = "btnGetAllFriends";
            this.btnGetAllFriends.Size = new System.Drawing.Size(380, 22);
            this.btnGetAllFriends.TabIndex = 5;
            this.btnGetAllFriends.Text = "获取前1000位用户（从“未分组”开始依次搜索）";
            this.btnGetAllFriends.UseVisualStyleBackColor = true;
            this.btnGetAllFriends.Visible = false;
            this.btnGetAllFriends.Click += new System.EventHandler(this.btnGetAllFriends_Click);
            // 
            // btnGetFriendDetails
            // 
            this.btnGetFriendDetails.Location = new System.Drawing.Point(576, 21);
            this.btnGetFriendDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetFriendDetails.Name = "btnGetFriendDetails";
            this.btnGetFriendDetails.Size = new System.Drawing.Size(163, 22);
            this.btnGetFriendDetails.TabIndex = 4;
            this.btnGetFriendDetails.Text = "获取详情&&下载头像";
            this.btnGetFriendDetails.UseVisualStyleBackColor = true;
            this.btnGetFriendDetails.Visible = false;
            this.btnGetFriendDetails.Click += new System.EventHandler(this.btnGetFriendDetails_Click);
            // 
            // cbFriendsList
            // 
            this.cbFriendsList.FormattingEnabled = true;
            this.cbFriendsList.Location = new System.Drawing.Point(448, 22);
            this.cbFriendsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFriendsList.Name = "cbFriendsList";
            this.cbFriendsList.Size = new System.Drawing.Size(121, 23);
            this.cbFriendsList.TabIndex = 3;
            this.cbFriendsList.Visible = false;
            this.cbFriendsList.SelectedValueChanged += new System.EventHandler(this.cbFriendsList_SelectedValueChanged);
            // 
            // btnGetGroupFriends
            // 
            this.btnGetGroupFriends.Location = new System.Drawing.Point(13, 66);
            this.btnGetGroupFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetGroupFriends.Name = "btnGetGroupFriends";
            this.btnGetGroupFriends.Size = new System.Drawing.Size(173, 22);
            this.btnGetGroupFriends.TabIndex = 2;
            this.btnGetGroupFriends.Text = "获取此组前50位用户";
            this.btnGetGroupFriends.UseVisualStyleBackColor = true;
            this.btnGetGroupFriends.Visible = false;
            this.btnGetGroupFriends.Click += new System.EventHandler(this.btnGetGroupFriends_Click);
            // 
            // cbGroupIds
            // 
            this.cbGroupIds.FormattingEnabled = true;
            this.cbGroupIds.Location = new System.Drawing.Point(128, 25);
            this.cbGroupIds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGroupIds.Name = "cbGroupIds";
            this.cbGroupIds.Size = new System.Drawing.Size(121, 23);
            this.cbGroupIds.TabIndex = 1;
            this.cbGroupIds.SelectedIndexChanged += new System.EventHandler(this.cbGroupIds_SelectedIndexChanged);
            // 
            // btnGetGroupIds
            // 
            this.btnGetGroupIds.Location = new System.Drawing.Point(11, 24);
            this.btnGetGroupIds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetGroupIds.Name = "btnGetGroupIds";
            this.btnGetGroupIds.Size = new System.Drawing.Size(112, 22);
            this.btnGetGroupIds.TabIndex = 0;
            this.btnGetGroupIds.Text = "获取用户组";
            this.btnGetGroupIds.UseVisualStyleBackColor = true;
            this.btnGetGroupIds.Click += new System.EventHandler(this.btnGetGroupIds_Click);
            // 
            // gbSendMessageNews
            // 
            this.gbSendMessageNews.Controls.Add(this.label18);
            this.gbSendMessageNews.Controls.Add(this.txtSendMessageDescription);
            this.gbSendMessageNews.Controls.Add(this.btnSendMessageNews);
            this.gbSendMessageNews.Controls.Add(this.label9);
            this.gbSendMessageNews.Controls.Add(this.txtNewsAppMsgId);
            this.gbSendMessageNews.Controls.Add(this.txtSendNewsMessageFakeid);
            this.gbSendMessageNews.Controls.Add(this.txtSendMessageUserName);
            this.gbSendMessageNews.Controls.Add(this.label17);
            this.gbSendMessageNews.Controls.Add(this.txtSendMessageTitle);
            this.gbSendMessageNews.Controls.Add(this.label7);
            this.gbSendMessageNews.Controls.Add(this.label8);
            this.gbSendMessageNews.Location = new System.Drawing.Point(19, 396);
            this.gbSendMessageNews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSendMessageNews.Name = "gbSendMessageNews";
            this.gbSendMessageNews.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSendMessageNews.Size = new System.Drawing.Size(743, 86);
            this.gbSendMessageNews.TabIndex = 10;
            this.gbSendMessageNews.TabStop = false;
            this.gbSendMessageNews.Text = "图文消息测试";
            this.gbSendMessageNews.Visible = false;
            // 
            // txtSendNewsMessageFakeid
            // 
            this.txtSendNewsMessageFakeid.Location = new System.Drawing.Point(302, 22);
            this.txtSendNewsMessageFakeid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSendNewsMessageFakeid.Name = "txtSendNewsMessageFakeid";
            this.txtSendNewsMessageFakeid.Size = new System.Drawing.Size(120, 25);
            this.txtSendNewsMessageFakeid.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(226, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "fakeid：";
            // 
            // gbFakeidBind
            // 
            this.gbFakeidBind.Controls.Add(this.label11);
            this.gbFakeidBind.Controls.Add(this.btnFakeIdBind);
            this.gbFakeidBind.Controls.Add(this.txtFakeidBindFakeid);
            this.gbFakeidBind.Controls.Add(this.label10);
            this.gbFakeidBind.Location = new System.Drawing.Point(16, 499);
            this.gbFakeidBind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFakeidBind.Name = "gbFakeidBind";
            this.gbFakeidBind.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFakeidBind.Size = new System.Drawing.Size(743, 66);
            this.gbFakeidBind.TabIndex = 11;
            this.gbFakeidBind.TabStop = false;
            this.gbFakeidBind.Text = "Fakeid-Openid自动匹配";
            this.gbFakeidBind.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(308, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(358, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "注意：请先确保P2P后台的P2PBridge已经完成设置。";
            // 
            // btnFakeIdBind
            // 
            this.btnFakeIdBind.Location = new System.Drawing.Point(192, 26);
            this.btnFakeIdBind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFakeIdBind.Name = "btnFakeIdBind";
            this.btnFakeIdBind.Size = new System.Drawing.Size(109, 22);
            this.btnFakeIdBind.TabIndex = 2;
            this.btnFakeIdBind.Text = "模拟测试";
            this.btnFakeIdBind.UseVisualStyleBackColor = true;
            this.btnFakeIdBind.Click += new System.EventHandler(this.btnFakeIdBind_Click);
            // 
            // txtFakeidBindFakeid
            // 
            this.txtFakeidBindFakeid.Location = new System.Drawing.Point(71, 24);
            this.txtFakeidBindFakeid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFakeidBindFakeid.Name = "txtFakeidBindFakeid";
            this.txtFakeidBindFakeid.Size = new System.Drawing.Size(115, 25);
            this.txtFakeidBindFakeid.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "fakeid：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(325, 636);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(420, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "苏州盛派网络科技有限公司 版权所有。内测使用，严禁传播。";
            // 
            // gbVerifyCode
            // 
            this.gbVerifyCode.Controls.Add(this.label14);
            this.gbVerifyCode.Controls.Add(this.picVerifyCode);
            this.gbVerifyCode.Controls.Add(this.txtVerifyCode);
            this.gbVerifyCode.Location = new System.Drawing.Point(464, 296);
            this.gbVerifyCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVerifyCode.Name = "gbVerifyCode";
            this.gbVerifyCode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVerifyCode.Size = new System.Drawing.Size(299, 96);
            this.gbVerifyCode.TabIndex = 13;
            this.gbVerifyCode.TabStop = false;
            this.gbVerifyCode.Text = "验证码";
            this.gbVerifyCode.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(141, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 30);
            this.label14.TabIndex = 7;
            this.label14.Text = "左侧出现图片时，\r\n将验证码填写在这里：";
            // 
            // gbMedia
            // 
            this.gbMedia.Controls.Add(this.label16);
            this.gbMedia.Controls.Add(this.btnGetVoice);
            this.gbMedia.Controls.Add(this.txtMediaFakeid);
            this.gbMedia.Controls.Add(this.label15);
            this.gbMedia.Location = new System.Drawing.Point(19, 571);
            this.gbMedia.Margin = new System.Windows.Forms.Padding(4);
            this.gbMedia.Name = "gbMedia";
            this.gbMedia.Padding = new System.Windows.Forms.Padding(4);
            this.gbMedia.Size = new System.Drawing.Size(744, 61);
            this.gbMedia.TabIndex = 14;
            this.gbMedia.TabStop = false;
            this.gbMedia.Text = "媒体文件";
            this.gbMedia.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(339, 29);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(310, 15);
            this.label16.TabIndex = 5;
            this.label16.Text = "如果fakeid留空，则从全局消息中获取第一个";
            // 
            // btnGetVoice
            // 
            this.btnGetVoice.Location = new System.Drawing.Point(193, 25);
            this.btnGetVoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetVoice.Name = "btnGetVoice";
            this.btnGetVoice.Size = new System.Drawing.Size(137, 22);
            this.btnGetVoice.TabIndex = 4;
            this.btnGetVoice.Text = "下载音频文件";
            this.btnGetVoice.UseVisualStyleBackColor = true;
            this.btnGetVoice.Click += new System.EventHandler(this.btnGetVoice_Click);
            // 
            // txtMediaFakeid
            // 
            this.txtMediaFakeid.Location = new System.Drawing.Point(71, 25);
            this.txtMediaFakeid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMediaFakeid.Name = "txtMediaFakeid";
            this.txtMediaFakeid.Size = new System.Drawing.Size(115, 25);
            this.txtMediaFakeid.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "fakeid：";
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(493, 12);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(163, 22);
            this.btnSwitch.TabIndex = 15;
            this.btnSwitch.Text = "切换本地/远程地址";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnTestWrongApi
            // 
            this.btnTestWrongApi.Location = new System.Drawing.Point(13, 132);
            this.btnTestWrongApi.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestWrongApi.Name = "btnTestWrongApi";
            this.btnTestWrongApi.Size = new System.Drawing.Size(163, 22);
            this.btnTestWrongApi.TabIndex = 16;
            this.btnTestWrongApi.Text = "测试API地址错误";
            this.btnTestWrongApi.UseVisualStyleBackColor = true;
            this.btnTestWrongApi.Visible = false;
            this.btnTestWrongApi.Click += new System.EventHandler(this.btnTestWrongApi_Click);
            // 
            // lblAppKeyNotice
            // 
            this.lblAppKeyNotice.Location = new System.Drawing.Point(493, 42);
            this.lblAppKeyNotice.Name = "lblAppKeyNotice";
            this.lblAppKeyNotice.Size = new System.Drawing.Size(282, 70);
            this.lblAppKeyNotice.TabIndex = 17;
            this.lblAppKeyNotice.Text = "<--凡是链接成功之后的AppKey可以任意切换，不用重新修改密码或重新链接。Passport会被自动缓存，不会重新获取。可观察各自Token。";
            this.lblAppKeyNotice.Visible = false;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(193, 10);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(292, 25);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://api.souidea.com:8282";
            // 
            // txtAppKey
            // 
            this.txtAppKey.FormattingEnabled = true;
            this.txtAppKey.Location = new System.Drawing.Point(193, 42);
            this.txtAppKey.Name = "txtAppKey";
            this.txtAppKey.Size = new System.Drawing.Size(292, 23);
            this.txtAppKey.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(428, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 15);
            this.label18.TabIndex = 11;
            this.label18.Text = "AppMsgId：";
            // 
            // txtNewsAppMsgId
            // 
            this.txtNewsAppMsgId.Location = new System.Drawing.Point(517, 22);
            this.txtNewsAppMsgId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewsAppMsgId.Name = "txtNewsAppMsgId";
            this.txtNewsAppMsgId.Size = new System.Drawing.Size(120, 25);
            this.txtNewsAppMsgId.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 660);
            this.Controls.Add(this.txtAppKey);
            this.Controls.Add(this.lblAppKeyNotice);
            this.Controls.Add(this.btnTestWrongApi);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.gbMedia);
            this.Controls.Add(this.gbVerifyCode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gbFakeidBind);
            this.Controls.Add(this.gbSendMessageNews);
            this.Controls.Add(this.gbFriends);
            this.Controls.Add(this.gbSendMessage);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "v2013.10.30 - Senparc.Weixin.MP.P2PSDK 测试工具";
            this.gbSendMessage.ResumeLayout(false);
            this.gbSendMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerifyCode)).EndInit();
            this.gbFriends.ResumeLayout(false);
            this.gbFriends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderImage)).EndInit();
            this.gbSendMessageNews.ResumeLayout(false);
            this.gbSendMessageNews.PerformLayout();
            this.gbFakeidBind.ResumeLayout(false);
            this.gbFakeidBind.PerformLayout();
            this.gbVerifyCode.ResumeLayout(false);
            this.gbVerifyCode.PerformLayout();
            this.gbMedia.ResumeLayout(false);
            this.gbMedia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecret;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.GroupBox gbSendMessage;
        private System.Windows.Forms.Button btnSendMessageSend;
        private System.Windows.Forms.TextBox txtSendMessageText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSendMessageFakeid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbFriends;
        private System.Windows.Forms.Button btnGetGroupIds;
        private System.Windows.Forms.ComboBox cbGroupIds;
        private System.Windows.Forms.Button btnGetGroupFriends;
        private System.Windows.Forms.ComboBox cbFriendsList;
        private System.Windows.Forms.Button btnGetFriendDetails;
        private System.Windows.Forms.TextBox txtSendMessageDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSendMessageTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSendMessageNews;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSendMessageUserName;
        private System.Windows.Forms.GroupBox gbSendMessageNews;
        private System.Windows.Forms.GroupBox gbFakeidBind;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFakeIdBind;
        private System.Windows.Forms.TextBox txtFakeidBindFakeid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGetAllFriends;
        private System.Windows.Forms.PictureBox picVerifyCode;
        private System.Windows.Forms.PictureBox picHeaderImage;
        private System.Windows.Forms.TextBox txtVerifyCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbVerifyCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbMedia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGetVoice;
        private System.Windows.Forms.TextBox txtMediaFakeid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnTestWrongApi;
        private System.Windows.Forms.Label lblGroupCnt;
        private System.Windows.Forms.Label lblAppKeyNotice;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ComboBox txtAppKey;
        private System.Windows.Forms.TextBox txtSendNewsMessageFakeid;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNewsAppMsgId;
    }
}

