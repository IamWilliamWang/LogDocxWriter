﻿namespace 日志书写器
{
    partial class FormEdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.插入tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全屏模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暗黑模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动聚焦ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停用备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.contextMenuStripPath = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.应用修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button保存 = new System.Windows.Forms.Button();
            this.contextMenuStripSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.保存并置为终稿ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.buttonTopMost = new System.Windows.Forms.Button();
            this.checkBoxMailbox = new System.Windows.Forms.CheckBox();
            this.comboBoxFontSize = new System.Windows.Forms.ComboBox();
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.contextMenuStripMain.SuspendLayout();
            this.contextMenuStripPath.SuspendLayout();
            this.contextMenuStripSave.SuspendLayout();
            this.groupBoxSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMain
            // 
            this.textBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMain.ContextMenuStrip = this.contextMenuStripMain;
            this.textBoxMain.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxMain.Location = new System.Drawing.Point(12, 59);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(821, 574);
            this.textBoxMain.TabIndex = 0;
            this.textBoxMain.TextChanged += new System.EventHandler(this.textBoxMain_TextChanged);
            this.textBoxMain.DoubleClick += new System.EventHandler(this.Form_DoubleClick);
            this.textBoxMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMain_KeyDown);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.插入tToolStripMenuItem,
            this.查找ToolStripMenuItem,
            this.剪切ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.全屏模式ToolStripMenuItem,
            this.暗黑模式ToolStripMenuItem,
            this.自动聚焦ToolStripMenuItem,
            this.停用备份ToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(181, 246);
            // 
            // 插入tToolStripMenuItem
            // 
            this.插入tToolStripMenuItem.Name = "插入tToolStripMenuItem";
            this.插入tToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.插入tToolStripMenuItem.Text = "中文空格";
            this.插入tToolStripMenuItem.Click += new System.EventHandler(this.插入tToolStripMenuItem_Click);
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查找ToolStripMenuItem.Text = "查找内容";
            this.查找ToolStripMenuItem.Click += new System.EventHandler(this.查找ToolStripMenuItem_Click);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 全屏模式ToolStripMenuItem
            // 
            this.全屏模式ToolStripMenuItem.Name = "全屏模式ToolStripMenuItem";
            this.全屏模式ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.全屏模式ToolStripMenuItem.Text = "精简模式";
            this.全屏模式ToolStripMenuItem.Click += new System.EventHandler(this.全屏模式ToolStripMenuItem_Click);
            // 
            // 暗黑模式ToolStripMenuItem
            // 
            this.暗黑模式ToolStripMenuItem.Name = "暗黑模式ToolStripMenuItem";
            this.暗黑模式ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.暗黑模式ToolStripMenuItem.Text = "暗黑主题";
            this.暗黑模式ToolStripMenuItem.Click += new System.EventHandler(this.暗黑模式ToolStripMenuItem_Click);
            // 
            // 自动聚焦ToolStripMenuItem
            // 
            this.自动聚焦ToolStripMenuItem.Name = "自动聚焦ToolStripMenuItem";
            this.自动聚焦ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.自动聚焦ToolStripMenuItem.Text = "自动聚焦";
            this.自动聚焦ToolStripMenuItem.Click += new System.EventHandler(this.自动聚焦ToolStripMenuItem_Click);
            // 
            // 停用备份ToolStripMenuItem
            // 
            this.停用备份ToolStripMenuItem.Name = "停用备份ToolStripMenuItem";
            this.停用备份ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.停用备份ToolStripMenuItem.Text = "停用备份";
            this.停用备份ToolStripMenuItem.Click += new System.EventHandler(this.停用备份ToolStripMenuItem_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(186, 19);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(65, 12);
            this.labelPath.TabIndex = 7;
            this.labelPath.Text = "文件根目录";
            // 
            // textBoxPath
            // 
            this.textBoxPath.AllowDrop = true;
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.ContextMenuStrip = this.contextMenuStripPath;
            this.textBoxPath.Location = new System.Drawing.Point(257, 14);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(324, 21);
            this.textBoxPath.TabIndex = 3;
            this.textBoxPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxPath_DragDrop);
            this.textBoxPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxPath_DragEnter);
            // 
            // contextMenuStripPath
            // 
            this.contextMenuStripPath.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.应用修改ToolStripMenuItem});
            this.contextMenuStripPath.Name = "contextMenuStripPath";
            this.contextMenuStripPath.Size = new System.Drawing.Size(125, 26);
            // 
            // 应用修改ToolStripMenuItem
            // 
            this.应用修改ToolStripMenuItem.Name = "应用修改ToolStripMenuItem";
            this.应用修改ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.应用修改ToolStripMenuItem.Text = "应用修改";
            this.应用修改ToolStripMenuItem.Click += new System.EventHandler(this.应用修改ToolStripMenuItem_Click);
            // 
            // button保存
            // 
            this.button保存.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button保存.ContextMenuStrip = this.contextMenuStripSave;
            this.button保存.Location = new System.Drawing.Point(743, 14);
            this.button保存.Name = "button保存";
            this.button保存.Size = new System.Drawing.Size(72, 23);
            this.button保存.TabIndex = 4;
            this.button保存.Text = "保存文档";
            this.button保存.UseVisualStyleBackColor = true;
            this.button保存.Click += new System.EventHandler(this.button保存_Click);
            // 
            // contextMenuStripSave
            // 
            this.contextMenuStripSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存并置为终稿ToolStripMenuItem});
            this.contextMenuStripSave.Name = "contextMenuStripSave";
            this.contextMenuStripSave.Size = new System.Drawing.Size(161, 26);
            // 
            // 保存并置为终稿ToolStripMenuItem
            // 
            this.保存并置为终稿ToolStripMenuItem.Name = "保存并置为终稿ToolStripMenuItem";
            this.保存并置为终稿ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.保存并置为终稿ToolStripMenuItem.Text = "保存并置为终稿";
            this.保存并置为终稿ToolStripMenuItem.Click += new System.EventHandler(this.保存并置为终稿ToolStripMenuItem_Click);
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSetting.Controls.Add(this.buttonTopMost);
            this.groupBoxSetting.Controls.Add(this.checkBoxMailbox);
            this.groupBoxSetting.Controls.Add(this.comboBoxFontSize);
            this.groupBoxSetting.Controls.Add(this.textBoxFont);
            this.groupBoxSetting.Controls.Add(this.labelFontSize);
            this.groupBoxSetting.Controls.Add(this.labelFont);
            this.groupBoxSetting.Controls.Add(this.labelPath);
            this.groupBoxSetting.Controls.Add(this.button保存);
            this.groupBoxSetting.Controls.Add(this.textBoxPath);
            this.groupBoxSetting.Location = new System.Drawing.Point(13, 7);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(821, 46);
            this.groupBoxSetting.TabIndex = 8;
            this.groupBoxSetting.TabStop = false;
            // 
            // buttonTopMost
            // 
            this.buttonTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTopMost.Location = new System.Drawing.Point(665, 14);
            this.buttonTopMost.Name = "buttonTopMost";
            this.buttonTopMost.Size = new System.Drawing.Size(72, 23);
            this.buttonTopMost.TabIndex = 10;
            this.buttonTopMost.Text = "窗口置顶";
            this.buttonTopMost.UseVisualStyleBackColor = true;
            this.buttonTopMost.Click += new System.EventHandler(this.buttonTopMost_Click);
            // 
            // checkBoxMailbox
            // 
            this.checkBoxMailbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMailbox.AutoSize = true;
            this.checkBoxMailbox.Checked = true;
            this.checkBoxMailbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMailbox.Location = new System.Drawing.Point(587, 11);
            this.checkBoxMailbox.Name = "checkBoxMailbox";
            this.checkBoxMailbox.Size = new System.Drawing.Size(72, 28);
            this.checkBoxMailbox.TabIndex = 9;
            this.checkBoxMailbox.Text = " 退出后\n打开邮箱";
            this.checkBoxMailbox.UseVisualStyleBackColor = true;
            // 
            // comboBoxFontSize
            // 
            this.comboBoxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxFontSize.Font = new System.Drawing.Font("宋体", 10F);
            this.comboBoxFontSize.FormattingEnabled = true;
            this.comboBoxFontSize.Items.AddRange(new object[] {
            "六号",
            "小五",
            "五号",
            "小四",
            "四号",
            "小三",
            "三号",
            "小二",
            "二号",
            "小一",
            "一号"});
            this.comboBoxFontSize.Location = new System.Drawing.Point(125, 15);
            this.comboBoxFontSize.Name = "comboBoxFontSize";
            this.comboBoxFontSize.Size = new System.Drawing.Size(55, 21);
            this.comboBoxFontSize.TabIndex = 2;
            this.comboBoxFontSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxFontSize_SelectedIndexChanged);
            // 
            // textBoxFont
            // 
            this.textBoxFont.Font = new System.Drawing.Font("黑体", 10F);
            this.textBoxFont.Location = new System.Drawing.Point(41, 14);
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.Size = new System.Drawing.Size(43, 23);
            this.textBoxFont.TabIndex = 1;
            this.textBoxFont.Text = "黑体";
            this.textBoxFont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFontSize
            // 
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.Location = new System.Drawing.Point(90, 19);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(29, 12);
            this.labelFontSize.TabIndex = 6;
            this.labelFontSize.Text = "字号";
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(6, 19);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(29, 12);
            this.labelFont.TabIndex = 5;
            this.labelFont.Text = "字体";
            // 
            // FormEdit
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 645);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.textBoxMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEdit";
            this.Text = "日志书写器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormEdit_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormEdit_DragEnter);
            this.DoubleClick += new System.EventHandler(this.Form_DoubleClick);
            this.Resize += new System.EventHandler(this.FormEdit_Resize);
            this.contextMenuStripMain.ResumeLayout(false);
            this.contextMenuStripPath.ResumeLayout(false);
            this.contextMenuStripSave.ResumeLayout(false);
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button button保存;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.ComboBox comboBoxFontSize;
        private System.Windows.Forms.CheckBox checkBoxMailbox;
        private System.Windows.Forms.Button buttonTopMost;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全屏模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暗黑模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动聚焦ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPath;
        private System.Windows.Forms.ToolStripMenuItem 应用修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停用备份ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSave;
        private System.Windows.Forms.ToolStripMenuItem 保存并置为终稿ToolStripMenuItem;
    }
}

