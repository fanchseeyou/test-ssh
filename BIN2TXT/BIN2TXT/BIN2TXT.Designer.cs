namespace BIN2TXT
{
    partial class BIN2TXT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BIN2TXT));
            this.labelRead = new System.Windows.Forms.Label();
            this.textBoxRead = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.labelWrite = new System.Windows.Forms.Label();
            this.textBoxWrite = new System.Windows.Forms.TextBox();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.richTextBoxData = new System.Windows.Forms.RichTextBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.groupBoxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRead
            // 
            this.labelRead.AutoSize = true;
            this.labelRead.Location = new System.Drawing.Point(12, 23);
            this.labelRead.Name = "labelRead";
            this.labelRead.Size = new System.Drawing.Size(71, 12);
            this.labelRead.TabIndex = 0;
            this.labelRead.Text = "BIN文件名：";
            // 
            // textBoxRead
            // 
            this.textBoxRead.Location = new System.Drawing.Point(89, 20);
            this.textBoxRead.Name = "textBoxRead";
            this.textBoxRead.ReadOnly = true;
            this.textBoxRead.Size = new System.Drawing.Size(138, 21);
            this.textBoxRead.TabIndex = 1;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(233, 18);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(39, 23);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "读取";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // labelWrite
            // 
            this.labelWrite.AutoSize = true;
            this.labelWrite.Location = new System.Drawing.Point(12, 55);
            this.labelWrite.Name = "labelWrite";
            this.labelWrite.Size = new System.Drawing.Size(71, 12);
            this.labelWrite.TabIndex = 3;
            this.labelWrite.Text = "TXT文件名：";
            // 
            // textBoxWrite
            // 
            this.textBoxWrite.Location = new System.Drawing.Point(89, 52);
            this.textBoxWrite.Name = "textBoxWrite";
            this.textBoxWrite.ReadOnly = true;
            this.textBoxWrite.Size = new System.Drawing.Size(138, 21);
            this.textBoxWrite.TabIndex = 4;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(233, 50);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(39, 23);
            this.buttonWrite.TabIndex = 5;
            this.buttonWrite.Text = "写入";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // richTextBoxData
            // 
            this.richTextBoxData.Location = new System.Drawing.Point(6, 20);
            this.richTextBoxData.Name = "richTextBoxData";
            this.richTextBoxData.ReadOnly = true;
            this.richTextBoxData.Size = new System.Drawing.Size(281, 149);
            this.richTextBoxData.TabIndex = 6;
            this.richTextBoxData.Text = "";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.richTextBoxData);
            this.groupBoxData.Location = new System.Drawing.Point(0, 84);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(287, 175);
            this.groupBoxData.TabIndex = 7;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "数据区（只预览前2048个字节）";
            // 
            // BIN2TXT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 262);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.textBoxWrite);
            this.Controls.Add(this.labelWrite);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.textBoxRead);
            this.Controls.Add(this.labelRead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(307, 300);
            this.MinimumSize = new System.Drawing.Size(307, 300);
            this.Name = "BIN2TXT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIN2TXT【QQ:728866519】";
            this.groupBoxData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRead;
        private System.Windows.Forms.TextBox textBoxRead;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Label labelWrite;
        private System.Windows.Forms.TextBox textBoxWrite;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.RichTextBox richTextBoxData;
        private System.Windows.Forms.GroupBox groupBoxData;
    }
}

