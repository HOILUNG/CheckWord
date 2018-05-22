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
            this.SuspendLayout();
            // 
            // tbx_word
            // 
            this.tbx_word.Location = new System.Drawing.Point(12, 31);
            this.tbx_word.Multiline = true;
            this.tbx_word.Name = "tbx_word";
            this.tbx_word.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_word.Size = new System.Drawing.Size(275, 541);
            this.tbx_word.TabIndex = 0;
            this.tbx_word.WordWrap = false;
            // 
            // tbx_url
            // 
            this.tbx_url.Location = new System.Drawing.Point(322, 31);
            this.tbx_url.Multiline = true;
            this.tbx_url.Name = "tbx_url";
            this.tbx_url.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_url.Size = new System.Drawing.Size(561, 223);
            this.tbx_url.TabIndex = 1;
            this.tbx_url.WordWrap = false;
            // 
            // tbx_result
            // 
            this.tbx_result.Location = new System.Drawing.Point(324, 339);
            this.tbx_result.Multiline = true;
            this.tbx_result.Name = "tbx_result";
            this.tbx_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_result.Size = new System.Drawing.Size(559, 233);
            this.tbx_result.TabIndex = 2;
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
            this.label2.Location = new System.Drawing.Point(320, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "网址列表 (每行一个完整链接地址 例：http://www.hao123.com/index.html )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "检测结果(显示格式：网址 词汇1,词汇2)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(908, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "开始检测";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(324, 261);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(559, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 7;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(908, 339);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "清空结果";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 602);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_result);
            this.Controls.Add(this.tbx_url);
            this.Controls.Add(this.tbx_word);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "广告法极限词检测";
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
    }
}

