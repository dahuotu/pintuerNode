using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace com.DaHuotu
{
    public partial class Checking : Form
    {
        public Checking()
        {
            InitializeComponent();
        }

        private void Checking_Load(object sender, EventArgs e)
        {
            checkWindows();
            checkNode();
        }

        /// <summary>
        /// 检测系统运行环境
        /// </summary>
        void checkWindows()
        {
            this.txtCheckLog.Text = string.Format("系统运行环境正常...\r\n");
        }
        /// <summary>
        /// 检测node运行环境
        /// </summary>
        void checkNode()
        {
            string cmd = @"node -v";
            string output = "";
            string pattern = @"v\d+(.\d+)*";
            string state = "";
            Tool.RunCmd(cmd, out output);
            string version = Tool.RegexTest(output, pattern);
            if (!string.IsNullOrEmpty(version))
            {
                state = "已";
                this.txtCheckLog.Text += string.Format("Node运行环境正常，您的机器{0}安装Node.js, 版本：{1}\r\n", state, version);
                btnExit.Visible = true;
                btnExit.Text = "朕，知道了！";
            }
            else
            {
                state = "未";
                this.txtCheckLog.Text += string.Format("Node运行环境异常，您的机器{0}安装Node.js, 请安装！\r\n", state);
                btnExit.Visible = true;
            }
        }
        /// <summary>
        /// 检测MySQL运行环境
        /// </summary>
        void checkMySql()
        {

        }
        /// <summary>
        /// 退出应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (this.Text == "退出")
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
                App app = new App();
                app.ShowDialog();
            }
        }
    }
}
