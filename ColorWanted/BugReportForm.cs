﻿using ColorWanted.theme;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ColorWanted
{
    internal partial class BugReportForm : Form
    {
        /// <summary>
        /// 数据模板
        /// </summary>
        private const string template =
@"操作系统: {0}
.NET版本: {1}
程序版本: {2}
错误类型: {3}
错误消息: {4}
错误源: {5}
";

        public BugReportForm()
        {
            componentsLayout();
            ThemeUtil.Apply(this);
            
        }

        internal void SetException(Exception exception)
        {
            tbMsg.Clear();
            tbMsg.AppendText(string.Format(template,
            Environment.OSVersion,
            Environment.Version,
            Application.ProductVersion,
            exception.GetType().FullName,
            exception.Message,
            exception.StackTrace));
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbMsg.Text);
            btnCopy.Text = "已复制";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbRestart.Checked)
            {
                Application.Restart();
                Close();
                return;
            }
            Environment.Exit(0);
        }

        private void lkIssue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lkIssue.Text);
        }
    }
}
