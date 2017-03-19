﻿namespace ColorWanted
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbHex = new System.Windows.Forms.Label();
            this.lbRgb = new System.Windows.Forms.Label();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayMenuDisplayMode = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuHideWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuFollowCaret = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuFixed = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuFormatModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuFormatMini = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuFormatCommon = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuFormatAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuShowPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuShowColorPicker = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuAutoPin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuRestoreLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuAutoStart = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuOpenConfigFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuShowHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.lbCMYK = new System.Windows.Forms.Label();
            this.lbHSB = new System.Windows.Forms.Label();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHex
            // 
            this.lbHex.BackColor = System.Drawing.Color.Black;
            this.lbHex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHex.ForeColor = System.Drawing.Color.Lime;
            this.lbHex.Location = new System.Drawing.Point(0, 0);
            this.lbHex.Name = "lbHex";
            this.lbHex.Padding = new System.Windows.Forms.Padding(2);
            this.lbHex.Size = new System.Drawing.Size(68, 20);
            this.lbHex.TabIndex = 0;
            this.lbHex.Text = "#FFFFFF";
            this.lbHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltip.SetToolTip(this.lbHex, "十六进制颜色值，快速复制：Alt+C");
            this.lbHex.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEventHandler);
            // 
            // lbRgb
            // 
            this.lbRgb.BackColor = System.Drawing.Color.Black;
            this.lbRgb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRgb.ForeColor = System.Drawing.Color.Lime;
            this.lbRgb.Location = new System.Drawing.Point(68, 0);
            this.lbRgb.Name = "lbRgb";
            this.lbRgb.Padding = new System.Windows.Forms.Padding(2);
            this.lbRgb.Size = new System.Drawing.Size(140, 20);
            this.lbRgb.TabIndex = 0;
            this.lbRgb.Text = "RGB(255,255,255)";
            this.lbRgb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltip.SetToolTip(this.lbRgb, "RGB通道颜色值，快速复制：1秒内快速按 Alt+C 两次");
            this.lbRgb.Visible = false;
            this.lbRgb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEventHandler);
            // 
            // tray
            // 
            this.tray.BalloonTipText = "屏幕取色器正在工作";
            this.tray.BalloonTipTitle = "赏色";
            this.tray.ContextMenuStrip = this.trayMenu;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "赏色-取色器";
            this.tray.Visible = true;
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuDisplayMode,
            this.trayMenuFormatModeToolStripMenuItem,
            this.toolStripSeparator3,
            this.trayMenuShowPreview,
            this.trayMenuShowColorPicker,
            this.trayMenuAutoPin,
            this.toolStripSeparator2,
            this.trayMenuRestoreLocation,
            this.trayMenuAutoStart,
            this.trayMenuOpenConfigFile,
            this.toolStripSeparator1,
            this.trayMenuShowHelp,
            this.trayMenuExit});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(149, 242);
            // 
            // trayMenuDisplayMode
            // 
            this.trayMenuDisplayMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuHideWindow,
            this.trayMenuFollowCaret,
            this.trayMenuFixed});
            this.trayMenuDisplayMode.Name = "trayMenuDisplayMode";
            this.trayMenuDisplayMode.Size = new System.Drawing.Size(148, 22);
            this.trayMenuDisplayMode.Text = "窗口模式";
            // 
            // trayMenuHideWindow
            // 
            this.trayMenuHideWindow.Checked = true;
            this.trayMenuHideWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trayMenuHideWindow.Name = "trayMenuHideWindow";
            this.trayMenuHideWindow.Size = new System.Drawing.Size(152, 22);
            this.trayMenuHideWindow.Text = "隐藏窗口";
            this.trayMenuHideWindow.Click += new System.EventHandler(this.trayMenuHideWindow_Click);
            // 
            // trayMenuFollowCaret
            // 
            this.trayMenuFollowCaret.Name = "trayMenuFollowCaret";
            this.trayMenuFollowCaret.Size = new System.Drawing.Size(152, 22);
            this.trayMenuFollowCaret.Text = "跟随模式";
            this.trayMenuFollowCaret.Click += new System.EventHandler(this.trayMenuFollowCaret_Click);
            // 
            // trayMenuFixed
            // 
            this.trayMenuFixed.Name = "trayMenuFixed";
            this.trayMenuFixed.Size = new System.Drawing.Size(152, 22);
            this.trayMenuFixed.Text = "固定模式";
            this.trayMenuFixed.Click += new System.EventHandler(this.trayMenuFixed_Click);
            // 
            // trayMenuFormatModeToolStripMenuItem
            // 
            this.trayMenuFormatModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuFormatMini,
            this.trayMenuFormatCommon,
            this.trayMenuFormatAll});
            this.trayMenuFormatModeToolStripMenuItem.Name = "trayMenuFormatModeToolStripMenuItem";
            this.trayMenuFormatModeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.trayMenuFormatModeToolStripMenuItem.Text = "显示格式";
            // 
            // trayMenuFormatMini
            // 
            this.trayMenuFormatMini.Checked = true;
            this.trayMenuFormatMini.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trayMenuFormatMini.Name = "trayMenuFormatMini";
            this.trayMenuFormatMini.Size = new System.Drawing.Size(100, 22);
            this.trayMenuFormatMini.Text = "迷你";
            this.trayMenuFormatMini.ToolTipText = "只显示HEX格式";
            this.trayMenuFormatMini.Click += new System.EventHandler(this.trayMenuFormatMini_Click);
            // 
            // trayMenuFormatCommon
            // 
            this.trayMenuFormatCommon.Name = "trayMenuFormatCommon";
            this.trayMenuFormatCommon.Size = new System.Drawing.Size(100, 22);
            this.trayMenuFormatCommon.Text = "常用";
            this.trayMenuFormatCommon.ToolTipText = "显示HEX格式和GRB格式";
            this.trayMenuFormatCommon.Click += new System.EventHandler(this.trayMenuFormatCommon_Click);
            // 
            // trayMenuFormatAll
            // 
            this.trayMenuFormatAll.Name = "trayMenuFormatAll";
            this.trayMenuFormatAll.Size = new System.Drawing.Size(100, 22);
            this.trayMenuFormatAll.Text = "全部";
            this.trayMenuFormatAll.ToolTipText = "显示所有格式";
            this.trayMenuFormatAll.Click += new System.EventHandler(this.trayMenuFormatAll_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // trayMenuShowPreview
            // 
            this.trayMenuShowPreview.Name = "trayMenuShowPreview";
            this.trayMenuShowPreview.Size = new System.Drawing.Size(148, 22);
            this.trayMenuShowPreview.Text = "显示预览窗口";
            this.trayMenuShowPreview.Click += new System.EventHandler(this.trayMenuShowPreview_Click);
            // 
            // trayMenuShowColorPicker
            // 
            this.trayMenuShowColorPicker.Name = "trayMenuShowColorPicker";
            this.trayMenuShowColorPicker.Size = new System.Drawing.Size(148, 22);
            this.trayMenuShowColorPicker.Text = "显示调色板";
            this.trayMenuShowColorPicker.Click += new System.EventHandler(this.trayMenuShowColorPicker_Click);
            // 
            // trayMenuAutoPin
            // 
            this.trayMenuAutoPin.Checked = true;
            this.trayMenuAutoPin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trayMenuAutoPin.Name = "trayMenuAutoPin";
            this.trayMenuAutoPin.Size = new System.Drawing.Size(148, 22);
            this.trayMenuAutoPin.Text = "边缘自动吸附";
            this.trayMenuAutoPin.Click += new System.EventHandler(this.trayMenuAutoPin_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // trayMenuRestoreLocation
            // 
            this.trayMenuRestoreLocation.Name = "trayMenuRestoreLocation";
            this.trayMenuRestoreLocation.Size = new System.Drawing.Size(148, 22);
            this.trayMenuRestoreLocation.Text = "重置窗口位置";
            this.trayMenuRestoreLocation.Click += new System.EventHandler(this.trayMenuRestoreLocation_Click);
            // 
            // trayMenuAutoStart
            // 
            this.trayMenuAutoStart.Name = "trayMenuAutoStart";
            this.trayMenuAutoStart.Size = new System.Drawing.Size(148, 22);
            this.trayMenuAutoStart.Text = "开机启动";
            this.trayMenuAutoStart.Click += new System.EventHandler(this.trayMenuAutoStart_Click);
            // 
            // trayMenuOpenConfigFile
            // 
            this.trayMenuOpenConfigFile.Name = "trayMenuOpenConfigFile";
            this.trayMenuOpenConfigFile.Size = new System.Drawing.Size(148, 22);
            this.trayMenuOpenConfigFile.Text = "查看配置文件";
            this.trayMenuOpenConfigFile.Click += new System.EventHandler(this.trayMenuOpenConfigFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // trayMenuShowHelp
            // 
            this.trayMenuShowHelp.Name = "trayMenuShowHelp";
            this.trayMenuShowHelp.Size = new System.Drawing.Size(148, 22);
            this.trayMenuShowHelp.Text = "帮助";
            this.trayMenuShowHelp.Click += new System.EventHandler(this.trayMenuShowHelp_Click);
            // 
            // trayMenuExit
            // 
            this.trayMenuExit.Name = "trayMenuExit";
            this.trayMenuExit.Size = new System.Drawing.Size(148, 22);
            this.trayMenuExit.Text = "退出";
            this.trayMenuExit.Click += new System.EventHandler(this.trayMenuExit_Click);
            // 
            // lbCMYK
            // 
            this.lbCMYK.BackColor = System.Drawing.Color.Black;
            this.lbCMYK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCMYK.ForeColor = System.Drawing.Color.Lime;
            this.lbCMYK.Location = new System.Drawing.Point(0, 20);
            this.lbCMYK.Name = "lbCMYK";
            this.lbCMYK.Padding = new System.Windows.Forms.Padding(2);
            this.lbCMYK.Size = new System.Drawing.Size(208, 20);
            this.lbCMYK.TabIndex = 3;
            this.lbCMYK.Text = "CMYK(93%,88%,89%,80%)";
            this.lbCMYK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.lbCMYK, "CMYK");
            this.lbCMYK.Visible = false;
            // 
            // lbHSB
            // 
            this.lbHSB.BackColor = System.Drawing.Color.Black;
            this.lbHSB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHSB.ForeColor = System.Drawing.Color.Lime;
            this.lbHSB.Location = new System.Drawing.Point(0, 40);
            this.lbHSB.Name = "lbHSB";
            this.lbHSB.Padding = new System.Windows.Forms.Padding(2);
            this.lbHSB.Size = new System.Drawing.Size(208, 20);
            this.lbHSB.TabIndex = 4;
            this.lbHSB.Text = "HSB(0度, 100%,0%)";
            this.lbHSB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.lbHSB, "CMYK");
            this.lbHSB.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 236);
            this.ControlBox = false;
            this.Controls.Add(this.lbHSB);
            this.Controls.Add(this.lbCMYK);
            this.Controls.Add(this.lbHex);
            this.Controls.Add(this.lbRgb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "赏色";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEventHandler);
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbRgb;
        private System.Windows.Forms.Label lbHex;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem trayMenuShowHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem trayMenuExit;
        private System.Windows.Forms.ToolStripMenuItem trayMenuHideWindow;
        private System.Windows.Forms.ToolStripMenuItem trayMenuAutoPin;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.ToolStripMenuItem trayMenuShowPreview;
        private System.Windows.Forms.ToolStripMenuItem trayMenuRestoreLocation;
        private System.Windows.Forms.ToolStripMenuItem trayMenuFollowCaret;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem trayMenuAutoStart;
        private System.Windows.Forms.ToolStripMenuItem trayMenuFixed;
        private System.Windows.Forms.ToolStripMenuItem trayMenuDisplayMode;
        private System.Windows.Forms.ToolStripMenuItem trayMenuShowColorPicker;
        private System.Windows.Forms.ToolStripMenuItem trayMenuOpenConfigFile;
        private System.Windows.Forms.Label lbCMYK;
        private System.Windows.Forms.ToolStripMenuItem trayMenuFormatModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trayMenuFormatMini;
        private System.Windows.Forms.ToolStripMenuItem trayMenuFormatCommon;
        private System.Windows.Forms.ToolStripMenuItem trayMenuFormatAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label lbHSB;
    }
}

