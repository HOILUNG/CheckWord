namespace CheckWord
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_word = new System.Windows.Forms.TextBox();
            this.tbx_url = new System.Windows.Forms.TextBox();
            this.tbx_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_cp_result = new System.Windows.Forms.Button();
            this.btn_cp_url = new System.Windows.Forms.Button();
            this.tbx_domain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_link = new System.Windows.Forms.Button();
            this.btn_link2 = new System.Windows.Forms.Button();
            this.btn_repeat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_txt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_txt = new System.Windows.Forms.RichTextBox();
            this.listbox_txt_result = new System.Windows.Forms.ListBox();
            this.lb_update = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_word
            // 
            this.tbx_word.Location = new System.Drawing.Point(9, 26);
            this.tbx_word.Multiline = true;
            this.tbx_word.Name = "tbx_word";
            this.tbx_word.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_word.Size = new System.Drawing.Size(220, 488);
            this.tbx_word.TabIndex = 7;
            this.tbx_word.WordWrap = false;
            // 
            // tbx_url
            // 
            this.tbx_url.Location = new System.Drawing.Point(8, 76);
            this.tbx_url.Multiline = true;
            this.tbx_url.Name = "tbx_url";
            this.tbx_url.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_url.Size = new System.Drawing.Size(561, 166);
            this.tbx_url.TabIndex = 3;
            this.tbx_url.WordWrap = false;
            // 
            // tbx_result
            // 
            this.tbx_result.Location = new System.Drawing.Point(8, 300);
            this.tbx_result.Multiline = true;
            this.tbx_result.Name = "tbx_result";
            this.tbx_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_result.Size = new System.Drawing.Size(559, 177);
            this.tbx_result.TabIndex = 5;
            this.tbx_result.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "词汇列表 (可自定义增减或         )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "2、网址列表 (每行一个完整链接地址 例：http://www.hao123.com/index.html )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "3、检测结果(显示格式：网址 词汇1,词汇2)";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(580, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "开始检测";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 248);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(559, 20);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 7;
            // 
            // btn_clear
            // 
            this.btn_clear.ForeColor = System.Drawing.Color.Red;
            this.btn_clear.Location = new System.Drawing.Point(580, 329);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "清空结果";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(580, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "清空网址";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cp_result
            // 
            this.btn_cp_result.ForeColor = System.Drawing.Color.Green;
            this.btn_cp_result.Location = new System.Drawing.Point(580, 300);
            this.btn_cp_result.Name = "btn_cp_result";
            this.btn_cp_result.Size = new System.Drawing.Size(75, 23);
            this.btn_cp_result.TabIndex = 6;
            this.btn_cp_result.Text = "复制结果";
            this.btn_cp_result.UseVisualStyleBackColor = true;
            this.btn_cp_result.Click += new System.EventHandler(this.btn_cp_result_Click);
            // 
            // btn_cp_url
            // 
            this.btn_cp_url.ForeColor = System.Drawing.Color.Green;
            this.btn_cp_url.Location = new System.Drawing.Point(580, 134);
            this.btn_cp_url.Name = "btn_cp_url";
            this.btn_cp_url.Size = new System.Drawing.Size(75, 23);
            this.btn_cp_url.TabIndex = 11;
            this.btn_cp_url.Text = "复制网址";
            this.btn_cp_url.UseVisualStyleBackColor = true;
            this.btn_cp_url.Click += new System.EventHandler(this.btn_cp_url_Click);
            // 
            // tbx_domain
            // 
            this.tbx_domain.Location = new System.Drawing.Point(8, 23);
            this.tbx_domain.Name = "tbx_domain";
            this.tbx_domain.Size = new System.Drawing.Size(559, 21);
            this.tbx_domain.TabIndex = 1;
            this.tbx_domain.Text = "http://www.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "1、输入网站自动获页面的网址列表（或手动输入网址列表）";
            // 
            // btn_link
            // 
            this.btn_link.ForeColor = System.Drawing.Color.Green;
            this.btn_link.Location = new System.Drawing.Point(580, 23);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(75, 23);
            this.btn_link.TabIndex = 2;
            this.btn_link.Text = "获取列表";
            this.btn_link.UseVisualStyleBackColor = true;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // btn_link2
            // 
            this.btn_link2.ForeColor = System.Drawing.Color.Red;
            this.btn_link2.Location = new System.Drawing.Point(580, 219);
            this.btn_link2.Name = "btn_link2";
            this.btn_link2.Size = new System.Drawing.Size(75, 23);
            this.btn_link2.TabIndex = 14;
            this.btn_link2.Text = "列表轮询";
            this.btn_link2.UseVisualStyleBackColor = true;
            this.btn_link2.Click += new System.EventHandler(this.btn_link2_Click);
            // 
            // btn_repeat
            // 
            this.btn_repeat.ForeColor = System.Drawing.Color.Green;
            this.btn_repeat.Location = new System.Drawing.Point(580, 74);
            this.btn_repeat.Name = "btn_repeat";
            this.btn_repeat.Size = new System.Drawing.Size(75, 23);
            this.btn_repeat.TabIndex = 15;
            this.btn_repeat.Text = "列表去重";
            this.btn_repeat.UseVisualStyleBackColor = true;
            this.btn_repeat.Click += new System.EventHandler(this.btn_repeat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(11, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(557, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "操作流程：请参考界面顺序，从左往右，从上到下；操作选项：绿色按钮为常用操作，红色为慎用操作。";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(743, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "常见问题：若5秒内获取列表失败，请重试或用浏览器打开网站是否正常；部分服务器对网站访问频率有限制，同一IP请勿频繁或间隔访问。";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 598);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.lb_update);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbx_word);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "首页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(241, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(667, 511);
            this.tabControl2.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.btn_cp_result);
            this.tabPage3.Controls.Add(this.btn_clear);
            this.tabPage3.Controls.Add(this.btn_cp_url);
            this.tabPage3.Controls.Add(this.tbx_url);
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.Controls.Add(this.btn_repeat);
            this.tabPage3.Controls.Add(this.tbx_domain);
            this.tabPage3.Controls.Add(this.tbx_result);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btn_link2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btn_link);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(659, 485);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "网页检测";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_txt);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.tbx_txt);
            this.tabPage4.Controls.Add(this.listbox_txt_result);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(659, 485);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "文本检测";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_txt
            // 
            this.btn_txt.ForeColor = System.Drawing.Color.Green;
            this.btn_txt.Location = new System.Drawing.Point(578, 22);
            this.btn_txt.Name = "btn_txt";
            this.btn_txt.Size = new System.Drawing.Size(75, 23);
            this.btn_txt.TabIndex = 10;
            this.btn_txt.Text = "文本检测";
            this.btn_txt.UseVisualStyleBackColor = true;
            this.btn_txt.Click += new System.EventHandler(this.btn_txt_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(578, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "清空文本";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(383, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "检测结果（双击结果查看文本蓝色匹配内容,每个词汇可能有多个匹配）";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "文本内容";
            // 
            // tbx_txt
            // 
            this.tbx_txt.Location = new System.Drawing.Point(6, 22);
            this.tbx_txt.Name = "tbx_txt";
            this.tbx_txt.Size = new System.Drawing.Size(559, 226);
            this.tbx_txt.TabIndex = 6;
            this.tbx_txt.Text = "";
            // 
            // listbox_txt_result
            // 
            this.listbox_txt_result.FormattingEnabled = true;
            this.listbox_txt_result.ItemHeight = 12;
            this.listbox_txt_result.Location = new System.Drawing.Point(6, 281);
            this.listbox_txt_result.Name = "listbox_txt_result";
            this.listbox_txt_result.Size = new System.Drawing.Size(561, 196);
            this.listbox_txt_result.TabIndex = 5;
            this.listbox_txt_result.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_txt_result_MouseDoubleClick);
            // 
            // lb_update
            // 
            this.lb_update.AutoSize = true;
            this.lb_update.Location = new System.Drawing.Point(154, 11);
            this.lb_update.Name = "lb_update";
            this.lb_update.Size = new System.Drawing.Size(53, 12);
            this.lb_update.TabIndex = 18;
            this.lb_update.TabStop = true;
            this.lb_update.Text = "更新列表";
            this.lb_update.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_update_LinkClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "关于";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(16, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 405);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "软件说明";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(24, 77);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(449, 36);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://zhuanlan.zhihu.com/p/25620515\r\n\r\nhttps://wenku.baidu.com/view/bffc3803b20" +
    "7e87101f69e3143323968001cf475.html";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(545, 36);
            this.label8.TabIndex = 1;
            this.label8.Text = "本工具只包含了部分可能涉及到的词汇（内容来自互联网），未包含全面的大家可自行搜索查询了解。\r\n\r\n可参考词汇：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "广告词汇";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(605, 72);
            this.label7.TabIndex = 0;
            this.label7.Text = "\r\n因为滥用广告词，夸大产品的真实性，误导消费者，为保障消费者权益。\r\n\r\n国家2016正式实施了被商家号称史上最严的新广告法,新广告法对明星代言,虚假广告,极限" +
    "用词等都作了规定。\r\n\r\n相关信息可通过搜索引擎了解详情，大家在做宣传写文案做详情，主图文字等一定要注意，否则可能会受到处罚。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 618);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_word;
        private System.Windows.Forms.TextBox tbx_url;
        private System.Windows.Forms.TextBox tbx_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_cp_result;
        private System.Windows.Forms.Button btn_cp_url;
        private System.Windows.Forms.TextBox tbx_domain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_link;
        private System.Windows.Forms.Button btn_link2;
        private System.Windows.Forms.Button btn_repeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel lb_update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listbox_txt_result;
        private System.Windows.Forms.RichTextBox tbx_txt;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_txt;
    }
}

