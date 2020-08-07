namespace ChroniumSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.request = new System.Windows.Forms.Button();
            this.reqUrl = new System.Windows.Forms.TextBox();
            this.source = new System.Windows.Forms.TextBox();
            this.parseText = new System.Windows.Forms.TextBox();
            this.parse = new System.Windows.Forms.Button();
            this.parseResult = new System.Windows.Forms.TextBox();
            this.setValueTarget = new System.Windows.Forms.TextBox();
            this.setValue = new System.Windows.Forms.Button();
            this.setValueValue = new System.Windows.Forms.TextBox();
            this.click = new System.Windows.Forms.Button();
            this.clickTarget = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.showDevTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 283);
            this.panel1.TabIndex = 0;
            // 
            // request
            // 
            this.request.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.request.Location = new System.Drawing.Point(713, 38);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(75, 23);
            this.request.TabIndex = 1;
            this.request.Text = "GO";
            this.request.UseVisualStyleBackColor = true;
            this.request.Click += new System.EventHandler(this.request_Click);
            // 
            // reqUrl
            // 
            this.reqUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reqUrl.Location = new System.Drawing.Point(12, 40);
            this.reqUrl.Name = "reqUrl";
            this.reqUrl.Size = new System.Drawing.Size(695, 22);
            this.reqUrl.TabIndex = 2;
            // 
            // source
            // 
            this.source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.source.Location = new System.Drawing.Point(13, 418);
            this.source.Multiline = true;
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(775, 70);
            this.source.TabIndex = 3;
            // 
            // parseText
            // 
            this.parseText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parseText.Location = new System.Drawing.Point(12, 495);
            this.parseText.Name = "parseText";
            this.parseText.Size = new System.Drawing.Size(695, 22);
            this.parseText.TabIndex = 4;
            // 
            // parse
            // 
            this.parse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.parse.Location = new System.Drawing.Point(714, 495);
            this.parse.Name = "parse";
            this.parse.Size = new System.Drawing.Size(75, 23);
            this.parse.TabIndex = 5;
            this.parse.Text = "parse";
            this.parse.UseVisualStyleBackColor = true;
            this.parse.Click += new System.EventHandler(this.parse_Click);
            // 
            // parseResult
            // 
            this.parseResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parseResult.Location = new System.Drawing.Point(12, 524);
            this.parseResult.Multiline = true;
            this.parseResult.Name = "parseResult";
            this.parseResult.Size = new System.Drawing.Size(776, 56);
            this.parseResult.TabIndex = 6;
            // 
            // setValueTarget
            // 
            this.setValueTarget.Location = new System.Drawing.Point(12, 68);
            this.setValueTarget.Name = "setValueTarget";
            this.setValueTarget.Size = new System.Drawing.Size(199, 22);
            this.setValueTarget.TabIndex = 2;
            this.setValueTarget.Text = "q";
            // 
            // setValue
            // 
            this.setValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setValue.Location = new System.Drawing.Point(713, 68);
            this.setValue.Name = "setValue";
            this.setValue.Size = new System.Drawing.Size(75, 23);
            this.setValue.TabIndex = 1;
            this.setValue.Text = "SET";
            this.setValue.UseVisualStyleBackColor = true;
            this.setValue.Click += new System.EventHandler(this.setValue_Click);
            // 
            // setValueValue
            // 
            this.setValueValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setValueValue.Location = new System.Drawing.Point(217, 68);
            this.setValueValue.Name = "setValueValue";
            this.setValueValue.Size = new System.Drawing.Size(490, 22);
            this.setValueValue.TabIndex = 2;
            this.setValueValue.Text = "c#";
            // 
            // click
            // 
            this.click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.click.Location = new System.Drawing.Point(713, 101);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(75, 23);
            this.click.TabIndex = 1;
            this.click.Text = "Click";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // clickTarget
            // 
            this.clickTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clickTarget.Location = new System.Drawing.Point(12, 101);
            this.clickTarget.Name = "clickTarget";
            this.clickTarget.Size = new System.Drawing.Size(695, 22);
            this.clickTarget.TabIndex = 2;
            this.clickTarget.Text = "btnK";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDevTools,
            this.readCsv});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // readCsv
            // 
            this.readCsv.Name = "readCsv";
            this.readCsv.Size = new System.Drawing.Size(224, 26);
            this.readCsv.Text = "CSV読み込み";
            this.readCsv.Click += new System.EventHandler(this.readCsv_Click);
            // 
            // showDevTools
            // 
            this.showDevTools.Name = "showDevTools";
            this.showDevTools.Size = new System.Drawing.Size(224, 26);
            this.showDevTools.Text = "DevTools";
            this.showDevTools.Click += new System.EventHandler(this.showDevTools_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.parseResult);
            this.Controls.Add(this.parse);
            this.Controls.Add(this.parseText);
            this.Controls.Add(this.source);
            this.Controls.Add(this.setValueValue);
            this.Controls.Add(this.clickTarget);
            this.Controls.Add(this.setValueTarget);
            this.Controls.Add(this.reqUrl);
            this.Controls.Add(this.click);
            this.Controls.Add(this.setValue);
            this.Controls.Add(this.request);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button request;
        private System.Windows.Forms.TextBox reqUrl;
        private System.Windows.Forms.TextBox source;
        private System.Windows.Forms.TextBox parseText;
        private System.Windows.Forms.Button parse;
        private System.Windows.Forms.TextBox parseResult;
        private System.Windows.Forms.TextBox setValueTarget;
        private System.Windows.Forms.Button setValue;
        private System.Windows.Forms.TextBox setValueValue;
        private System.Windows.Forms.Button click;
        private System.Windows.Forms.TextBox clickTarget;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readCsv;
        private System.Windows.Forms.ToolStripMenuItem showDevTools;
    }
}

