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
            this.SuspendLayout();
            // 
            // tbx_word
            // 
            this.tbx_word.Location = new System.Drawing.Point(12, 31);
            this.tbx_word.Multiline = true;
            this.tbx_word.Name = "tbx_word";
            this.tbx_word.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_word.Size = new System.Drawing.Size(275, 518);
            this.tbx_word.TabIndex = 7;
            this.tbx_word.WordWrap = false;
            // 
            // tbx_url
            // 
            this.tbx_url.Location = new System.Drawing.Point(295, 99);
            this.tbx_url.Multiline = true;
            this.tbx_url.Name = "tbx_url";
            this.tbx_url.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_url.Size = new System.Drawing.Size(561, 200);
            this.tbx_url.TabIndex = 3;
            this.tbx_url.WordWrap = false;
            // 
            // tbx_result
            // 
            this.tbx_result.Location = new System.Drawing.Point(295, 346);
            this.tbx_result.Multiline = true;
            this.tbx_result.Name = "tbx_result";
            this.tbx_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_result.Size = new System.Drawing.Size(559, 203);
            this.tbx_result.TabIndex = 5;
            this.tbx_result.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "词汇列表(根据实际情况自定义增减)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "2、网址列表 (每行一个完整链接地址 例：http://www.hao123.com/index.html )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "3、检测结果(显示格式：网址 词汇1,词汇2)";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(879, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "开始检测";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(295, 305);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(559, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 7;
            // 
            // btn_clear
            // 
            this.btn_clear.ForeColor = System.Drawing.Color.Red;
            this.btn_clear.Location = new System.Drawing.Point(879, 375);
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
            this.button2.Location = new System.Drawing.Point(879, 186);
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
            this.btn_cp_result.Location = new System.Drawing.Point(879, 346);
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
            this.btn_cp_url.Location = new System.Drawing.Point(879, 157);
            this.btn_cp_url.Name = "btn_cp_url";
            this.btn_cp_url.Size = new System.Drawing.Size(75, 23);
            this.btn_cp_url.TabIndex = 11;
            this.btn_cp_url.Text = "复制网址";
            this.btn_cp_url.UseVisualStyleBackColor = true;
            this.btn_cp_url.Click += new System.EventHandler(this.btn_cp_url_Click);
            // 
            // tbx_domain
            // 
            this.tbx_domain.Location = new System.Drawing.Point(295, 46);
            this.tbx_domain.Name = "tbx_domain";
            this.tbx_domain.Size = new System.Drawing.Size(559, 21);
            this.tbx_domain.TabIndex = 1;
            this.tbx_domain.Text = "http://www.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "1、输入网站自动获页面的网址列表（或手动输入网址列表）";
            // 
            // btn_link
            // 
            this.btn_link.ForeColor = System.Drawing.Color.Green;
            this.btn_link.Location = new System.Drawing.Point(879, 46);
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
            this.btn_link2.Location = new System.Drawing.Point(879, 242);
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
            this.btn_repeat.Location = new System.Drawing.Point(879, 97);
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
            this.label5.Location = new System.Drawing.Point(10, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(557, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "操作流程：请参考界面顺序，从左往右，从上到下；操作选项：绿色按钮为常用操作，红色为慎用操作。";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 580);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(701, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "常见问题：获取列表失败，请重试或用浏览器打开网站是否正常；部分服务器对网站访问频率有限制，同一IP请勿频繁或间隔访问。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 602);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_repeat);
            this.Controls.Add(this.btn_link2);
            this.Controls.Add(this.btn_link);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_domain);
            this.Controls.Add(this.btn_cp_url);
            this.Controls.Add(this.btn_cp_result);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_result);
            this.Controls.Add(this.tbx_url);
            this.Controls.Add(this.tbx_word);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

