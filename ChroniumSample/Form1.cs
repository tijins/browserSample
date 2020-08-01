using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChroniumSample
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser browser;

        public Form1()
        {
            InitializeComponent();

            browser = new ChromiumWebBrowser("http://www.google.com/webhp") {
                Dock = DockStyle.Fill
            };
            panel1.Controls.Add(browser);

            browser.LoadingStateChanged += Browser_LoadingStateChanged;
            browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
        }

        private void Browser_IsBrowserInitializedChanged(object sender, EventArgs e)
        {
            browser.ShowDevTools();
        }
            
        private async void Browser_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading)
            {
                var text = await e.Browser.MainFrame.GetSourceAsync();
                this.Invoke((MethodInvoker)delegate {
                    source.Text = text;
                    reqUrl.Text = e.Browser.MainFrame.Url;
                });
            }
        }

        private void request_Click(object sender, EventArgs e)
        {
            browser.Load(reqUrl.Text);
        }

        private async void parse_Click(object sender, EventArgs e)
        {
            string srcText = await browser.GetSourceAsync();
            var list = await new HtmlParser().ParseDocumentAsync(srcText);
            var results = list.QuerySelectorAll(parseText.Text);
            if(results != null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var elm in results)
                {
                    sb.Append(elm.TextContent);
                    sb.AppendLine();
                }
                parseResult.Text = sb.ToString();
            }
        }

        private void setValue_Click(object sender, EventArgs e)
        {
            var jsTemplate = "document.getElementsByName('{0}')[0].value = '{1}'";
            var js = String.Format(jsTemplate, setValueTarget.Text, setValueValue.Text);
            browser.ExecuteScriptAsync(js);
        }

        private void click_Click(object sender, EventArgs e)
        {
            var jsTemplate = "document.getElementsByName('{0}')[0].click()";
            var js = String.Format(jsTemplate, clickTarget.Text);
            browser.ExecuteScriptAsync(js);
        }
    }
}
