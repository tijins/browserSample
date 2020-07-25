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
            this.request.Location = new System.Drawing.Point(713, 8);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(75, 23);
            this.request.TabIndex = 1;
            this.request.Text = "GO";
            this.request.UseVisualStyleBackColor = true;
            this.request.Click += new System.EventHandler(this.request_Click);
            // 
            // reqUrl
            // 
            this.reqUrl.Location = new System.Drawing.Point(12, 10);
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
            this.setValueTarget.Location = new System.Drawing.Point(12, 38);
            this.setValueTarget.Name = "setValueTarget";
            this.setValueTarget.Size = new System.Drawing.Size(199, 22);
            this.setValueTarget.TabIndex = 2;
            this.setValueTarget.Text = "q";
            // 
            // setValue
            // 
            this.setValue.Location = new System.Drawing.Point(713, 38);
            this.setValue.Name = "setValue";
            this.setValue.Size = new System.Drawing.Size(75, 23);
            this.setValue.TabIndex = 1;
            this.setValue.Text = "SET";
            this.setValue.UseVisualStyleBackColor = true;
            this.setValue.Click += new System.EventHandler(this.setValue_Click);
            // 
            // setValueValue
            // 
            this.setValueValue.Location = new System.Drawing.Point(217, 38);
            this.setValueValue.Name = "setValueValue";
            this.setValueValue.Size = new System.Drawing.Size(490, 22);
            this.setValueValue.TabIndex = 2;
            this.setValueValue.Text = "c#";
            // 
            // click
            // 
            this.click.Location = new System.Drawing.Point(713, 71);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(75, 23);
            this.click.TabIndex = 1;
            this.click.Text = "Click";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // clickTarget
            // 
            this.clickTarget.Location = new System.Drawing.Point(12, 71);
            this.clickTarget.Name = "clickTarget";
            this.clickTarget.Size = new System.Drawing.Size(695, 22);
            this.clickTarget.TabIndex = 2;
            this.clickTarget.Text = "btnK";
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

