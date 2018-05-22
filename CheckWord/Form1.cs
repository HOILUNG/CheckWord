using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Net;

namespace CheckWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbx_word.Text = Properties.Resources.String1.Replace("、","\r\n") ;
            
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            
            
            
            var list = tbx_url.Lines.Where(m=>m.Contains("http:")).ToList();

            var word = tbx_word.Text.Split(new[] { "、", ",", "(", ")","（","）", "|", " ", "”", "“", "。","：", "\r\n" }, StringSplitOptions.RemoveEmptyEntries).Select(m=>m.Trim()).Distinct();


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
            MessageBox.Show("全部检测完毕");
            

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
                    if (!host.Contains("http://"))
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

                    rsp = await httpClient.GetAsync("");
                    if (!rsp.IsSuccessStatusCode)
                        return null;
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
            tbx_result.Text = string.Empty;
        }
    }
}
