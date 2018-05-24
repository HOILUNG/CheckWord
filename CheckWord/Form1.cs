using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CheckWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbx_word.Text = Properties.Resources.String1.Replace("、","\r\n") ;
            this.Text = string.Format("{0} {1}", this.ProductName, this.ProductVersion);
            
            
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            
            var list = tbx_url.Lines.Where(m=>m.IndexOf("http")==0).ToList();
            if(list.Count<1)
            {                
                tbx_url.ShowToolTip("需要输入完整网址请参考实例！（每行一条）", "提示", ToolTipIcon.Info);
                return;
            }else if(tbx_word.Text.Trim().Length<2)
            {                
                tbx_word.ShowToolTip("需要填写词汇列表！（每行一条）", "提示", ToolTipIcon.Info);
                return;
            }

            var word = tbx_word.Text.Split(new[] { "、", ",", "(", ")","（","）", "|", " ", "”", "“", "。","：", "/","-", "—", "\r\n" }, StringSplitOptions.RemoveEmptyEntries).OrderByDescending(m=>m.Length).Select(m=>m.Trim()).Distinct();


            progressBar1.Maximum = list.Count;
            progressBar1.Value = 0;

            var sb = new StringBuilder();
            foreach (var item in word)
            {
                sb.Append(item+"|");
            }
            
            var regex = new Regex(sb.ToString(0,sb.Length-1));
            foreach (var item in list)
            {
                progressBar1.PerformStep();
                try
                {
                    var html = await GetHtml(item);

                    var rm = regex.Matches(html);
                    var sb2 = new StringBuilder();
                    if (rm.Count>0)
                    {
                        
                        foreach (Match r in rm)
                        {
                          //  if(sb2.ToString().IndexOf(r.Value)<0)
                                sb2.Append(r.Value + ",");
                        }
                        
                        tbx_result.AppendText($"{item}\t{sb2.ToString(0,sb2.Length-1)}\r\n");
                    }
                }
                catch (Exception ex)
                {
                    System.IO.File.AppendAllText("log.txt", ex.Message);
                }
            }
            MessageBox.Show("全部检测完毕,列表数量："+tbx_result.Lines.Length);
            

        }

        public async Task<string> GetHtml(string host)
        {
            var html = string.Empty;
            var rsp = await GetHttpAsync(host);
            if (rsp == null)
                return html;
            var htmlbyte = await rsp.Content.ReadAsByteArrayAsync();
            //1头部编码
            var charset = rsp.Content.Headers.ContentType.CharSet;
            //网页编码
            if (!string.IsNullOrEmpty(charset))
            {
                html = Encoding.GetEncoding(charset).GetString(htmlbyte);
            }
            else
            {
                if (htmlbyte[0] == 239)
                {
                    charset = Encoding.UTF8.BodyName;
                    html = Encoding.GetEncoding(charset).GetString(htmlbyte);
                }
                else
                {
                    html = Encoding.GetEncoding("gb2312").GetString(htmlbyte);
                    charset = Regex.Match(html, "((?<=charset=\")[\\w\\-]+)|(?<=charset=)[\\w\\-]+", RegexOptions.IgnoreCase).Value;
                    if (charset != "gb2312" && !string.IsNullOrEmpty(charset))
                        html = Encoding.GetEncoding(charset).GetString(htmlbyte);
                }

            }

            //默认编码
            if (string.IsNullOrEmpty(charset))
            {
                charset = Encoding.Default.BodyName;
                html = Encoding.GetEncoding(charset).GetString(htmlbyte);
            }


            return html;
        }
       

        public async Task<HttpResponseMessage> GetHttpAsync(string host)
        {
            HttpResponseMessage rsp;
            using (HttpClient httpClient = new HttpClient(new HttpClientHandler()
            {
                AllowAutoRedirect = true,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            }))
            {
                try
                {
                    if (host.IndexOf("http")<0)
                   {
                        host = "http://" + host;
                    }                    
                    var requurl = new Uri(host);
                    var ips = await Dns.GetHostAddressesAsync(requurl.Host);
                    if (ips.Length < 0)
                    {
                        return null;
                    }

                    httpClient.Timeout = TimeSpan.FromSeconds(5);
                    httpClient.BaseAddress = requurl;
                    httpClient.DefaultRequestHeaders.AcceptLanguage.ParseAdd("zh-CN,zh;q=0.8");
                    httpClient.DefaultRequestHeaders.Accept.ParseAdd("text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
                    httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.115 Safari/537.36");


                    
                    HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Head, requurl);
                    var headrequest=await httpClient.SendAsync(httpRequestMessage);                   
                    if (headrequest.IsSuccessStatusCode&& !headrequest.Content.Headers.ContentType.MediaType.Contains("text/html"))
                    {
                        return null;
                    }

                    
                    rsp = await httpClient.GetAsync("");
                    if (!rsp.IsSuccessStatusCode)
                        return null;
                    if (!rsp.Content.Headers.ContentType.MediaType.Contains("text/html"))
                    {
                        return null; 
                    }
                    
                    
                }
                catch (Exception ex)
                {
                    // LogHelper.GetLogger(typeof(WebSite)).Error("httprequest fail 45 "+host,ex);
                    return null;
                }
            }

            return rsp;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbx_result.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbx_url.ResetText();
        }

        private void btn_cp_url_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(tbx_url.Text);
            tbx_url.ShowToolTip("复制成功", "提示", ToolTipIcon.Info);
        }

        private void btn_cp_result_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(tbx_result.Text);
            tbx_result.ShowToolTip("复制成功", "提示", ToolTipIcon.Info);            
        }

        private async void btn_link_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbx_domain.Text.IndexOf("http")<0 || tbx_domain.Text.IndexOf(".")<0 || tbx_domain.Text.IndexOf(":") < 0)
                {
                    
                    tbx_domain.ShowToolTip("请输入正确的网站地址","提示",ToolTipIcon.Warning);
                    return;
                }
                var domain = new Uri(tbx_domain.Text);

                await GetUrlLink(domain);
                MessageBox.Show("获取网站链接完毕,列表数量：" + tbx_url.Lines.Length);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                                  
            }
        }

        private async Task GetUrlLink(Uri domain)
        {
            
            var html = await GetHtml(domain.ToString());
            if(string.IsNullOrEmpty(html))
            {
                tbx_domain.ShowToolTip("获取网站内容失败，请检测网站或重试", "提示", ToolTipIcon.Warning);
                return;
            }
            var htmldoc = new HtmlAgilityPack.HtmlDocument();
            htmldoc.LoadHtml(html);
            var nodes = htmldoc.DocumentNode.SelectNodes("//a[not(contains(@href,'#')) and not(contains(@href,'javascript:'))  and not(contains(@href,'tel:'))  and not(contains(@href,'mail:')) and @href]");
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    var href = node.GetAttributeValue("href", "");
                    if (href == string.Empty)
                        continue;
                    //if (href.IndexOf(".pdf") > 0)
                    //    continue;
                    //if (href.IndexOf(".jpg") > 0)
                    //    continue;
                    //if (href.IndexOf(".png") > 0)
                    //    continue;
                    //if (href.Contains("miibeian.gov.cn"))
                    //    continue;
                    //if (href.Contains("beian.gov.cn"))
                    //    continue;
                    //if (href.Contains("wpa.qq.com"))
                    //    continue;


                    try
                    {
                        

                        if (href.IndexOf("http") < 0 && href.IndexOf(":") < 0)
                        {
                            var newurl = new Uri(new Uri($"{domain.Scheme}://{domain.Host}"), href);
                            tbx_url.AppendText(newurl.ToString() + "\r\n");
                        }
                        else if (href.IndexOf("http") == 0)
                        {
                            var newurl = new Uri(href);
                            if (newurl.Host == domain.Host)
                            {
                                tbx_url.AppendText(newurl.ToString() + "\r\n");
                            }

                        }
                    }
                    catch (Exception)
                    {

                    }


                }
            }
        }

        private void btn_repeat_Click(object sender, EventArgs e)
        {
           var abc= tbx_url.Lines.Distinct();
            tbx_url.ResetText();
            foreach (var item in abc)
            {
                tbx_url.AppendText(item+"\r\n");
            }
        }

        private async void btn_link2_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("1,为避免重复访问网站，轮询一般只操作一次、\r\n2,部分网站对访问频率有设置,访问频繁可能有限制\r\n\r\n是否对列表中网址进行二次轮询获得更多网址？", "警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
            {
                var links = tbx_url.Lines.Distinct();
                foreach (var item in links)    
                {
                    try
                    {
                        if (string.IsNullOrEmpty(item) || item.Length<5)
                            continue;
                        
                        var domain = new Uri(item);
                        await GetUrlLink(domain);
                    }
                    catch (Exception)
                    {
                    }
                }
                MessageBox.Show("轮询完毕,列表数量：" + tbx_url.Lines.Length);
            }
        }
    }


    public static class ExControl
    {
        static ToolTip toolTip;
        public static void ShowToolTip(this Control control, string text, string title, ToolTipIcon toolTipIcon)
        {
            if (toolTip != null)
                toolTip.Dispose();
            toolTip = new ToolTip();
            //toolTip.IsBalloon = true;
            toolTip.ToolTipTitle = title;
            toolTip.ToolTipIcon = toolTipIcon;
            //toolTip.ShowAlways = true;
            //toolTip.SetToolTip(control, text);
            //var _mousePoint = Control.MousePosition;
            //int _x = control.PointToClient(_mousePoint).X;
            //int _y = control.PointToClient(_mousePoint).Y;
            //toolTip.Show(text, control, _x, _y);
            toolTip.Show(text, control);
        }
    }
}
